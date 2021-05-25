using System;
using Abstração_Heranca_Encapsulamento.Classes;

namespace Abstração_Heranca_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;

            do
            {
                Console.WriteLine(@"
                Escolha um método de pagamento
                B - Boleto
                C - Crédito
                D - Débito
                X - Cancelar Pagamento");               
                string opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "B":
                    Boleto b = new Boleto();
                    b.Registrar();
                    opcaoValida = true;
                        break;
                    case "C":
                    Credito c = new Credito();
                    Console.WriteLine(c.SalvarCartao());
                    c.Pagar();
                    opcaoValida = true;
                        break;
                    case "D":
                    Debito d = new Debito();
                    Console.WriteLine(d.SalvarCartao());
                    d.Pagar();
                    opcaoValida = true;
                        break;
                    case "X":
                    Pagamento p = new Pagamento();
                    Console.WriteLine(p.Cancelar());
                    opcaoValida = true;
                        break;
                    default:
                    Console.WriteLine("Opção de pagamento invalida!");
                    opcaoValida = false;
                        break;
                }               
            } while (!opcaoValida);
        }
    }
}
