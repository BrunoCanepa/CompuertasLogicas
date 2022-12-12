namespace Library;
/// <summary>
/// Clase para simular un bool, dandole el tipo IInput
/// </summary>
public class LogicInput : IInput
{
    public LogicInput(bool value)
    {
        this.Value = value;
    }
    public bool Value { get; set; }
    public bool Calcular()
    {
        return this.Value;
    }
}