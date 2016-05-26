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

namespace RoombaControl
{
    public partial class RoombaControler : Form
    {
        RoombaPacket roombaPacket = new RoombaPacket();

        private void sendPacket(byte[] packet)
        {
            if (serialPort.IsOpen == false)
                return;
            
            serialPort.Write(packet, 0, packet.Length);
            richTextBox_received.AppendText("send >> "+BitConverter.ToString(packet)+"\r\n");
            richTextBox_received.ScrollToCaret();
        }

        public RoombaControler()
        {
            InitializeComponent();
        }

        private void RoombaControler_Load(object sender, EventArgs e)
        {
            string[] port_list = SerialPort.GetPortNames();
            foreach (string portname in port_list)
            {
                select_port.Items.Add(portname);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_speed.Text = trackbar_speed.Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                button_open.Text = "Open";
                return;
            }

            serialPort.PortName = select_port.SelectedItem.ToString();
            serialPort.BaudRate = Convert.ToInt32(comboBox_baud.SelectedIndex.ToString());

            try
            {
                serialPort.Open();
                sendPacket(roombaPacket.Baud(Convert.ToByte(comboBox_baud.SelectedIndex.ToString()))); //todo 長すぎ
                button_open.Text = "Close";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void button_front_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Drive_Straight(trackbar_speed.Value));
        }


        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            label_radius.Text = trackbar_radius.Value.ToString();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Drive(0,0));
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Drive_Turn(true, trackbar_speed.Value));
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Drive_Turn(false, trackbar_speed.Value));
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Drive_Straight(-trackbar_speed.Value));
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton_start_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Start());
        }

        private void radioButton_safe_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Safe());
        }

        private void radioButton_full_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Full());
        }

        private void radioButton_power_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Power());
        }

        private void radioButton_clean_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Clean());
        }

        private void checkBox_mainbrush_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Motors(
                    true, true, checkBox_mainbrush.Checked, checkBox_vaccum.Checked, checkBox_sidebrush.Checked));
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private delegate void Delegate_writeTextbox(string data);

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen == false)
                return;
           
            try {
                string data = serialPort.ReadExisting();

                Invoke(new Delegate_writeTextbox(writeTextbox), new Object[]{data});
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void writeTextbox(string str)
        {
            richTextBox_received.AppendText(str+"\r\n");
            richTextBox_received.ScrollToCaret();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void checkBox_vaccum_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Motors(
                true, true, checkBox_mainbrush.Checked, checkBox_vaccum.Checked, checkBox_sidebrush.Checked));
        }
        
        private void button_clean_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Clean());
        }

        private void button_drive_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Drive(trackbar_speed.Value, trackbar_radius.Value));
        }

        private void checkBox_sidebrush_CheckedChanged(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Motors(
               true, true, checkBox_mainbrush.Checked, checkBox_vaccum.Checked, checkBox_sidebrush.Checked));
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Start());
        }

        private void button_safe_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Safe());
        }

        private void button_full_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Full());
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Power());
        }

        private void label_keycontrol_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
            switch (e.KeyData)
            {
                case Keys.Up:
                    button_front_Click(sender, e);
                    break;
                case Keys.Down:
                    button_back_Click(sender, e);
                    break;
                case Keys.Left:
                    button_left_Click(sender, e);
                    break;
                case Keys.Right:
                    button_right_Click(sender, e);
                    break;
                case Keys.Space:
                    button_stop_Click(sender, e);
                    break;
            }
        }

        private void label_keycontrol_Click(object sender, EventArgs e)
        {
            label_keycontrol.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.FamilyMart(0));
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Play());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Frog2(0));
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            sendPacket(roombaPacket.Frog1(0));
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
