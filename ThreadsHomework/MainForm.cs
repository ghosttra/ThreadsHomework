using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsHomework {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private Thread SimpleDigits;
        private Thread fibonacci;
        private void bStartSD_Click(object sender, EventArgs e) {
            lbSimpleDigits.Items.Clear();
            SimpleDigits = new Thread(CreateSimpleDigits) { IsBackground = true };
            SimpleDigits.Start(new int[] { (int)nFromSD.Value, (int)nToSD.Value });
        }
        private void CreateSimpleDigits(object Diapazon) {
            var CastedParam = Diapazon as int[];

            Action<int> action = (int i) => {
                lbSimpleDigits.Items.Add(i);
            };
            for (int i = CastedParam[0]; i < CastedParam[1]; i++) {
                Thread.Sleep(50);

                if (IsPrime(i)) {
                    if (InvokeRequired)
                        Invoke(action, i);
                    else
                        action(i);
                }
            }
        }
        private bool IsPrime(int number) {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

        private void bStartFibonacci_Click(object sender, EventArgs e) {
            lbFibonacci.Items.Clear();
            fibonacci = new Thread(Fibonacci) { IsBackground = true };
            fibonacci.Start();
        }
        private void Fibonacci() {
            long a = 0, b = 1, c = 0;
            Action action = () => {
                c = a + b;
                lbFibonacci.Items.Add(c);
                a = b;
                b = c;
            };
            for (int i = 0; i < 100; i++) {
                Thread.Sleep(500);
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();
            }
        }

        private void bStopPrime_Click(object sender, EventArgs e) {
            try {
                SimpleDigits.Abort();
            }
            catch (Exception) {

                MessageBox.Show("Thread is not initialised, try to START thread");
            }
        }

        private void bStopFibonacci_Click(object sender, EventArgs e) {
            try {
                fibonacci.Abort();
            }
            catch (Exception) {

                MessageBox.Show("Thread is not initialised, try to START thread");
            }
        }

        private void bSuspendFibonacci_Click(object sender, EventArgs e) {
            try {
                fibonacci.Suspend();
            }
            catch (Exception) {
                MessageBox.Show("Thread is not initialised, try to START thread");
            }
        }

        private void bSuspendSD_Click(object sender, EventArgs e) {
            try {
                SimpleDigits.Suspend();
            }
            catch (Exception) {
                MessageBox.Show("Thread is not initialised, try to START thread");
            }
        }

        private void bResumeSD_Click(object sender, EventArgs e) {
            try {
                SimpleDigits.Resume();
            }
            catch (Exception) {
                MessageBox.Show("Thread is not initialised, try to START thread");
            }
        }

        private void bResumeFibonacci_Click(object sender, EventArgs e) {
            try {
                fibonacci.Resume();
            }
            catch (Exception) {
                MessageBox.Show("Thread is not initialised, try to START thread");
            }
        }
    }
}