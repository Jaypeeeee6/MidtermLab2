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

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        private Thread ThreadA, ThreadB;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart run = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(run);
            ThreadA.Name = "Thread A Process";
            ThreadB = new Thread(run);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            lbltxt1.Text = ("-End Of Thread-");
            Console.WriteLine("-End Of Thread-");
        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
