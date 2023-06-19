namespace DCMDWF4
{
    partial class GraphBuilder
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.valueBox = new System.Windows.Forms.GroupBox();
            this.stepValue = new System.Windows.Forms.TextBox();
            this.xMaxValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.xMinValue = new System.Windows.Forms.TextBox();
            this.btn1Activator = new System.Windows.Forms.Button();
            this.bValue = new System.Windows.Forms.TextBox();
            this.aValue = new System.Windows.Forms.TextBox();
            this.DxValue = new System.Windows.Forms.TextBox();
            this.XkValue = new System.Windows.Forms.TextBox();
            this.X0Value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.derChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.valueBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derChart)).BeginInit();
            this.SuspendLayout();
            // 
            // valueBox
            // 
            this.valueBox.BackColor = System.Drawing.SystemColors.Control;
            this.valueBox.Controls.Add(this.stepValue);
            this.valueBox.Controls.Add(this.xMaxValue);
            this.valueBox.Controls.Add(this.label10);
            this.valueBox.Controls.Add(this.label9);
            this.valueBox.Controls.Add(this.label8);
            this.valueBox.Controls.Add(this.xMinValue);
            this.valueBox.Controls.Add(this.btn1Activator);
            this.valueBox.Controls.Add(this.bValue);
            this.valueBox.Controls.Add(this.aValue);
            this.valueBox.Controls.Add(this.DxValue);
            this.valueBox.Controls.Add(this.XkValue);
            this.valueBox.Controls.Add(this.X0Value);
            this.valueBox.Controls.Add(this.label7);
            this.valueBox.Controls.Add(this.label6);
            this.valueBox.Controls.Add(this.label5);
            this.valueBox.Controls.Add(this.label4);
            this.valueBox.Controls.Add(this.label3);
            this.valueBox.Controls.Add(this.label2);
            this.valueBox.Controls.Add(this.label1);
            this.valueBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueBox.ForeColor = System.Drawing.Color.IndianRed;
            this.valueBox.Location = new System.Drawing.Point(12, 12);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(634, 180);
            this.valueBox.TabIndex = 0;
            this.valueBox.TabStop = false;
            // 
            // stepValue
            // 
            this.stepValue.Location = new System.Drawing.Point(511, 115);
            this.stepValue.Name = "stepValue";
            this.stepValue.Size = new System.Drawing.Size(100, 20);
            this.stepValue.TabIndex = 18;
            this.stepValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stepValue_KeyPress);
            // 
            // xMaxValue
            // 
            this.xMaxValue.Location = new System.Drawing.Point(511, 72);
            this.xMaxValue.Name = "xMaxValue";
            this.xMaxValue.Size = new System.Drawing.Size(100, 20);
            this.xMaxValue.TabIndex = 17;
            this.xMaxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xMaxValue_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(444, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "step =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(444, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "xMax =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(444, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "xMin =";
            // 
            // xMinValue
            // 
            this.xMinValue.Location = new System.Drawing.Point(511, 28);
            this.xMinValue.Name = "xMinValue";
            this.xMinValue.Size = new System.Drawing.Size(100, 20);
            this.xMinValue.TabIndex = 13;
            this.xMinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xMinValue_KeyPress);
            // 
            // btn1Activator
            // 
            this.btn1Activator.BackColor = System.Drawing.Color.Aquamarine;
            this.btn1Activator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn1Activator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn1Activator.Location = new System.Drawing.Point(0, 137);
            this.btn1Activator.Name = "btn1Activator";
            this.btn1Activator.Size = new System.Drawing.Size(628, 37);
            this.btn1Activator.TabIndex = 12;
            this.btn1Activator.Text = "FIND MY VALUES";
            this.btn1Activator.UseVisualStyleBackColor = false;
            this.btn1Activator.Click += new System.EventHandler(this.btn1Activator_Click);
            // 
            // bValue
            // 
            this.bValue.Location = new System.Drawing.Point(261, 71);
            this.bValue.Name = "bValue";
            this.bValue.Size = new System.Drawing.Size(100, 20);
            this.bValue.TabIndex = 11;
            this.bValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bValue_KeyPress);
            // 
            // aValue
            // 
            this.aValue.Location = new System.Drawing.Point(261, 25);
            this.aValue.Name = "aValue";
            this.aValue.Size = new System.Drawing.Size(100, 20);
            this.aValue.TabIndex = 10;
            this.aValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aValue_KeyPress);
            // 
            // DxValue
            // 
            this.DxValue.Location = new System.Drawing.Point(59, 111);
            this.DxValue.Name = "DxValue";
            this.DxValue.Size = new System.Drawing.Size(100, 20);
            this.DxValue.TabIndex = 9;
            this.DxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DxValue_KeyPress);
            // 
            // XkValue
            // 
            this.XkValue.Location = new System.Drawing.Point(59, 70);
            this.XkValue.Name = "XkValue";
            this.XkValue.Size = new System.Drawing.Size(100, 20);
            this.XkValue.TabIndex = 8;
            this.XkValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.XkValue_KeyPress);
            // 
            // X0Value
            // 
            this.X0Value.Location = new System.Drawing.Point(59, 24);
            this.X0Value.Name = "X0Value";
            this.X0Value.Size = new System.Drawing.Size(100, 20);
            this.X0Value.TabIndex = 7;
            this.X0Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.X0Value_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(218, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "b =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(218, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "a =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "dx =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "X  =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "X  =";
            // 
            // derChart
            // 
            chartArea1.Name = "ChartArea1";
            this.derChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.derChart.Legends.Add(legend1);
            this.derChart.Location = new System.Drawing.Point(12, 198);
            this.derChart.Name = "derChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "XPoints";
            this.derChart.Series.Add(series1);
            this.derChart.Size = new System.Drawing.Size(634, 347);
            this.derChart.TabIndex = 1;
            this.derChart.Text = "Chart";
            // 
            // GraphBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 571);
            this.Controls.Add(this.derChart);
            this.Controls.Add(this.valueBox);
            this.Name = "GraphBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeviationCalculator";
            this.valueBox.ResumeLayout(false);
            this.valueBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.derChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox valueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bValue;
        private System.Windows.Forms.TextBox aValue;
        private System.Windows.Forms.TextBox DxValue;
        private System.Windows.Forms.TextBox XkValue;
        private System.Windows.Forms.TextBox X0Value;
        private System.Windows.Forms.Button btn1Activator;
        private System.Windows.Forms.DataVisualization.Charting.Chart derChart;
        private System.Windows.Forms.TextBox stepValue;
        private System.Windows.Forms.TextBox xMaxValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xMinValue;
    }
}

