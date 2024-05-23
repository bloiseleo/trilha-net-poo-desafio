using System;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone(string numero, string imei, int memoria) : base(numero, "Iphone", imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo no iphone {nomeApp}");
        }
    }
}