using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int x;
            ClassA a = new ClassA();
            label1.Text = a.GetNumber().ToString();
            ClassB b = new ClassB();
            x = Convert.ToInt32(label1.Text);
            for (int i = 2; i <= x; i++)
            {
                if (b.Check(i) == true) comboBox1.Items.Add(i);
            }
        }
    }
}
