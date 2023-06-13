namespace DCMDWF2
{
    partial class Formula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formula));
            this.Calculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Calculate.BackgroundImage")));
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(150, 133);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(962, 407);
            this.Calculate.TabIndex = 0;
            this.Calculate.Text = "THEMAGICAL CALCULATION BUTTON";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.btnClickCalculateMagical);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "EnterX";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxKeyPrssXValue);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "EnterY";
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxKeyPrssYValue);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(676, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "EnterZ";
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxKeyPrssZValue);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(988, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "EnterU";
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxKeyPressUValue);
            // 
            // Formula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1293, 552);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Calculate);
            this.Name = "Formula";
            this.Text = "CALCULATE MY NUMBERS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

