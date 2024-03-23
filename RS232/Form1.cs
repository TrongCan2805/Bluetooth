using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace RS232
{

    public partial class Form1 : Form
    {
        string ReceiveData = String.Empty;
        string TransmitData = String.Empty;

        // tao thoi gian 
        Timer timerAutoMode = new Timer();
        bool autoMode = false; // che do tu dong 


        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            btnDisConn.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnon1.Enabled = false;
            btnoff1.Enabled = false;
            btnon2.Enabled = false;
            btnoff2.Enabled = false;

            timerAutoMode.Interval = 100; // Thời gian đo lường trong 1 giây
            timerAutoMode.Tick += TimerAutoMode_Tick;

        }

      


        // cau hinh thoi gian 
        private void TimerAutoMode_Tick(object sender, EventArgs e)
        {
            // Lấy thời gian hiện tại của máy tính
            DateTime currentTime = DateTime.Now;
     
            // Kiểm tra nếu thời gian hiện tại nằm trong khoảng từ 7h đến 23h
            if (currentTime.Hour >= 7 && currentTime.Hour < 23)
            {
                // Gửi tín hiệu bật 3 led
                if (serialPort1.IsOpen)
                {
                    TransmitData = "q";
                    serialPort1.Write(TransmitData);
                    
                }
            }
            else
            {
                // Gửi tín hiệu tắt led
                if (serialPort1.IsOpen)
                {
                    TransmitData = "w";
                    serialPort1.Write(TransmitData);
                   
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports) 
            {
                comboBox1.Items.Add(port);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;

        }

        // ket noi cong com 
        private void btnConn_Click(object sender, EventArgs e)
        {
 
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select COM Port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if(serialPort1.IsOpen)
                    {
                        MessageBox.Show(" COM Ports is connected and ready for use ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serialPort1.Open();
                        txtConn.BackColor = Color.Lime;
                        txtConn.Text = " Connecting...";
                        comboBox1.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        btnDisConn.Enabled = true;
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("COM port is not found. Please check your COM or Cable.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
        }

        // ngat ket noi cong COM
        private void btnDisConn_Click(object sender, EventArgs e)
        {
            button1.Enabled=false;
            button2.Enabled=false; 
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnon1.Enabled = false;
            btnoff1.Enabled = false;
            btnon2.Enabled = false;
            btnoff2.Enabled = false;
            
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    txtConn.BackColor = Color.Red;
                    txtConn.Text = " Disconnected !";
                    comboBox1.Enabled = true;
                   btnDisConn.Enabled = false;

            }
                
        }


        // bat led 1
        private void btnOn_Click(object sender, EventArgs e)
        {
            
          
                if (serialPort1.IsOpen)
                {
                    TransmitData = "e";
                    serialPort1.Write(TransmitData);
                   
                }
             
        }


        // Tat led 1
        private void btnOff_Click(object sender, EventArgs e)
        {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "r";
                    serialPort1.Write(TransmitData);

                }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceiveData = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DoupDate));
        }


        // nhan gia tri tu COM
        private void DoupDate(object sender, EventArgs e)
        {
            //bat tat led1
            if( ReceiveData == "t")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledon;
            }
            if (ReceiveData == "y")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledoff;
            }

            //bat led 2
            if (ReceiveData == "u")
            {
                pictureBox2.Image = RS232.Properties.Resources.ledon;
            }
            if (ReceiveData == "i")
            {
                pictureBox2.Image = RS232.Properties.Resources.ledoff;
            }

            //bat tat led 3
            if (ReceiveData == "o")
            {
                pictureBox4.Image = RS232.Properties.Resources.ledon;
            }
            if (ReceiveData == "p")
            {
                pictureBox4.Image = RS232.Properties.Resources.ledoff;
            }


            //che do auto tat 3 led
            else if(ReceiveData == "a")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledoff;
                pictureBox2.Image = RS232.Properties.Resources.ledoff;
                pictureBox4.Image = RS232.Properties.Resources.ledoff;
            }

            // bat 3 led
            else if (ReceiveData == "s")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledon;
                //pictureBox2.Image = RS232.Properties.Resources.ledon;
               // pictureBox4.Image = RS232.Properties.Resources.ledon;
            }

            else if (ReceiveData == "d")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledoff;
                pictureBox4.Image = RS232.Properties.Resources.ledoff;
                pictureBox3.Image = RS232.Properties.Resources.dusang;

            }
            else if (ReceiveData == "f")
            {
                pictureBox1.Image = RS232.Properties.Resources.ledon;
                pictureBox4.Image = RS232.Properties.Resources.ledon;
                pictureBox3.Image = RS232.Properties.Resources.dusangr;
            }

        }



        // bat led 2
        private void btnon1_Click(object sender, EventArgs e)
        {
            
           
                if (serialPort1.IsOpen)
                {
                    TransmitData = "g";
                    serialPort1.Write(TransmitData);

                }
               
        }

        // tat led 2
        private void btnoff1_Click(object sender, EventArgs e)
        {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "h";
                    serialPort1.Write(TransmitData);
                } 
        }

      
        // bat led 3
        private void btnon2_Click(object sender, EventArgs e)
        {
              if (serialPort1.IsOpen)
              {
                    TransmitData = "j";
                    serialPort1.Write(TransmitData);

              }            
        }

        // tat led 3
        private void btnoff2_Click(object sender, EventArgs e)
        {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "k";
                    serialPort1.Write(TransmitData);

                } 
        }

      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exits? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if ( serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
            }
        }

        // che do AUTO
        private void button1_Click(object sender, EventArgs e)
        {
            // tat cac nut nhan
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnon1.Enabled = false;
            btnoff1.Enabled = false;
            btnon2.Enabled = false;
            btnoff2.Enabled = false;
            groupBox6.Enabled = true;


            // Bật chế độ tự động
            autoMode = true;
            if (!timerAutoMode.Enabled)
                timerAutoMode.Start();
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.White;
           
        }


        // bang tay
        private void button2_Click(object sender, EventArgs e)
        {
             
            
            // bat cac nut nhan 
            btnDisConn.Enabled = true;
            btnOn.Enabled = true;
            btnOff.Enabled = true;
            btnon1.Enabled = true;
            btnoff1.Enabled = true;
            btnon2.Enabled = true;
            btnoff2.Enabled = true;
            groupBox6.Enabled = false;

            // tat che đo tu dong 
            autoMode = false;
            if (timerAutoMode.Enabled)
                timerAutoMode.Stop();
  
           
            button1.BackColor = Color.White;
            button2.BackColor = Color.Yellow;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
