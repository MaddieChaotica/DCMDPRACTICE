
namespace DCMDWF
{
    partial class HelloByeByeFMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(142, 41);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(118, 47);
            button1.TabIndex = 0;
            button1.Text = "FALSE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Hello_Button;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(790, 41);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(117, 41);
            button2.TabIndex = 1;
            button2.Text = "TRUTH";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Byebye_Button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(0, 227);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(162, 15);
            label1.TabIndex = 2;
            label1.Text = "THIS LABEL WILL BE CHAGED";
            // 
            // HelloByeByeFMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 538);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "HelloByeByeFMainForm";
            Text = "Hello-by-bye foirm";
            Load += Main_Form;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

