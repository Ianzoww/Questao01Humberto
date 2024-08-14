namespace WebApplication1.Modells
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double ValorImc()
        {

            return (Peso / (Math.Pow(Altura, 2)));
        }
    }
}
