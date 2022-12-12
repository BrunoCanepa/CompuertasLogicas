namespace Library;
public class CompuertaNOT : Compuerta
{
    public CompuertaNOT(string nombre) : base(nombre)
    {
    }
    /// <summary>
    /// Devuelve el resultado de la compuerta NOT y tira una excepción si no tiene una entrada
    /// </summary>
    /// <returns></returns>
    public override bool Calcular()
    {
        if (Entradas.Count != 1)
        {
            throw new IndexOutOfRangeException("La compuerta no tiene 1 entrada");
        }
        return !Entradas.First().Value.Calcular();
    }
}