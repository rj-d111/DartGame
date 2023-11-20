using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsExperiment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            backgroundWorker1.RunWorkerAsync();
            button1.Enabled = false;
            button1.Text = "Please wait...";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <=100; i++)
            {
                Thread.Sleep(100);
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbl_percent.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Task completed");
        }

        private void btn_changeColor_Click(object sender, EventArgs e)
        {
            List<Color> allowedColors = new List<Color> { Color.Red, Color.Pink, Color.Blue, Color.Green, Color.Violet };
            //CustomColorDialog cd = new CustomColorDialog(allowedColors);
            ColorDialog cd = new ColorDialog();
            cd.Color = panel1.BackColor;
            cd.CustomColors = allowedColors.Select(c => c.R + c.G * 0x100 + c.B * 0x10000).ToArray();
            cd.SolidColorOnly = true;
           // cd.FullOpen = true;
            cd.AnyColor = true;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = cd.Color;
            }
        }
    }
}
