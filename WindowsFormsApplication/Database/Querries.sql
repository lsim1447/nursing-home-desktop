select * from Napszakok

select * from Felhasznalok
delete from Felhasznalok where FelhasznaloID = 6
select * from Szemelyek

select * from Gyogyszerek 
update Raktaron set Datum = '2016-09-23' where GyogyszerID = 1
select * from Raktaron

select * from Adagok order by Datum

select * from Pelenkak

select * from RaktaronPelenka

select * from AdagokPelenka

select * from FelhasznaloTipusok

insert into Napszakok values('REGGEL')
insert into Napszakok values('DÉL')
insert into Napszakok values('ESTE')       

select Raktaron.Egysegar from Raktaron where GyogyszerID = '2'
update Adagok set Datum = '2016-06-24' where AdagokID < 4

select sum(Raktaron.Mennyiseg) from Raktaron, Gyogyszerek where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID and Gyogyszerek.Nev = 'Algoflex500gr'


select sum(Raktaron.Mennyiseg) from Raktaron, Gyogyszerek where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID and Gyogyszerek.Nev = 'Ampicilin'

select sum(Raktaron.Mennyiseg) from Raktaron, Gyogyszerek where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID and Gyogyszerek.Nev = 'Ampicilin'

select Gyogyszerek.Nev, Raktaron.Mennyiseg from Raktaron, Gyogyszerek where Raktaron.GyogyszerID = Gyogyszerek.GyogyszerID



select sum(Adagok.AdagAra) from Adagok, Napszakok, Gyogyszerek, Szemelyek where Napszakok.NapszakID = Adagok.NapszakID and Gyogyszerek.GyogyszerID = Adagok.GyogyszerID  and Szemelyek.SzemelyID = Adagok.SzemelyID and Szemelyek.Nev = 'Barabás Péter' and Adagok.Datum >= '2016-07-01' and Adagok.Datum <= '2016-07-30'


select Gyogyszerek.Nev, sum(Adagok.Mennyiseg) as OsszesitettMennyiseg, sum (Adagok.AdagAra) as Osszertek
from Gyogyszerek, Adagok
where Adagok.GyogyszerID = Gyogyszerek.GyogyszerID and Adagok.Datum > '2015-01-01'
group by Gyogyszerek.Nev

select Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, Adagok.Mennyiseg
	from Gyogyszerek, Adagok, Napszakok 
	where Gyogyszerek.GyogyszerID = Adagok.GyogyszerID and Adagok.NapszakID = Napszakok.NapszakID
	      and Adagok.Datum >= '2016-07-01' and Adagok.Datum <= '2016-07-31' and Gyogyszerek.Nev = 'Ampicilin'
	order by Adagok.Datum, Napszakok.NapszakID 

select Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, sum(Adagok.Mennyiseg) as Mennyiseg, sum(Adagok.AdagAra) as OsszAr
	from Gyogyszerek, Adagok, Napszakok 
	where Gyogyszerek.GyogyszerID = Adagok.GyogyszerID and Adagok.NapszakID = Napszakok.NapszakID
	      and Adagok.Datum >= '2016-07-01' and Adagok.Datum <= '2016-07-31'
	group by Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, Napszakok.NapszakID
	order by Adagok.Datum, Napszakok.NapszakID


	select Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, sum(Adagok.Mennyiseg) as Mennyiseg, sum(Adagok.AdagAra) as OsszAr 
	from Gyogyszerek, Adagok, Napszakok, Szemelyek  
	where Gyogyszerek.GyogyszerID = Adagok.GyogyszerID  and Szemelyek.SzemelyID = Adagok.SzemelyID and Adagok.NapszakID = Napszakok.NapszakID and Szemelyek.Nev = 'Márton Margit' and Adagok.Datum >= '2016-07-02' and Adagok.Datum <= '2016-07-30' 
	group by Gyogyszerek.Nev, Adagok.Datum, Napszakok.Napszak, Napszakok.NapszakID 
	order by Adagok.Datum, Napszakok.NapszakID


	select Gyogyszerek.Nev, sum(Adagok.Mennyiseg) as OsszMennyiseg, sum (Adagok.AdagAra) as Osszertek 
	from Gyogyszerek, Adagok, Szemelyek 
	where Szemelyek.SzemelyID = Adagok.SzemelyID and Szemelyek.Nev = 'Márton Margit' and Adagok.GyogyszerID = Gyogyszerek.GyogyszerID and Adagok.Datum >= '2016-07-01'  and Adagok.Datum <= '2016-07-30' 
	group by Gyogyszerek.Nev

	select sum(Adagok.AdagAra) 
	from Adagok, Szemelyek
	where Adagok.SzemelyID = Szemelyek.SzemelyID and Szemelyek.Nev = 'Márton Margit'  and Adagok.Datum >= '2016-07-01' and Adagok.Datum <= '2016-07-31'
	

	select Szemelyek.Nev, Sum(Adagok.AdagAra) as Vegosszeg into #T1
	from Szemelyek, Adagok
	where Szemelyek.SzemelyID = Adagok.SzemelyID and Adagok.Datum >= '2016-06-30' and Adagok.Datum <= '2016-08-06'
	group by Szemelyek.Nev
	order by Szemelyek.Nev

	select sum(#T1.Vegosszeg) from #T1

	select Pelenkak.Nev, RaktaronPelenka.Mennyiseg, RaktaronPelenka.Ar from RaktaronPelenka, Pelenkak where RaktaronPelenka.PelenkaID = Pelenkak.PelenkaID

	select Szemelyek.Nev, Pelenkak.Nev, AdagokPelenka.Mennyiseg from Szemelyek, Pelenkak, AdagokPelenka where Szemelyek.SzemelyID = AdagokPelenka.SzemelyID and AdagokPelenka.PelenkaID = Pelenkak.PelenkaID and Szemelyek.Nev = 'Dénes Ildikó'


	insert into Adagok values (1,1,1,'2016-09-06', 1, 4.0625)

	select Szemelyek.Nev, Gyogyszerek.Nev, Napszakok.Napszak, Adagok.Mennyiseg from Adagok, Szemelyek, Gyogyszerek, Napszakok where Adagok.SzemelyID = Szemelyek.SzemelyID and Adagok.GyogyszerID = Gyogyszerek.GyogyszerID and Napszakok.NapszakID = Adagok.NapszakID  and Adagok.Datum = '2016-09-06' and Szemelyek.Nev = 'Márton Margit'

	insert into Felhasznalok values('admin', '21232f297a57a5a743894a0e4a801fc3', 'Lazar Szilard','szilard.lazar@yahoo.com', 1)

	select FelhasznaloTipusok.Tipus from Felhasznalok,FelhasznaloTipusok where FelhasznaloTipusok.FelhasznaloTipusID = Felhasznalok.FelhasznaloTipusID and Felhasznalok.FelhasznaloNev = 'admin'