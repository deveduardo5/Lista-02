//  Um funcionário deseja contar quantos dias de trabalho ele teve em um mês.
//  Para isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que terminou de informar os dias.
//  O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for.

// while
int diasTrabalhados = 0;
int dia;

Console.WriteLine("Digite os dias trabalhados (de 1 a 31) até que digite 0, que indica que terminou de informar os dias.");
while (true)
{
    Console.Write("Dia trabalhado: ");

    dia = int.Parse(Console.ReadLine());
    if (dia == 0)
    {
        break;
    }
    diasTrabalhados++;
    Console.WriteLine($"Dias trabalhados: {diasTrabalhados}");
}


// do while
int diasTrabalhados = 0;
int dia;
do
{
    Console.Write("Dia trabalhado: ");
    dia = int.Parse(Console.ReadLine());
    if (dia == 0)
    {
        break;
    }
    diasTrabalhados++;
    Console.WriteLine($"Dias trabalhados: {diasTrabalhados}");
} while (true);

// for
int diasTrabalhados = 0;
int dia;
for (int i = 1; i <= 31; i++)
{
    Console.Write("Dia trabalhado: ");
    dia = int.Parse(Console.ReadLine());
    if (dia == 0)
    {
        break;
    }
    diasTrabalhados++;
    Console.WriteLine($"Dias trabalhados: {diasTrabalhados}");
}

