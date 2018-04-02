/* drop proc Regisztral */
create procedure Regisztral(@pNev varchar(200), @pJelszo varchar (200), @pTeljesNev varchar(75), @pEmail varchar(75), @pHozzaferesId int)
as
begin
	insert into Felhasznalok values (@pNev, @pJelszo, @pTeljesNev, @pEmail, @pHozzaferesId)
end



/* drop procedure UjEmber */
create procedure UjEmber(@Nev varchar(100), @Cnp varchar(30))
as
begin
	insert into Szemelyek values (@Cnp, @Nev)
end



/* drop procedure TorolEmber */
create procedure TorolEmber(@Nev varchar(100))
as
begin
	declare @cnp varchar(15)
	select @cnp = Szemelyek.CNP from Szemelyek where Nev = @Nev

	delete from Adagok where CNP = @cnp
	delete from AdagokPelenka where CNP = @cnp
	delete from Szemelyek where CNP = @cnp
end



/* drop procedure UjGyogyszer */
create procedure UjGyogyszer(@Nev varchar(100), @Mertekegyseg varchar(30), @Tipus varchar(30), @Darab int)
as
begin
	insert into Gyogyszerek values (@Nev, @Mertekegyseg, @Darab, @Tipus)
end

/* drop procedure TorolGyogyszer */
create procedure TorolGyogyszer(@Nev varchar(100))
as
begin
	delete from Raktaron where GyogyszerID in (select Gyogyszerek.GyogyszerID from Gyogyszerek where Nev = @Nev)
	delete from Adagok where GyogyszerID in (select Gyogyszerek.GyogyszerID from Gyogyszerek where Nev = @Nev)
	delete from Gyogyszerek where Nev = @Nev
end


/* drop procedure TorolVisszaallitGyogyszer */
create procedure TorolVisszaallitGyogyszer(@szid varchar(15), @gyid int, @nid int, @mid float, @datum varchar(100), @adagAra float)
as
begin
	delete top (1)
		   from Adagok 
		   where CNP = @szid and GyogyszerID = @gyid and NapszakID = @nid 
		   and Mennyiseg between  @mid - 0.002 and @mid + 0.002 and Datum = @datum and AdagAra between @adagAra - 0.001 and @adagAra + 0.002
	declare @temp float
		set @temp = -1
	declare @egysegar float
	set @egysegar = @adagAra / @mid 
	select @temp = Raktaron.Egysegar
		from Raktaron
		where GyogyszerID = @gyid and Egysegar between @egysegar - 0.001 and @egysegar + 0.002
	if (@temp != -1) -- ha van ilyen egysegaru es nevu gyogyszer
		begin
			declare @dat varchar(30)
			set @dat = (select top (1) Raktaron.Datum from Raktaron where GyogyszerID = @gyid and Egysegar between @egysegar - 0.001 and @egysegar + 0.002)
			update Raktaron
				set Mennyiseg = Mennyiseg + @mid
				where GyogyszerID = @gyid and Egysegar between @egysegar - 0.001 and @egysegar + 0.002 and Datum = @dat
		end
	else	-- ha nincs ilyen egysegaru gyogyszer az adott fajtabol
		begin
			declare @szoroz float
			declare @darab int
			select @darab = Gyogyszerek.Darabszam from Gyogyszerek where GyogyszerID = @gyid
			set @szoroz	= @egysegar * @darab
			insert into Raktaron values (@gyid, @szoroz, @egysegar, @mid, @datum)
		end
end

/* drop procedure TorolVisszaallitPelenka */
create procedure TorolVisszaallitPelenka(@szid varchar(15), @pid int,  @mid int, @datum varchar(100), @adagAra float)
as
begin
	delete top (1)
		   from AdagokPelenka 
		   where CNP = @szid and PelenkaID = @pid 
		   and Mennyiseg = @mid and Datum = @datum and AdagAra between @adagAra - 0.001 and @adagAra + 0.002
	declare @temp float
		set @temp = -1
	declare @egysegar float
	set @egysegar = @adagAra / @mid 
	select @temp = RaktaronPelenka.Egysegar
		from RaktaronPelenka
		where PelenkaID = @pid and Egysegar between @egysegar - 0.001 and @egysegar + 0.002
	if (@temp != -1) -- ha van ilyen egysegaru es nevu pelenka
		begin
			declare @dat varchar(30)
			set @dat = (select top (1) RaktaronPelenka.Datum from RaktaronPelenka where PelenkaID = @pid and Egysegar between @egysegar - 0.001 and @egysegar + 0.002)
			update RaktaronPelenka
				set Mennyiseg = Mennyiseg + @mid
				where PelenkaID = @pid and Egysegar between @egysegar - 0.001 and @egysegar + 0.002 and Datum = @dat
		end
	else	-- ha nincs ilyen egysegaru pelenka az adott fajtabol
		begin
			declare @szoroz float
			declare @darab int
			select @darab = Pelenkak.Darabszam from Pelenkak where PelenkaID = @pid
			set @szoroz	= @egysegar * @darab
			insert into RaktaronPelenka values (@pid, @szoroz, @egysegar, @mid, @datum)
		end
end

/* drop procedure TorolPelenka */
create procedure TorolPelenka(@Nev varchar(100))
as
begin
	declare @pid int
	select @pid = Pelenkak.PelenkaID from Pelenkak where Nev = @Nev
	delete from RaktaronPelenka where PelenkaID = @pid
	delete from AdagokPelenka where PelenkaID = @pid
	delete from Pelenkak where PelenkaID = @pid
end

/* drop procedure KeszletFeltoltese */
create procedure KeszletFeltoltese(@Nev varchar(50),  @DobozSzam int , @Ar float, @Datum varchar(30))
as
begin
	declare @temp int
	set @temp = -1;
	declare @db int
	set @db = -1;

	select @temp = Gyogyszerek.GyogyszerID 
		from Gyogyszerek, Raktaron
		where Gyogyszerek.GyogyszerID = Raktaron.GyogyszerID and Gyogyszerek.Nev = @Nev and Raktaron.Ar = @Ar and Raktaron.Datum = @Datum
	
	select @db = Darabszam from Gyogyszerek where Gyogyszerek.Nev = @Nev

	declare @pAr float
	declare @temporal float
	set @temporal = 0.0 + @db

	set @pAr = @Ar / @temporal
	declare @szam float
	set @szam = @DobozSzam * @db

	if (@temp = -1)
		begin
			declare @t int
			select @t = Gyogyszerek.GyogyszerID from Gyogyszerek where Nev = @Nev
			insert into Raktaron values (@t, @Ar, @pAr, @szam, @Datum)
		end
	else
		begin
			declare @nr float;
			select @nr = Raktaron.Mennyiseg from Raktaron where GyogyszerID = @temp and Ar = @Ar
			set @nr = @nr + @szam;
			update Raktaron set Mennyiseg = @nr, Egysegar = @pAr  
				where GyogyszerID = @temp and Ar = @Ar and Datum = @Datum
		end
end

/*drop proc TorolRaktarbol*/
create procedure TorolRaktarbol(@Nev varchar(50), @Mennyiseg float, @Ar float, @Datum varchar(20))
as
begin
	declare @temp int
	select @temp = Gyogyszerek.GyogyszerID from Gyogyszerek where Gyogyszerek.Nev = @Nev

	delete from Raktaron where GyogyszerID = @temp and Ar between @Ar - 0.009 and @Ar + 0.009 and Mennyiseg between @Mennyiseg - 0.002  and @Mennyiseg + 0.002 and Datum = @Datum
end

--drop procedure ujAdagHozzaadasa
--declare @out int 
--exec ujAdagHozzaadasa 'Barabás Péter', 'Algoflex500gr', 'Reggel', '2016-07-20', 5,  @out out
create procedure ujAdagHozzaadasa(@SzemelyNeve varchar(50), @GyogyszerNeve varchar(50), @Napszak varchar(20), @Datum varchar(20), @Mennyiseg float, @felhasznaloId int, @pOut int out)
as
begin
	declare @szid varchar(15)
	declare @gyid int
	declare @nid int
	declare @menny float

	select @szid = Szemelyek.CNP from Szemelyek where Szemelyek.Nev = @SzemelyNeve
	select @gyid = Gyogyszerek.GyogyszerID from Gyogyszerek where Gyogyszerek.Nev = @GyogyszerNeve
	select @nid = Napszakok.NapszakID from Napszakok where Napszakok.Napszak = @Napszak
	set @menny = (select sum(Raktaron.Mennyiseg) from Raktaron where GyogyszerID = @gyid)
	if (@menny >= @Mennyiseg)
		begin
			declare @ar float
			declare @MM float
			set @menny = @Mennyiseg
			while @menny <> 0
				begin
					declare @dat varchar(30)
					select @dat = min(Raktaron.Datum) from Raktaron where GyogyszerID = @gyid and Mennyiseg <> 0
					--set @ar = (select min(Raktaron.Ar) from Raktaron where GyogyszerID = @gyid and Mennyiseg <> 0)
					select @ar = Raktaron.Ar from Raktaron where GyogyszerID = @gyid and Datum = @dat and Mennyiseg <> 0
					print @ar
					set @MM = (select Raktaron.Mennyiseg from Raktaron where GyogyszerID = @gyid and Ar = @ar)
					declare @egysegar float
					declare @ossz float
					if	(@MM >= @menny)
						begin
							update Raktaron set Mennyiseg = Mennyiseg - @menny where GyogyszerID = @gyid and Ar = @ar
								set @egysegar = 0.0
								select @egysegar = Raktaron.Egysegar from Raktaron where GyogyszerID = @gyid and Ar = @ar
								set @ossz = @egysegar * @menny
							insert into Adagok values (@szid, @gyid, @nid, @felhasznaloId, @Datum, @menny, @ossz)
							set @menny = 0
						end
					else
						begin
							set @egysegar = 0.0
							select @egysegar = Raktaron.Egysegar from Raktaron where GyogyszerID = @gyid and Ar = @ar
							set @ossz = @egysegar * @MM
							insert into Adagok values (@szid, @gyid, @nid,  @felhasznaloId, @Datum, @MM, @ossz)
							update Raktaron set Mennyiseg = 0 where GyogyszerID = @gyid and Ar = @ar
							set @menny = @menny - @MM
						end
				end
			set @pOut = 1
		end
	else 
		begin
			set @pOut = -1
		end
end


--drop procedure OsszesAdagHozzaadasa
--exec OsszesAdagHozzaadasa 'Barabás Péter', 'Algoflex500gr', 'Reggel', '2016-07-20'
create procedure OsszesAdagHozzaadasa(@SzemelyNeve varchar(50), @GyogyszerNeve varchar(50), @Napszak varchar(20), @Datum varchar(20),  @felhasznaloId int)
as
begin
	declare @szid varchar(30)
	declare @gyid int
	declare @nid int
	declare @menny float

	select @szid = Szemelyek.CNP from Szemelyek where Szemelyek.Nev = @SzemelyNeve
	select @gyid = Gyogyszerek.GyogyszerID from Gyogyszerek where Gyogyszerek.Nev = @GyogyszerNeve
	select @nid = Napszakok.NapszakID from Napszakok where Napszakok.Napszak = @Napszak
	set @menny = (select sum(Raktaron.Mennyiseg) from Raktaron where GyogyszerID = @gyid)
			declare @ar float
			declare @MM float
				set @ar = 0
				select @ar = min(Raktaron.Ar) from Raktaron where GyogyszerID = @gyid and Mennyiseg <> 0
			declare @egysegar float
			declare @ossz float
			while @ar <> 0
				begin
					set @ar = 0
					select @ar = min(Raktaron.Ar) from Raktaron where GyogyszerID = @gyid and Mennyiseg <> 0
					if (@ar <> 0)
						begin
							select @MM = Raktaron.Mennyiseg from Raktaron where GyogyszerID = @gyid and Ar = @ar
								set @egysegar = -1
								select @egysegar = Raktaron.Egysegar from Raktaron where GyogyszerID = @gyid and Ar = @ar
								set @ossz = @egysegar * @MM
							update Raktaron set Mennyiseg = 0 where GyogyszerID = @gyid and Ar = @ar
							insert into Adagok values (@szid, @gyid, @nid,  @felhasznaloId, @Datum, @MM, @ossz)
						end
				end
end

/* drop procedure KeszletFeltoltesePelenkaval */
create procedure KeszletFeltoltesePelenkaval(@Nev varchar(50),  @DobozSzam int , @Ar float, @Datum varchar(30))
as
begin
	declare @temp int
	set @temp = -1;
	declare @db int
	set @db = -1;

	select @temp = Pelenkak.PelenkaID 
		from Pelenkak, RaktaronPelenka
		where Pelenkak.PelenkaID = RaktaronPelenka.PelenkaID and Pelenkak.Nev = @Nev and RaktaronPelenka.Ar = @Ar and RaktaronPelenka.Datum = @Datum
	
	select @db = Darabszam from Pelenkak where Pelenkak.Nev = @Nev

	declare @pAr float
	declare @temporal float
	set @temporal = 0.0 + @db

	set @pAr = @Ar / @temporal
	declare @szam int
	set @szam = @DobozSzam * @db

	if (@temp = -1)
		begin
			declare @t int
			select @t = Pelenkak.PelenkaID from Pelenkak where Nev = @Nev
			insert into RaktaronPelenka values (@t, @Ar, @pAr, @szam, @Datum)
		end
	else
		begin
			declare @nr int;
			select @nr = RaktaronPelenka.Mennyiseg from RaktaronPelenka where PelenkaID = @temp and Ar = @Ar
			set @nr = @nr + @szam;
			update RaktaronPelenka set Mennyiseg = @nr, Egysegar = @pAr  
				where PelenkaID = @temp and Ar = @Ar and Datum = @Datum
		end
end

/*drop proc TorolPelenkatRaktarbol*/
create procedure TorolPelenkatRaktarbol(@Nev varchar(50), @Mennyiseg int, @Ar float, @Datum varchar(20))
as
begin
	declare @temp int
	select @temp = Pelenkak.PelenkaID from Pelenkak where Pelenkak.Nev = @Nev

	delete from RaktaronPelenka where PelenkaID = @temp and Ar = @Ar and Mennyiseg = @Mennyiseg and Datum = @Datum
end



--drop procedure ujPelenkaAdagHozzaadasa
create procedure ujPelenkaAdagHozzaadasa(@SzemelyNeve varchar(50), @PelenkaNeve varchar(50), @Datum varchar(20), @Mennyiseg int, @felhasznaloId int, @pOut int out)
as
begin
	declare @szid varchar(30)
	declare @pid int
	declare @menny int

	select @szid = Szemelyek.CNP from Szemelyek where Szemelyek.Nev = @SzemelyNeve
	select @pid = Pelenkak.PelenkaID from Pelenkak where Pelenkak.Nev = @PelenkaNeve

	set @menny = (select sum(RaktaronPelenka.Mennyiseg) from RaktaronPelenka where PelenkaID = @pid)
	if (@menny >= @Mennyiseg)
		begin
			declare @ar float
			declare @MM int
			set @menny = @Mennyiseg
			while @menny <> 0
				begin
					declare @dat varchar(30)
					select @dat = min(RaktaronPelenka.Datum) from RaktaronPelenka where PelenkaID = @pid and Mennyiseg <> 0
					select @ar = RaktaronPelenka.Ar from RaktaronPelenka where PelenkaID = @pid and Datum = @dat and Mennyiseg <> 0
					print @ar
					set @MM = (select RaktaronPelenka.Mennyiseg from RaktaronPelenka where PelenkaID = @pid and Ar = @ar)
					declare @egysegar float
					declare @ossz float
					if	(@MM >= @menny)
						begin
							update RaktaronPelenka set Mennyiseg = Mennyiseg - @menny where PelenkaID = @pid and Ar = @ar
								set @egysegar = 0.0
								select @egysegar = RaktaronPelenka.Egysegar from RaktaronPelenka where PelenkaID = @pid and Ar = @ar
								set @ossz = @egysegar * @menny
							insert into AdagokPelenka values (@szid, @pid, @felhasznaloId, @Datum, @menny, @ossz)
							set @menny = 0
						end
					else
						begin
							update RaktaronPelenka set Mennyiseg = 0 where PelenkaID = @pid and Ar = @ar
								set @egysegar = 0.0
								select @egysegar = RaktaronPelenka.Egysegar from RaktaronPelenka where PelenkaID = @pid and Ar = @ar
								set @ossz = @egysegar * @MM
							insert into AdagokPelenka values (@szid, @pid, @felhasznaloId, @Datum, @MM, @ossz)
							set @menny = @menny - @MM
						end
				end
			set @pOut = 1
		end
	else 
		begin
			set @pOut = -1
		end
end

--drop procedure OsszesPelenkaAdagHozzaadasa
create procedure OsszesPelenkaAdagHozzaadasa(@SzemelyNeve varchar(50), @PelenkaNeve varchar(50), @Datum varchar(20), @felhasznaloId int)
as
begin
	declare @szid varchar(30)
	declare @pid int
	declare @menny int

	select @szid = Szemelyek.CNP from Szemelyek where Szemelyek.Nev = @SzemelyNeve
	select @pid = Pelenkak.PelenkaID from Pelenkak where Pelenkak.Nev = @PelenkaNeve
	set @menny = (select sum(RaktaronPelenka.Mennyiseg) from RaktaronPelenka where PelenkaID = @pid)
			declare @ar float
			declare @MM int
				set @ar = 0
				select @ar = min(RaktaronPelenka.Ar) from RaktaronPelenka where PelenkaID = @pid and Mennyiseg <> 0
			declare @egysegar float
			declare @ossz float
			while @ar <> 0
				begin
					set @ar = 0
					select @ar = min(RaktaronPelenka.Ar) from RaktaronPelenka where PelenkaID = @pid and Mennyiseg <> 0
					if (@ar <> 0)
						begin
							select @MM = RaktaronPelenka.Mennyiseg from RaktaronPelenka where PelenkaID = @pid and Ar = @ar
								set @egysegar = -1
								select @egysegar = RaktaronPelenka.Egysegar from RaktaronPelenka where PelenkaID = @pid and Ar = @ar
								set @ossz = @egysegar * @MM
							update RaktaronPelenka set Mennyiseg = 0 where PelenkaID = @pid and Ar = @ar
							insert into AdagokPelenka values (@szid, @pid, @felhasznaloId, @Datum, @MM, @ossz)
						end
				end
end

/* drop procedure CNPmodosito*/
create procedure CNPmodosito(@regiCNP varchar(15), @ujCNP varchar(15), @Nev varchar(75))
as
begin
	insert into Szemelyek values(@ujCNP, @Nev)
	update Adagok set CNP = @ujCNP where CNP = @regiCNP
	update AdagokPelenka set CNP = @ujCNP where CNP = @regiCNP
	delete from Szemelyek where CNP = @regiCNP
end
