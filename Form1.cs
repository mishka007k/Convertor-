using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class Convertor : Form
    {
        public Convertor()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Purple;
            
        }

        private void TextChanched(object sender, EventArgs e)
        {
            float tonn= float.Parse(textBox1.Text)/1000;
            tn.Text = tonn.ToString();
            float gramm = float.Parse(textBox1.Text)*1000;
            gr.Text = gramm.ToString();
            float centner = float.Parse(textBox1.Text) /100;
            cn.Text = centner.ToString();


        }
    }
}
