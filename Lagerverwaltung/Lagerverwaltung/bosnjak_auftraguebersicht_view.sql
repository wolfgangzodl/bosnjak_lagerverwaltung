select Jahr, AuftragNummer, b.UnternehmenName, b.Art, b.PLZ, b.Ort, b.Strasse, a.AuftraggeberName, a.PLZ, a.Ort, a.Strasse from Auftrag
join Bauvorhaben b on b.BauvorhabenNr = Auftrag.BauvorhabenNr
join Auftraggeber a on a.AuftraggeberNr = Auftrag.AuftraggeberNR;