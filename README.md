# Swp
 Este es mi primer programa en C#, donde programé la parte lógica de un juego. Por motivos irrelevantes, el proyecto de hacer una aplicación para Android con este código se suspendió, por lo que el ejecutable se puede correr y jugar desde la consola pero no existe una versión con GUI.
 Últimas modificaciones hechas en diciembre de 2018.
 
 # Mecánica del juego
El juego consiste en mover las filas y columnas para que los números queden en orden ascendente o descendente en sentido horizontal o vertical. La "C" representa el comodín que reemplaza a cualquier número.
El sistema imprimirá una tabla y la palabra "Move". Aquí se debe escribir una de las siguientes tres opciones: "c" para mover una columna, "f" para mover una fila o "s" para reordenar de manera aleatoria una fila. Luego se debe apretar la tecla Intro para continuar. Ahora debemos insertar el número de fila/columna que queremos seleccionar (la numeración arranca en 0 y aumenta de izquierda a derecha y de arriba a abajo) y volver a confirmar con Intro. En el caso de las opciones "c" y "f" debemos repetir este paso pero esta vez indicando el número de fila/columna con la que queremos intercambiar.
El sistema volverá a imprimir la misma tabla reordenada y le avisará si consiguió el objetivo. Si requiere seguir ordenando para alcanzar el objetivo, puede repetir los pasos nuevamente cuantas veces sea necesario.
