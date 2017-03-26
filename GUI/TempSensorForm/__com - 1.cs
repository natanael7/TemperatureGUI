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
        private bool Work;

        private String ReadedData;
        private String Command;
        private bool CommandReady;

        private SerialPort Port;

        private Thread ComThread;


        public String[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public bool GetComState()
        {
            bool Result = false;
            if (Port != null)
            {
                Result = Port.IsOpen;
            }
            return Result;
        }


        private bool Open(String Name)
        {
            bool result = false;
            Port = null;
            Port = new SerialPort(Name, 9600, Parity.None, 8, StopBits.One);
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

        public void Stop() { Work = false; Thread.Sleep(200); }

        public bool Start(String Name)
        {
            bool Result;
            Work = false;
            Result= Open(Name);
            if (Result)
            {
                Work = true;
                Command = "";
                CommandReady = false;
                ComThread = new Thread(ComThreadFunc);
                ComThread.IsBackground = true;
                ComThread.Start();
            }
            return Result;
        }

        private bool WaitReadingData(int TimeInterval = 100)
        {
            bool Result = false;

            int Attemp = 20;
            while (Attemp > 0 && Port.BytesToRead > 0)
            {
                Thread.Sleep(TimeInterval);
                Attemp--;
            }
            if (Attemp > 0) Result = true;

            return Result;
        }

        private bool WaitResponse(int TimeInterval = 200)
        {
            bool Result = false;

            int Attemp = 20;
            while (Attemp > 0 && Port.BytesToRead <= 0)
            {
                Thread.Sleep(TimeInterval);
                Attemp--;
            }
            if (Attemp > 0) Result = true;

            return Result;
        }

        public bool Write(String Data)
        {
            if (!CommandReady)
            {
                Command = Data;
                CommandReady = true;
            }

            return CommandReady;
        }

        public int Read(int code) 
        {
            return code;
        }

        private void ComThreadFunc()
        {
            //int MaxBufferSize = 64;
            while (Work)
            {
                if (!CommandReady) 
                    Thread.Sleep(100);
                else
                {
                    if (Command.Length <= 0) Thread.Sleep(100);
                    else
                    {
                        switch (Command[0])
                        {
                            case 'R':
                                {
                                    ReadedData = Port.ReadExisting();
                                    if (ReadedData.Length == 0) ReadedData = "NO DATA!";
                                    Command = "";
                                }
                                break;

                            case 'W':
                                {
                                    String ClearDataBuffer = Port.ReadExisting();
                                    Port.Write(Command.Substring(2));
                                    Command = "";
                                }
                                break;
                        }
                    }
                }
            }

            Port.Close();

        }

 
        //            switch (Command[0])
        //            {
        //                case 'R':
        //                    {
        //                        ReadedData = Port.ReadExisting();
        //                        if (ReadedData.Length == 0) ReadedData = "NO DATA!";
        //                        Command = "";
        //                    }
        //                    break;

        //                case 'W':
        //                    {
        //                        String ClearDataBuffer = Port.ReadExisting();
        //                        Port.Write(Command.Substring(2));
        //                        Command = "";
        //                    }
        //                    break;
        //            }
    





    }
}

//3:33,False;32,False;31,False;30,False;29,False;28,False;27,True;26,True;25,False;24,False;23,True;22,True;


       //private void ComThreadFunc()
       // {
       //     int MaxBufferSize = 50;
       //     while (Work)
       //     {
       //         if (!CommandReady && Port.BytesToRead <= 0) Thread.Sleep(250);
       //         else
       //         {
       //             if (CommandReady)
       //             {
       //                 String ClearDataBuffer = Port.ReadExisting();

       //                 int TotalPackets= 0;
       //                 int PacketSize= 0;
       //                 String Packet= "";

       //                 TotalPackets = Command.Length / MaxBufferSize;
       //                 PacketSize = Command.Length % MaxBufferSize;
       //                 if(PacketSize > 0) TotalPackets++;

       //                 int PacketId= 0; 
       //                 while(PacketId < TotalPackets)
       //                 {

       //                     Packet = PacketId.ToString().PadLeft(3, '0') + ":" + TotalPackets.ToString().PadLeft(3, '0') + ":";
       //                     if (TotalPackets - PacketId > 1)
       //                     {
       //                         Packet += MaxBufferSize.ToString().PadLeft(3, '0') + ":"; ;
       //                         Packet += Command.Substring(PacketId * MaxBufferSize, MaxBufferSize);
       //                     }
       //                     else
       //                     {
       //                         Packet += PacketSize.ToString().PadLeft(3, '0') + ":";
       //                         Packet += Command.Substring(PacketId * MaxBufferSize, PacketSize);
       //                     }

       //                     Port.Write(Packet);
       //                     if (!WaitResponse())
       //                     {
       //                         ClearDataBuffer = Port.ReadExisting();
       //                         ReadedData = "";
       //                         PacketId = TotalPackets;

                            
       //                         //Response.Text += " - Errore di trasmissione!";
       //                         Response.Invoke(new Form1.test(TEST), " - Errore di trasmissione!");

       //                     }
       //                     else
       //                     {
       //                         ReadedData = Port.ReadExisting();

       //                         if (ReadedData != "255:OK.\r\n")
       //                         {
       //                             PacketId = TotalPackets;
       //                             ReadedData += " - Errore di trasmissione!";
       //                         }

       //                         Response.Invoke(new Form1.test(TEST), ReadedData);
       //                         //Response.Text += ReadedData;

       //                     }

       //                     PacketId++;
       //                 }

       //                 Command = "";
       //                 CommandReady = false;
       //             }
       //             else
       //             {
       //                 ReadedData = Port.ReadExisting();
       //                 //Response.Text+= ReadedData;
       //                 Response.Invoke(new Form1.test(TEST), ReadedData);
       //             }
       //         }

       //     }

       //     Port.Close();

       // }
