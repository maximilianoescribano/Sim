using SIM_G7_TP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
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
            Stopwatch timer = new Stopwatch();
            timer.Start();
            switch (tabRandomMethods.SelectedIndex)
            {
                case 0:
                    GenerateUniformDistrib();
                    break;
                case 1:
                    GenerateExponentialDistrib();
                    break;
                case 2:
                   GenerateNormalDistrib();
                   break;
            }
            
            timer.Stop();
            lblElapsedTimeGenerator.Text = timer.ElapsedMilliseconds.ToString();
        }

        private void GenerateUniformDistrib()
        {
            // Variables tomadas de interfaz 
            var rndNumCount = Convert.ToUInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt32(nudUniformDistribSeed.Value);
            var A = Convert.ToUInt32(nudUniformDistribA.Value);
            var B = Convert.ToUInt32(nudUniformDistribB.Value);
            var numIntervals = Convert.ToUInt32(nudNumInvervals.Value);

            var rndGen = new RandomGenra2();
            this.Cursor = Cursors.WaitCursor;

            //calculo numero aletorios
            randomNumbers = rndGen.GenerateUniformDistribution(A, B, rndGen.GenerateCSharpRandoms(seed, rndNumCount));
            FillDgNumbers(randomNumbers);
            this.Cursor = Cursors.Default;

            //calculo frecuencias
            if (numIntervals <= 0) return;

            timer = Stopwatch.StartNew();
            var frecuencias = rndGen.GenerateUniformFrecuencies(numIntervals, randomNumbers);
           
            FillDbFrecuencies(frecuencias);
            gradlib.Visible = true;
            gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencias.Count - 1));
            fillChart(frecuencias);
        }


        private void GenerateExponentialDistrib()
        {
            var rndNumCount = Convert.ToUInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt32(nudExponentialDistribSeed.Value);
            var lambda = Convert.ToDouble(nudExponentialDistribLambda.Value);
            var numIntervals = Convert.ToUInt32(nudNumInvervals.Value);

            var rndGen = new RandomGenra2();
            this.Cursor = Cursors.WaitCursor;

            //calculo numero aletorios
            randomNumbers = rndGen.GenerateExponentialDistribution(lambda, rndGen.GenerateCSharpRandoms(seed, rndNumCount));
            FillDgNumbers(randomNumbers);
            this.Cursor = Cursors.Default;

            //calculo frecuencias
            if (numIntervals <= 0) return;

            timer = Stopwatch.StartNew();
            var frecuencias = rndGen.GenerateExponentialFrecuencies(numIntervals, lambda, randomNumbers);
            timer.Stop();
            lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();
            FillDbFrecuencies(frecuencias);
            gradlib.Visible = true;
            gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencias.Count - 1));
            fillChart(frecuencias);
        }


        private void GenerateNormalDistrib()
        {
            var rndNumCount = Convert.ToUInt32(nudRandomNumbersCount.Value);
            var seed = Convert.ToInt32(nudNormalDistribSeed.Value);
            var media = Convert.ToDouble(nudNormalDistribMedia.Value);
            var deviation = Convert.ToDouble(nudNormalDistribDeviation.Value);
            var numIntervals = Convert.ToUInt32(nudNumInvervals.Value);

            var rndGen = new RandomGenra2();
            this.Cursor = Cursors.WaitCursor;

            //calculo numero aletorios
            randomNumbers = rndGen.GenerateNormalDistribution(media, deviation, rndGen.GenerateCSharpRandomsList(seed, rndNumCount));
            FillDgNumbers(randomNumbers);
            this.Cursor = Cursors.Default;

            //calculo frecuencias
            if (numIntervals <= 0) return;

            timer = Stopwatch.StartNew();
            var frecuencias = rndGen.GenerateNormalFrecuencies(numIntervals, media, deviation, randomNumbers);
            timer.Stop();
            lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();
            FillDbFrecuencies(frecuencias);
            gradlib.Visible = true;
            gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencias.Count - 1));
            fillChart(frecuencias);
        }


        private void FillDgNumbers(double[] num)
        {
            dtgNumeros.Rows.Clear();
            for (var i = 0; i < num.Length; i++)
            {
                dtgNumeros.Rows.Add(i + 1, num[i]);
            }
        }

        //Llena tabla frec
        private void FillDbFrecuencies(List<double[]> frecuencias)
        {
            dtgIntervalos.Rows.Clear();
            frecuencias.ForEach( x =>
                     dtgIntervalos.Rows.Add(String.Format("{0} - {1}", x[0], x[1]) , x[2], x[3], x[4], x[5])
                );
        }

        private void fillChart(List<double[]> frecuencias)
        {
            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();

            foreach (var frec in frecuencias)
            {
                graficoObtenida.Series["Observada"].Points.AddXY(frec[1], frec[2]);
               // graficoObtenida.Series["Esperada"].Points.AddXY(frec[1], frec[3]);
                graficoObtenida.Series["Observada"].Points[frec.Rank-1].AxisLabel = String.Format("{0} - {1}", frec[1], frec[0]);
            }

            graficoObtenida.Series["Observada"].ChartType = SeriesChartType.Column;
            graficoObtenida.Series["Observada"].XValueType = ChartValueType.Double;
            graficoObtenida.Series["Observada"].YValueType = ChartValueType.Int32;
            //graficoObtenida.ChartAreas[0].AxisX.LabelStyle.Interval = ((frec[0, 1] - frec[0, 0])/2);
            graficoObtenida.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep30;
            graficoObtenida.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            graficoObtenida.Series["Observada"].IsVisibleInLegend = true;
            graficoObtenida.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            graficoObtenida.ChartAreas[0].AxisX.Minimum = frecuencias.First()[0];
            graficoObtenida.ChartAreas[0].AxisX.Maximum = frecuencias.Last()[1] + ((frecuencias.First()[1] - frecuencias.First()[0]) / 2);
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

      

    }
}
