using Library;
public class Program
{
    public static void Main(string[] args)
    {
        CompuertaAND and1 = new CompuertaAND("AND-1");
        and1.AgregarEntrada("A", 1);
        and1.AgregarEntrada("B", 1);

        CompuertaOR or2 = new CompuertaOR("OR-2");
        or2.AgregarEntrada("C", 0);
        or2.AgregarEntrada(and1.Nombre, and1.Calcular());

        CompuertaNOT not3 = new CompuertaNOT("NOT-3");
        not3.AgregarEntrada(or2.Nombre, or2.Calcular());
        Console.WriteLine(not3.Calcular());
    }
}