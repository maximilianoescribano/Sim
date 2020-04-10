using SIM_G7_TP1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIM_G7_TP1
{
    public partial class Main : Form
    {
        double[] randomNumbers;

        public Main()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            switch (tabRandomMethods.SelectedIndex)
            {
                case 0:
                    generateCongrLineal();
                    break;
                case 1:
                    generateCongrMulti();
                    break;
                case 2:
                   generateLanguageRandom();
                   break;
            }
        }

        private void generateLanguageRandom()
        {
            int rndNumCount = Convert.ToInt16(nudRandomNumbersCount.Value);
            int seed = Convert.ToInt16(nudLangSeed.Value);
            RandomGenerator rndGen = new RandomGenerator(seed);

            randomNumbers = rndGen.generateLangRandom(rndNumCount);
            fillDGNumbers(randomNumbers);
            generateFrecuencies();
        }

        private void generateCongrLineal()
        {
            int rndNumCount = Convert.ToInt16(nudRandomNumbersCount.Value);
            int seed = Convert.ToInt16(nudCongrLinealSemilla.Value);
            int constMulti = Convert.ToInt16(nudCongrLinealConstMulti.Value);
            int constAditiv = Convert.ToInt16(nudCongrLinealConstAditiva.Value);
            int magMod = Convert.ToInt16(nudCongrLinealMagnitudModulo.Value);

            RandomGenerator rndGen = new RandomGenerator(seed, constMulti, magMod, constAditiv);

            randomNumbers = rndGen.generateCongrLinealRandom(rndNumCount);
            fillDGNumbers(randomNumbers);
            generateFrecuencies();
        }

        private void generateCongrMulti()
        {
            int rndNumCount = Convert.ToInt16(nudRandomNumbersCount.Value);
            int seed = Convert.ToInt16(nudCongrMultiSeed.Value);
            int constMulti = Convert.ToInt16(nudCongrMultiConstMulti.Value);
            int magMod = Convert.ToInt16(nudCongrMultiMagnitudModulo.Value);

            RandomGenerator rndGen = new RandomGenerator(seed, constMulti, magMod, 0);

            randomNumbers = rndGen.generateCongrMultiRandom(rndNumCount);
            fillDGNumbers(randomNumbers);
            generateFrecuencies();
        }

        private void generateFrecuencies()
        {
            RandomGenerator gen = new RandomGenerator();
            int numIntervals = Convert.ToInt16(nudNumInvervals.Value);

            double[,] frecuencias = gen.validateFrecuencies(randomNumbers, numIntervals);

            fillDBFrecuencies(frecuencias);
            gradlib.Visible = true;
            gradlib.Text = $"Grados de Libertad = {(frecuencias.GetLength(0) - 1)}";
            fillChart(frecuencias);
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
                intervalo = $"{frec[i, 0]} - {frec[i, 1]}";
                dtgIntervalos.Rows.Add(intervalo, frec[i, 2], frec[i, 3], frec[i, 4], frec[i, 5]);
            }

        }

        private void fillChart(double[,] frec)
        {
            String intervalo;

            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();

            for (int f = 0; f < frec.GetLength(0); f++)
            {
                intervalo = $"{frec[f, 1]} - {frec[f, 0]}";
                graficoObtenida.Series["Observada"].Points.AddXY(frec[f, 1], frec[f, 2]);
                graficoObtenida.Series["Esperada"].Points.AddXY(frec[f, 1], frec[f, 3]);
                graficoObtenida.Series["Observada"].Points[f].AxisLabel = intervalo;
            }

            graficoObtenida.Series["Observada"].ChartType = SeriesChartType.Column;
            graficoObtenida.Series["Observada"].XValueType = ChartValueType.Double;
            graficoObtenida.Series["Observada"].YValueType = ChartValueType.Int32;
            graficoObtenida.ChartAreas[0].AxisX.LabelStyle.Interval = (frec[0, 1] - frec[0, 0]/2);
            graficoObtenida.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //graficoObtenida.ChartAreas[0].AxisX.ScaleView.Zoom(0, 0.5);
            graficoObtenida.Series["Observada"].IsVisibleInLegend = true;
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgNumeros.Rows.Clear();
            graficoObtenida.Series[0].Points.Clear();
            graficoObtenida.Series[1].Points.Clear();
            gradlib.Visible = false;
        }

        private void generateTestChi()
        {
            randomNumbers = new[]
            {
                0.15, 0.22, 0.41, 0.65, 0.84, 0.81, 0.62, 0.45, 0.32, 0.07, 0.11, 0.29, 0.58, 0.73, 0.93, 0.97, 0.79,
                0.55, 0.35, 0.09, 0.99, 0.51, 0.35, 0.02, 0.19, 0.24, 0.98, 0.10, 0.31, 0.17
            };
            fillDGNumbers(randomNumbers);
            generateFrecuencies();
        }
    }
}
