using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImportCSV_Click(object sender, EventArgs e)
        {
            /* Création d'un openFileDialog qui te permetra de charger le fichier à changer */
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set initial folder for the research of a file
            openFileDialog1.InitialDirectory = "c:\\";
            // This set the kind of file who we're looking for
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            // Set the default kind of files we search (here its .CSV files)
            openFileDialog1.FilterIndex = 1;


            // open and check if something is selected
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Errors
                try
                {
                    /*Création du stream d'ecriture du fichier avec en 1er paramètre le lien du fichier(openFileDialog1.FileName retourne le lien du fichier qui est séléctionné)*/
                    using (StreamWriter myStream = new StreamWriter(openFileDialog1.FileName, true))
                    {
                        /*Ecriture dans ton fichier du contenu d'une textbox*/
                        myStream.Write(FileName.Text);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: Impossible de lire le fichier. Erreur d'origine: " + ex.Message);
                }
            }
        }

    }
}
