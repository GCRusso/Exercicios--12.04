/*3 - Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
- Se quantidade &lt;= 5 o desconto será de 2%
- Se quantidade &gt; 5 e quantidade &lt;=10 o desconto será de 3%
- Se quantidade &gt; 10 o desconto será de 5%
Dica: utilize if / else if / else 

&lt(less than) = menor que
&gt(greater than) = maior que 

1- criar diversos produtos
2- criar valores dos produtos(preço unitário)
3- calcular (total = quantidade adquirida * preço unitário)
4- quantidade = 5 desconto de 2%
5- > 5 && <10 desconto de 3%
6- > 10 desconto de 5%

*/

Console.WriteLine($@"
**********Lojinha do Russo**********

Produtos disponíveis a baixo:
1 - Mouse Gamer RGB / R$ 25,00
2 - Teclado Gamer RGB / R$ 23,00
3 - Caixa de som / R$ 74,20
4 - Gabinete / R$ 114,50
5 - Monitor 120hz / R$ R$ 319,90

            ----- Descontos -----
* 5 produtos do mesmo modelo, desconto de 2%.
* 6 até 10 produtos do mesmo modelo, desconto de 3%
* Acima de 10 produtos do mesmo modelo, desconto de 5%
");

Console.WriteLine($"Digite o respectivo numero do produto desejado: ");
int produto = int.Parse(Console.ReadLine());


switch (produto)
{
    case 1:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Você selecionou: Mouse Gamer RGB");
        Console.ResetColor();
        break;

    case 2:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Você selecionou: Teclado Gamer RGB");
        Console.ResetColor();
        break;

    case 3:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Você selecionou: Caixa de som");
        Console.ResetColor();
        break;

    case 4:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Você selecionou: Gabinete");
        Console.ResetColor();
        break;

    case 5:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Você selecionou: Monitor 120hz");
        Console.ResetColor();
        break;

    default:
        do
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Você informou um produto inexistente! Tente novamente: ");
            Console.ResetColor();
            produto = int.Parse(Console.ReadLine());
        }

        while (produto < 1 || produto > 5);
        {
            switch (produto)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Você selecionou: Mouse Gamer RGB");
                    Console.ResetColor();
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Você selecionou: Teclado Gamer RGB");
                    Console.ResetColor();
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Você selecionou: Caixa de som");
                    Console.ResetColor();
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Você selecionou: Gabinete");
                    Console.ResetColor();
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Você selecionou: Monitor 120hz");
                    Console.ResetColor();
                    break;
            }
        }
        break;

}

double mouse = 25;
double teclado = 23;
double som = 74.20;
double gabinete = 114.50;
double monitor = 319.90;

double total = 0;
double valor = 0;
double desconto = 0;


Console.WriteLine($"Qual a quantidade desejada?: ");
int quantidade = int.Parse(Console.ReadLine());

//Valor abaixo de 5 unidades
if(produto == 1 && quantidade < 5)
{
valor = Math.Round((mouse * quantidade), 2);
total = Math.Round((valor),2);
}
if(produto == 2 && quantidade < 5)
{
valor = Math.Round((teclado * quantidade),2);
total = Math.Round((valor),2);
}
if(produto == 3 && quantidade < 5)
{
valor = Math.Round((som * quantidade),2);
total = Math.Round((valor),2);
}
if(produto == 4 && quantidade < 5)
{
valor = Math.Round((gabinete * quantidade),2);
total = Math.Round((valor),2);
}
if(produto == 5 && quantidade < 5)
{
valor = Math.Round((monitor * quantidade),2);
total = Math.Round((valor),2);
}




//Valor com 5 unidades
if(produto == 1 && quantidade == 5)
{
valor = Math.Round((mouse * quantidade),2);
desconto = Math.Round((valor / 100 * 2),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 2 && quantidade == 5)
{
valor = Math.Round((teclado * quantidade),2);
desconto = Math.Round((valor / 100 * 2),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 3 && quantidade == 5)
{
valor = Math.Round((som * quantidade),2);
desconto = Math.Round((valor / 100 * 2),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 4 && quantidade == 5)
{
valor = Math.Round((gabinete * quantidade),2);
desconto = Math.Round((valor / 100 * 2),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 5 && quantidade == 5)
{
valor = Math.Round((monitor * quantidade),2);
desconto = Math.Round((valor / 100 * 2),2);
total = Math.Round((valor - desconto),2);
}




//Valor entre 5 e 10 produtos
if(produto == 1 && quantidade > 5 && quantidade < 11)
{
valor = Math.Round((mouse * quantidade),2);
desconto = Math.Round((valor / 100 * 3),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 2 && quantidade > 5 && quantidade < 11)
{
valor = Math.Round((teclado * quantidade),2);
desconto = Math.Round((valor / 100 * 3),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 3 && quantidade > 5 && quantidade < 11)
{
valor = Math.Round((som * quantidade),2);
desconto = Math.Round((valor / 100 * 3),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 4 && quantidade > 5 && quantidade < 11)
{
valor = Math.Round((gabinete * quantidade),2);
desconto = Math.Round((valor / 100 * 3),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 5 && quantidade > 5 && quantidade < 11)
{
valor = Math.Round((monitor * quantidade),2);
desconto = Math.Round((valor / 100 * 3),2);
total = Math.Round((valor - desconto),2);
}



//valor aciam de 10 produtos
if(produto == 1 && quantidade > 10)
{
valor = Math.Round((mouse * quantidade),2);
desconto = Math.Round((valor / 100 * 5),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 2 && quantidade > 10)
{
valor = Math.Round((teclado * quantidade),2);
desconto = Math.Round((valor / 100 * 5),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 3 && quantidade > 10)
{
valor = Math.Round((som * quantidade),2);
desconto = Math.Round((valor / 100 * 5),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 4 && quantidade > 10)
{
valor = Math.Round((gabinete * quantidade),2);
desconto = Math.Round((valor / 100 * 5),2);
total = Math.Round((valor - desconto),2);
}
if(produto == 5 && quantidade > 10)
{
valor = Math.Round((monitor * quantidade),2);
desconto = Math.Round((valor / 100 * 5),2);
total = Math.Round((valor - desconto),2);
}

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"O valor ficou em: R$ {valor}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Você ganhou um desconto de total: R$ {desconto}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"O total a pagar é de: R$ {total}");
Console.ResetColor();
