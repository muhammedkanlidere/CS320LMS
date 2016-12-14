using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ForTesting
{
    public partial class RFIDController : Form
    {
        string[] ports = SerialPort.GetPortNames();
        public static string uidText ="";
        public RFIDController()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void RFIDController_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }

            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("11520");
            comboBox2.SelectedIndex = 1;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Already Connected");
            }else
            {   
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                try
                {
                    serialPort1.Open();
                    serialPort1.Write("request");
                    listBox1.Items.Add("Connected");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); 
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    listBox1.Items.Add("Connection Closed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void RFIDController_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }


        public void serialConfig(SerialPort port, string com , int boundRate)
        {
            port.PortName = com;
            port.BaudRate = boundRate;
        }
       

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            
            //BookControl BookControl = (BookControl)Application.OpenForms["BookControl"];
            //TextBox txtRfid = (TextBox)BookControl.Controls["txtRfid"];
            //txtRfid.Text = indata;
            if (indata.IndexOf("Card UID") > -1)
            {
                uidText = indata.Substring(10, 11);
                this.Invoke((MethodInvoker)(() => listBox1.Items.Add(uidText)));
            }
            else
            {
                this.Invoke((MethodInvoker)(() => listBox1.Items.Add(indata)));
            }
           
            
          
            
            

        }
        public string getUid()
        { 
            return uidText;
        }
        public void clearUid()
        {
            uidText = "";
        }

        private void RFIDController_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
