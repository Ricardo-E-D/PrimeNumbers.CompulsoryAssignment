using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CompulsoryAssignment
{
    public class PrimeGenerator
    {
        // 1) Function implementation using sequential approach 
        // changing this, voids the assignments specified requirements of said method
        public List<long> GetPrimesSequential(long first, long last)
        {
            if (first > last) throw new Exception("The starting number is greater than the last");

            var primes = new List<long>();

            for (long i = first; i < last; i++)
            {
                if (i == 2 || i == 3)
                {
                    primes.Add(i);
                    continue;
                }

                // numbers below 1,
                // divisible by 2 (except 2) and
                // divisible by 3 (except 3)
                // cannot be prime
                if (i <= 1 || i % 2 == 0 || i % 3 == 0) continue;

                // for checking if the current number [i] is prime
                bool isPrime = true;
                // ✨✨ magic starts here ✨✨
                for (long j = 5; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    primes.Add(i);
            }

            return primes;
        }

        // 2) Function implementation using parallel approach 
        // changing this, voids the assignments specified requirements of said method
        public List<long> GetPrimesParallel(long first, long last)
        {
            if (first > last) throw new Exception("The starting number is greater than the last");

            //TODO: populate the list in order
            // currently, this does not take race-conditions into account
            var primes = new List<long>();

            //TODO: alternative to parsing longs to ints?
            Parallel.For(Convert.ToInt32(first), Convert.ToInt32(last + 1), i =>
            {
                if (i == 2 || i == 3)
                {
                    primes.Add(i);
                    return;
                }

                if (i <= 1 || i % 2 == 0 || i % 3 == 0) return;

                bool isPrime = true;
                //TODO: are nested parallel-loops possible?
                for (long j = 5; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    primes.Add(i);
            });
            return primes;
        }

        #region alternative to the Parallel method
        //public Task<List<long>> GetPrimesParallelAsync(long first, long last)
        //{
        //    return Task.Factory.StartNew(() =>
        //    {
        //        if (first > last) throw new Exception("The starting number is greater than the last");

        //        var primes = new List<long>();

        //        Parallel.For(Convert.ToInt32(first), Convert.ToInt32(last + 1), i =>
        //        {
        //            var ia = i;
        //            if (i == 2 || i == 3)
        //            {
        //                primes.Add(ia);
        //                return;
        //            }

        //            if (i <= 1 || i % 2 == 0 || i % 3 == 0) return;

        //            bool isPrime = true;
        //            for (long j = 5; j < i / 2; j++)
        //            {
        //                if (i % j == 0)
        //                {
        //                    isPrime = false;
        //                    break;
        //                }
        //            }

        //            if (isPrime)
        //                primes.Add(ia);
        //        });

        //        return primes.ToList();
        //    });
        //}
        #endregion
    }
}
