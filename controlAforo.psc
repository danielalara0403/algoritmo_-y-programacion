Algoritmo controlAforo
	Definir asistente, exceso Como Entero
	
	Escribir "Ingrese la cantidad de asistente confirmado. ";
	Leer asistente;
	
	SI asistente > 150 Entonces
		exceso = asistentes -150;
		Escribir "!ALERTA DE SEGURIDAD¡ se ha excedido la capacidad maxima de la sala";
		Escribir " Hay", exceso, "persona(s) por encima de limite permitido.";
	FinSi
	
	Escribir "Registro de aforo concluido. ";
FinAlgoritmo
