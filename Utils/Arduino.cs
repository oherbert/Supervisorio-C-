using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Arduino_teste2.Utils
{
    class Arduino
    {


        public static String portCom { get; set; }
        public static String streamCom { get; private set; }
        private static SerialPort serialPort = new SerialPort();
        private static Thread reading = new Thread(Read);


        public static void tryOpenPort()
    {
           
        if (serialPort.IsOpen == false)
        {
            serialPort.PortName = portCom; 
            serialPort.BaudRate = 9600;
            serialPort.ReadTimeout = 1200;
            serialPort.WriteTimeout = 1200;
            try
            {
                serialPort.Open();
                if (reading.IsAlive == false)
                reading.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel encontrar o arduino na porta selecionada: "+ portCom);
            }

            if (serialPort.IsOpen == true)
                streamCom = "Aberta";
            else
                streamCom = "Fechada";
        }
    }

        public static void close()
        {
            if (serialPort.IsOpen == true)
            {
                serialPort.Close();
            }
        }

        private static void Read()
    {
            while (true)
        {
                if (serialPort.IsOpen == true)
                {
                    try
                    {
                        string message = serialPort.ReadLine();
                        streamCom = message;
                    }
                    catch (Exception e)
                    {
                        if (e is TimeoutException)
                            Console.WriteLine("Sem dados");
                        else if (e is ThreadStateException)
                            Console.WriteLine("Thread encereado");
                    }
                    Thread.Sleep(1000);
                }
                else
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Porta fechada");
                    streamCom = "Fechada";
                }
        }

            
    }


}
}

 