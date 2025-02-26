namespace TargetSistemas.Questoes;

internal class Fibonacci
{
    public static bool PertenceASequencia(int numero)
    {
        return PertenceASequenciaRecursiva(numero, 0, 1);
    }

    private static bool PertenceASequenciaRecursiva(int numero, int a, int b)
    {
        if (a == numero || b == numero)
            return true;
        if (b > numero)
            return false;
        return PertenceASequenciaRecursiva(numero, b, a + b);
    }
}
