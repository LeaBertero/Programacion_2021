Proceso sin_titulo
	
	definir opcion como entero;
	
	escribir "Ingrese una de las opciones";
	escribir "";
	escribir "Opcion 1";
	escribir "Opcion 2";
	escribir "Opcion 3";
	leer opcion;
	
	
	Segun opcion Hacer
		1:
			escribir "Se ha ingresado a la opcion 1";
			esperar tecla;
		2:
			escribir "Se ha ingresado a la opcion 2";
			Esperar Tecla;
		3:
			escribir "Se ha ingresado a la opcion 3";
			esperar tecla;
			
		De Otro Modo:
			escribir "Salir";
			esperar tecla;
	FinSegun
	
	escribir "El programa ha finalizado";
	
FinProceso
