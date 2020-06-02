using System;

namespace Aula07Encapsulamento
{
    public class Mastercard:Cartao
    {
        public int parcelas { get; set; }
        
        public void ComprarComDescontoMastercard(float desconto){
            cvv=0123;
            Console.WriteLine($"Foi aplicado o desconto de {desconto}, em {parcelas} parcelas.");


        } 
    }
}