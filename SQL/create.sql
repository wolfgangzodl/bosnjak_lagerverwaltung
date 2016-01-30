use bosnjak;

drop table AuftragUebersicht;
drop table Auftrag;
drop table Auftraggeber;
drop table Bauvorhaben;

create table Bauvorhaben (
	BauvorhabenNr int primary key,
	UnternehmenName varchar(200),
	Art varchar(200),
	PLZ varchar(6),
	Ort varchar(150),
	Strasse varchar(150),
	Bemerkung varchar(500),
)

create table Auftraggeber (
	AuftraggeberNr int primary key,
	AuftraggeberName varchar(200),
	PLZ varchar(6),
	Ort varchar(150),
	Strasse varchar(150)
)

create table Auftrag (
	AuftragNummer int primary key,
	PL char(2),
	BauvorhabenNr int references Bauvorhaben,
	AuftraggeberNr int references Auftraggeber,
	Arbeitsart char(2),
	ErstellungsDatum date,
	AuftragssummeNetto decimal(25,2),
	Zahlungsbedienungen varchar(250),
	Abgschlossen bit default 0
)

create table AuftragUebersicht (
	AuftragNummer int references Auftrag,
	TeilrechnungNr int,
	TeilrechnungNetto decimal(25,2),
	TeilrechnungDatum date default getdate(),
	RestbetragNetto decimal(25,2) -- wenn abgschlossen dann 0
	primary key(AuftragNummer, TeilrechnungNr)
)

