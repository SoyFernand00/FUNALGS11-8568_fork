int[] lista=new int[5];
Random r = new Random();
for (int i = 0; i < lista.Length; i++)
{
    lista[i] = r.Next(1,11);
}
foreach  (int i in lista)
{
    Console.WriteLine(i);
}

Console.WriteLine("Ingresar nuevo:");
int n=int.Parse(Console.ReadLine());
Array.Resize(ref lista, lista.Length+1);
lista[lista.Length-1] = n;

foreach (int i in lista)
{
    Console.WriteLine(i);
}

/*Console.WriteLine("Ingresar nuevo:");
int n=int.Parse(Console.ReadLine());
Array.Resize(ref lista, n);
lista[lista.Length-1] = n;*/

foreach (int i in lista)
{
    Console.WriteLine(i);
}