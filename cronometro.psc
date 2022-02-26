Proceso sin_titulo
	
	definir hora, min, seg como entero;
	DEFINIR salir como entero;
	
	salir <- 3;
	
	Repetir
		
		escribir "HORAS";
		
		Limpiar Pantalla;
		
		
		Para hora <- 0 Hasta 23 Con Paso 1 Hacer
			
			escribir hora, " ", "Horas";
			
		FinPara
		
		
		Limpiar Pantalla;
		
		escribir "MINUTOS";
		
		
		Para min <- 0 Hasta 59 Con Paso 1 Hacer
			
			escribir min, " ", "Minutos";
			
		FinPara
		
		Limpiar Pantalla;
		
		escribir "SEGUNDOS";
		
		
		Para seg <- 0 Hasta 59 Con Paso 1 Hacer
			
			escribir seg, " ", "Segundos";
			
		FinPara
		
		ESCRIBIR "";
		
		escribir "Para salir? - Ingrese el numero 3";
		leer salir;
		
		
	Hasta Que salir = 3 
	
FinProceso
