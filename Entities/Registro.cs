using System;

namespace Arduino_teste2.Entities
{
    class Registro
    {
        public String DataTime { get; private set; }
        public Double Zona1 { get; set; }
        public Double Zona2 { get; set; }

        public Registro(double zona1, double zona2)
        {
            this.Zona1 = zona1;
            this.Zona2 = zona2;
            DataTime = DateTime.Now.ToString();
        }
    }
}
