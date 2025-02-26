using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TargetSistemas.Questoes;

internal class FaturamentoDistribuidora
{
    private IReadOnlyList<Faturamento> Faturamentos { get; set; }

    public FaturamentoDistribuidora() => Faturamentos = GetFaturamentos();
    

    public Faturamento MenorValor() => Faturamentos.Where(f => f.Valor > 0).OrderBy(f => f.Valor).FirstOrDefault();
    public Faturamento MaiorValor() => Faturamentos.Where(f => f.Valor > 0).OrderByDescending(f => f.Valor).FirstOrDefault();
    public List<Faturamento> DiasAcimaDaMedia()
    {
        decimal media = Faturamentos.Where(f => f.Valor > 0).Average(f => f.Valor);
        return Faturamentos.Where(f => f.Valor > media).OrderBy(f => f.Dia).ToList();
    }

    public record Faturamento([property: JsonPropertyName("dia")] int Dia, [property: JsonPropertyName("valor")] decimal Valor);

    private List<Faturamento> GetFaturamentos()
    {
        string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
        string filePath = Path.Combine(projectDirectory, "Dados", "Font1.json");

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Faturamento>>(json);
        }


        return new List<Faturamento>();

    }

}
