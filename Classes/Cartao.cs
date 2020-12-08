namespace Encapisulamento.Classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;}
            set{numero = value;}
        }
        private string bandeira = "Mastercard";
        private string Bandeira{
            get{return bandeira;}
        }
        protected string token;
        private string cvv;
        protected float limite;
        public string RegistrarCompras(bool validado){
            return"";
        }
        private float ValidarCompra(float saldo){
            return 0;
        }
        protected string ValidarToken(string ValidarCompra){
            return"";
        }



    }
}