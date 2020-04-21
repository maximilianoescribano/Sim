using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIM_G7_TP1.Models
{
    public class RandomGenerator
    {
        #region TP1
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

        public double[] generateLangRandom(uint count)
        {
            var rnd = new Random(Semilla);
            var nums = new double[count];

            for (var i = 0; i < count; i++)
                nums[i] = TruncateDecimal(rnd.NextDouble(), 4);

            return nums;
        }

        public double TruncateDecimal(double value, int precision)
        {
            double step = (double)Math.Pow(10, precision);
            double tmp = Math.Truncate(step * value);
            return tmp / step;
        }

        public double[] generateCongrLinealRandom(int count)
        {
            double[] nums = new double[count];

            for (int i = 0; i < count; i++)
            {
                int newSeed = generateSeed();
                double rnd = ((double)newSeed) / (M);

                //nums[i] = Math.Round(rnd, 4);
                nums[i] = TruncateDecimal(rnd, 4);
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

#endregion TP1

        public double[] generateUniformDistrib(int lowBind, int highBind, double[] randoms)
        {
           var randNormal = new double[randoms.Length];

            for (var i = 0; i < randoms.Length; i++)
                randNormal[i] = this.TruncateDecimal(lowBind + randoms[i] * (highBind - lowBind), 4);

            return randNormal;
        }

        public double[] generateExponentialDistrib(double lambda, double[] randoms)
        {
            double[] randNormal = new double[randoms.Length];
            double x = 0;
            MayorValor = 0;
            MenorValor = Double.MaxValue;;

            for (int i = 0; i < randoms.Length; i++)
            {
                x = (Math.Log(1 - randoms[i])) / -lambda;
                randNormal[i] = this.TruncateDecimal(x, 4);
            }

            setMinMax(randNormal);

            return randNormal;
        }

        public double[] generateNormalDistrib(double media, double desviacion, double[] randoms)
        {
            double[] randNormal = new double[randoms.Length];
            double z = 0;

            double[] seedRandoms = generateUniformDistrib(1, randoms.Length, randoms);

            for (int i = 0; i < randoms.Length; i++)
			{
                this.Semilla = (int)seedRandoms[i];
                double[] rand = generateLangRandom(12);
			    double sumRnd = rand.Sum();
                z = ((sumRnd - 6) * desviacion) + media;
                randNormal[i] = z;
			}

            setMinMax(randNormal);

            return randNormal;
        }

        private void setMinMax(double[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            }

            MenorValor = nums.Min();
            MayorValor = nums.Max();
        }

        public double[,] validateFrecuencies(double[] nums, int intervals, double lowBind = 0, double highBind = 1)
        {
            double[,] frecuencies = buildIntervals(intervals, nums.Length, lowBind, highBind);
            int index = 0;
            int frecObs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                index = getIndexIntervalForNumber(nums[i], frecuencies);
                frecObs = (int)frecuencies[index, 2];
                frecObs++;
                frecuencies[index, 2] = frecObs;
            }

            return calculateTestValues(frecuencies);

            //return oldMethod(nums, intervals);
        }



        public double[,] validateFrecuenciesExp(double[] nums, int intervals, double lowBind = 0, double highBind = 1)
        {
            double[,] frecuencies = buildIntervals(intervals, nums.Length, lowBind, highBind);
            int index = 0;
            int frecObs = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                index = getIndexIntervalForNumber(nums[i], frecuencies);
                frecObs = (int)frecuencies[index, 2];
                frecObs++;
                frecuencies[index, 2] = frecObs;
            }

            return calculateTestValues(frecuencies);

        }


        private double[,] oldMethod(double[] nums, int intervals)
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

        private double[,] calculateTestValues(double[,] intervals)
        {
            double calcEst = 0;
            double calcEstAcum = 0;
            double frecEsp = 0;
            int frecObs = 0;

            for (int i = 0; i < intervals.GetLength(0); i++)
            {
                frecEsp = intervals[i, 3];
                frecObs = (int)intervals[i, 2];

                calcEst = Math.Round(Math.Pow(frecObs - frecEsp, 2) / frecEsp, 4);
                calcEstAcum += calcEst;

                intervals[i, 4] = calcEst;
                intervals[i, 5] = calcEstAcum;
            }

            return intervals;
        }

        private double[,] buildIntervals(int numIntervals, int numsTotals, double lowBind = 0, double highBind = 1)
        {
            double[,] intervals = new double[numIntervals, 6];
            double low = 0;
            double high = 0;
            double frecEsp = 0;
            double range = highBind - lowBind;
            double intervalRange = Math.Round(((double)range / numIntervals), 4);

            low = lowBind;
            high = lowBind;
            for (int i = 0; i < numIntervals; i++)
            {
                low = high;
                high = Math.Round(low + intervalRange, 4);
                intervals[i, 0] = low;
                intervals[i, 1] = high;
                frecEsp = Math.Round(((double)numsTotals) / numIntervals, 4);
                intervals[i, 3] = frecEsp;
            }

            return intervals;
        }

        public int countNumbersWithinInterval(double low, double high, double[] nums)
        {
            return nums.Count(item => item >= low && item < high);
        }

        public int getIndexIntervalForNumber(double num, double[,] intervals)
        {
            int index = 0;

            for (int i = 0; i < intervals.GetLength(0); i++)
            {
                if (num >= intervals[i, 0] && num < intervals[i, 1])
                {
                    return i;
                }
            }

            return index;
        }
 
    }
}
