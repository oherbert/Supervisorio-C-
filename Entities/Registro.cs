using System;


namespace Arduino_teste2.Entities
{
    class Registro
    {
        public DateTime DateTime { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }


        public Registro(DateTime dateTime, string nome, double valor)
        {
            DateTime = dateTime;
            Nome = nome;
            Valor = valor;
        }

        public Registro(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public Registro()
        {
        }


        public override string ToString()
        {
            return DateTime + "," + Nome + "," + Valor;
        }
    }
}
