// Crear un Loop que imprima todos los valores del 1 al 255
for (short i = 1; i <= 255; i++)
{
    Console.WriteLine(i);
}
/* Crear un nuevo loop que imprima todos los valores del 1 al 100 que son divisibles 
por 3 o 5, pero no ambos
    if ((i % 3 == 0 || i % 5 == 0) && !(i % 3 == 0 && i % 5 == 0))
    {
        Console.WriteLine(i);
    } */
/* Modificar el bucle previo para imprimir todos los valores de 1 al 100
pero que impriman Fizz para divisible de 3 Buzz para 5 y FizzBuzz para ambos */
for (short idx = 1; idx <= 255; idx++)
{
    if (idx % 3 == 0 && idx % 5 == 0)
    {
        Console.WriteLine("FizzBuzz" + " valor = " + idx);
    }
    else if (idx % 3 == 0)
    {
        Console.WriteLine("Fizz" + " valor = " + idx);
    }
    else if (idx % 5 == 0)
    {
        Console.WriteLine("Buzz" + " valor = " + idx);
    }
    else
    {
        Console.WriteLine("No divisible por 3 ni por 5" + " valor = " + idx);
    }
}

/* Utilizar un bucle while en lugar de for para FizzBuzz */
short i = 1;
while (i <= 255)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz" + " valor = " + i);
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz" + " valor = " + i);
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz" + " valor = " + i);
    }
    else
    {
        Console.WriteLine("No divisible por 3 ni por 5" + " valor = " + i);
    }
    i++;
}
