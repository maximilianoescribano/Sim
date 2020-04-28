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
using Excel = Microsoft.Office.Interop.Excel;

namespace SIM_G7_TP1
{
    public partial class TP3 : Form
    {
        double[] randomNumbers;
        Stopwatch timer;
        List<double[]> frecuencies;

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
            var A = Convert.ToDouble(nudUniformDistribA.Value);
            var B = Convert.ToDouble(nudUniformDistribB.Value);
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
            frecuencies = rndGen.GenerateUniformFrecuencies(numIntervals, randomNumbers);
           
            FillDbFrecuencies(frecuencies);
            gradlib.Visible = true;
            gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencies.Count - 1));
            fillChart(frecuencies);
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
            frecuencies = rndGen.GenerateExponentialFrecuencies(numIntervals, lambda, randomNumbers);
            timer.Stop();
            lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();
            FillDbFrecuencies(frecuencies);
            gradlib.Visible = true;
            gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencies.Count - 1));
            fillChart(frecuencies);
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
            frecuencies = rndGen.GenerateNormalFrecuencies(numIntervals, media, deviation, randomNumbers);
            timer.Stop();
            lblElapsedTimeFrecuencies.Text = timer.ElapsedMilliseconds.ToString();
            FillDbFrecuencies(frecuencies);
            gradlib.Visible = true;
            gradlib.Text = String.Format("Grados de Libertad = {0}", (frecuencies.Count - 1));
            fillChart(frecuencies);
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
                graficoObtenida.Series["Esperada"].Points.AddXY(frec[1], frec[3]);
                graficoObtenida.Series["Observada"].Points[frec.Rank-1].AxisLabel = String.Format("{0} - {1}", frec[1], frec[0]);
            }

            graficoObtenida.Series["Observada"].ChartType = SeriesChartType.Column;
            graficoObtenida.Series["Observada"].XValueType = ChartValueType.Double;
            graficoObtenida.Series["Observada"].YValueType = ChartValueType.Int32;
            //graficoObtenida.ChartAreas[0].AxisX.LabelStyle.Interval = ((frec[0, 1] - frec[0, 0])/2);
            graficoObtenida.ChartAreas[0].AxisX.LabelAutoFitStyle = LabelAutoFitStyles.LabelsAngleStep30;
            graficoObtenida.ChartAreas[0].AxisX.Interval = 100;
            graficoObtenida.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            graficoObtenida.Series["Observada"].IsVisibleInLegend = true;
            graficoObtenida.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Number;
            graficoObtenida.ChartAreas[0].AxisX.Minimum = frecuencias.First()[0];
            graficoObtenida.ChartAreas[0].AxisX.Maximum = frecuencias.Last()[1] + ((frecuencias.First()[1] - frecuencias.First()[0]) / 2);
            //graficoObtenida.Series["Observada"]["PointWidth"] = (0.6).ToString();
            //graficoObtenida.Series["Esperada"]["PointWidth"] = (0.6).ToString();
            
        }

        private void fillExcelChart()
        {
            if (frecuencies == null)
            {
                return;
            }

            if (frecuencies.Count == 0)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;


            //worksheet = workbook.Worksheets[1] as Excel.Worksheet;
            worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
            worksheet.Name = "Grafico Frecuencias";

            for (int i = 1; i <= dtgIntervalos.ColumnCount; i++)
            {
                worksheet.Cells[1, i] = dtgIntervalos.Columns[i - 1].HeaderText.ToString();
            }

            for (int i = 0; i < frecuencies.Count; i++)
            {
                worksheet.Cells[2 + i, 1] = String.Format("{0} - {1}", frecuencies.ElementAt(i)[0], frecuencies.ElementAt(i)[1]);
                worksheet.Cells[2 + i, 2] = (double)frecuencies.ElementAt(i)[2];
                worksheet.Cells[2 + i, 3] = (double)frecuencies.ElementAt(i)[3];
                worksheet.Cells[2 + i, 4] = (double)frecuencies.ElementAt(i)[4];
                worksheet.Cells[2 + i, 5] = (double)frecuencies.ElementAt(i)[5];
            }

            String topLeft = "A2";
            String bottomRight = "C" + (frecuencies.Count + 1);

            // Add chart.
            Excel.ChartObjects charts = worksheet.ChartObjects() as Microsoft.Office.Interop.Excel.ChartObjects;
            Excel.ChartObject chartObject = charts.Add(330, 10, 600, 400); //as Microsoft.Office.Interop.Excel.ChartObject;
            Excel.Chart chart = chartObject.Chart;

            // Set chart range.
            var range = worksheet.get_Range(topLeft, bottomRight);
            chart.SetSourceData(range);

            const string graphTitle = "Distribucion";
            const string xAxis = "Intervalos";
            const string yAxis = "Frecuencia";
            // Set chart properties.
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
            chart.ChartWizard(Source: range,
                Title: graphTitle,
                CategoryTitle: xAxis,
                ValueTitle: yAxis);

            var chartObj = worksheet.ChartObjects(1) as Microsoft.Office.Interop.Excel.ChartObject;
            chartObj.Activate();

            var chartGroup = workbook.ActiveChart.ChartGroups(1) as Microsoft.Office.Interop.Excel.ChartGroup;
            chartGroup.Overlap = 0;
            chartGroup.GapWidth = 0;
            chartGroup.HasSeriesLines = false;

            this.Cursor = Cursors.Default;

            app.Visible = true;
            //app.Quit();
            app = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgNumeros.Rows.Clear();
            dtgIntervalos.Rows.Clear();
            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();
            gradlib.Visible = false;
        }

        private void btnGraficoExcel_Click(object sender, EventArgs e)
        {
            fillExcelChart();
        }

      

    }
}
