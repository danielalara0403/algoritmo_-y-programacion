Algoritmo controlvelocidad
	Definir velocidad como Real ;
	
	Escribir " ingrese la velocidad registrada del vehiculo (km/h),";
	Leer velocidad
	
	SI velocidad > 80 Entonces
		Escribir "¡ALERTA! Ha superado el limite de velocidad de 80 km/h.";
		Escribir " se ha generado una fotomulta automaticamente.";
	FinSi
	Escribir "Evaluacion de transito finalizada.";
	
FinAlgoritmo
