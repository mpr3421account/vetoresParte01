/*Fazer um programa para ler um número inteiro N e a altura de N pessoas.
Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
pessoas.*/
using System.Globalization;

Console.WriteLine("Entrada:");
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for(int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
double sum = 0.0;
for(int i = 0; i < n; i++)
{
    sum += vect[i];
}

double avg = sum / n;

Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));