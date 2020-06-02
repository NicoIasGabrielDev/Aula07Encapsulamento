using System;

namespace Aula07Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao cartao = new Cartao();
            Mastercard master = new Mastercard();
            master.parcelas = 4;
            master.titular = "Nicolas";
            master.ComprarComDescontoMastercard(10f);
        }
    }
}
