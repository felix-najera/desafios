// See https://aka.ms/new-console-template for more information
static void pares()
{
    Console.WriteLine("Ingresa un numero entero positivo");
    int numeros = int.Parse(Console.ReadLine());
    
    for(int i = 1; i <= numeros; i++)
    {
        if (i % 2 == 1)
        {
            continue;
        }
        Console.WriteLine(i);
    }
}
//pares();
//numero primo 
static void primos()
{
    Console.WriteLine("ingrese un numero entero positivo");
    int num = int.Parse(Console.ReadLine());
    bool primo = true;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            primo = false;
            break;
        }
    }
    if (primo && num > 1)
    {
        Console.WriteLine("es primo");
    }
    else
    {
        Console.WriteLine("es primo");
    }
}
primos();
//promedio

static void promedio()
{
        int suma = 0;
        int contador = 0;
        string txt = "";
        Console.WriteLine("ingrese las notas del alumno del 1 al 10 o escriba fin para terminar");
        txt = Console.ReadLine();
        while (txt != "fin")
        {
            try
            {
                int nota = int.Parse(txt);
                if (nota >= 1 && nota <= 10)
                {
                    suma += nota;
                    contador++;
                }
                else
                {
                    Console.WriteLine("la nota debe estar entre 1 y 10.");
                }
            }
            catch
            {
                Console.WriteLine("datos invalidos");
            }
            Console.WriteLine("ingrese otra nota o escriba fin:");
            txt = Console.ReadLine();
        }
        if (contador > 0)
        {
            double promedio = (double)suma / contador;
            Console.WriteLine("El promedio es: " + promedio);
        }
        else
        {
            Console.WriteLine("no se ingresaron notas.");
        }
}
//promedio();