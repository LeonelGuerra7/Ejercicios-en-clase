int numero = 1;

while (true)
{
    if (Div7y11(numero))
    {
        Console.WriteLine("El primer número divisible por 7 y 11 es: " + numero);
        break;
    }

    numero++;
}
    

    static bool Div7y11(int num)
{
    return num % 7 == 0 && num % 11 == 0;
}