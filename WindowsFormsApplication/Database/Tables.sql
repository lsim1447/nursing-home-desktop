Drop table Felhasznalok
Drop table FelhasznaloTipusok
Drop table Adagok
Drop table Raktaron
Drop table Napszakok
Drop table Gyogyszerek
Drop table AdagokPelenka

Drop table Szemelyek
Drop table RaktaronPelenka
Drop table Pelenkak

CREATE TABLE FelhasznaloTipusok(
	FelhasznaloTipusID int primary key IDENTITY,
	Tipus varchar(50)
)
CREATE TABLE Felhasznalok(
	FelhasznaloID int primary key IDENTITY,
	FelhasznaloNev varchar(200),
	Jelszo varchar(200),
	TeljesNev varchar(75),
	Email varchar(75),
	FelhasznaloTipusID int REFERENCES FelhasznaloTipusok(FelhasznaloTipusID)
)
CREATE TABLE Szemelyek(
	CNP varchar(30)  primary key,
	Nev varchar(30),
)
CREATE TABLE Gyogyszerek(
	GyogyszerID int primary key IDENTITY,
	Nev varchar(30),
	Mertekegyseg varchar(30),
	Darabszam int,
	Tipus varchar(30)
)
CREATE TABLE Napszakok(
	NapszakID int primary key IDENTITY,
	Napszak varchar(30)
)
CREATE TABLE Adagok(
	AdagokID int primary key identity,
	CNP varchar(30) REFERENCES Szemelyek(CNP),
	GyogyszerID int REFERENCES Gyogyszerek(GyogyszerID),
	NapszakID int REFERENCES Napszakok(NapszakID),
	FelhasznaloID int REFERENCES Felhasznalok(FelhasznaloID),
	Datum varchar(20),
	Mennyiseg float,
	AdagAra float
)
CREATE TABLE Raktaron(
	GyogyszerID int REFERENCES Gyogyszerek(GyogyszerID),
	Ar float,
	Egysegar float,
	Mennyiseg float,
	Datum varchar(30),
	primary key (Ar, GyogyszerID, Datum)
)

CREATE TABLE Pelenkak(
	PelenkaID int Primary key Identity,
	Nev varchar(100),
	Darabszam int
)
CREATE TABLE AdagokPelenka(
	AdagPenekaID int primary key identity,
	CNP varchar(30) REFERENCES Szemelyek(CNP),
	PelenkaID int REFERENCES Pelenkak(PelenkaID),
	FelhasznaloID int REFERENCES Felhasznalok(FelhasznaloID),
	Datum varchar(20),
	Mennyiseg int,
	AdagAra float
)
CREATE TABLE RaktaronPelenka(
	PelenkaID int REFERENCES Pelenkak(PelenkaID),
	Ar float,
	Egysegar float,
	Mennyiseg int,
	Datum varchar(30),
	primary key (Ar, PelenkaID, Datum)
)
insert into Napszakok values('REGGEL')
insert into Napszakok values('DÉL')
insert into Napszakok values('ESTE')  

insert into FelhasznaloTipusok values('admin')
insert into FelhasznaloTipusok values('user')