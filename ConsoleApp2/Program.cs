// See https://aka.ms/new-console-template for more information

#region ejercicio1
List<int> resultados = new List<int>() { 7, 8, 6, 7, 8, 9, 10, 5, 7, 8 };

foreach (int i in resultados)
{
    Console.WriteLine(i);
}
Console.WriteLine("el promedio es: " + resultados.Average());
#endregion

#region ejercicio2
List<int> edades = new List<int>() { 20, 33, 22, 24, 14, 22, 12, 17, 16, 15, 10, 23, 29, 12, 21, 4, 15, 13, 18, 13 };
int mayores = 0;
int menores = 0;
foreach (int i in edades)
{
    if (i >= 18)
    {
        mayores++;
    }
    else
    {
        menores++;
    }
}
Console.WriteLine("hay " + mayores.ToString() + " mayores y " + menores.ToString() + " menores");
#endregion

#region ejercicio3
List<string> nombres = new List<string>() { "Pedro", "Martin", "Juan", "Lautaro", "Saul" };
var nuevalista = nombres.OrderBy(o => o.Length);
Console.WriteLine(nuevalista.First().ToString());
Console.WriteLine(nuevalista.Last().ToString());
#endregion

#region ejercicio4
List<string> listaSuper = new List<string>() { "jabon", "papel", "tomate", "papa", "pollo" };
List<string> listaQuitar = new List<string>();
List<string> listaExtras = new List<string>();
Console.WriteLine("Ingrese nombre de elemento que va a comprar ('fin' para terminar):");
var elemento = Console.ReadLine();
while (elemento != "fin")
{
    if (elemento == "")
    {
        Console.WriteLine("no ingreso ningun elemento");
    }
    else if (listaSuper.Contains(elemento))
    {
        listaQuitar.Add(elemento);
        Console.WriteLine("El elemento estaba en la lista");
    }
    else
    {
        listaExtras.Add(elemento);
        Console.WriteLine("El elemento no estaba en la lista");
    }
    Console.WriteLine("Ingrese nombre de elemento que va a comprar ('fin' para terminar):");
    elemento = Console.ReadLine();
}
listaSuper = listaSuper.Except(listaQuitar).ToList();
Console.WriteLine("los elementos que estaban en la lista y no se compraron son:");
foreach (string s in listaSuper)
{
    Console.WriteLine(s);
}
listaSuper = listaSuper.Concat(listaExtras).ToList();
Console.WriteLine("los elementos comprados que no estaban en la lista son:");
foreach (string s in listaExtras)
{
    Console.WriteLine(s);
}
#endregion

#region ejercicio5
string[,] matriz=new string[5,5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if ((i + j) % 2 == 0)
        {
            matriz[i, j] = "P";
        }
        else
        {
            matriz[i, j] = "I";
        }
    }
}

for (int i = 0; i < 5; i++)
{
    string hilera = "";
    for (int j = 0; j < 5; j++)
    {
        hilera += matriz[i, j] + " ";
    }
    Console.WriteLine(hilera);
}
#endregion

#region ejercicio6
int[,] temperaturas= new int[5,7];
var rand = new Random();
int dia = 0;
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        temperaturas[i,j]= rand.Next(7, 38);
        dia++;
        if (dia == 31)
        {
            break;
        }
    }
}

for (int i = 0; i < 5; i++)
{
    string hilera = "";
    for (int j = 0; j < 7; j++)
    {
        hilera += temperaturas[i, j].ToString() + " ";
    }
    Console.WriteLine(hilera);
}
int encontrarIndice(int[,] arregloBidim, int elemento)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 7; j++)
        {
            if (arregloBidim[i, j] == elemento)
            {
                return j;
            }
        }
    }
    return -1;
}

int[] semana=new int[7];
string[] diasSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        semana[j] = temperaturas[i, j];
    }
    Console.WriteLine("La temperatura más alta en la cabina en la semana " + (i + 1) + " fue de: " + semana.Where(x => x != 0).Max()
    + " grados y se produjo el día " + diasSemana[Array.IndexOf(semana, semana.Where(x => x != 0).Max())]);
    Console.WriteLine("La temperatura más baja en la cabina en la semana " + (i + 1) + " fue de: " + semana.Where(x => x != 0).Min()
    + " grados y se produjo el día " + diasSemana[Array.IndexOf(semana, semana.Where(x => x != 0).Min())]);
    Array.Clear(semana);
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 7; j++)
    {
        semana[j] = temperaturas[i, j];
    }
    Console.WriteLine("El promedio de temperatura de la semana "+(i+1)+" es: "+Math.Truncate(semana.Where(c => c != 0).Average()));
    Array.Clear(semana);
}

Console.WriteLine("La temperatura más alta en la cabina en el mes de mayo fue de: " + temperaturas.Cast<int>().Max() + " grados" +
    " y se produjo un día " + diasSemana[encontrarIndice(temperaturas, temperaturas.Cast<int>().Max())]);
#endregion

#region ejercicio7
int[,] tablas = new int[10, 10];
for (int j = 0; j < 10; j++)
{
    tablas[0, j] = j;
}

for (int i = 0; i < 10; i++)
{
    tablas[i, 0] = i;
}

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        tablas[i, j] = i*j;
    }
}

for (int i = 0; i < 10; i++)
{
    string hilera = "";
    for (int j = 0; j < 10; j++)
    {
        hilera += tablas[i, j].ToString() + " ";
    }
    Console.WriteLine(hilera);
}
#endregion

#region ejercicio8
string[,] adivinanza=new string[10, 10];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        adivinanza[i, j] = "*";
    }
}

var rnd = new Random();
for(int n= 0; n < 19; n++)
{
    adivinanza[rnd.Next(10), rnd.Next(10)] = "X";
}

int intentos = 3;
do
{
    Console.WriteLine("Ingrese el numero de fila donde cree que está la X (0-9):");
    var ejex=Console.ReadLine();
    Console.WriteLine("Ingrese el numero de Columna donde cree que está la X (0-9):");
    var ejey = Console.ReadLine();
    int i, j;
    int.TryParse(ejex, out i);
    int.TryParse(ejey, out j);
    if(i>9 || j > 9)
    {
        Console.WriteLine("debe ingresar numeros entre 0 y 9");
    }else if (adivinanza[i, j] == "X")
    {
        Console.WriteLine("Correcto!");
        break;
    }
    intentos--;
    Console.WriteLine("incorrecto, "+intentos+" intento/s restante/s");
}while(intentos > 0);

for (int i = 0; i < 10; i++)
{
    string hilera = "";
    for (int j = 0; j < 10; j++)
    {
        hilera += adivinanza[i, j] + " ";
    }
    Console.WriteLine(hilera);
}
#endregion