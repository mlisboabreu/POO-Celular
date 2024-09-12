using System.Linq;
namespace Smart
{
    public abstract class SmartPhone {
        private string __imei;
        private string __modelo;
        private int __memoria;
        
        
        public string Num {get; set;}
        public string Imei 
        {
            get
            {
                return __imei;
            }
            set
            {
                if(value.All(char.IsDigit))
                {
                    __imei = value;
                }
                else if(value=="")
                {
                    Console.WriteLine("IMEI não pode ser vazio");
                }
            }
        }
        public string Modelo
        {
            get
            {
                return __modelo;
            }
            set
            {
                if(value == "")
                {
                    Console.WriteLine("modelo não pode ser vazio");
                }
                else
                {
                    __modelo = value;
                }
            }
        }
        public int Memoria
        {
            get
            {
                return __memoria;
            }
            set
            {
                if(value == 0)
                {
                    Console.WriteLine("a memória não pode ser nula");
                }
                else
                {
                    __memoria = value;
                }
            }
        }


        public void Ligar()
        {
            Console.WriteLine("Está ligando");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Está recebendo ligação");
        }
        public void Apre()
        {
            Console.WriteLine(Num);
            Console.WriteLine(Imei);
            Console.WriteLine(Modelo);
            Console.WriteLine(Memoria);
        }

        public abstract void InstalarAplicativo(string nome);
    }
}