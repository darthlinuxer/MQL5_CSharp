namespace GuiMT_Net6;

partial class Form1
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
        splitContainer1 = new SplitContainer();
        checkBox1 = new CheckBox();
        label2 = new Label();
        label1 = new Label();
        numericUpDownTimer = new NumericUpDown();
        close = new Button();
        refresh = new Button();
        chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        timer1 = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDownTimer).BeginInit();
        ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.FixedPanel = FixedPanel.Panel1;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(checkBox1);
        splitContainer1.Panel1.Controls.Add(label2);
        splitContainer1.Panel1.Controls.Add(label1);
        splitContainer1.Panel1.Controls.Add(numericUpDownTimer);
        splitContainer1.Panel1.Controls.Add(close);
        splitContainer1.Panel1.Controls.Add(refresh);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(chart1);
        splitContainer1.Size = new Size(1041, 555);
        splitContainer1.SplitterDistance = 39;
        splitContainer1.TabIndex = 0;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(244, 8);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(180, 24);
        checkBox1.TabIndex = 5;
        checkBox1.Text = "Activate Refresh Timer";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(212, 7);
        label2.Name = "label2";
        label2.Size = new Size(15, 20);
        label2.TabIndex = 4;
        label2.Text = "s";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(109, 7);
        label1.Name = "label1";
        label1.Size = new Size(44, 20);
        label1.TabIndex = 3;
        label1.Text = "every";
        // 
        // numericUpDownTimer
        // 
        numericUpDownTimer.Location = new Point(159, 5);
        numericUpDownTimer.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        numericUpDownTimer.Name = "numericUpDownTimer";
        numericUpDownTimer.Size = new Size(47, 27);
        numericUpDownTimer.TabIndex = 2;
        numericUpDownTimer.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // close
        // 
        close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        close.BackColor = Color.Red;
        close.ForeColor = SystemColors.ButtonHighlight;
        close.Location = new Point(935, 3);
        close.Name = "close";
        close.Size = new Size(94, 29);
        close.TabIndex = 1;
        close.Text = "Close";
        close.UseVisualStyleBackColor = false;
        close.Click += close_Click;
        // 
        // refresh
        // 
        refresh.Location = new Point(3, 3);
        refresh.Name = "refresh";
        refresh.Size = new Size(94, 29);
        refresh.TabIndex = 0;
        refresh.Text = "Refresh";
        refresh.UseVisualStyleBackColor = true;
        refresh.Click += refresh_Click;
        // 
        // chart1
        // 
        chartArea2.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea2);
        chart1.Dock = DockStyle.Fill;
        legend2.Name = "Legend1";
        chart1.Legends.Add(legend2);
        chart1.Location = new Point(0, 0);
        chart1.Name = "chart1";
        series2.ChartArea = "ChartArea1";
        series2.Legend = "Legend1";
        series2.Name = "Series1";
        chart1.Series.Add(series2);
        chart1.Size = new Size(1041, 512);
        chart1.TabIndex = 0;
        chart1.Text = "chart1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1041, 555);
        Controls.Add(splitContainer1);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)numericUpDownTimer).EndInit();
        ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private SplitContainer splitContainer1;
    private Button close;
    private Button refresh;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private Label label1;
    private NumericUpDown numericUpDownTimer;
    private CheckBox checkBox1;
    private Label label2;
    private System.Windows.Forms.Timer timer1;
}