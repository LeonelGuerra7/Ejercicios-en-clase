string Contra = "Jutiapa";
string ingresa;

do
{
    Console.Write("Ingresa la contraseña: ");
    ingresa = Console.ReadLine();

    if (ingresa != Contra)
    {
        Console.WriteLine("Contraseña incorrecta. Intenta de nuevo.");
    }

} while (ingresa != Contra);

Console.WriteLine("¡Contraseña correcta! Bienvenido a Jutiapa.");
    
