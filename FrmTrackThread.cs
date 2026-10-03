using System;
using System.Threading;
using System.Windows.Forms;

namespace MidtermsTP
{
    public partial class FrmTrackThread : Form
    {
        private Thread threadA, threadB, threadC, threadD;
        public FrmTrackThread()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            btnRun.Enabled = false;
            lblStatus.Text = "-Thread Starts-";
            Console.WriteLine("-Thread Starts-");

            threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadC = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadD = new Thread(new ThreadStart(MyThreadClass.Thread2));

            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";
            threadC.Name = "Thread C Process";
            threadD.Name = "Thread D Process";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();
          
            Thread waitThread = new Thread(() =>
            {
                threadA.Join();
                threadB.Join();
                threadC.Join();
                threadD.Join();

                Console.WriteLine("-End of Thread-");
                Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = "-End of Thread-";
                    btnRun.Enabled = true;
                });
            });
            waitThread.Start();
        }
    }
}
