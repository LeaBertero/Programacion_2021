Proceso sin_titulo
	
	
	definir frase Como Caracter;
	definir contador como entero;
	
	escribir "Ingrese frase";
	leer frase;
	
	escribir "";
	
	Para contador<-0 Hasta Longitud(frase) Con Paso 1 Hacer
		Escribir "Letra numero: ", contador +1, " - ", SubCadena(frase,contador,contador);
		Esperar Tecla;
	FinPara
	
	
FinProceso
