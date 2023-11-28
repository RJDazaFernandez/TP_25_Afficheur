using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//  Editeur: Daza Fernandez Renso
//  TP SDelbosc: TP Afficheur
//  28/11/23


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


namespace TP_25_Afficheur_proj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //initialisation de la fenetre form
        }

        private void textBoxTextAfficher_TextChanged(object sender, EventArgs e) // ligne de texte
        {

        }

        private void ButtonAfficher_Click(object sender, EventArgs e) // button afficher
        {
            this.serialPort1.Open(); // permet d'ouvrir le port et initialiser son utilisation
            
            this.textBoxTextAfficher.Text = Text; //affichage du texte
            
            String Effet = this.listBox.Text; // modification des effets du text
            String configTrame = "\x0\x0\x0\x0\x0\x0" + "\x1Z00" + "\x2" + "E$" + "AAU0100FF00" + "IBL00200000" + "VDU07061000" + "\x4";// configuration de la trame
            String TextTrame = "\x0\x0\x0\x0\x0\x0" + "\x1Z00" + "\x2" + "AA" + "\x1B\x22" +  Effet + "BONJOUR" + "\x4"; // modification du texte du panneau signaletique

            this.serialPort1.Write(configTrame); //ecriture de la configuration de la trame
            this.serialPort1.Write(TextTrame); //ecriture du texte de la trame
            this.serialPort1.Close(); // fermeture du port
            
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
