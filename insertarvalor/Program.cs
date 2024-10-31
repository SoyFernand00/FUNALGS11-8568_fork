void imprime(int[] lis)
{
    foreach (int i in lis)
    {
        Console.WriteLine(i);
    }
}
int[] lista = { 5, 6, 8, 9 };
imprime(lista);

//pedir numero y posicion
//aumentar tamaño de arreglo
//desplazar numeros hacia el final hasta insertar nuevo valor

Console.WriteLine("Ingresar nuevo:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Ingresar posicion:");
int p = int.Parse(Console.ReadLine());

Array.Resize(ref lista, lista.Length+1);
for (int i = lista.Length-1; i > p; i--)
{
    lista[i]=lista[i-1];
}
lista[p] = n;
imprime(lista);