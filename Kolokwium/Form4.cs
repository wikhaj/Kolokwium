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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            for(int i = 0; i < 1000; i++)
            {
                comboBox1.Items.Add(i);
                comboBox2.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float result = calculator(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
            textBox1.Text = result.ToString();
        }
        float calculator(int one, int two)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    return one + two;
                case 1:
                    return one - two;
                case 2:
                    return one * two;
                case 3:
                    return one / two;
            }
            return 0;
        }
    }
}
