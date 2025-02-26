

namespace TargetSistemas.Questoes;

internal class PercentualFaturamento
{
    private Dictionary<string, double> _dados;

    public PercentualFaturamento()
    {
        _dados = GetDados();
    }


    public decimal Calcular(string cidade)
    {
        if (_dados == null)
            return 0;
        if (_dados.ContainsKey(cidade))
            return (decimal)(_dados[cidade] / _dados.Values.Sum() * 100);
        return 0;
    }


    private Dictionary<string, double>? GetDados()
    {
        return new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };
    }


}
