create database fase1;

use fase1;

CREATE TABLE paises (
	id int NOT NULL PRIMARY KEY,
	iso char(2) DEFAULT NULL,
	nombre varchar(80) DEFAULT NULL
) 

create table usuario(
	idUsu int  IDENTITY(1,1) NOT NULL PRIMARY KEY,
	nombre varchar(30) NOT NULL,
	apellido varchar(30) NOT NULL,
	nick varchar(30) NOT NULL,
	contra varchar(30) NOT NULL,
	fechaNac date NOT NULL,
	email varchar(30) NOT NULL,
	FK_idPais int constraint FK_idPais foreign key (FK_idPais) references paises(id)
);

select * from paises
INSERT INTO usuario VALUES('Luisa', 'Calderon', 'mary', '123', '1995-08-23', 'maria@correo.com',94);

select * from usuario