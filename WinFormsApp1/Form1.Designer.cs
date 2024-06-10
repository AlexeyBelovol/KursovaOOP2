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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelTitle = new Label();
            textBoxTeams = new TextBox();
            buttonGenerate = new Button();
            textBoxSchedule = new TextBox();
            buttonSave = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = SystemColors.Highlight;
            labelTitle.BorderStyle = BorderStyle.FixedSingle;
            labelTitle.Font = new Font("Candara Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.ButtonFace;
            labelTitle.Location = new Point(58, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(296, 31);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Розбиття турніру на раунди";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
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
            buttonGenerate.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGenerate.ForeColor = SystemColors.ControlText;
            buttonGenerate.Location = new Point(23, 272);
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
            // buttonSave
            // 
            buttonSave.BackColor = Color.CornflowerBlue;
            buttonSave.Font = new Font("Candara", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave.ForeColor = SystemColors.ControlText;
            buttonSave.Location = new Point(218, 272);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(177, 63);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Зберегти в .DOC";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 385);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(418, 379);
            Controls.Add(buttonSave);
            Controls.Add(textBoxSchedule);
            Controls.Add(buttonGenerate);
            Controls.Add(textBoxTeams);
            Controls.Add(labelTitle);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Курсова Робота Бєловол О.В.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private TextBox textBoxTeams;
        private Button buttonGenerate;
        private TextBox textBoxSchedule;
        private Button buttonSave;
        private PictureBox pictureBox1;
    }
}
