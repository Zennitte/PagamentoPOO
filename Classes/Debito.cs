using System;

namespace Abstração_Heranca_Encapsulamento.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 600f;
        public void Pagar()
        {
            float valor = this.Valor;

            if (valor > Saldo)
            {
                Console.WriteLine("Você não possui saldo o suficiente para pagar esse valor!");
            }
            else
            {
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso");
            }
        }
    }
}