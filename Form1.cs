using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_25_Afficheur_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxTextAfficher_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAfficher_Click(object sender, EventArgs e)
        {
            this.serialPort1.Open();
            
            this.textBoxTextAfficher.Text = Text;
            
            String Effet = this.listBox.Text;
            String configTrame = "\x0\x0\x0\x0\x0\x0" + "\x1Z00" + "\x2" + "E$" + "AAU0100FF00" + "IBL00200000" + "VDU07061000" + "\x4";
            String TextTrame = "\x0\x0\x0\x0\x0\x0" + "\x1Z00" + "\x2" + "AA" + "\x1B\x22" +  Effet + "BONJOUR" + "\x4";

           
            

            this.serialPort1.Write(configTrame);
            this.serialPort1.Write(TextTrame);
            this.serialPort1.Close();
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
