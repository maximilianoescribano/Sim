using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIM_G7_TP1.Models
{
    public class RandomGenerator
    {
        private int _a;
        private int _c;
        private int _m;
        private int _semilla;
        private double _rnd;
        private double _chi2;
        private double _menorValor;
        private double _mayorValor;

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int C
        {
            get { return _c; }
            set { _c = value; }
        }

        public int M
        {
            get { return _m; }
            set { _m = value; }
        }

        public int Semilla
        {
            get { return _semilla; }
            set { _semilla = value; }
        }

        public double Chi2
        {
            get { return _chi2; }
            set { _chi2 = value; }
        }

        public double MenorValor
        {
            get { return _menorValor; }
            set { _menorValor = value; }
        }

        public double MayorValor
        {
            get { return _mayorValor; }
            set { _mayorValor = value; }
        }

        public RandomGenerator() : this(0)
        {
        }

        public RandomGenerator(int semilla) : this(semilla, 0, 0, 0)
        {
        }

        public RandomGenerator(int semilla, int a, int m, int c)
        {
            _a = a;
            _c = c;
            _m = m;
            _semilla = semilla;
            _rnd = 0;
            _chi2 = 0;
            _menorValor = 0;
            _mayorValor = 0;
        }

        public double[] generateLangRandom(int count)
        {
            var rnd = new Random(Semilla);
            var nums = new double[count];

            for (var i = 0; i < count; i++)
            {
                nums[i] = Math.Round(rnd.NextDouble(), 4);
            }

            return nums;
        }

        public double[] generateCongrLinealRandom(int count)
        {
            double[] nums = new double[count];

            for (int i = 0; i < count; i++)
            {
                int newSeed = generateSeed();
                double rnd = ((double)newSeed) / (M);

                nums[i] = Math.Round(rnd, 4);
            }

            return nums;
        }

        private int generateSeed()
        {
            int Xn;

            Xn = Semilla * A + C;

            Semilla = Xn % M;

            return Semilla;
        }

        public double[] generateCongrMultiRandom(int count)
        {
            double[] nums = new double[count];
            C = 0;

            nums = generateCongrLinealRandom(count);

            return nums;
        }


        public double[,] validateFrecuencies(double[] nums, int intervals)
        {
            double[,] frecuencies = new double[intervals, 6];
            double low = 0;
            double high = 0;
            double frecEsp = 0;
            int frecObs = 0;
            double calcEst = 0;
            double calcEstAcum = 0;

            for (int i = 0; i < intervals; i++)
            {
                low = high;
                var high1 = Math.Round(((double)1 / intervals), 4);
                high = Math.Round(low + high1, 4);
                frecEsp = Math.Round(((double)nums.Length) / intervals, 4);
                frecObs = countNumbersWithinInterval(low, high, nums);
                calcEst = Math.Round(Math.Pow(frecObs - frecEsp, 2) / frecEsp, 4);
                calcEstAcum += calcEst;

                frecuencies[i, 0] = low;
                frecuencies[i, 1] = high;
                frecuencies[i, 2] = frecObs;
                frecuencies[i, 3] = frecEsp;
                frecuencies[i, 4] = calcEst;
                frecuencies[i, 5] = calcEstAcum;
            }

            return frecuencies;
        }

        public int countNumbersWithinInterval(double low, double high, double[] nums)
        {
            return nums.Count(item => item >= low && item < high);
        }
    }
}
