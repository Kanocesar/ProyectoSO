#include <mysql.h>
#include <string.h>
#include <stdlib.h>
#include <stdio.h>
int DameID(Lista jugador lista)
{
	MYSQL *conn;
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	int i=0;
	char nombre[20];
	encontrado = 0;
	char consulta [80];
	//Creamos una conexion al servidor MYSQL 
	conn = mysql_init(NULL);
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//inicializar la conexion
	conn = mysql_real_connect (conn, "localhost","user", "pass", "competicion",0, NULL, 0);
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", 
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	// consulta SQL para obtener una tabla con todos los datos
	// de la base de datos
	err=mysql_query (conn, "SELECT * FROM personas");
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta. El resultado de la
	//consulta se devuelve en una variable del tipo puntero a
	//MYSQL_RES tal y como hemos declarado anteriormente.
	//Se trata de una tabla virtual en memoria que es la copia
	//de la tabla real en disco.
	resultado = mysql_store_result (conn);
	// El resultado es una estructura matricial en memoria
	// en la que cada fila contiene los datos de una persona
	// Ahora obtenemos la primera fila que se almacena en una
	// variable de tipo MYSQL_ROW
	row = mysql_fetch_row (resultado);
	// En una fila hay tantas columnas como datos tiene una
	// persona. En nuestro caso hay tres columnas: dni(row[0]),
	// nombre(row[1]) y edad (row[2]).
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		printf ("Dame el nombre del jugador que quieres buscar\n");
		scanf ("%s", jugador);
		//pide nombre del jugador a buscar
		while ((i<lista.num)&&(encontrado==0)) {
			if ( strcmp (lista.jugador[i].nombre, jugador) == 0;
			//compara nombre recibido con nombre del jugador
			encontrado = 1;
			if (encontrado == 0)
			i++;
		}
		if (encontrado == 1)
			printf ("La ID del jugador %s, es: %d\n", jugador, lista.jugador[i].ID);
				err=mysql_query (conn, consulta); 
		else {
			printf ("Error al consultar datos de la base %u %s\n",
					mysql_errno(conn), mysql_error(conn));
			exit (1);
		}
		
		// cerrar la conexion con el servidor MYSQL 
		mysql_close (conn);
		exit(0);
}

