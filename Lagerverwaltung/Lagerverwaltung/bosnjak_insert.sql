use Bosnjak;

insert into Bauvorhaben values (1, 'Fit Fabrik', 'Wassereintritt', '1220', 'Wien', 'Gewerbeparkstrasse 3');
insert into Bauvorhaben values (2, 'Austrothem', 'Brandschutzkonzept Produktionshalle', '7083', 'Purbach am Neusiedler See', 'Industriestraße 1');
insert into Bauvorhaben values (3, 'Technologiezentrum Eisenstadt', null, '7000', 'Eisenstadt', 'Marktstraße 3/Kommzone');
insert into Bauvorhaben values (4, 'FunderMax', 'Dachöffnung Ventilator MRZ 13', '7201', 'Neudörfl', 'Bickfordgasse');
insert into Bauvorhaben values (5, 'Bapistengemeinde Beheimgasse Liku', null, '1170', 'Wien', 'Beheimgasse 1');

insert into Auftraggeber values (1, 'ARO Immobilien GmbH', '1040', 'Wien', 'Prinz-Eugen-Straße 8-10');
insert into Auftraggeber values (2, 'Austrotherm GmbH', '7083', 'Purbach am Neusiedler See', 'Industriestraße 1');
insert into Auftraggeber values (3, 'Belig Beteiligungs- und Liegenschafts GmbH', '7000', 'Eisenstadt', 'Marktstraße 3');
insert into Auftraggeber values (4, 'FunderMax GmbH', '9300', 'St. Veit/Glan', 'Klagenfurter Strasse 87-89');
insert into Auftraggeber values (5, 'Baptistengemeinde', '1170', 'Wien', 'Beheimgasse 1');

insert into Auftrag values (year(getdate()), 1, 'FA', 1, 1, 'FD', 0, 0 ,0);
insert into Auftrag values (year(getdate()),2, 'FJ', 2, 2, 'FD', 0, 0, 0);
insert into Auftrag values (year(getdate()),3, 'FJ', 3, 3, 'FD', -1, 0, 0);
insert into Auftrag values (year(getdate()),4, 'FJ', 4, 4, 'FD', 0, 0, 0);
insert into Auftrag values (year(getdate()),5, 'PO', 5, 5, 'FD', 0, 0 ,0);
