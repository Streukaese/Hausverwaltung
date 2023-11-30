create database Hausverwaltung;

	create table Haus (
	id int not null auto_increment primary key,
	adresse varchar(70) not null,
	plz int(5) not null,
	ort varchar(30) not null,
);

CREATE TABLE `hausverwaltung`.`wohnungen` (
	`id` INT NOT NULL AUTO_INCREMENT , 
	`haus_id` INT NOT NULL REFERENCES haus(id), 
	`tuer` VARCHAR(50) NOT NULL , 
	`wohnflaeche` INT NOT NULL , 
	PRIMARY KEY (`id`)
) ENGINE = InnoDB;

alter table wohnungen add foreign key (haus_id) references haus(id);