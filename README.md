## Ejercicio 4
**�String es una tipo por valor o un tipo por referencia?**

String es un tipo por referencia que se almacenan siempre en el heap, y lo que se pasa a una funci�n
como par�metro no es una copia del dato, como en el caso de los tipos por valor, sino una copia de la referencia al dato.

**�Qu� secuencias de escape tiene el tipo string? Secuencias de escape:**

' - comilla simple

" - comillas dobles

\ - barra invertida

\0 - nulo

\a - alerta

\b - retroceso

\f - alimentaci�n de formulario

\n - nueva l�nea

\r - retorno de carro

\t - pesta�a horizontal

\v - pesta�a vertical

\u - Secuencia de escape Unicode (UTF-16)

\U - Secuencia de escape Unicode (UTF-32)

\x - Secuencia de escape Unicode similar a "\u" excepto con longitud variable

**�Qu� sucede cuando utiliza el car�cter @ antes de una cadena de texto?**

Colocar @ antes de una cadena de texto sirve para interpretar literalmente el contenido de la cadena,
es decir, si una cadena tiene @ justo antes de las comillas de apertura, la cadena se interpretar� literalmente
sin prestar atenci�n a c�digos de escape, saltos de l�nea, o cualquier otro s�mbolo que est� contenga y que pudiera
hacer protestar al compilador o hacer que �ste interpretara de forma especial dichos s�mbolos.