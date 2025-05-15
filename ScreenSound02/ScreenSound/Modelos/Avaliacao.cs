namespace ScreenSound.Modelos;

public class Avaliacao
{
    private double nota;

    public Avaliacao(double nota)
    {
        if (nota < 0)
        {
            this.nota = 0;
        } else if (nota > 10)
        {
            this.nota = 10;
        } else
        {
            this.nota = nota;
        }
    }

    public static Avaliacao Parse(string texto)
    {
        double nota = double.Parse(texto);
        return new Avaliacao(nota);
    }

    public double Nota { get => nota; set => nota = value; }
}