// 4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A solução deve ser implementada usando while, do while e for.

int idade;
int somaIdades = 0;
int quantidadeAmigos = 0;
double mediaIdades;

Console.WriteLine("Digite as idades dos amigos até que digite 0 para sair.");
while (true)
{
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade == 0)
    {
        break;
    }
    somaIdades += idade;
    quantidadeAmigos++;
    mediaIdades = (double)somaIdades / quantidadeAmigos;
    Console.WriteLine($"Média de idades: {mediaIdades}");
}
// do while
somaIdades = 0;
quantidadeAmigos = 0;
mediaIdades = 0;
do
{
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade == 0)
    {
        break;
    }
    somaIdades += idade;
    quantidadeAmigos++;
    mediaIdades = (double)somaIdades / quantidadeAmigos;
    Console.WriteLine($"Média de idades: {mediaIdades}");
} while (true);

// for
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());
    if (idade == 0)
    {
        break;
    }
    somaIdades += idade;
    quantidadeAmigos++;
    mediaIdades = (double)somaIdades / quantidadeAmigos;
    Console.WriteLine($"Média de idades: {mediaIdades}");
}