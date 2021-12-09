Proceso sin_titulo
	
	definir frase como caracter;
	definir contador como entero;
	definir opc como entero;
	
	Repetir
		
		escribir "Ingresar una frase";
		leer frase;
		escribir "Presione una tecla para ver la frase en minuscula y mayuscula";
		escribir "";
		escribir "La frase esta en minuscula";
		escribir "La frase ingresada es:  - ", frase;
		escribir "";
		escribir "La frase ahora, esta en mayusculas";
		frase <- Mayusculas(frase);
		escribir frase;
		escribir "Presione una tecla para iniciar el deletro y verificar la cantidad de letras de la frase...";
		esperar Tecla;
		
		
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
	
	escribir "Ha salido del programa, que tenga buenos dias !";
	
FinProceso
