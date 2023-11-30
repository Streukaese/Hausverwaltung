"INSERT INTO haus (id, adresse, plz, ort) VALUES (NULL, @adresse, @plz, @ort)"

Select id, haus_id, tuer, wohnflaeche from wohnungen where haus_id=11

SET @num := 0;
UPDATE tablename SET id = @num := (@num+1);
ALTER TABLE tablename AUTO_INCREMENT = 1;