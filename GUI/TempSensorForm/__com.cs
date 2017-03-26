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
        public String writeData = "";
        public String readedData = "";
        public String readedOneValue = "";
        private bool ReadEnabled = false;
        private bool Work = false;

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
            ReadEnabled = false;
            Thread.Sleep(100);
            Port.Close();
        }

        public bool Start(String _name)
        {
            bool result = false;
            result = Open(_name);
            if(result)
            {
                Work = true;
            }
            return result;
        }
        
        public bool Write(String _data)
        {
            bool result = false;
            //if (writeData == "")
            //{
            writeData = _data;
            TX = new Thread(TransferThread);
            TX.IsBackground = true;
            TX.Start();
            result = true;
            //}
            return result;
        }

        public string readOneValue()
        {
            String data;
            data = Port.ReadLine();
            data = data.Remove(data.Length-1, 1);
            readedOneValue = data;
            return readedOneValue;
        }

        public void startRead()
        {
            RX = new Thread(ReadThread);
            RX.IsBackground = true;
            ReadEnabled = true;
            RX.Start();
        }

        private void ReadThread()
        {
            while (ReadEnabled)
            {
                if (Port.BytesToRead > 0)
                {
                    readedData = Port.ReadLine();
                    try { readedData = readedData.Remove(readedData.Length - 1, 1); }
                    catch { };
                }
                Thread.Sleep(90);
            }
        }

        private void TransferThread()
        {
            Port.Write(writeData);
            writeData = "";
        }
    }
}