use fase1


CREATE TABLE torneo (
	idTor int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	fechaCreacion date NOT NULL,
	FK_idUsu int constraint FK_idUsu foreign key (FK_idUsu) references usuario(idUsu),
	participantes int NOT NULL
) 


CREATE TABLE estado_partida (
	idEP int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	estado varchar(20)
) 

CREATE TABLE tipo_partida (
	idTP int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	tipo varchar(20)
) 

CREATE TABLE partida (
	idPart int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	fechaCreacion date NOT NULL,
	FK_idCrea int constraint FK_idCrea foreign key (FK_idCrea) references usuario(idUsu),
	rival varchar(30),
	FK_idEst int constraint FK_idEst foreign key (FK_idEst) references estado_partida(idEP),
	FK_idTipo int constraint FK_idTipo foreign key (FK_idTipo) references tipo_partida(idTP)
)

CREATE TABLE partida_torneo (
	idPT int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FK_idPartida int constraint FK_idPartida foreign key (FK_idPartida) references partida(idPart),
	FK_idTorneo int constraint FK_idTorneo foreign key (FK_idTorneo) references torneo(idTor)
) 


CREATE TABLE reporte (
	idRep int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	FK_idPart int constraint FK_idPart foreign key (FK_idPart) references partida(idPart),
	noMov int NOT NULL,
	ganador varchar(30),
	perdedor varchar(30)
) 

insert into estado_partida values('Ganada')
insert into estado_partida values('Perdida')
insert into estado_partida values('Finalizada')
insert into estado_partida values('Pausada')
insert into estado_partida values('En Curso')

select * from estado_partida
select * from tipo_partida
select * from partida

insert into tipo_partida values('Individual')
insert into tipo_partida values('Versus')

INSERT INTO partida VALUES('10-10-2020', (select idUsu from usuario where nick='Jos'), null, 5, 1);

INSERT INTO partida VALUES('10/10/2020', (select idUsu from usuario where nick='Jos'), null, 5, 1);

select idPart, fechaCreacion, (select nick from usuario where nick='dana'), rival, (select estado from estado_partida where idEP=5), (select tipo from tipo_partida where idTP=1) from partida 

select idPart, fechaCreacion, U.nick, rival, E.estado, T.tipo
from partida, usuario U, estado_partida E, tipo_partida T
where FK_idCrea=(select idUsu from usuario where nick='dana') and FK_idEst=E.idEP and FK_idTipo=T.idTP