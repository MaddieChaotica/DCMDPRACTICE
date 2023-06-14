namespace DCMDWF6
{
    partial class ArrayInserter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrayInserter));
            this.inputBox = new System.Windows.Forms.ListBox();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.numberGenerator = new System.Windows.Forms.Button();
            this.nValue = new System.Windows.Forms.TextBox();
            this.kValue = new System.Windows.Forms.TextBox();
            this.nMessage = new System.Windows.Forms.Label();
            this.kMessage = new System.Windows.Forms.Label();
            this.zeroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBox.FormattingEnabled = true;
            this.inputBox.ItemHeight = 26;
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(247, 420);
            this.inputBox.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 26;
            this.outputBox.Location = new System.Drawing.Point(541, 12);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(247, 420);
            this.outputBox.TabIndex = 1;
            // 
            // numberGenerator
            // 
            this.numberGenerator.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberGenerator.Location = new System.Drawing.Point(266, 13);
            this.numberGenerator.Name = "numberGenerator";
            this.numberGenerator.Size = new System.Drawing.Size(269, 49);
            this.numberGenerator.TabIndex = 2;
            this.numberGenerator.Text = "GENERATE MY NUMBERS!";
            this.numberGenerator.UseVisualStyleBackColor = true;
            this.numberGenerator.Click += new System.EventHandler(this.numberGenerator_Click);
            // 
            // nValue
            // 
            this.nValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nValue.Location = new System.Drawing.Point(266, 68);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(100, 30);
            this.nValue.TabIndex = 3;
            this.nValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nValue_KeyPress);
            // 
            // kValue
            // 
            this.kValue.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kValue.Location = new System.Drawing.Point(435, 68);
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(100, 30);
            this.kValue.TabIndex = 4;
            this.kValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kValue_KeyPress);
            // 
            // nMessage
            // 
            this.nMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nMessage.Location = new System.Drawing.Point(266, 105);
            this.nMessage.Name = "nMessage";
            this.nMessage.Size = new System.Drawing.Size(132, 75);
            this.nMessage.TabIndex = 5;
            this.nMessage.Text = "INPUT THE AMOUNT OF ELEMENTS";
            this.nMessage.UseMnemonic = false;
            // 
            // kMessage
            // 
            this.kMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kMessage.Location = new System.Drawing.Point(403, 105);
            this.kMessage.Name = "kMessage";
            this.kMessage.Size = new System.Drawing.Size(132, 75);
            this.kMessage.TabIndex = 6;
            this.kMessage.Text = "INPUT THE POSITON OF YOUR ZERO";
            this.kMessage.UseMnemonic = false;
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Image = ((System.Drawing.Image)(resources.GetObject("zeroButton.Image")));
            this.zeroButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.zeroButton.Location = new System.Drawing.Point(265, 175);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(269, 257);
            this.zeroButton.TabIndex = 7;
            this.zeroButton.Text = "INSERT MY ZERO";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // ArrayInserter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.kMessage);
            this.Controls.Add(this.nMessage);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.numberGenerator);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.inputBox);
            this.Name = "ArrayInserter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I WILL INSERT INTO YOUR ARRAY, OWO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inputBox;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Button numberGenerator;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.TextBox kValue;
        private System.Windows.Forms.Label nMessage;
        private System.Windows.Forms.Label kMessage;
        private System.Windows.Forms.Button zeroButton;
    }
}

