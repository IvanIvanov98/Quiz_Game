namespace Quiz_Game
{
    partial class FormResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResult));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeSrednoLabel = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBoxBronze = new System.Windows.Forms.PictureBox();
            this.pictureBoxSilver = new System.Windows.Forms.PictureBox();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.labelIdMedal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBronze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(543, 304);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 165);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(419, 193);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(413, 382);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(443, 578);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(82, 35);
            this.timeLabel.TabIndex = 12;
            this.timeLabel.Text = "label11";
            // 
            // timeSrednoLabel
            // 
            this.timeSrednoLabel.AutoSize = true;
            this.timeSrednoLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeSrednoLabel.Font = new System.Drawing.Font("Mistral", 18F);
            this.timeSrednoLabel.Location = new System.Drawing.Point(431, 654);
            this.timeSrednoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeSrednoLabel.Name = "timeSrednoLabel";
            this.timeSrednoLabel.Size = new System.Drawing.Size(82, 35);
            this.timeSrednoLabel.TabIndex = 13;
            this.timeSrednoLabel.Text = "label11";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.BackColor = System.Drawing.Color.Transparent;
            this.labelCorrect.Font = new System.Drawing.Font("Mistral", 18F);
            this.labelCorrect.Location = new System.Drawing.Point(395, 78);
            this.labelCorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(176, 35);
            this.labelCorrect.TabIndex = 14;
            this.labelCorrect.Text = "Верни отговори:";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.BackColor = System.Drawing.Color.Transparent;
            this.labelWrong.Font = new System.Drawing.Font("Mistral", 18F);
            this.labelWrong.Location = new System.Drawing.Point(225, 351);
            this.labelWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(191, 35);
            this.labelWrong.TabIndex = 15;
            this.labelWrong.Text = "Грешни отговори:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 18F);
            this.label1.Location = new System.Drawing.Point(788, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Резултат:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Mistral", 22F);
            this.labelResult.Location = new System.Drawing.Point(824, 245);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(63, 44);
            this.labelResult.TabIndex = 17;
            this.labelResult.Text = "351";
            // 
            // pictureBoxBronze
            // 
            this.pictureBoxBronze.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBronze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBronze.BackgroundImage")));
            this.pictureBoxBronze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBronze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBronze.Location = new System.Drawing.Point(787, 444);
            this.pictureBoxBronze.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBronze.Name = "pictureBoxBronze";
            this.pictureBoxBronze.Size = new System.Drawing.Size(105, 187);
            this.pictureBoxBronze.TabIndex = 18;
            this.pictureBoxBronze.TabStop = false;
            this.pictureBoxBronze.Visible = false;
            // 
            // pictureBoxSilver
            // 
            this.pictureBoxSilver.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSilver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSilver.BackgroundImage")));
            this.pictureBoxSilver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSilver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSilver.Location = new System.Drawing.Point(787, 444);
            this.pictureBoxSilver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxSilver.Name = "pictureBoxSilver";
            this.pictureBoxSilver.Size = new System.Drawing.Size(105, 187);
            this.pictureBoxSilver.TabIndex = 19;
            this.pictureBoxSilver.TabStop = false;
            this.pictureBoxSilver.Visible = false;
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGold.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGold.BackgroundImage")));
            this.pictureBoxGold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGold.Location = new System.Drawing.Point(787, 444);
            this.pictureBoxGold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(105, 187);
            this.pictureBoxGold.TabIndex = 20;
            this.pictureBoxGold.TabStop = false;
            this.pictureBoxGold.Visible = false;
            // 
            // labelIdMedal
            // 
            this.labelIdMedal.AutoSize = true;
            this.labelIdMedal.BackColor = System.Drawing.Color.Transparent;
            this.labelIdMedal.Location = new System.Drawing.Point(466, 153);
            this.labelIdMedal.Name = "labelIdMedal";
            this.labelIdMedal.Size = new System.Drawing.Size(46, 17);
            this.labelIdMedal.TabIndex = 21;
            this.labelIdMedal.Text = "label2";
            this.labelIdMedal.Visible = false;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 768);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelIdMedal);
            this.Controls.Add(this.pictureBoxGold);
            this.Controls.Add(this.pictureBoxSilver);
            this.Controls.Add(this.pictureBoxBronze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.timeSrednoLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBronze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeSrednoLabel;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBoxBronze;
        private System.Windows.Forms.PictureBox pictureBoxSilver;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.Label labelIdMedal;
    }
}