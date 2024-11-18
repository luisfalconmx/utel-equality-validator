// Ask for the values of A, B and C
Console.WriteLine("Ingresa el valor de A:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el valor de B:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Ingresa el valor de C:");
int c = int.Parse(Console.ReadLine());

// Define the initial value for while loop
bool shouldContinue = true;

while (shouldContinue)
{
    // show the menu
    Console.WriteLine("\n");
    Console.WriteLine("Selecciona una opción:");
    Console.WriteLine("1. Validar suma");
    Console.WriteLine("2. Salir");
    string option = Console.ReadLine();

    switch (option) {
        case "1":
            // Validate the sum of two numbers are equal to the result
            if (a + b == c || b + c == a || a + c == b) {
                Console.WriteLine("SON IGUALES");
            } else {
                Console.WriteLine("SON DISTINTOS");
            }
            break;
        case "2":
            // Exit the program
            Console.WriteLine("¡Hasta luego!");
            shouldContinue = false;
            break;
        default:
            // Show an error message
            Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
            break;
    }
}