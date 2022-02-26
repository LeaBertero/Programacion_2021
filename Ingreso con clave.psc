Proceso IngresoConclave
	
	definir clave como caracter;
	
	
	clave <- "clave123";
	
	escribir "Ingrese clave";
	leer clave;
	
	
	
	Repetir
		Si clave = "clave123" Entonces
			Escribir  "Clave valida - ";
		SiNo
			escribir "Clave no valida -  ingrese de nuevo";
			leer clave;
		FinSi
	Hasta Que clave = "clave123";
	
	escribir "clave ingresada es correcta";
	
FinProceso
