using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TempSensorForm
{
    public partial class TempSensorForm : Form
    {
        private Const Constants;
        private Thread ReleaseData;
        private __com Com;

        private bool Switch_Mode;
        private bool Switch_UnitTemp;
        private bool Switch_Screen;
        private bool Switch_ReadManualTemp;

        private void resetSwitchesBunttons()
        {
            Switch_Mode = Const.AUTOMATIC;
            Switch_UnitTemp = Const.CELSIUS;
            Switch_Screen = Const.LCD;
            Switch_ReadManualTemp = Const.OFF;
            buttonStart.Text = "Start";
            buttonTempUnit.Text = "Fahrenheit";
            buttonScreen.Text = "Display";
            buttonMode.Text = "Manual";
        }

        private void cleanDisplay()
        {
            foreach (Control led in displayBox.Controls)
            {
                ((Panel)led).BackColor = Color.LightGray;
            }
        }

        private void turnDisplayLedsOn(String _cifra, int _value)
        {
            bool[,] MAP_LEDS = 
            {   
                { true,  true,  true,  true,  true,  true,  false },  
                { false, false, true,  true,  false, false, false },
                { false, true,  true,  false, true,  true,  true  },
                { false, true,  true,  true,  true,  false, true  },
                { true,  false, true,  true,  false, false, true  },
                { true,  true,  false, true,  true,  false, true  },
                { true,  true,  false, true,  true,  true,  true  },
                { false, true,  true,  true,  false, false, false },
                { true,  true,  true,  true,  true,  true,  true  },
                { true,  true,  true,  true,  true,  false, true  },
            };
            for (int i = 0; i < 7; i++)
            {
                Control[] Temp = this.Controls.Find(("led" + _cifra + (i + 1)).ToString(), true);
                ((Panel)Temp[0]).BackColor = Color.LightGray;
                if (MAP_LEDS[_value, i]) ((Panel)Temp[0]).BackColor = Color.Red;
            }
        }

        private void showOnDisplay(String _number)
        {
            int value = 0;
            cleanDisplay();
            try
            {
                value = int.Parse(_number.Substring(0, _number.IndexOf(".")));
                if (value / 100 > 0)
                {
                    turnDisplayLedsOn("C", int.Parse(_number.Substring(0, 1)));
                    turnDisplayLedsOn("D", int.Parse(_number.Substring(1, 1)));
                    turnDisplayLedsOn("U", int.Parse(_number.Substring(2, 1)));
                    turnDisplayLedsOn("F", int.Parse(_number.Substring(4, 1)));
                }
                else
                    if (value / 10 > 0)
                    {
                        turnDisplayLedsOn("D", int.Parse(_number.Substring(0, 1)));
                        turnDisplayLedsOn("U", int.Parse(_number.Substring(1, 1)));
                        turnDisplayLedsOn("F", int.Parse(_number.Substring(3, 1)));
                    }
                    else
                    {
                        turnDisplayLedsOn("U", int.Parse(_number.Substring(0, 1)));
                        turnDisplayLedsOn("F", int.Parse(_number.Substring(2, 1)));
                    }
                ledDot.BackColor = Color.Red;
            }
            catch
            {
                buttonConnect_Click(null, null);
                MessageBox.Show("Transmission Error: reset connection");
            };
        }

        private bool releaseDataEnabled = true;
        private void ReleaseDataFunc()
        {
            lcd.Text = "TEMPERATURE" + Environment.NewLine + "METER";
            Thread.Sleep(1200);
            while (releaseDataEnabled)
            {
                if (Switch_Mode = Const.MANUAL)
                {
                    if (Switch_ReadManualTemp = Const.ON)
                    {
                        Thread.Sleep(150);
                        Switch_ReadManualTemp = Const.OFF;
                    }
                }
                if (Switch_UnitTemp == Const.CELSIUS)
                    lcd.Text = "CELSIUS";
                else
                    lcd.Text = "FAHRENHEIT";

                if (Switch_Screen == Const.LCD)
                {
                    cleanDisplay();
                    if (Switch_UnitTemp == Const.CELSIUS)
                        lcd.Text += Environment.NewLine + "VALUE: " + Com.readedData + "°";
                    else
                        lcd.Text += Environment.NewLine + "VALUE: " + Com.readedData + "°";
                }
                else
                {
                    showOnDisplay(Com.readedData);
                }
                Thread.Sleep(100);
            }
            lcd.Text = "DATALOGGER" + Environment.NewLine + "SENAI";
            releaseDataEnabled = true;
        }

        public TempSensorForm()
        {
            InitializeComponent();
        }

        private void TempSensorForm_Load(object sender, EventArgs e)
        {
            Com = new __com();
            String[] ComList = Com.getPorts();
            Array.Reverse(ComList);
            comboCom.Items.AddRange(ComList);
            if(ComList.Length != 0)
                comboCom.SelectedIndex = 0;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            resetSwitchesBunttons();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Connect")
                if (Com.Start(comboCom.SelectedItem.ToString()))
                {
                    Com.Write(Const.CODE_CONNECTION_ON.ToString());
                    Thread.Sleep(150);
                    if (Com.readOneValue() == Const.CODE_CONNECTION_ON.ToString())
                    {
                        buttonConnect.Text = "Disconnect";
                        StatusSquare.BackColor = Color.LimeGreen;
                        StatusLabel.Text = "Success by connecting to Arduino";
                    }
                    else
                    {
                        Com.Write(Const.CODE_CONNECTION_OFF.ToString());
                        Com.Stop();
                        StatusLabel.Text = "Arduino not found on selected port";
                    }
                }
                else
                    StatusLabel.Text = "Error initiating the selected port!";
            else 
            {
                Com.Write(Const.CODE_CONNECTION_OFF.ToString());
                Com.Stop();
                buttonConnect.Text = "Connect";
                StatusSquare.BackColor = Color.Red;
                resetSwitchesBunttons();
                releaseDataEnabled = false;
                buttonTempUnit.Enabled = false;
                buttonScreen.Enabled = false;
                buttonMode.Enabled = false;
                buttonRead.Enabled = false;
                cleanDisplay();
                StatusLabel.Text = "Disconnected! Waiting for new connection.";
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start")
            {
                if (buttonConnect.Text == "Disconnect")
                {
                    Com.Write(Const.CODE_STARTUP_ON.ToString());
                    Com.startRead();
                    buttonStart.Text = "Stop";
                    buttonTempUnit.Enabled = true;
                    buttonScreen.Enabled = true;
                    buttonMode.Enabled = true;
                    StatusLabel.Text = "Reading of Temperature started";
                    ReleaseData = new Thread(ReleaseDataFunc);
                    releaseDataEnabled = true;
                    ReleaseData.Start();
                }
                else
                    StatusLabel.Text = "Connect to Port COM first!";
            }
            else
            {
                Com.Write(Const.CODE_STARTUP_OFF.ToString());
                resetSwitchesBunttons();
                buttonTempUnit.Enabled = false;
                buttonScreen.Enabled = false;
                buttonMode.Enabled = false;
                buttonRead.Enabled = false;
                StatusLabel.Text = "Reading of Temperature stopped";
                releaseDataEnabled = false;
                cleanDisplay();
            }
        }

        private void buttonTempUnit_Click(object sender, EventArgs e)
        {
            if (buttonTempUnit.Text == "Fahrenheit")
            {
                buttonTempUnit.Text = "Celsius";
                Com.Write(Const.CODE_UNIT_FAHRENHEIT.ToString());
                Switch_UnitTemp = Const.FAHRENHEIT;
                StatusLabel.Text = "Temperature Unit changed to Fahrenheit";
            }
            else
            {
                buttonTempUnit.Text = "Fahrenheit";
                Com.Write(Const.CODE_UNIT_CELSIUS.ToString());
                Switch_UnitTemp = Const.CELSIUS;
                StatusLabel.Text = "Temperature Unit changed to Celsius";
            }
        }

        private void buttonScreen_Click(object sender, EventArgs e)
        {
            if (buttonScreen.Text == "Display")
            {
                buttonScreen.Text = "LDC";
                Switch_Screen = Const.DISPLAY;
                StatusLabel.Text = "Screen changed to Display";
            }
            else
            {
                buttonScreen.Text = "Display";
                Switch_Screen = Const.LCD;
                StatusLabel.Text = "Screen changed to LCD";
            }
        }

        private void buttonMode_Click(object sender, EventArgs e)
        {
            if (buttonMode.Text == "Manual")
            {
                buttonMode.Text = "Automático";
                buttonRead.Enabled = true;
                Com.Write(Const.CODE_MODE_MANUAL.ToString());
                Switch_Mode = Const.MANUAL;
                StatusLabel.Text = "Reading changed to Manual";
            }
            else
            {
                buttonMode.Text = "Manual";
                buttonRead.Enabled = false;
                Com.Write(Const.CODE_MODE_AUTO.ToString());
                Switch_Mode = Const.AUTOMATIC;
                StatusLabel.Text = "Reading changed to Automatic";
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Com.Write(Const.CODE_READ_TEMP.ToString());
            Switch_ReadManualTemp = Const.ON;
        }

        private void TempSensorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Com.getComState())
            {
                Com.Write(Const.CODE_CONNECTION_OFF.ToString());
                Com.Stop();
            }
            try
            {
                ReleaseData.Abort();
            }
            catch { };
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            foreach( Control C in groupBox4.Controls){
                ((Button) C).Text = "on";
            }
           // ((Button)groupBox4.Controls["buttonSreen"]).Text = "on";
        }*/

    }
}

/*
BUTTON START
if (buttonStart.Text == "Start")
            {
                if (Com.Write(Constants.CODE_STARTUP_ON))
                {
                    if (Com.Read() == Constants.CODE_STARTUP_ON)
                    {
                        buttonStart.Text = "Stop";
                        StatusLabel.Text = "Reading of Temperature started";
                        Release = new Thread(ReleaseFunc);
                        releaseEnabled = true;
                        Release.Start();
                    }
                    else
                        StatusLabel.Text = "Error receiving start command";
                }
                else
                    StatusLabel.Text = "Error sending start command!";
            }
            else
            {
                if (Com.Write(Constants.CODE_STARTUP_OFF))
                {
                    if (Com.Read() == Constants.CODE_STARTUP_OFF)
                    {
                        buttonStart.Text = "Start";
                        StatusLabel.Text = "Reading of Temperature stopped";
                    }
                    else
                        StatusLabel.Text = "Failure to receive stop command!";
                }
                else
                    StatusLabel.Text = "Failure to send stop command!";
            }

BUTTON CONNECT
if (buttonConnect.Text == "Connect")
            {
                if (Com.Start(comboCom.SelectedItem.ToString()))
                {
                    if (Com.Write(Constants.CODE_CONNECTION_ON))
                    {
                        if (Com.Read() == Constants.CODE_CONNECTION_ON)
                        {
                            buttonConnect.Text = "Disconnect";
                            StatusSquare.BackColor = Color.LimeGreen;
                            StatusLabel.Text = "Success by connecting with Arduino!";
                        }
                        else
                        {
                            Com.Stop();
                            StatusLabel.Text = "Arduino not found on selected port!";
                        }
                    }
                    else
                        StatusLabel.Text = "Error sending connection command!";
                }
                else
                    StatusLabel.Text = "Error initiating the selected port!";
            }
            else {
                if (Com.Write(Constants.CODE_CONNECTION_OFF))
                {
                    if (Com.Read() == Constants.CODE_CONNECTION_OFF)
                        StatusLabel.Text = "Disconnected with Arduino! Waiting new connection!";
                    else
                        StatusLabel.Text = "Error receiving disconnect command! Reset Arduino Manually.";
                    Com.Stop();
                    buttonConnect.Text = "Connect";
                    StatusSquare.BackColor = Color.Red;
                }
                else
                    StatusLabel.Text = "Failure to send disconnection command!";
            }




*/