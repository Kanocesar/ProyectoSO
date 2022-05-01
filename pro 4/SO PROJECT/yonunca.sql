DROP DATABASE IF EXISTS yonunca;
CREATE DATABASE yonunca;

USE yonunca;

CREATE TABLE Jugador(
	Id INT PRIMARY KEY NOT NULL,
	Nombre VARCHAR(20),
	Pass VARCHAR(20),
	Edad INT
)ENGINE = InnoDB;

CREATE TABLE Partida(
	Id INT PRIMARY KEY NOT NULL,
	Ganador VARCHAR(20),
	Fecha VARCHAR(20)

)ENGINE = InnoDB;

CREATE TABLE Relacion(
	IdJugador INT,
	FOREIGN KEY(IdJugador) REFERENCES Jugador(Id),
	IdPartida INT,
	FOREIGN KEY(IdPartida) REFERENCES Partida(Id),
	ResponderSi INT
)ENGINE = InnoDB;


INSERT INTO Partida (Id, Ganador, Fecha) VALUES (1,'Cesar','2020-10-06');
INSERT INTO Partida (Id, Ganador, Fecha) VALUES (2,'Max','2021-06-13');

INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (1,'Cesar','ALONSO',23);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (2,'Max','Manzana',20);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (3,'Charly','12321',21);
INSERT INTO Jugador (Id,Nombre,Pass,Edad) VALUES (4,'Oscar','mimara',12);

INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (1,1,4);
INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (2,1,9);
INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (3,1,5);
INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (4,1,5);
INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (1,2,2);
INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (3,2,8);
INSERT INTO Relacion (IdJugador, IdPartIda, ResponderSi) VALUES (4,2,5);



