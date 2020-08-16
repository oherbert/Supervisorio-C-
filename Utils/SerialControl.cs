using Arduino_teste2.Entities;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Arduino_teste2.Utils
{
    class SerialControl
    {
        public static List<Registro> GetRegistros(string serial) {

            if (serial.Contains("{") && serial.Contains("}")) {
                string str = serial.Replace('{', ' ');
                str = str.Replace('}', ' ');
                str = str.Trim();
                string[] vs =  serial.Split(',');


            }

            List<Registro> list = new List<Registro>();

            return (list);
                


        }
    }
}
