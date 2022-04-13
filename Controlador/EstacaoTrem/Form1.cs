using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstacaoTrem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort serialPort = new SerialPort();

        private void chk1A_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1A.Checked)
            {
                chk1B.Checked = false;
                serialPort.WriteLine("0t2A");
                chk1A.Enabled = false;
                chk1B.Enabled = true;
            }  
        }

        private void chk1B_CheckedChanged(object sender, EventArgs e)
        {

            if (chk1B.Checked)
            {
                chk1A.Checked = false;
                serialPort.WriteLine("0t2B");
                chk1B.Enabled = false;
                chk1A.Enabled = true;
            }            
        }

        private void chk2A_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2A.Checked)
            {
                chk2B.Checked = false;
                serialPort.WriteLine("0t3A");
                chk2A.Enabled = false;
                chk2B.Enabled = true;
            }
        }

        private void chk2B_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2B.Checked)
            {
                chk2A.Checked = false;
                serialPort.WriteLine("0t3B");
                chk2A.Enabled = true;
                chk2B.Enabled = false;
            }
        }

        private void chk3A_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3A.Checked)
            {
                chk3B.Checked = false;
                serialPort.WriteLine("0t1A");
                chk3A.Enabled = false;
                chk3B.Enabled = true;
            }
        }

        private void chk3B_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3B.Checked)
            {
                chk3A.Checked = false;
                serialPort.WriteLine("0t1B");
                chk3A.Enabled = true;
                chk3B.Enabled = false;
            }
        }

        private void chk4A_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4A.Checked)
            {
                chk4B.Checked = false;
                serialPort.WriteLine("0t4A");
                chk4A.Enabled = false;
                chk4B.Enabled = true;
            }
        }

        private void chk4B_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4B.Checked)
            {
                chk4A.Checked = false;
                serialPort.WriteLine("0t4B");
                chk4A.Enabled = true;
                chk4B.Enabled = false;
            }
        }        

        private void vel1_Scroll(object sender, EventArgs e)
        {
            lblVel1.Text = vel1.Value.ToString()+ "%";
            int vel = vel1.Value;
            vel = (int)(vel * 1.26);
            if (vel == 0)
            {                
                vel--;
            }           
            byte[] velCurto = BitConverter.GetBytes(vel);
            serialPort.Write("3s");
            serialPort.Write(velCurto, 0, 1);
            serialPort.WriteLine("-");                    
        }

        private void vel2_Scroll(object sender, EventArgs e)
        {
            lblVel2.Text = vel2.Value.ToString() + "%";
            int vel = vel2.Value;
            vel = (int)(vel * 1.26);
            if (vel == 0)
            {
                vel--;
            }
            byte[] velCurto = BitConverter.GetBytes(vel);
            serialPort.Write("4s");
            serialPort.Write(velCurto, 0, 1);
            serialPort.WriteLine("-");
        }

        private void btnParar1_Click(object sender, EventArgs e)
        {
            byte[] velCurto = BitConverter.GetBytes(1);
            serialPort.Write("3s");
            serialPort.Write(velCurto, 0, 1);
            serialPort.WriteLine("-");
            vel1.Value = 0;
            lblVel1.Text = "0%";
        }

        private void btnParar2_Click(object sender, EventArgs e)
        {
            byte[] velCurto = BitConverter.GetBytes(1);
            serialPort.Write("4s");
            serialPort.Write(velCurto, 0, 1);
            serialPort.WriteLine("-");
            vel2.Value = 0;
            lblVel2.Text = "0%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnFarol1_Click(object sender, EventArgs e)
        {
            if (btnFarol1.BackColor == Color.Yellow)
            {
                serialPort.WriteLine("3l0-");
                btnFarol1.BackColor = Color.Silver;
            }
            else
            {
                serialPort.WriteLine("3l1-");
                btnFarol1.BackColor = Color.Yellow;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.BaudRate = 115200;
                serialPort.PortName = "COM" + txtPorta.Text;
                serialPort.Open();                
                gpbControle.Enabled = true;
                gpbDesvio.Enabled = true;
                gpbGuindaste.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Conexão falhou", "ERRO");                           
            }
        }

        private void btnBuzina1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = "train_horn_1.mp3";
            wplayer.controls.play();
        }

        private void btnFarol2_Click(object sender, EventArgs e)
        {
            if (btnFarol2.BackColor == Color.Yellow)
            {
                serialPort.WriteLine("4l0-");
                btnFarol2.BackColor = Color.Silver;
            }
            else
            {
                serialPort.WriteLine("4l1-");
                btnFarol2.BackColor = Color.Yellow;
            }
        }
    }
}
