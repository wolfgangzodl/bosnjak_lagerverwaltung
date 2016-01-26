use bosnjak;

drop table Auftrag;
drop table Auftraggeber;
drop table Bauvorhaben;

create table Bauvorhaben (
	BauvorhabenNr int primary key,
	UnternehmenName varchar(200),
	Art varchar(200),
	PLZ varchar(6),
	Ort varchar(150),
	Strasse varchar(150)
)

create table Auftraggeber (
	AuftraggeberNr int primary key,
	AuftraggeberName varchar(200),
	PLZ varchar(6),
	Ort varchar(150),
	Strasse varchar(150)
)

create table Auftrag (
	Jahr varchar(4),
	AuftragNummer int primary key,
	PL char(2),
	BauvorhabenNr int references Bauvorhaben,
	AuftraggeberNr int references Auftraggeber,
	Arbeitsart char(2),
	SR int,
	SZ int,
	NK int
)
