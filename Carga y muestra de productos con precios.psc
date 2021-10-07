Proceso Carga_productos_precios
	
	definir producto como caracter;
	definir precio como real;
	dimension producto[3];
	dimension precio[3];
	definir contador como entero;
//	definir total como real;
	
	escribir "En este programa puede cargar dos productos con sus respectivos precios, presione una tecla para comenzar";
	
	esperar tecla;
	Limpiar Pantalla;
	
	Para contador<-1 Hasta 2 Con Paso 1 Hacer
		Limpiar Pantalla;
		escribir "Producto", " N° ", contador;
		leer producto[contador];
		Limpiar Pantalla;
		escribir "Precio", " N° ", contador;
		leer precio[contador];
	FinPara
	
	escribir "Presione una tecla para ver la lista de sus productos cargados";
	esperar tecla;
	Limpiar Pantalla;
	
	escribir "**** LISTA DE PRECIOS Y PRODUCTOS ****";
	
	Para contador<-1 Hasta 2 Con Paso 1 Hacer
		escribir "";
		escribir "producto", " N° ",contador, " = ", producto[contador];
		escribir "precio", " N° ", contador, " = "," $ ", precio[contador];
	FinPara
	
FinProceso
