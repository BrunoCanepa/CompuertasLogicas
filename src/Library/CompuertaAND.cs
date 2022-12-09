namespace Library;
public class CompuertaAND : Compuerta
{
    public CompuertaAND(string nombre) : base(nombre)
    {
    }
    /// <summary>
    /// Devuelve el resultado de la compuerta AND
    /// </summary>
    /// <returns></returns>
    public int Calcular()
    {
        int res = 1;
        foreach (var element in Entradas)
        {
            res *= element.Value;
        }
        return res;
    }
}
