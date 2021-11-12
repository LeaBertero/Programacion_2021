Proceso sin_titulo
	
	definir personas como caracter;
	definir opcion como entero;
	
	dimension personas[10];
	
	personas[0] <- "Primera persona";
	personas[1] <- "Segunda persona";
	personas[2] <- "Tercera persona";
	personas[3] <- "Cuarta persona";
	personas[4] <- "Quinta persona";
	personas[5] <- "Sexta persona";
	personas[6] <- "Septima persona";
	personas[7] <- "Octava persona";
	personas[8] <- "Novena persona";
	personas[9] <- "Décima persona";
	
	escribir "Ingrese un número para buscar una persona en particular dentro de la lista de 10 integrantes:";
	escribir "";
	escribir "La persona a buscar es:";
	leer personas[];
	escribir "La persona buscada es la N° ", " ", personas[], " - ", " Espere...";
	
	Limpiar Pantalla;
	escribir "Presione una tecla para continuar...";
	esperar tecla;
	
	escribir "Leyendo perssonas... aguarde por favor:";
	esperar 3 segundos;
	Limpiar Pantalla;
	
	escribir "";
	
	escribir personas[0];
	escribir personas[1];
	escribir personas[2];
	escribir personas[3];
	escribir personas[4];
	escribir personas[5];
	escribir personas[6];
	escribir personas[7];
	escribir personas[8];
	escribir personas[9];
	
	escribir "";
	
	escribir "La persona encontrada es la N° ", personas[];
	
	
	
	
FinProceso
