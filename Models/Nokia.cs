namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei) : base(numero, modelo, imei) {}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo Nokia...");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}