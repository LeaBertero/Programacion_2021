Proceso sin_titulo
	
	definir frase como caracter;
	definir contador como entero;
	definir opc como entero;
	
	Repetir
		
		escribir "Ingresar una frase";
		leer frase;
		escribir "";
		escribir "La frase ingresada es";
		escribir "";
		frase <- Mayusculas(frase);
		escribir frase;
		esperar Tecla;
		
		escribir "Presione una tecla para comenzar el deletro de la frase ingresada";
		
		Esperar Tecla;
		Limpiar Pantalla;
		
		escribir Longitud(frase);
		
		Para contador<-0 Hasta Longitud(frase)-1 Con Paso 1 Hacer
			escribir "           letra N°  " , " ---> ", contador +1 , "  - > ", SubCadena(frase,contador,contador);
			esperar tecla;
		FinPara
		
		opc <- 9;
		escribir "Ingrese opcion 9 para salir.. de lo contrario presione ENTER para ingresar una frase nueva";
		leer opc;
		
		Limpiar Pantalla;
		
	Hasta Que opc = 9;
	
FinProceso
