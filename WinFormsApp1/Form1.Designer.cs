namespace WinFormsApp1
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
            labelTitle = new Label();
            textBoxTeams = new TextBox();
            buttonGenerate = new Button();
            textBoxSchedule = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = SystemColors.ActiveCaptionText;
            labelTitle.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonFace;
            labelTitle.Location = new Point(55, 26);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(294, 28);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Розбиття турніру на раунди";
            labelTitle.Click += label1_Click;
            // 
            // textBoxTeams
            // 
            textBoxTeams.Location = new Point(23, 82);
            textBoxTeams.Multiline = true;
            textBoxTeams.Name = "textBoxTeams";
            textBoxTeams.Size = new Size(178, 166);
            textBoxTeams.TabIndex = 1;
            // 
            // buttonGenerate
            // 
            buttonGenerate.BackColor = Color.CornflowerBlue;
            buttonGenerate.ForeColor = SystemColors.ControlText;
            buttonGenerate.Location = new Point(124, 263);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(177, 63);
            buttonGenerate.TabIndex = 2;
            buttonGenerate.Text = "Згенерувати";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxSchedule
            // 
            textBoxSchedule.Location = new Point(218, 82);
            textBoxSchedule.Multiline = true;
            textBoxSchedule.Name = "textBoxSchedule";
            textBoxSchedule.ReadOnly = true;
            textBoxSchedule.Size = new Size(178, 166);
            textBoxSchedule.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 394);
            Controls.Add(textBoxSchedule);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxTeams);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Курсова Робота Бєловол О.В.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTeams;
        private Button buttonGenerate;
        private TextBox textBoxSchedule;
    }
}
