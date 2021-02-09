using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Method);
            thread.IsBackground = true;
            thread.Start();
        }
        private void Method()
        {
            for (int i = 0; i < 100000; i++)
            {
                if (textBox1.InvokeRequired)
                {
                    textBox1.Invoke(new Action<int>(x => { textBox1.Text = x.ToString(); }), i);
                }

            }


        }
    }
}
