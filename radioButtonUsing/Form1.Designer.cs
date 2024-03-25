namespace radioButtonUsing
{
    partial class Form1
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 33);
            radioButton1.Margin = new Padding(4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 34);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(10, 66);
            radioButton2.Margin = new Padding(4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 34);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(10, 37);
            radioButton3.Margin = new Padding(4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 34);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Evli";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(10, 79);
            radioButton4.Margin = new Padding(4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(93, 34);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "Bekar";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(20, 18);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(160, 110);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(20, 136);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(160, 124);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medeni Hal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 277);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
