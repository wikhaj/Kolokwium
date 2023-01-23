using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium
{
    public partial class Form5 : Form
    {
        public Form3 f;

        public Form5(Form3 f3)
        {
            f = f3;
            InitializeComponent();
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            f.old_note = richTextBox1.Text;
        }
    }
}
