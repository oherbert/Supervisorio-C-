using Arduino_teste2.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Arduino_teste2.Utils
{
    class ConversorEntradaSerial
    {
        public static List<Registro> getRegistros(string serial) {


            List<Registro> registros = new List<Registro>();
            DateTime now = DateTime.Now;

            if (serial.Contains("{") && serial.Contains("}")) {

                string padrao = @"[\W]";
                string[] array = System.Text.RegularExpressions.Regex.Split(serial,padrao);


                for (int i = 0; i < array.Length; i++) {
                    if (array[i].Contains("Zona"))
                    {
                        registros.Add(new Registro(now, array[i], Convert.ToDouble(array[i + 1])));
                        i++;
                    }
                }               
                
            }


            registros.ForEach(x=> Console.WriteLine(x));

            return (registros);
                


        }
    }
}
