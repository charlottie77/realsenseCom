using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace DF_FaceTracking.cs
{
    class PortChat
    {
        static bool _continue;
        static SerialPort _serialPort;
        //static int count = 0;
        public static Thread readThread = new Thread(Read);
        static bool inuse = false;

        public static void start()
        {
            //string name;
            //string message = "Notatall\n";
            //int message = 2;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
           

            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            //Allow the user to set the appropriate properties.
            _serialPort.PortName = SetPortName("COM7");
            _serialPort.BaudRate = SetPortBaudRate(9600);
            _serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = SetPortDataBits(8);
            _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            //_serialPort.PortName = SetPortName("COM7");
            //_serialPort.BaudRate = SetPortBaudRate(_serialPort.BaudRate);
            //_serialPort.Parity = SetPortParity(_serialPort.Parity);
            //_serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
            //_serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
            //_serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            // Set the read/write timeouts
           // _serialPort.ReadTimeout = 2500;
            //_serialPort.WriteTimeout = 1500;

            _serialPort.ReadTimeout = 4000;
            _serialPort.WriteTimeout = 3500;

            _serialPort.Open();
            _continue = true;
            readThread.Start();

            //Send(message);

            //while (_continue)
            //{
            //    count++;
            //    //message = Console.ReadLine();
            //    // message = "Not at all";//json
            //    // _serialPort.WriteLine(message.ToString());
            //    if (count == 10)
            //        _serialPort.WriteLine(message);
            //    // Console.WriteLine(message + "!!");
            //    if (count == 11)
            //    {
            //        count = 0;
            //    }
            //}       
        }

        public static void Send(string msg)
        {
            
            if(msg != null && _serialPort != null && !inuse)
            {
                try
                {
                    inuse = true;
                    _serialPort.WriteLine(msg);
                }
                catch(Exception e)
                {
                    inuse = false;
                    Console.WriteLine(e.ToString());
                   
                }
               
            }
        }

        public static void Quit()
        {
            if(_serialPort != null)
            {
                _serialPort.Close();
                readThread.Join();
            }
            
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    //if (_serialPort.ReadLine().Equals("Notatall"))
                    //{
                    //    Console.WriteLine("received");
                    //}
                    Console.WriteLine("begin write");
                    string temp = _serialPort.ReadLine();
                    Console.WriteLine(temp);
                    inuse = false;

                }
                catch (TimeoutException te) { Console.WriteLine(te.ToString()); }
            }
        }

        // Display Port values and prompt user to enter a port.
        public static string SetPortName(string defaultPortName)
        {
            string portName = "";

            Console.WriteLine("Available Ports:");
            foreach (string s in SerialPort.GetPortNames())
            {
                Console.WriteLine("   {0}", s);
            }

            //Console.Write("Enter COM port value (Default: {0}): ", defaultPortName);
            //portName = Console.ReadLine();

            //if (portName == "" || !(portName.ToLower()).StartsWith("com"))
            //{
            //    portName = defaultPortName;
            //}
            portName = defaultPortName;
            return portName;
        }
        // Display BaudRate values and prompt user to enter a value.
        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            int baudRate;

            Console.Write("Baud Rate(default:{0}): ", defaultPortBaudRate);
            //baudRate = Console.ReadLine();

            //if (baudRate == "")
            //{
            //    baudRate = defaultPortBaudRate.ToString();
            //}

            baudRate = defaultPortBaudRate;

            return baudRate;
        }

        // Display PortParity values and prompt user to enter a value.
        public static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity;

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            // Console.Write("Enter Parity value (Default: {0}):", defaultPortParity.ToString(), true);
            //parity = Console.ReadLine();

            //if (parity == "")
            //{
            //    parity = defaultPortParity.ToString();
            //}
            parity = "None";
            //parity = defaultPortParity.ToString();

            return (Parity)Enum.Parse(typeof(Parity), parity, true);
        }
        // Display DataBits values and prompt user to enter a value.
        public static int SetPortDataBits(int defaultPortDataBits)
        {
            int dataBits;

            //Console.Write("Enter DataBits value (Default: {0}): ", defaultPortDataBits);
            //dataBits = Console.ReadLine();

            //if (dataBits == "")
            //{
            //    dataBits = defaultPortDataBits.ToString();
            //}
            dataBits = defaultPortDataBits;

            return dataBits;
        }

        // Display StopBits values and prompt user to enter a value.
        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits;

            Console.WriteLine("Available StopBits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            //Console.Write("Enter StopBits value (None is not supported and \n" +
            // "raises an ArgumentOutOfRangeException. \n (Default: {0}):", defaultPortStopBits.ToString());
            //stopBits = Console.ReadLine();

            //if (stopBits == "")
            //{
            //    stopBits = defaultPortStopBits.ToString();
            //}

            stopBits = "One";
            //stopBits = defaultPortStopBits.ToString();
            return (StopBits)Enum.Parse(typeof(StopBits), stopBits, true);
        }
        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake;

            //Console.WriteLine("Available Handshake options:");
            //foreach (string s in Enum.GetNames(typeof(Handshake)))
            //{
            //    Console.WriteLine("   {0}", s);
            //}

            //Console.Write("Enter Handshake value (Default: {0}):", defaultPortHandshake.ToString());
            //handshake = Console.ReadLine();

            //if (handshake == "")
            //{
            //    handshake = defaultPortHandshake.ToString();
            //}
            handshake = defaultPortHandshake.ToString();
            return (Handshake)Enum.Parse(typeof(Handshake), handshake, true);
        }
    }
}
