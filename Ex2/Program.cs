// 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas até que ele digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for.

double despesas = 0;
double despesa;
Console.WriteLine("Digite suas despesas até que digite um valor negativo para sair.");

// while
while (true)
{
    Console.Write("Despesa: ");
    despesa = double.Parse(Console.ReadLine());
    if (despesa < 0)
    {
        break;
    }
    despesas += despesa;
    Console.WriteLine($"Despesas: {despesas}");
}
Console.WriteLine($"Total de despesas: {despesas}");

// do while
despesas = 0;
do
{
    Console.Write("Despesa: ");
    despesa = double.Parse(Console.ReadLine());
    if (despesa < 0)
    {
        break;
    }
    despesas += despesa;
    Console.WriteLine($"Despesas: {despesas}");
} while (true);
Console.WriteLine($"Total de despesas: {despesas}");

// for
despesas = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Despesa: ");
    despesa = double.Parse(Console.ReadLine());
    if (despesa < 0)
    {
        break;
    }
    despesas += despesa;
    Console.WriteLine($"Despesas: {despesas}");
}
Console.WriteLine($"Total de despesas: {despesas}");