namespace DCMDWF5
{
    partial class LineCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineCounter));
            this.theLineBox = new System.Windows.Forms.ListBox();
            this.lineCntActivator = new System.Windows.Forms.Button();
            this.lineTextMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // theLineBox
            // 
            this.theLineBox.FormattingEnabled = true;
            this.theLineBox.Location = new System.Drawing.Point(12, 74);
            this.theLineBox.Name = "theLineBox";
            this.theLineBox.Size = new System.Drawing.Size(409, 225);
            this.theLineBox.TabIndex = 0;
            this.theLineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.theLineBox_KeyPress);
            // 
            // lineCntActivator
            // 
            this.lineCntActivator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lineCntActivator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lineCntActivator.BackgroundImage")));
            this.lineCntActivator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineCntActivator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineCntActivator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineCntActivator.Location = new System.Drawing.Point(84, 305);
            this.lineCntActivator.Name = "lineCntActivator";
            this.lineCntActivator.Size = new System.Drawing.Size(250, 119);
            this.lineCntActivator.TabIndex = 1;
            this.lineCntActivator.Text = "COUNT MY LINES, MACHINE";
            this.lineCntActivator.UseVisualStyleBackColor = false;
            this.lineCntActivator.Click += new System.EventHandler(this.lineCntActivator_Click);
            // 
            // lineTextMessage
            // 
            this.lineTextMessage.AutoSize = true;
            this.lineTextMessage.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineTextMessage.Location = new System.Drawing.Point(8, 33);
            this.lineTextMessage.Name = "lineTextMessage";
            this.lineTextMessage.Size = new System.Drawing.Size(421, 19);
            this.lineTextMessage.TabIndex = 2;
            this.lineTextMessage.Text = "TYPE YOUR LINES IN, MORTAl, AND I SHALL COUNT THEM";
            // 
            // LineCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(433, 447);
            this.Controls.Add(this.lineTextMessage);
            this.Controls.Add(this.lineCntActivator);
            this.Controls.Add(this.theLineBox);
            this.Name = "LineCounter";
            this.Text = "The Line Counter (TM)";
            this.Load += new System.EventHandler(this.LineCounter_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LineCounter_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox theLineBox;
        private System.Windows.Forms.Button lineCntActivator;
        private System.Windows.Forms.Label lineTextMessage;
    }
}

