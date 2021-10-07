Proceso Prueba_arreglo_nuevo
	
	definir frase como cadena;
	definir contador como entero;
	
	
	limpiar pantalla;
	escribir "Ingrese una frase...";
	leer frase;
	
	//0123456789012345678901234567890
	//Hoy es un día mas de cuarentena
	
	Limpiar Pantalla;
	
	escribir "La frase ingresada es:", " ", frase;
	escribir "";
	escribir "La longitud de la frase es:", " ", longitud(frase), " ", "letras";
	escribir "";
	escribir "";
	Para contador<-0 Hasta Longitud(frase)-1 Con Paso 1 Hacer
		escribir "N° de letra"," - ", contador+1 , " - ", SubCadena(frase,contador,contador);
		esperar tecla;
	FinPara
	
	
	
FinProceso
