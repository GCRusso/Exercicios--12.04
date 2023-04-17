/*4 - Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
menor valor lido.*/

int maior = 0, menor = 0, i = 0, numero = 0, tl = 10;

Console.WriteLine($"Informe o 1 número: ");
numero = Convert.ToInt32(Console.ReadLine());
maior = numero;
menor = numero;
i = 1;

for (i= 2; i <= tl; i++)
{
    Console.WriteLine($"Informe o " + i + " número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    if (numero < menor)
    {
        menor = numero;
    }

    if (numero > maior)
    {
        maior = numero;
    }
}

Console.WriteLine($"O maior número é: {maior}");
Console.WriteLine($"O menor número é: {menor}");
