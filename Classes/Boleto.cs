using System;

namespace Abstração_Heranca_Encapsulamento.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoBarras;
        Random r = new Random();
        public void Registrar()
        {
            CodigoBarras = r.Next(30000000).ToString();
            
            Console.WriteLine($"Boleto gerado com o código {CodigoBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de {this.Valor * 0.88:C2}");
        }
    }
}