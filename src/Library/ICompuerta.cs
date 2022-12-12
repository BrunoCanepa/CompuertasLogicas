namespace Library;
/// <summary>
/// Interdace de compuertas
/// </summary>
public interface ICompuerta
{
    public void AgregarEntrada(string nombre, IInput valor);
    public bool Calcular();
}