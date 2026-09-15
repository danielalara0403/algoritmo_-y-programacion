Algoritmo AlertaTemperatura
	Definir temp Como Real
	
	Escribir "Ingrese la temperatura actual en grados celsius (°c).";
	Leer temp;
	
	SI temp < 0 Entonces
		Escribir "ADVERTENCIA: Temperatura bajo cero detectada.";
		Escribir "Riesgo de congelamiento en carreteras. ", "Conduzca con precaucion. ";
		
	FinSi
	 Escribir " Registro meteorologico completado.";
	
FinAlgoritmo
