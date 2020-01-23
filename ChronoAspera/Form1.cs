using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChronoAspera
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            comboBoxActions.Items.AddRange(new object[] { "Appel","Redaction consultation", "Recherche juridique","Réponse au mail"});// Lister les actions à chronométrer : unfichier de config
            saveFileDialogAction.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";// filtre des fichiers à modifier avec un .xls
            saveFileDialogAction.FilterIndex = 2;
            saveFileDialogAction.RestoreDirectory = true;


        }

        private void cStart_Click(object sender, EventArgs e)
        {
            {
                
                stopwatch.Start(); // Lancement chrono
                chronoTimer.Start(); // lancement du timer qui va mettre a jour l'affichage du chrono
                chronoTimer.Tick += ChronoTimer_Tick; // création du Tick : se délcare toute les 100 ms pour éxécuter une action

            }
        }

        private void ChronoTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed; // prend le temps écoulé du chronométre depuis le start jusqu'a l'appel de la fonction Elapsed

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds); // ùise en forme de l'affichage
            labelChrono.Text = elapsedTime; // envoi de l'affichage
        }

        private void sChrono_Click(object sender, EventArgs e) // clic sur le stop
        {
            stopwatch.Stop(); // arréte le chrono
            
            TimeSpan ts = stopwatch.Elapsed; // prend le temps écoulé

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            labelChrono.Text = elapsedTime;
            chronoTimer.Stop();

        }

        private void rChono_Click(object sender, EventArgs e)
        {
            stopwatch.Reset(); // reset du chrono
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            labelChrono.Text = elapsedTime; // Remise à Zéro affichage

            }

        private void buttonAddAction_Click(object sender, EventArgs e) //ajouter une action dans la combo box des actions
        {
            comboBoxActions.Items.Add(textBoxAddAction.Text);
            textBoxAddAction.Text = string.Empty; 
        }

        private void SaveAction_Click(object sender, EventArgs e) //gére la sauvegarde et l'inscription d'une action dans le fichier
        {
            if (saveFileDialogAction.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Stream myStream = saveFileDialogAction.OpenFile(); //Ouvre le flux sur le fichier sélectionné

                    if (myStream != null)
                    {
                        using (myStream)
                        {
                            using (StreamWriter writer = new StreamWriter(myStream, Encoding.UTF8))// écriture de l'action dans le fichier cible
                            {
                                writer.WriteLine(labelChrono.Text + " - " + comboBoxActions.SelectedItem);
                                saveActionTextbox.Text = saveFileDialogAction.FileName; // renvoie une string sur la textbox qui indique la source du fichier
                                labelListAction.Text = "Liste des actions : ";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur survenue lors de la sauvegarde : " + ex.Message);
                }

                using (StreamReader rd = new StreamReader(saveActionTextbox.Text)) //flux pour mettre à jour la liste des actions
                {
                    string line;
                    while ((line = rd.ReadLine()) != null)
                    {
                        textBoxListAction.AppendText(line);
                    }
                }
            }
        }

        private void updateAction_Click(object sender, EventArgs e) // mettre à jour la liste des actions et le fichier avec la nouvelle action
        {
            textBoxListAction.Clear();
            using (StreamWriter wr = File.AppendText(saveActionTextbox.Text))//ecrit sur le fichier
            {
                wr.WriteLine(labelChrono.Text + " - " + comboBoxActions.SelectedItem);

            }
            using (StreamReader rd = new StreamReader(saveActionTextbox.Text))//affiche dans la liste des actions le contenu du fichier
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    textBoxListAction.AppendText(line + Environment.NewLine);

                }

            }
        }

        private void importSaveAction_Click(object sender, EventArgs e) //import d'une sauvegarde
        {
            if (openFileDialogImportAction.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = openFileDialogImportAction.OpenFile();

                    if (myStream != null)
                    {
                        using (myStream)
                        {
                            saveActionTextbox.Text = openFileDialogImportAction.FileName;
                        }
                        using (StreamReader rd = new StreamReader(saveActionTextbox.Text))
                        {
                            string line;
                            while ((line = rd.ReadLine()) != null)
                            {
                                textBoxListAction.AppendText(line + Environment.NewLine);// met à jour la liste des actions

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur survenue lors de la récupération : " + ex.Message);
                }
            }
        }

    }
}
