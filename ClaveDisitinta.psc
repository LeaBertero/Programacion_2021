Proceso IngresoConClave
	
	definir clave como caracter;
	
	clave <- "Hola";
	
	escribir "Ingrse su clave";
	leer clave;
	
	Mientras clave <> "Hola" Hacer
		
		escribir "La clave es distinta de (Hola), ingrese nuevamente la clave correcta";
		Esperar Tecla;
		
		Repetir
			
			si clave = "Hola" Entonces
				escribir "Clave correcta"; 
			SiNo
				escribir "Ingrese nuevamente la clave";
				leer clave;
				
			FinSi
			
		Hasta Que clave = "Hola"; 
		
	FinMientras
	
	escribir "Se ha ingresado la clave", " ()***() " , clave, " ()***() " , "Por lo tanto es correcto, presione una tecla para continuar..." ;
	Esperar Tecla;
	
FinProceso
