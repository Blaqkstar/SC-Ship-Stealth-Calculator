namespace SC_Stealth_Detection_Range_Finder
{
    partial class CalculatorMain
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
            this.IRLabel = new System.Windows.Forms.Label();
            this.EMLabel = new System.Windows.Forms.Label();
            this.IRInput = new System.Windows.Forms.TextBox();
            this.EMInput = new System.Windows.Forms.TextBox();
            this.CSInput = new System.Windows.Forms.TextBox();
            this.CSLabel = new System.Windows.Forms.Label();
            this.RangeOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SignatureValuesGroupBox = new System.Windows.Forms.GroupBox();
            this.SignatureValuesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IRLabel
            // 
            this.IRLabel.AutoSize = true;
            this.IRLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IRLabel.Location = new System.Drawing.Point(30, 31);
            this.IRLabel.Name = "IRLabel";
            this.IRLabel.Size = new System.Drawing.Size(20, 14);
            this.IRLabel.TabIndex = 0;
            this.IRLabel.Text = "IR:";
            // 
            // EMLabel
            // 
            this.EMLabel.AutoSize = true;
            this.EMLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMLabel.Location = new System.Drawing.Point(25, 56);
            this.EMLabel.Name = "EMLabel";
            this.EMLabel.Size = new System.Drawing.Size(27, 14);
            this.EMLabel.TabIndex = 1;
            this.EMLabel.Text = "EM:";
            // 
            // IRInput
            // 
            this.IRInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IRInput.Location = new System.Drawing.Point(57, 28);
            this.IRInput.Name = "IRInput";
            this.IRInput.Size = new System.Drawing.Size(100, 20);
            this.IRInput.TabIndex = 0;
            // 
            // EMInput
            // 
            this.EMInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.EMInput.Location = new System.Drawing.Point(57, 53);
            this.EMInput.Name = "EMInput";
            this.EMInput.Size = new System.Drawing.Size(100, 20);
            this.EMInput.TabIndex = 1;
            // 
            // CSInput
            // 
            this.CSInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CSInput.Location = new System.Drawing.Point(57, 79);
            this.CSInput.Name = "CSInput";
            this.CSInput.Size = new System.Drawing.Size(100, 20);
            this.CSInput.TabIndex = 2;
            // 
            // CSLabel
            // 
            this.CSLabel.AutoSize = true;
            this.CSLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSLabel.Location = new System.Drawing.Point(27, 82);
            this.CSLabel.Name = "CSLabel";
            this.CSLabel.Size = new System.Drawing.Size(23, 14);
            this.CSLabel.TabIndex = 5;
            this.CSLabel.Text = "CS:";
            // 
            // RangeOutput
            // 
            this.RangeOutput.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RangeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RangeOutput.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeOutput.ForeColor = System.Drawing.Color.Red;
            this.RangeOutput.Location = new System.Drawing.Point(102, 161);
            this.RangeOutput.Name = "RangeOutput";
            this.RangeOutput.Size = new System.Drawing.Size(119, 23);
            this.RangeOutput.TabIndex = 6;
            this.RangeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "/ / RANGE / / ";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CalculateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CalculateButton.FlatAppearance.BorderSize = 0;
            this.CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(128, 187);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(93, 25);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "CALCULATE";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1, 301);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(22, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(170, 218);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(51, 22);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SignatureValuesGroupBox
            // 
            this.SignatureValuesGroupBox.Controls.Add(this.IRInput);
            this.SignatureValuesGroupBox.Controls.Add(this.IRLabel);
            this.SignatureValuesGroupBox.Controls.Add(this.EMLabel);
            this.SignatureValuesGroupBox.Controls.Add(this.EMInput);
            this.SignatureValuesGroupBox.Controls.Add(this.CSInput);
            this.SignatureValuesGroupBox.Controls.Add(this.CSLabel);
            this.SignatureValuesGroupBox.Location = new System.Drawing.Point(21, 12);
            this.SignatureValuesGroupBox.Name = "SignatureValuesGroupBox";
            this.SignatureValuesGroupBox.Size = new System.Drawing.Size(187, 130);
            this.SignatureValuesGroupBox.TabIndex = 8;
            this.SignatureValuesGroupBox.TabStop = false;
            this.SignatureValuesGroupBox.Text = "Emissions";
            // 
            // CalculatorMain
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(233, 325);
            this.Controls.Add(this.SignatureValuesGroupBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RangeOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CalculatorMain";
            this.Text = "Stealth Calculator";
            this.Shown += new System.EventHandler(this.Formshown);
            this.SignatureValuesGroupBox.ResumeLayout(false);
            this.SignatureValuesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IRLabel;
        private System.Windows.Forms.Label EMLabel;
        private System.Windows.Forms.TextBox IRInput;
        private System.Windows.Forms.TextBox EMInput;
        private System.Windows.Forms.TextBox CSInput;
        private System.Windows.Forms.Label CSLabel;
        private System.Windows.Forms.Label RangeOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox SignatureValuesGroupBox;
    }
}

