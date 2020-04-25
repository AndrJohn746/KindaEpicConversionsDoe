namespace KindaEpicConversionsDoe
{
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
            this.title = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.Label();
            this.textra = new System.Windows.Forms.Label();
            this.convBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.convButton = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(455, 32);
            this.title.TabIndex = 0;
            this.title.Text = "Unit Converter - American to Metric";
            // 
            // options
            // 
            this.options.AutoSize = true;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.options.Location = new System.Drawing.Point(151, 60);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(160, 119);
            this.options.TabIndex = 1;
            this.options.Text = "1. Inches to Centimetres\r\n\r\n2. Feet to Centimetres\r\n\r\n3. Yards to Metres\r\n\r\n4. Mi" +
    "les to Kilometres";
            // 
            // textra
            // 
            this.textra.AutoSize = true;
            this.textra.Location = new System.Drawing.Point(75, 203);
            this.textra.Name = "textra";
            this.textra.Size = new System.Drawing.Size(199, 51);
            this.textra.TabIndex = 2;
            this.textra.Text = "Enter conversion choice (1-4):\r\n\r\nEnter value to be converted:";
            // 
            // convBox
            // 
            this.convBox.Location = new System.Drawing.Point(294, 204);
            this.convBox.Name = "convBox";
            this.convBox.Size = new System.Drawing.Size(100, 22);
            this.convBox.TabIndex = 3;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(294, 232);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 22);
            this.valueBox.TabIndex = 4;
            // 
            // convButton
            // 
            this.convButton.BackColor = System.Drawing.Color.PowderBlue;
            this.convButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convButton.Location = new System.Drawing.Point(78, 287);
            this.convButton.Name = "convButton";
            this.convButton.Size = new System.Drawing.Size(316, 32);
            this.convButton.TabIndex = 5;
            this.convButton.Text = "Convert";
            this.convButton.UseVisualStyleBackColor = false;
            this.convButton.Click += new System.EventHandler(this.convButton_Click);
            // 
            // answer
            // 
            this.answer.ForeColor = System.Drawing.Color.Red;
            this.answer.Location = new System.Drawing.Point(12, 341);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(455, 23);
            this.answer.TabIndex = 6;
            this.answer.Text = "0 u = 0 u";
            this.answer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(488, 403);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.convButton);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.convBox);
            this.Controls.Add(this.textra);
            this.Controls.Add(this.options);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "UC - American to Metric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label options;
        private System.Windows.Forms.Label textra;
        private System.Windows.Forms.TextBox convBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button convButton;
        private System.Windows.Forms.Label answer;
    }
}

