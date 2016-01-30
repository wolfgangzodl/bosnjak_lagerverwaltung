use Bosnjak;



insert into Bauvorhaben values (1, 'Fit Fabrik', 'Wassereintritt', '1220', 'Wien', 'Gewerbeparkstrasse 3', 'Dies ist eine Bemerkung');
insert into Bauvorhaben values (2, 'Austrothem', 'Brandschutzkonzept Produktionshalle', '7083', 'Purbach am Neusiedler See', 'Industriestraße 1','Dies ist eine Bemerkung');
insert into Bauvorhaben values (3, 'Technologiezentrum Eisenstadt', null, '7000', 'Eisenstadt', 'Marktstraße 3/Kommzone','Dies ist eine Bemerkung');
insert into Bauvorhaben values (4, 'FunderMax', 'Dachöffnung Ventilator MRZ 13', '7201', 'Neudörfl', 'Bickfordgasse','Dies ist eine Bemerkung');
insert into Bauvorhaben values (5, 'Bapistengemeinde Beheimgasse Liku', null, '1170', 'Wien', 'Beheimgasse 1','Dies ist eine Bemerkung');

insert into Auftraggeber values (1, 'ARO Immobilien GmbH', '1040', 'Wien', 'Prinz-Eugen-Straße 8-10');
insert into Auftraggeber values (2, 'Austrotherm GmbH', '7083', 'Purbach am Neusiedler See', 'Industriestraße 1');
insert into Auftraggeber values (3, 'Belig Beteiligungs- und Liegenschafts GmbH', '7000', 'Eisenstadt', 'Marktstraße 3');
insert into Auftraggeber values (4, 'FunderMax GmbH', '9300', 'St. Veit/Glan', 'Klagenfurter Strasse 87-89');
insert into Auftraggeber values (5, 'Baptistengemeinde', '1170', 'Wien', 'Beheimgasse 1');

insert into Auftrag values (1, 'FA', 1, 1, 'FD', getdate(), 10000, 'Skonto 3% bis 12.03.2016',0);
insert into Auftrag values (2, 'FJ', 2, 2, 'FD',getdate(), 10000, 'Skonto 3% bis 12.03.2016',0);
insert into Auftrag values (3, 'FJ', 3, 3, 'FD', getdate(), 10000, 'Skonto 3% bis 12.03.2016',0);
insert into Auftrag values (4, 'FJ', 4, 4, 'FD',getdate(), 10000, 'Skonto 3% bis 12.03.2016',0);
insert into Auftrag values (5, 'PO', 5, 5, 'FD',getdate(), 10000, 'Skonto 3% bis 12.03.2016',0);

insert into AuftragUebersicht values (1,1, 2000, getdate(), 8000);
insert into AuftragUebersicht values (1,2, 2000, getdate(), 8000);
insert into AuftragUebersicht values (1,3, 2000, getdate(), 8000);
insert into AuftragUebersicht values (2,1, 2000, getdate(), 8000);
insert into AuftragUebersicht values (3,1, 2000, getdate(), 8000);


select * from Bauvorhaben;
select * from Auftraggeber;
select * from Auftrag;