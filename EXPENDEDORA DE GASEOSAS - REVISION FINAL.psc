Proceso EXPENDEDORA_DE_GASEOSAS
	//Variables definidas
	Definir opcion como entero;
	definir contadorCoca, contadorFanta, contadorSprite, contadorCerveza como entero;
	escribir "BIENVENIDO A LA MAQUINA EXPENDEDORA DE GASEOSAS !!";
	escribir "";
	escribir "A CONTINUACIÓN SE DESPLEGARÁ UN MENÚ, DENTRO DE CUAL TENDRÁ QUE ELEGIR LO QUE DESEA CONSUMIR...";
	escribir "Para iniciar presione una tecla...";
	Esperar Tecla;
	//Menú de opciones
	Borrar Pantalla;
	escribir "SELECCIONE UNA DE LAS OPCIONES A CONTINUACIÓN:";
	escribir "";
	escribir "MENÚ DE OPCIONES";
	escribir "";
	escribir "OPCIÓN 1 - COCA COLA - (5 UNIDADES)";
	escribir "OPCIÓN 2 - FANTA - (5 UNIDADES)";
	escribir "OPCIÓN 3 - SPRITE - (5 UNIDADES)";
	escribir "OPCIÓN 4 - CERVEZA - (5 UNIDADES)";
	escribir "";
	Escribir "opción 9 - SALIR";
	escribir "";
	escribir "Seleccione una de las opciones";
	leer opcion;
	//Contadores que restan productos al seleccionarlos
	contadorCoca <- 5;
	contadorFanta <- 5;
	contadorSprite <- 5;
	contadorCerveza <- 5;
	//Repetidor de acciones segun opcion elegida
	Repetir
		Segun opcion Hacer
			1:
				Borrar Pantalla;
				Si contadorCoca = 0 Entonces
					escribir "No hay mas Coca Cola, Elija otra opcion de Menú";
				SiNo
					escribir "Ha seleccionado - COCA COLA, que la disfrute!";
					escribir "";
					contadorCoca <- contadorCoca -1;
					escribir "Quedan", " ", contadorCoca," ","COCA COLA";
				FinSi
				
				escribir "Para seguir, presione una tecla";
				esperar tecla;
				Borrar Pantalla;
				escribir "si desea seguir retirando por favor seleccione nuevamente una OPCIÓN DE MENÚ o 9 para finalizar:";
				escribir "";
				escribir "MENÚ DE OPCIONES";
				escribir "";
				escribir "OPCIÓN 1 - COCA COLA (", contadorCoca, ")" ;
				escribir "OPCIÓN 2 - FANTA (", contadorFanta, ")" ;
				escribir "OPCIÓN 3 - SPRITE (", contadorsprite, ")" ;
				escribir "OPCIÓN 4 - CERVEZA (", contadorCerveza, ")" ;
				escribir "";
				Escribir "opción 9 - SALIR";
				escribir "";
				escribir "Seleccione una de las opciones";
				leer opcion;
			2:
				Borrar Pantalla;
				Si contadorFanta = 0 Entonces
					escribir "No hay mas Fanta, Elija otra opcion de Menú";
				SiNo
					escribir "Ha seleccionado - Fanta, que la disfrute!";
					escribir "";
					contadorFanta <- contadorFanta -1;
					escribir "Quedan", " ", contadorFanta," ","Fanta";
				FinSi
				escribir "Para seguir, presione una tecla";
				esperar tecla;
				Borrar Pantalla;
				escribir "si desea seguir retirando por favor seleccione nuevamente una OPCIÓN DE MENÚ o 9 para finalizar:";
				escribir "";
				escribir "MENÚ DE OPCIONES";
				escribir "";
				escribir "OPCIÓN 1 - COCA COLA (", contadorCoca, ")" ;
				escribir "OPCIÓN 2 - FANTA (", contadorFanta, ")" ;
				escribir "OPCIÓN 3 - SPRITE (", contadorsprite, ")" ;
				escribir "OPCIÓN 4 - CERVEZA (", contadorCerveza, ")" ;
				escribir "";
				Escribir "opción 9 - SALIR";
				escribir "";
				escribir "Seleccione una de las opciones";
				leer opcion;
			3:
				Borrar Pantalla;
				Si contadorSprite = 0 Entonces
					escribir "No hay mas Sprite, Elija otra opcion de Menú";
				SiNo
					escribir "Ha seleccionado - Sprite, que la disfrute!";
					escribir "";
					contadorSprite <- contadorSprite -1;
					escribir "Quedan", " ", contadorSprite," ","Sprite";
				FinSi
				escribir "Para seguir, presione una tecla";
				esperar tecla;
				Borrar Pantalla;
				escribir "si desea seguir retirando por favor seleccione nuevamente una OPCIÓN DE MENÚ o 9 para finalizar:";
				escribir "";
				escribir "MENÚ DE OPCIONES";
				escribir "";
				escribir "OPCIÓN 1 - COCA COLA (", contadorCoca, ")" ;
				escribir "OPCIÓN 2 - FANTA (", contadorFanta, ")" ;
				escribir "OPCIÓN 3 - SPRITE (", contadorsprite, ")" ;
				escribir "OPCIÓN 4 - CERVEZA (", contadorCerveza, ")" ;
				escribir "";
				Escribir "opción 9 - SALIR";
				escribir "";
				escribir "Seleccione una de las opciones";
				leer opcion;
			4:
				Borrar Pantalla;
				Si contadorCerveza = 0 Entonces
					escribir "No hay mas Cerveza, Elija otra opcion de Menú";
				SiNo
					escribir "Ha seleccionado - Cerveza, que la disfrute!";
					escribir "";
					contadorCerveza <- contadorCerveza -1;
					escribir "Quedan", " ", contadorCerveza," ","Cerveza";
				FinSi
				escribir "Para seguir, presione una tecla";
				esperar tecla;
				Borrar Pantalla;
				escribir "si desea seguir retirando por favor seleccione nuevamente una OPCIÓN DE MENÚ o 9 para finalizar:";
				escribir "";
				escribir "MENÚ DE OPCIONES";
				escribir "";
				escribir "OPCIÓN 1 - COCA COLA (", contadorCoca, ")" ;
				escribir "OPCIÓN 2 - FANTA (", contadorFanta, ")" ;
				escribir "OPCIÓN 3 - SPRITE (", contadorsprite, ")" ;
				escribir "OPCIÓN 4 - CERVEZA (", contadorCerveza, ")" ;
				escribir "";
				Escribir "opción 9 - SALIR";
				escribir "";
				escribir "Seleccione una de las opciones";
				leer opcion;
			9:
				Borrar Pantalla;
				escribir "Salir del programa, presione una tecla para finalizar...";
				esperar tecla;
				//Opcion9 - finaliza el programa
			De Otro Modo:
				escribir "OPCIÓN EQUIVOCADA, INGRESE NUEVAMENTE";
				leer opcion;
				//Vuelve a pedir opcion, en caso de poner una erronea
		FinSegun
	Hasta Que opcion = 9;
	//sale del programa
	
	
FinProceso
