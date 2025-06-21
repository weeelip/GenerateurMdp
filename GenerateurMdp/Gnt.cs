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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GenerateurMdp
{
    public partial class GenMdp : Form
    {
        public GenMdp()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        

        private void Gen_Click(object sender, EventArgs e)
        {
            GenererMdp();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CopyMdp();
           
        }

       
  

        private void clear_Click(object sender, EventArgs e)
        {
            EffacerTout();

        }

        private void app_Click(object sender, EventArgs e)
        {
            var tf = new Apropos();
            tf.ShowDialog();



        }
        private void quit_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Voulez vous vraiment quitter l'application ?", "Quitter ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                Application.Exit();

            }


        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {

            AccesFolder();
            


        }
        private void btnGenListe_Click(object sender, EventArgs e)
        {
            GenListe();


        }

        private void EffacerTout()
        {
            LMaj.Checked = true;
            LMin.Checked = false;
            CarSpe.Checked = false;
            Chiffres.Checked = false;
            NbCar.Value = 8;
            result.Text = "";

        }
        private void CopyMdp()
        {
            if (String.IsNullOrEmpty(result.Text))
            {

                MessageBox.Show("Aucun mot de passe généré !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Clipboard.SetData(DataFormats.Text, result.Text);
                MessageBox.Show("Mot de passe copié !",
                   "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenererMdp()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();



            string chars = "";


            if (LMin.Checked == true)
            {
                chars += "abcdefghijklmnopqrstuvwxyz";
            }
            if (LMaj.Checked == true)
            {
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (Chiffres.Checked == true)
            {
                chars += "1234567890";
            }
            if (CarSpe.Checked == true)
            {
                chars += "&'(-_^$ù*ù:;,?./§%¨£µ%)=";
            }



            for (int i = 0; i < NbCar.Value; i++)
            {

                try
                {
                    int index = rnd.Next(chars.Length);
                    sb.Append(chars[index]);

                }
                catch(IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Veuillez séléctionner au moins une case",
                    "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
            }


            if (NbCar.Value < 8)
            {
                MessageBox.Show("Il est conseillé de générer un mot de passe égal ou supérieur à 8 caractères !",
               "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            result.Text = sb.ToString();

        }

        private string GenererMdpL()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();


            string chars = "";


            if (minListe.Checked == true)
            {
                chars += "abcdefghijklmnopqrstuvwxyz";
            }
            if (majListe.Checked == true)
            {
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }

            if (chiffresListe.Checked == true)
            {
                chars += "1234567890";
            }
            if (specListe.Checked == true)
            {
                chars += "&'(-_^$ù*ù:;,?./§%¨£µ%)=";
            }



            for (int i = 0; i < nbCara.Value - 1; i++)
            {

                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);

            }


            if (nbCara.Value < 8)
            {
                MessageBox.Show("Il est conseillé de générer des mots de passes égaux ou supérieurs à 8 caractères !",
               "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return sb.ToString();

        }

        private void AccesFolder()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();

            txtSauvegarde.Text = folderDlg.SelectedPath;
        }

       

        private void GenListe()
        {
            int j = 1;
            int k = 1;
            bool gen = false;
            try
            {

                Directory.SetCurrentDirectory(txtSauvegarde.Text);

                while (File.Exists(txtSauvegarde.Text + "/Motsdepasses" + k + ".txt") == true)
                {
                    k++;
                }
                StreamWriter objFichierAEcrire = new StreamWriter("Motsdepasses" + k + ".txt", true);


                for (int i = 0; i < nbMdp.Value; i++)
                {
                    progressGen.Maximum = (int)nbMdp.Value;
                    progressGen.Value = j;
                    try
                    {
                        objFichierAEcrire.WriteLine(GenererMdpL());
                        System.Threading.Thread.Sleep(50);
                        gen = true;
                    }

                    catch
                    {
                        MessageBox.Show("Veuillez au moins séléctionner une option",
                        "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        break;

                    }
                    j++;
                }

                if (gen == true)
                {
                    MessageBox.Show("Mot de passe généré !",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progressGen.Value = 0;
                    objFichierAEcrire.Close();
                }




            }
            catch
            {
                MessageBox.Show("Séléctionnez un emplacement de sauvegarde valide",
                   "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Stop); ;
                //System.Diagnostics.Process.Start("@txtSauvegarde.Text");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
