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
            comboBoxActions.Items.AddRange(new object[] { "Appel","Redaction consultation", "Recherche juridique","Réponse au mail"});
            saveFileDialogAction.Filter = "Fichiers texte|*.txt|Tous les fichiers|*.*";
            saveFileDialogAction.FilterIndex = 2;
            saveFileDialogAction.RestoreDirectory = true;


        }

        private void cStart_Click(object sender, EventArgs e)
        {
            {
                
                stopwatch.Start();
                chronoTimer.Start();
                chronoTimer.Tick += ChronoTimer_Tick;

            }
        }

        private void ChronoTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            labelChrono.Text = elapsedTime;
        }

        private void sChrono_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            labelChrono.Text = elapsedTime;
            chronoTimer.Stop();

        }

        private void rChono_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            TimeSpan ts = stopwatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
           ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            labelChrono.Text = elapsedTime;

            }

        private void buttonAddAction_Click(object sender, EventArgs e)
        {
            comboBoxActions.Items.Add(textBoxAddAction.Text);
            textBoxAddAction.Text = string.Empty; 
        }

        private void SaveAction_Click(object sender, EventArgs e)
        {
            if (saveFileDialogAction.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Stream myStream = saveFileDialogAction.OpenFile();

                    if (myStream != null)
                    {
                        using (myStream)
                        {
                            using (StreamWriter writer = new StreamWriter(myStream, Encoding.UTF8))
                            {
                                writer.WriteLine(labelChrono.Text + " - " + comboBoxActions.SelectedItem);
                                saveActionTextbox.Text = saveFileDialogAction.FileName;
                                labelListAction.Text = "Liste des actions : ";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur survenue lors de la sauvegarde : " + ex.Message);
                }

                using (StreamReader rd = new StreamReader(saveActionTextbox.Text))
                {
                    string line;
                    while ((line = rd.ReadLine()) != null)
                    {
                        textBoxListAction.AppendText(line);
                    }
                }
            }
        }

        private void updateAction_Click(object sender, EventArgs e)
        {
            textBoxListAction.Clear();
            using (StreamWriter wr = File.AppendText(saveActionTextbox.Text))
            {
                wr.WriteLine(labelChrono.Text + " - " + comboBoxActions.SelectedItem);

            }
            using (StreamReader rd = new StreamReader(saveActionTextbox.Text))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    textBoxListAction.AppendText(line + Environment.NewLine);

                }

            }
        }

        private void importSaveAction_Click(object sender, EventArgs e)
        {
            if (openFileDialogImportAction.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream mySteam = openFileDialogImportAction.OpenFile();

                    if (mySteam != null)
                    {
                        using (mySteam)
                        {
                            saveActionTextbox.Text = openFileDialogImportAction.FileName;
                        }
                        using (StreamReader rd = new StreamReader(saveActionTextbox.Text))
                        {
                            string line;
                            while ((line = rd.ReadLine()) != null)
                            {
                                textBoxListAction.AppendText(line + Environment.NewLine);

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
