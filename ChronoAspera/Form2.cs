using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace ChronoAspera
{
    public partial class Form2 : Form
    {
        public Form2(List<string> aList)
        {
            InitializeComponent();
            foreach (string el in aList) 
            {
                actionCheckedListBox1.Items.Add(el);
                actionCheckedListBox1.CheckOnClick = true;
            }
        }

        private void cancelButtonForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delActionButtonForm2_Click(object sender, EventArgs e)
        {

        }
    }
}
