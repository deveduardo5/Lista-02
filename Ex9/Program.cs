// 9. Um cliente deseja saber o total de suas compras em um supermercado. O aluno deve solicitar que o usuário insira o valor de cada compra até que ele digite 0. A soma dos valores das compras deve ser implementada usando as três estruturas de repetição.

double totalCompras = 0;
double valorCompra;
Console.WriteLine("Digite o valor das compras até que digite 0 para sair.");
while (true)
{
    Console.Write("Valor da compra: ");
    valorCompra = double.Parse(Console.ReadLine());
    if (valorCompra == 0)
    {
        break;
    }
    totalCompras += valorCompra;
    Console.WriteLine($"Total de compras: {totalCompras}");
}
// do while
totalCompras = 0;
do
{
    Console.Write("Valor da compra: ");
    valorCompra = double.Parse(Console.ReadLine());
    if (valorCompra == 0)
    {
        break;
    }
    totalCompras += valorCompra;
    Console.WriteLine($"Total de compras: {totalCompras}");
} while (true);

// for
totalCompras = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Valor da compra: ");
    valorCompra = double.Parse(Console.ReadLine());
    if (valorCompra == 0)
    {
        break;
    }
    totalCompras += valorCompra;
    Console.WriteLine($"Total de compras: {totalCompras}");
}