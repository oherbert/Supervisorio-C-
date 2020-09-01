using System;
using System.IO.Ports;
using System.Threading;
using System.Windows;

namespace Arduino_teste2.Entities
{
    class Arduino
    {


        public static String PortCom { get; set; }
        public static String StreamCom { get; private set; }
        private static SerialPort SerialPort = new SerialPort();
        private static Thread Reading = new Thread(Read);


        public static void tryOpenPort()
        {

            if (SerialPort.IsOpen == false)
            {
                SerialPort.PortName = PortCom;
                SerialPort.BaudRate = 9600;
                SerialPort.ReadTimeout = 1200;
                SerialPort.WriteTimeout = 1200;
                try
                {
                    SerialPort.Open();
                    if (Reading.IsAlive == false)
                        Reading.Start();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possivel encontrar o arduino na porta selecionada: " + PortCom);
                }

                if (SerialPort.IsOpen == true)
                    StreamCom = "Aberta";
                else
                    StreamCom = "Fechada";
            }
        }

        public static void close()
        {
            if (SerialPort.IsOpen == true)
            {
                SerialPort.Close();
            }
        }

        private static void Read()
        {
            while (true)
            {
                if (SerialPort.IsOpen == true)
                {
                    try
                    {
                        string message = SerialPort.ReadLine();
                        StreamCom = message;
                    }
                    catch (TimeoutException e)
                    {
                        Console.WriteLine("Arduino não envia dados: " + e.StackTrace);
                    }
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Porta fechada");
                    StreamCom = "Fechada";
                }
            }


        }


    }
}

