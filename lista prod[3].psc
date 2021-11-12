Proceso sin_titulo
	
	definir producto como caracter;
	definir cont como entero;
	
	Dimension  cont[4];
	cont[1] <-  [1];
	cont[2] <-  [2];
	cont[3] <-  [3];
	
	dimension producto[4];
	
	escribir "Ingrese producto"," - ", cont[1];
	leer producto[1];
	
	escribir "Ingrese producto", " - ", cont[2];
	leer producto[2];
	
	escribir "Ingrese producto", " - ", cont[3];
	leer producto[3];
	
	escribir "Presione uuna tecla para ver los pruductos de la lista";
	escribir "";
	
	Borrar Pantalla;
	escribir "";
	
	Escribir  "Lista de productos";
	
	escribir producto[1];
	escribir producto[2];
	escribir producto[3];
	
	
	escribir "Presione una tecla para salir";
	Esperar Tecla;
FinProceso
