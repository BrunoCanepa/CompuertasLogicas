namespace Library;
public class CompuertaNOT : Compuerta
{
    public CompuertaNOT(string nombre) : base(nombre)
    {
        
    }
    /// <summary>
    /// Devuelve el resultado de la compuerta NOT
    /// </summary>
    /// <returns></returns>
    public int Calcular()
    {
        foreach (var element in Entradas)
        {   
            if (element.Value == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        return 0;
    }
}