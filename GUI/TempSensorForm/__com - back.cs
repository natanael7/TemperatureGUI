using System;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace TempSensorForm
{
    class __com
    {
        private SerialPort Port;
        private Thread RX;
        private Thread TX;
        public String WriteData;
        public String readedData;
        private bool Work;
        public bool Done;

        private bool Open(String _name)
        {
            bool result = false;
            Port = null;
            Port = new SerialPort(_name, 9600, Parity.None, 8, StopBits.One);
            if (Port != null)
            {
                Port.Handshake = Handshake.None;
                Port.WriteTimeout = 10000;
                Port.ReadTimeout = 10000;
                Port.DiscardNull = true;
                Port.Open();
                result = Port.IsOpen;
            }
            return result;
        }

        public String[] getPorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool getComState()
        {
            bool result = false;
            if(Port != null)
            {
                result = Port.IsOpen;
            }
            return result;
        }

        public void Stop()
        {
            Work = false;
            Thread.Sleep(100);
            Port.Close();
        }

        public bool Start(String _name)
        {
            bool result = false;
            Work = false;
            result = Open(_name);
            if(result)
            {
                Work = true;
                RX = new Thread(ReadThread);
                RX.IsBackground = true;
                TX = new Thread(TransferThread);
                TX.IsBackground = true;
            }
            return result;
        }
        
        public bool Write(int _command)
        {
            bool result = false;
            if (WriteData == "0")
            {
                WriteData = _command.ToString();
                TX.Start();
                result = true;
            }
            return result;
        }

        public void Read()
        {
            RX.Start();
            //while (!Done) { ;}
        }

        private void ReadThread()
        {
            while (Work)
            {
                readedData = Port.ReadExisting();
                Done = true;
                Thread.Sleep(100);
            }
            //Port.Close();
            
        }

        private void TransferThread()
        {
            Port.Write(WriteData.ToString());
            WriteData = "0";
        }
    }
}