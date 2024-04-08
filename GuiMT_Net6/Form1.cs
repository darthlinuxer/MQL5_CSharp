using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace GuiMT_Net6;

public partial class Form1 : Form
{
    private EventHandler handler;

    public Form1()
    {
        InitializeComponent();
    }

    ~Form1()
    {
        timer1.Tick -= handler;
        timer1.Dispose();
    }

    private void refresh_Click(object sender, EventArgs? e)
    {
        this.LoadValues();
        MQL5CSharp.msgBack = "DLL msg: Refresh Button clicked or timer activated!";
        MQL5CSharp.lastEvent = DLLEvents.refreshButtonClicked;
    }

    private void close_Click(object sender, EventArgs e) => MQL5CSharp.lastEvent = DLLEvents.close;

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

    private void Form1_Load(object sender, EventArgs e)
    {
        this.chart1.Palette = ChartColorPalette.Excel;
        this.LoadValues();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            handler = new EventHandler(refresh_Click);
            this.timer1.Interval = (int)numericUpDownTimer.Value * 1000;
            this.timer1.Tick += handler;
            this.timer1.Enabled = true;
            this.timer1.Start();
            return;
        }

        this.timer1.Stop();
        this.timer1.Tick -= handler;
        this.timer1.Enabled = false;
    }
}