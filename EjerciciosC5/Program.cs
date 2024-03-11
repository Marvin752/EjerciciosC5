static void numi()
{
    Console.Clear();
    int num = -1;
    int max = int.MinValue;
    int min = int.MaxValue;
    int cont = 0;
    Console.WriteLine("Ingrese \"0\" para salir");
    do
    {
        Console.WriteLine();
        Console.Write("Ingrese valores: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num != 0)
        {
            max = Math.Max(max, num);
            min = Math.Min(min, num);
            cont++;
        }
    } while (num != 0);
    if (cont != 0)
    {
        Console.WriteLine();
        Console.WriteLine("El nuemro mayor fue: " + max);
        Console.WriteLine("El numero menro fue: " + min);
    }
    Console.WriteLine();
    Console.Write("Presione \"Enter\" para contuniar...");
    Console.ReadKey();  
}
static void adivi()
{
    Console.Clear();
    Console.Write("Ingrese un numero: ");
    int numi = Convert.ToInt32(Console.ReadLine());
    int numi1 = numi * 2;
    int numi2 = numi1 + 8;
    int numi3 = numi2 * 5;
    String nose = Convert.ToString(numi3);
    String no = nose.Substring(0,nose.Length - 1);
    int numi4 = Convert.ToInt32(no) - 4;
    Console.WriteLine();
    Console.WriteLine("El numero es: " + numi4);
    Console.WriteLine();
    Console.Write("Presione \"Enter\" para contuniar...");
    Console.ReadKey();
}
static void pala()
{
    Console.Clear();
    String ingre;
    Console.Write("Escriba una frase: ");
    ingre = Console.ReadLine().ToUpper().Trim();
    int hola = 1, j = 0, s = 0;
    while (j < ingre.Length)
    {
        if (ingre[j] == ' ')
        {
            hola++;
        }
        else if (ingre[j] == 'A' || ingre[j] == 'E' || ingre[j] == 'I' || ingre[j] == 'O' || ingre[j] == 'U')
        {
            s++;
        }
        j++;
    }
    Console.WriteLine();
    Console.WriteLine("La palabra tiene {0} palabras", hola);
    Console.WriteLine("La palabra tiene {0} vocales", s);
    Console.WriteLine();
    Console.Write("Presione \"Enter\" para contuniar...");
    Console.ReadKey();
}
static void poli()
{
    Console.Clear();
    string ori;
    string difi = "";
    Console.Write("Ingrese un palindromo: ");
    ori = Console.ReadLine().ToLower().Trim();
    for (int i = ori.Length -1; i >= 0; i--)
    {
        difi = string.Concat(difi, ori[i]);
    }
    if(ori == difi)
    {
        Console.WriteLine();
        Console.WriteLine("La palabra es un palindromo");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("La palabra no es un palindromo");
    }
    Console.WriteLine();
    Console.Write("Presione \"Enter\" para contuniar...");
    Console.ReadKey();
}
try
{
    int op = 0;
    do
    {
        Console.Clear();
        Console.WriteLine("Elija el pograma que quiere ejecutar");
        Console.WriteLine();
        Console.WriteLine("1) Valores positivos");
        Console.WriteLine("2) Adivinar el numero");
        Console.WriteLine("3) Contador de palabras");
        Console.WriteLine("4) Palíndromo");
        Console.WriteLine("0) Salir");
        Console.WriteLine();
        Console.Write("> ");
        op = Convert.ToInt32(Console.ReadLine());
        if (op != 0)
        {
            switch (op)
            {
                case 1:
                    numi();
                    break;
                case 2:
                    adivi();
                    break;
                case 3:
                    pala();
                    break;
                case 4:
                    poli();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("La opción ingresada no es valida");
                    Console.ReadKey();
                    break;
            }
        }
    } while (op != 0);
    Console.WriteLine();
    Console.WriteLine("Gracias por usar el programa :3");
}
catch(Exception error)
{
    Console.WriteLine();
    Console.WriteLine("El formato ingresado no es valido " + error);
}