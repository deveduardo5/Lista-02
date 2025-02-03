// 10. Um vendedor de passagens deseja saber quantas passagens ele vendeu em um dia. O aluno deve pedir ao usuário para inserir o valor das passagens vendidas até que ele digite um valor negativo. O total de passagens vendidas deve ser calculado e apresentado utilizando while, do while e for.

double passagensVendidas = 0;
double passagem;
while (true)
{
    Console.Write("Valor da passagem vendida: ");
    passagem = double.Parse(Console.ReadLine());
    if (passagem < 0)
    {
        break;
    }
    passagensVendidas += passagem;
    Console.WriteLine($"Total de passagens vendidas: {passagensVendidas}");
}

// do while
passagensVendidas = 0;
do
{
    Console.Write("Valor da passagem vendida: ");
    passagem = double.Parse(Console.ReadLine());
    if (passagem < 0)
    {
        break;
    }
    passagensVendidas += passagem;
    Console.WriteLine($"Total de passagens vendidas: {passagensVendidas}");
} while (true);

// for
passagensVendidas = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Valor da passagem vendida: ");
    passagem = double.Parse(Console.ReadLine());
    if (passagem < 0)
    {
        break;
    }
    passagensVendidas += passagem;
    Console.WriteLine($"Total de passagens vendidas: {passagensVendidas}");
}
