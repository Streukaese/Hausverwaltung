create database Hausverwaltung;

	create table Haus (
	id int not null auto_increment primary key,
	adresse varchar(70) not null,
	plz int(5) not null,
	ort varchar(30) not null,
);