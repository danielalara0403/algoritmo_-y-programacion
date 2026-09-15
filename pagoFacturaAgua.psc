Algoritmo pagoFacturaAgua
	Definir montoOriginal, recargo, montoTotal Como Real
	Definir diasRetraso como Entero;
	
	Escribir " Ingrese el monto original de la factura ($ - COD)";
	Leer montoOriginal;
	Escribir "Ingrese los dias de retraso en el pago. ";
	Leer diasRetraso;
	
	montoTotal <- montoOriginal
	
	SI diasRetraso > 5 Entonces
		recargo <- montoOriginal *0.05;
		montoTotal <- montoOriginal + recargo;
		Escribir " Se aplicado un recargo de 5% ($",recargo, ") por mora."
	FinSi
	Escribir "monto total definitivo a pagar.$",montoTotal; 
FinAlgoritmo
