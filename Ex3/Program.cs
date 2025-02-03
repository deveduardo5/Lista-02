// 3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utilizando as três estruturas de repetição.

int alunosAprovados = 0;
double nota;
Console.WriteLine("Digite as notas dos alunos (de 0 a 10) até que digite -1 para sair.");
while (true)
{
    Console.Write("Nota: ");
    nota = double.Parse(Console.ReadLine());
    if (nota < 0)
    {
        break;
    }
    if (nota >= 6)
    {
        alunosAprovados++;
    }
    Console.WriteLine($"Alunos aprovados: {alunosAprovados}");
}
Console.WriteLine($"Total de alunos aprovados: {alunosAprovados}");

alunosAprovados = 0;
do
{
    Console.Write("Nota: ");
    nota = double.Parse(Console.ReadLine());
    if (nota < 0)
    {
        break;
    }
    if (nota >= 6)
    {
        alunosAprovados++;
    }
    Console.WriteLine($"Alunos aprovados: {alunosAprovados}");
} while (true);
Console.WriteLine($"Total de alunos aprovados: {alunosAprovados}");

alunosAprovados = 0;
for (int i = 0; i < int.MaxValue; i++)
{
    Console.Write("Nota: ");
    nota = double.Parse(Console.ReadLine());
    if (nota < 0)
    {
        break;
    }
    if (nota >= 6)
    {
        alunosAprovados++;
    }
    Console.WriteLine($"Alunos aprovados: {alunosAprovados}");
}
