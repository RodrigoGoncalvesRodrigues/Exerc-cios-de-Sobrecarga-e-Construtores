public class Retangulo
{
    double Largura;
    double Altura;
    public Retangulo()
    {
        Largura = 0;
        Altura = 0;
    }
    public Retangulo(double Largura, double Altura)
    {
        this.Largura = Largura;
        this.Altura = Altura;
    }

    public double CalcularArea()
    {
        return Largura * Altura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }
    public void Redimensionar(double novaLargura, double novaAltura)
    {
        Largura = novaLargura;
        Altura = novaAltura;
    }
    public void Redimensionar(double fator)
    {
        Largura *= fator;
        Altura *= fator;
    }
}