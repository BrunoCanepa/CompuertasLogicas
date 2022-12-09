namespace Library;
public class CompuertaOR : Compuerta
{
    public CompuertaOR(string nombre) : base(nombre)
    {

    }
    /// <summary>
    /// Devuelve el resultado de la compuerta OR
    /// </summary>
    /// <returns></returns>
    public int Calcular()
    {
        foreach (var element in Entradas)
        {   
            if (element.Value == 1)
            {
                return 1;
            }
        }
        return 0;
    }
}