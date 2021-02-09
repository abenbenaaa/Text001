using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SynchronizationContext _SynchronizationContext;
        public Form1()
        {
            InitializeComponent();
            _SynchronizationContext = SynchronizationContext.Current;
        }
        void Work()
        {
            Thread.Sleep(5000);
            UpdateMessage("The answet");

        }
        void UpdateMessage(string message)
        {
            _SynchronizationContext.Post(_=> textBox1.Text = message, null);
        }       //
        //   state:
        //     传递给委托的对象。
        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(Work).Start();
        }
    }
}
