using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rs232connection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = GetAllPort();
            Console.WriteLine("danh sach ports");
            foreach (string port in list)
            {
                Console.WriteLine(port);
            
            }


            //Console.WriteLine(list.Count);
            //bool portOpened = Openport("COM1");

            Console.WriteLine("send and receive data");
            bool check =  SendReceiveData();

            //bool portClosed = ClostPort("COM1");
            Console.ReadLine();
        }

        private static bool SendReceiveData()
        {
            throw new NotImplementedException();
        }

        private static bool ClostPort(string portName)
        {
            System.IO.Ports.SerialPort myport = new System.IO.Ports.SerialPort(portName);
            if (myport.IsOpen != false) myport.Close();
            return true;
        }

        private static bool Openport(string portname)
        {
            System.IO.Ports.SerialPort myport = new System.IO.Ports.SerialPort(portname);
            if (myport.IsOpen == false) myport.Open();
            return true;

        }

        private static List<string> GetAllPort()
        {
            List<string> allports = new List<string>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allports.Add(portName);
            
            }
            return allports;
        }
    }
}
