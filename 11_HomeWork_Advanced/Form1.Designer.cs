namespace _11_HomeWork_Advanced
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
            buttonCalculate = new Button();
            textBoxRadius = new TextBox();
            labelArea = new Label();
            labelLength = new Label();
            labelVolume = new Label();
            labelRadius = new Label();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(242, 128);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(306, 142);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Обчислити";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(97, 89);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(100, 23);
            textBoxRadius.TabIndex = 1;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(63, 212);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(55, 15);
            labelArea.TabIndex = 2;
            labelArea.Text = "S = π · R²";
            // 
            // labelLength
            // 
            labelLength.AutoSize = true;
            labelLength.Location = new Point(63, 165);
            labelLength.Name = "labelLength";
            labelLength.Size = new Size(68, 15);
            labelLength.TabIndex = 2;
            labelLength.Text = "D = 2 · π · R";
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.Location = new Point(63, 255);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(82, 15);
            labelVolume.TabIndex = 2;
            labelVolume.Text = "V = 4/3 · π · R³";
            // 
            // labelRadius
            // 
            labelRadius.AutoSize = true;
            labelRadius.Location = new Point(63, 92);
            labelRadius.Name = "labelRadius";
            labelRadius.Size = new Size(28, 15);
            labelRadius.TabIndex = 3;
            labelRadius.Text = "R = ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRadius);
            Controls.Add(labelVolume);
            Controls.Add(labelLength);
            Controls.Add(labelArea);
            Controls.Add(textBoxRadius);
            Controls.Add(buttonCalculate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private TextBox textBoxRadius;
        private Label labelArea;
        private Label labelLength;
        private Label labelVolume;
        private Label labelRadius;
    }
}
