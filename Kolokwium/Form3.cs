using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium
{
    public partial class Form3 : Form
    {
        public string old_note;

        Form1 f;
        public Form3(Form1 f1)
        {
            InitializeComponent();
            f = f1;
            richTextBox1.Text = f.note;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5(this);
            f5.ShowDialog();
            richTextBox1.Text = old_note;
            f.note = old_note;
        }

    }
}
