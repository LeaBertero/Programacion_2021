Proceso sin_titulo
	
	definir clave como caracter;
	
	clave <- "Hola";
	
	escribir "Ingrese la clave";
	leer clave;
	
	Repetir
		si clave = "Hola" Entonces
			
			escribir "La clave es correcta";
			
		SiNo
			escribir "Ingrese nuevamente la clave";
			leer clave;
			si clave = "Hola" Entonces
				escribir "La clave es correcta, ingresando...";
			FinSi
			
		FinSi
	Hasta Que clave = "Hola";
	
	escribir "Bienvendo al sistema, presione una tecla para continuar";
	esperar tecla;
	
FinProceso
