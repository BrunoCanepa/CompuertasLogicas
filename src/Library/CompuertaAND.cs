namespace Library;
public class CompuertaAND : Compuerta
{
    public CompuertaAND(string nombre) : base(nombre)
    {
    }
    /// <summary>
    /// Devuelve el resultado de la compuerta AND, y tira una excepció si no tiene dos entradas.
    /// </summary>
    /// <returns></returns>
    public override bool Calcular()
    {
        if (Entradas.Count != 2)
        {
            throw new IndexOutOfRangeException("La compuerta no tiene 2 entradas");
        }
            foreach (var element in Entradas)
            {
                if (!element.Value.Calcular())
                {
                    return false;
                }
            }
            return true;
    }
}
