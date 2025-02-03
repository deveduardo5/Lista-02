// 5. Um gerente de loja quer saber quantos produtos estão em estoque. O aluno deve solicitar que o usuário insira a quantidade de produtos recebidos e vendidos até que ele digite 0. Depois disso, o programa deve calcular a quantidade total de produtos em estoque, utilizando as três estruturas de repetição.

int produtosEstoque = 0;
int produtosRecebidos;
int produtosVendidos;
Console.WriteLine("Digite a quantidade de produtos recebidos e vendidos até que digite 0 para sair.");
while (true)
{
    Console.Write("Produtos recebidos: ");
    produtosRecebidos = int.Parse(Console.ReadLine());
    if (produtosRecebidos == 0)
    {
        break;
    }
    Console.Write("Produtos vendidos: ");
    produtosVendidos = int.Parse(Console.ReadLine());
    produtosEstoque += produtosRecebidos - produtosVendidos;
    Console.WriteLine($"Produtos em estoque: {produtosEstoque}");
}

// do while
produtosEstoque = 0;
do
{
    Console.Write("Produtos recebidos: ");
    produtosRecebidos = int.Parse(Console.ReadLine());
    if (produtosRecebidos == 0)
    {
        break;
    }
    Console.Write("Produtos vendidos: ");
    produtosVendidos = int.Parse(Console.ReadLine());
    produtosEstoque += produtosRecebidos - produtosVendidos;
    Console.WriteLine($"Produtos em estoque: {produtosEstoque}");
} while (true);

// for
produtosEstoque = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Produtos recebidos: ");
    produtosRecebidos = int.Parse(Console.ReadLine());
    if (produtosRecebidos == 0)
    {
        break;
    }
    Console.Write("Produtos vendidos: ");
    produtosVendidos = int.Parse(Console.ReadLine());
    produtosEstoque += produtosRecebidos - produtosVendidos;
    Console.WriteLine($"Produtos em estoque: {produtosEstoque}");
}
