using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompulsoryAssignment
{
    public partial class Form1 : Form
    {
        private readonly PrimeGenerator primeGenerator;
        public Form1()
        {
            primeGenerator = new PrimeGenerator();
            InitializeComponent();
        }

        private void BtnGetPrimeNumbersSeq_Click(object sender, EventArgs e)
        {
            long minVal, maxVal;
            long.TryParse(TxtMinVal.Text, out minVal);
            long.TryParse(TxtMaxVal.Text, out maxVal);

            List<long> primes = new List<long>();


            MeasureTime(() => primes = primeGenerator.GetPrimesSequential(minVal, maxVal));
            foreach (var n in primes)
                ListBoxOfPrimes.Items.Add(n.ToString());
        }

        #region in conjunction with [GetPrimesParallel()]
        private async void BtnGetPrimeNumbersPar_Click(object sender, EventArgs e)
        {
            long minVal, maxVal;
            long.TryParse(TxtMinVal.Text, out minVal);
            long.TryParse(TxtMaxVal.Text, out maxVal);

            List<long> primes = new List<long>();

            await Task.Run(() =>
            {
                MeasureTime(() => primes = primeGenerator.GetPrimesParallel(minVal, maxVal));
            });

            foreach (var prime in primes)
                ListBoxPar.Items.Add(prime.ToString());
        }
        #endregion

        #region alternative to using an async method
        //private void BtnGetPrimeNumbersPar_Click(object sender, EventArgs e)
        //{
        //    long minVal, maxVal;
        //    long.TryParse(TxtMinVal.Text, out minVal);
        //    long.TryParse(TxtMaxVal.Text, out maxVal);

        //    List<long> primes = new List<long>();

        //    var primesGenenerator = primeGenerator.GetPrimesParallelAsync(minVal, maxVal);

        //    primesGenenerator.ContinueWith(t =>
        //    {
        //        primes = primesGenenerator.Result;
        //        foreach (var prime in primes)
        //        {
        //            ListBoxPar.Items.Add(prime.ToString());
        //        }
        //    }, TaskScheduler.FromCurrentSynchronizationContext());        //allows the UI-thread to run
        //}
        #endregion

        #region Utils
        private static void MeasureTime(Action @delegate)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            @delegate.Invoke();
            sw.Stop();

            Console.WriteLine($"    Time = {sw.ElapsedMilliseconds / 1000f:F5} sec.");
        }
        #endregion
    }
}
