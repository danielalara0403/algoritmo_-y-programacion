Algoritmo BonificacionFinal
	Definir unidadesvendidas, antiguedad  Como Entero;
	Definir sueldoBase, bonificacion, sueldoFinal Como Real;
	
	sueldo <- 2200000
	bonificacion <- 200000
	sueldofinal <- sueldoBase
	
	Escribir "Ingrese la cantidad de unidades vendidas en el mes . ";
	Leer unidadesVendidas; 
	Escribir " Ingrese los años de antiguedad en la empesa. ";
	Leer antiguedad;
	
	SI unidadesvendidas > 50 Y antiguedad > 2 Entonces
	   sueldofinal <- sueldoBase + bonificacion;
Escribir "!Felicidades ¡ Ha cumplido con las metas de ventas! tienes una bonificacion de: $",bonificacion ;
	FinSi
	Escribir " Tu salario este mes es de: $",sueldofinal;
	
FinAlgoritmo
