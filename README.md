# Singleton

Es un patr�n creacional. [Link descripci�n](https://sourcemaking.com/design_patterns/singleton)

Garantiza que solo exista una instancia y tengamos un m�todo de acceso global a la misma.

## Diagrama de clases
![UML](singleton.jpg)

## SOLID

* Single responsibility

La responsabilidad de un singleton es mantener una instancia accesible globalmente y controlar el acceso a sus dependencias. Luego es responsabilidad del desarrollador modelarla correctamente para que tenga una responsabilidad unica.

* Open/Closed principle

Si se hereda la clase para extenderla, habr�a que modificar el m�todo getInstance para que refleje en la instancia devuelta la funcionalidad heredada.

* Liskov substitution

Heredando la clase singleton deber�a cumplirse con este principio.

* Interface segregation

Depende del buen criterio del desarrollador.

* Dependency inversion

Tambi�n depende del criterio del desarrollador.