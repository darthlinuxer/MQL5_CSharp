using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace GuiMT
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.LoadValues();
            MQL5CSharp.msgBack = "DLL msg: Refresh Button clicked!";
            MQL5CSharp.lastEvent = DLLEvents.refreshButtonClicked;
        }
        private void buttonClose_Click(object sender, EventArgs e) => MQL5CSharp.lastEvent = DLLEvents.close;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.chart1.Palette = ChartColorPalette.Excel;
            this.LoadValues();
        }
        public void LoadValues()
        {
            Series serie;
            if (this.chart1.Series.FirstOrDefault(x => x.Name == "Series1") == null)
                serie = this.chart1.Series.Add("Series1");
            else
                serie = this.chart1.Series.FirstOrDefault(x => x.Name == "Series1");

            if (serie == null) return;
            serie.ChartType = SeriesChartType.Column;
            int i = 1;
            serie.Points.Clear();
            foreach (double item in MQL5CSharp.values)
            {
                serie.Points.AddXY(i, item);
                i++;
            }            
        }      
    }
}
