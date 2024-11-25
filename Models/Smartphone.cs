namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string MEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string fabricante, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            MEI = fabricante;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
