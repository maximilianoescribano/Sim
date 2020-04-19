using SIM_G7_TP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIM_G7_TP1
{
    public partial class TP3 : Form
    {
        double[] randomNumbers;
        Stopwatch timer;

        public TP3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            switch (tabRandomMethods.SelectedIndex)
            {
                case 0:
                    generateUniformDistrib();
                    break;
                case 1:
                    generateExponentialDistrib();
                    break;
                case 2:
                   generateNormalDistrib();
                   break;
            }
        }

        private void generateNormalDistrib()
        {
            Int32 rndNumCount = Convert.ToInt32(nudRandomNumbersCount.Value);
            int seed = Convert.ToInt16(nudNormalDistribSeed.Value);
            double media = Convert.ToDouble(nudNormalDistribMedia.Value);
            double deviation = Convert.ToDouble(nudNormalDistribDeviation.Value);

            RandomGenerator rndGen = new RandomGenerator(seed);

            this.Cursor = Cursors.WaitCursor;
            timer = Stopwatch.StartNew();
            randomNumbers = rndGen.generateLangRandom(rndNumCount);
            randomNumbers = rndGen.generateNormalDistrib(media, deviation, randomNumbers);
            timer.Stop();
            lblElapsedTimeGenerator.Text = timer.ElapsedMilliseconds.ToString();

            fillDGNumbers(randomNumbers);
            generateFrecuencies(rndGen.MenorValor, rndGen.MayorValor);
            this.Cursor = Cursors.Default;
        }

        private void generateUniformDistrib()
        {
            var rndNumCount = Convert.ToInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt16(nudUniformDistribSeed.Value);

            int A = Convert.ToInt16(nudUniformDistribA.Value);
            int B = Convert.ToInt16(nudUniformDistribB.Value);

            //if (!linerControl(seed, constMulti, magMod, constAditiv)) return;

            var rndGen = new RandomGenerator();

            this.Cursor = Cursors.WaitCursor;

            randomNumbers = rndGen.generateLangRandom(rndNumCount);
            randomNumbers = rndGen.generateUniformDistrib(A, B, randomNumbers);
            fillDGNumbers(randomNumbers);
            //generateFrecuencies();
            this.Cursor = Cursors.Default;
        }

        private void generateExponentialDistrib()
        {
            int rndNumCount = Convert.ToInt16(nudRandomNumbersCount.Value);
            int seed = Convert.ToInt16(nudExponentialDistribSeed.Value);
            double lambda = Convert.ToDouble(nudExponentialDistribLambda.Value);


            //if (congrControl(seed, constMulti, magMod)) return;

            var rndGen = new RandomGenerator(seed);

            this.Cursor = Cursors.WaitCursor;
            randomNumbers = rndGen.generateLangRandom(rndNumCount);
            randomNumbers = rndGen.generateExponentialDistrib(lambda, randomNumbers);
            fillDGNumbers(randomNumbers);

            generateFrecuencies(rndGen.MenorValor, rndGen.MayorValor);
            this.Cursor = Cursors.Default;
        }

        private void generateFrecuencies(double min, double max)
        {
            RandomGenerator gen = new RandomGenerator();
            int numIntervals = Convert.ToInt16(nudNumInvervals.Value);


            if (numIntervals > 0)
            {
                timer = Stopwatch.StartNew();
                var frecuencias = gen.validateFrecuencies(randomNumbers, numIntervals, min, max);
                timer.Stop();
                lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();

                fillDBFrecuencies(frecuencias);
                gradlib.Visible = true;
                gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencias.GetLength(0) - 1));
                fillChart(frecuencias);
            }
        }

        private void fillDGNumbers(double[] num)
        {
            dtgNumeros.Rows.Clear();
            for (int i = 0; i < num.Length; i++)
            {
                dtgNumeros.Rows.Add(i + 1, num[i]);
            }
        }

        private void fillDBFrecuencies(double[,] frec)
        {
            dtgIntervalos.Rows.Clear();
            String intervalo = "";

            for (var i = 0; i < frec.GetLength(0); i++)
            {
                intervalo = String.Format("{0} - {1}", frec[i, 0], frec[i, 1]);
                dtgIntervalos.Rows.Add(intervalo, frec[i, 2], frec[i, 3], frec[i, 4], frec[i, 5]);
            }

        }

        private void fillChart(double[,] frec)
        {
            String intervalo;

            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();

            for (var f = 0; f < frec.GetLength(0); f++)
            {
                intervalo = String.Format("{0} - {1}", frec[f, 1], frec[f, 0]);
                graficoObtenida.Series["Observada"].Points.AddXY(frec[f, 1], frec[f, 2]);
                graficoObtenida.Series["Esperada"].Points.AddXY(frec[f, 1], frec[f, 3]);
                graficoObtenida.Series["Observada"].Points[f].AxisLabel = intervalo;

            }

            graficoObtenida.Series["Observada"].ChartType = SeriesChartType.Column;
            graficoObtenida.Series["Observada"].XValueType = ChartValueType.Double;
            graficoObtenida.Series["Observada"].YValueType = ChartValueType.Int32;
            //graficoObtenida.ChartAreas[0].AxisX.LabelStyle.Interval = ((frec[0, 1] - frec[0, 0])/2);
            graficoObtenida.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep30;
            graficoObtenida.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            graficoObtenida.Series["Observada"].IsVisibleInLegend = true;
            graficoObtenida.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            graficoObtenida.ChartAreas[0].AxisX.Minimum = frec[frec.GetLowerBound(0), 0];
            graficoObtenida.ChartAreas[0].AxisX.Maximum = frec[frec.GetUpperBound(0), 1] + ((frec[0, 1] - frec[0, 0]) / 2);
            //graficoObtenida.Series["Observada"]["PointWidth"] = (0.6).ToString();
            //graficoObtenida.Series["Esperada"]["PointWidth"] = (0.6).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgNumeros.Rows.Clear();
            dtgIntervalos.Rows.Clear();
            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();
            gradlib.Visible = false;
        }

        private bool linerControl(int semilla, int a, int m, int c)
        {
            if (a == 0 && m == 0 && c == 0) return false;

            var cond_a = (a - 1) % 4 == 0;
            var cond_m = Math.Log(m, 2) % 1 == 0 && m != 1; 

            var a1 = Math.Max(m, c);
            var b1 = Math.Min(m, c);
            int resultado;
            do
            {
                resultado = b1;  
                b1 = a1 % b1;    
                a1 = resultado;  
            }
            while(b1 != 0);


            if (cond_a && cond_m && resultado == 1) return true;

            var dialogResult = MessageBox.Show(@"Alguno de los valores es Incorrecto y puede no cumplir con las 
condiciones necesarias para el buen funcionamiento. ¿Desea Continuar? ", @"Control de valores", MessageBoxButtons.YesNo);
            return (dialogResult == DialogResult.Yes);
        }

        private bool congrControl(int semilla, int a, int m)
        {
            if (a == 0 && m == 0) return false;

            var cond_a = ((a - 3) % 8 == 0 || (a - 5) % 8 == 0 ) && a != 1;
            var cond_m = Math.Log(m, 2) % 1 == 0 && m != 1; 
            var cond_sem = semilla % 2 != 0;

            if (cond_a && cond_m && cond_sem) return true;

            var dialogResult = MessageBox.Show(@"Alguno de los valores es Incorrecto y puede no cumplir con las 
condiciones necesarias para el buen funcionamiento. ¿Desea Continuar? ", @"Control de valores", MessageBoxButtons.YesNo);
            return (dialogResult == DialogResult.Yes);
        }

    }
}
