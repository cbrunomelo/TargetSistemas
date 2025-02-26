using TargetSistemas.Questoes;
using static TargetSistemas.Questoes.FaturamentoDistribuidora;

// Questão 1
int valor = SomaValores.Calcular();
Console.WriteLine($"Questão 1: {valor}");

// Questão 2
bool pertence = Fibonacci.PertenceASequencia(13);
Console.WriteLine($"Questão 2: O número 13 pertence à sequência de Fibonacci? {pertence}");


// Questão 3
//• O menor valor de faturamento ocorrido em um dia do mês;

FaturamentoDistribuidora faturamento = new FaturamentoDistribuidora();

Faturamento menorFaturamento = faturamento.MenorValor();

Console.WriteLine($"Questão 3: O menor valor de faturamento ocorrido em um dia do mês foi de {menorFaturamento.Valor} no dia {menorFaturamento.Dia}.");

//• O maior valor de faturamento ocorrido em um dia do mês;

Faturamento maiorFaturamento = faturamento.MaiorValor();

Console.WriteLine($"Questão 3: O maior valor de faturamento ocorrido em um dia do mês foi de {maiorFaturamento.Valor} no dia {maiorFaturamento.Dia}.");


// • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

List<Faturamento> diasAcimaDaMedia = faturamento.DiasAcimaDaMedia();

Console.WriteLine($"Questão 3: O número de dias no mês em que o valor de faturamento diário foi superior à média mensal foi de {diasAcimaDaMedia.Count}.");

foreach (Faturamento dia in diasAcimaDaMedia)
{
    Console.WriteLine($"Dia {dia.Dia}: {dia.Valor}");
}

// Questão 4
PercentualFaturamento percentual = new PercentualFaturamento();
decimal percentualFaturamento = percentual.Calcular("SP");

Console.WriteLine($"Questão 4: O percentual de faturamento do estado de São Paulo foi de {percentualFaturamento.ToString("c")}%");

// Questão 5

String Invertida = StringInvertida.Inverter("Hello World!");
Console.WriteLine($"Questão 5: {Invertida}");
