namespace Aula07Encapsulamento
{
    public class Cartao
    {
         public string titular {get; set;}
        public string numero {get; set;}
        public string bandeira {get; set;}
        private string token{get; set;}
        protected int cvv{get; set;}
         
        public string AprovarCompra(){
            return "compra aprovada";
        }
        private bool ValidarToken(){
            if(token != null && token != ""){
                return true;
            }
            return false;
        }
        protected bool ValidarCompra(){
            return true;
        }
    }
}