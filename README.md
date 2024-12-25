# C# Métodos
Los metodos son bloques de código que realizan una tarea específica, son reutilizzbles y permiten mantener la legibilidad del código.
El desarrollo de un método comienza con la creación de una firma del método.  La firma del método declara el tipo de retorno, el nombre y los parametros de entrada del método.

```csharp
SayHello();

void SayHello()
{
	Console.WriteLine("Hello World")M
}
```
El nombre del método es `SayHello`. Su tipo de retorno es void, lo que significa que no devuelve ningún dato.
Los métodos pueden deovolver  un valor de cualquier tipo de dato, como bool, int, double y tambien matrices.

## Parámetros en métodos
La información que consumen un metodo se llama parámetro. Parámetro se refiere  a la variable de la firma del método.
Un parámetro se define especificando el tipo de dato seguido del nombre del parámetro.
El argumento es el valor que se pasa cuando se llama al método.

```csharp
CountTo(5);

void CountTo(int max)
{
	for (int i = 0; i < max; i++)
	{
		Console.WriteLine();
	}
}
```
## Alcance del método
Cada bloque de código tiene su propio ámbito. Ámbito es la region de un programa donde se puede acceder a determinados datos.
Las variable globales no están restringidas a ningún ámbito, se pueden utilizar en cualquier parte del programa.
Las variable declaradas dentro de un metodo solo son accesibles para ese método.

## Parámetros de tipo valor y referencia
