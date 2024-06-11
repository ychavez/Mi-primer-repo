// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escribe la operacion que deseas realizar: ");


string operacion = Console.ReadLine();

if(operacion == "Dividr")
{
    System.Console.WriteLine("Escribe el primer numero: ");
    int num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Escribe el segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("El resultado de la division es: " + (num1 / num2));
}

if(operacion == "Restar")
{
    System.Console.WriteLine("Escribe el primer numero: ");
    int num1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Escribe el segundo numero: ");
    int num2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("El resultado de Restar es: " + (num1 - num2));
}

