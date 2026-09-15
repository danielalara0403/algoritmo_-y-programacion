Algoritmo DescuentoEspecial
	Definir montocompra, descuento, montofinal Como Real
	
	Escribir " Ingrese el valor total de su compra ($).";
	Leer montocompra;
	
	montofinal <- montocompra;
	SI montocompra > 100 Entonces 
		descuento <- montocompra * 0.10;
		montofinal <- montocompra - descuento;
		Escribir " ¡ felicidades ! Ha recibido un descuento de: $", descuento
	FinSi
	
	Escribir " El total a pagar es: $", montofinal;
	
FinAlgoritmo
