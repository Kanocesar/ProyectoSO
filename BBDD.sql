DROP DATABASE IF EXISTS competicion;
CREATE DATABASE competicion;

USE competicion;

CREATE TABLE jugador (
     nombre VARCHAR(60),
     idjugador INT,
     edad INT
)ENGINE=InnoDB;

CREATE TABLE partida (
     ganador VARCHAR(60),
     idpartida INT,
     fecha INT,
     duracion INT
)ENGINE=InnoDB;

CREATE TABLE puntuaciones (
     idj INT,
     idp INT,
     resultado INT

)ENGINE = InnoDB;

INSERT INTO jugador VALUES ('Juanjo', 1, 21);
INSERT INTO jugador VALUES ('Peter', 2, 98);
INSERT INTO jugador VALUES ('Harry',3 , 56);
INSERT INTO jugador VALUES ('Lucas', 4, 31);

INSERT INTO partida VALUES ('Juanjo',1, 21022022, 22);
INSERT INTO partida VALUES ('Juanjo',1, 21022022, 22);
INSERT INTO partida VALUES ('Juanjo',1, 21022022, 22);
INSERT INTO partida VALUES ('Juanjo',1, 21022022, 22);

INSERT INTO puntuaciones VALUES (2, 1, 2);
INSERT INTO puntuaciones VALUES (2, 1, 2);
INSERT INTO puntuaciones VALUES (2, 1, 2);
INSERT INTO puntuaciones VALUES (2, 1, 2);
