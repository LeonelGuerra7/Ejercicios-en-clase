int suma = 0;
int numero;

Console.WriteLine("Ingresa números positivos. Ingresa un número negativo para terminar.");

while (true)
{
    Console.Write("Ingresa un número: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out numero))
    {
        if (numero < 0)
            break; 

        suma += numero; 
    }
    else
    {
        Console.WriteLine("Por favor, ingresa un número válido.");
    }
}

Console.WriteLine("La suma de los números ingresados es: " + suma);