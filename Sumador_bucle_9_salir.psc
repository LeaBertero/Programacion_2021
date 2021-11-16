Proceso Sumador_bucle
	
	//variables definidas para el ingreso de variables numéricas.-
	definir num1, num2, res, Finbucle como Real;
	
	Borrar Pantalla;
	
	//se le asigna el numero 9 a variable Finbucle para decirle al usuario, que presionando esa tecla.-
	//sale del bucle y el programa termina..
	
	Finbucle <- 9;
	//Nota para el usuario, donde se le explica que no puede ingresar cero como número válido.-
	escribir "BIENVENIDO";
	
	escribir "";
	
	escribir "Éste es un programa de sumador en bucle";
	escribir "El mismo le pedirá que ingrese dos numeros, los cuales no permiten el ingreso de cero, como número valido";
	escribir "Lo cual, pedirá, que ingrese nuevamente un número distinto de cero, para poder realizar definitivamente, la operacion";
	escribir "";
	
	//ingresa el primer número.-
	escribir "Presione una tecla para ingresar número";
	
	//espera que el usuario presione una tecla.-
	esperar tecla;
	
	//borra la pantalla y a contiuacion, pide ingresar el primer número.-
	Borrar Pantalla;
	
	Repetir
		//Ingresa el primer número.-
		escribir "Ingrese primer numero";
		leer num1;
		//En este segmento dice que si ususario ingresa numero cero, da ingreso incorrecto y el programa
		//pide nuevamente el ingreso de un número valido, es decir... un número distinto de cero. Cuando se 
		//Ingresa un número distinto de cero, el programa sigue su condición hasta realizar la sumatoria de los
		//números ingresados, generando como respuesta, el resultado final.-
		Si num1 = 0 Entonces
			//En este sección realiza el bucle de pedir a usuario, que ingrese el número correcto.-
			Repetir
				escribir "Ingresar nuevamente Primer numero";
				
				leer num1;
				
			Hasta Que num1 > 0;
			Borrar Pantalla;
			
			//Con el ingreso del segundo número, es la misma secuencia que en el ingreso del primer número.-
			escribir "Ingrese segundo numero";
			leer num2;
			
			si num2 = 0 Entonces
				
				repetir 
					escribir "Ingrese nuevamente Segundo número";
					leer num2;
				Hasta Que num2 > 0;
				
				Borrar Pantalla;
				
			FinSi
			
		SiNo
			
			escribir "Ingrese segundo numero";
			leer num2;
			
		FinSi
		//Borra pantalla y muestra mensaje para que usuario vea en pantalla su resultado de dicha operacion.-
		Borrar Pantalla;
		
		escribir "Ha finalizado la suma de dos numeros, presione una tecla para ver su resultado";
		
		res <- 0;
		
		res <- num1 + num2;
		escribir "";
		//Muestra resultado.-
		
		escribir "Su resultado es", " ---->> ", res ;
		
		esperar tecla;
		
		escribir "Presione una tecla";
		
		Esperar Tecla;
		
		Borrar Pantalla;
		
		//Aqui finaliza la operación mencionada anteriormente, y sale del programa, una vez que
		// usuario, presiona la tecla 9 .-
		escribir "Ingrese 9 para salir o INTRO para realizar otra suma de numeros positivos o negativos";
		leer Finbucle;
		
		//usuario presiona la tecla 9 y sale del programa.-
	Hasta Que Finbucle = 9;
	
	//Mensaje para usuario, que ha finalizado el programa.-
	escribir "Gracias, lo esperamos nuevamente =)";
	escribir "";
	
	escribir "Presione una tecla para salir";
	esperar tecla;
	
	
FinProceso
