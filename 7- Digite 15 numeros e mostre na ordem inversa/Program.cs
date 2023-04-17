int[] numeros = new int[16];

for (int i = 1; i < 16; i++)
{
    Console.WriteLine($"Digite o numero {i}:");

    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Números digitados na ordem inversa:");


for (int i = 15; i >= 0; i--)
{
    Console.WriteLine(numeros[i]);
}