namespace CarRacingGame
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioBtn30s = new System.Windows.Forms.RadioButton();
            this.radioBtn60s = new System.Windows.Forms.RadioButton();
            this.radioBtn120s = new System.Windows.Forms.RadioButton();
            this.radioBtnUnlimited = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(165, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 344);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Location = new System.Drawing.Point(478, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 344);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // radioBtn30s
            // 
            this.radioBtn30s.AutoSize = true;
            this.radioBtn30s.Font = new System.Drawing.Font("Adobe Caslon Pro", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn30s.Location = new System.Drawing.Point(87, 158);
            this.radioBtn30s.Name = "radioBtn30s";
            this.radioBtn30s.Size = new System.Drawing.Size(129, 45);
            this.radioBtn30s.TabIndex = 6;
            this.radioBtn30s.TabStop = true;
            this.radioBtn30s.Text = "30 Second";
            this.radioBtn30s.UseVisualStyleBackColor = true;
            // 
            // radioBtn60s
            // 
            this.radioBtn60s.AutoSize = true;
            this.radioBtn60s.Font = new System.Drawing.Font("Adobe Caslon Pro", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn60s.Location = new System.Drawing.Point(87, 209);
            this.radioBtn60s.Name = "radioBtn60s";
            this.radioBtn60s.Size = new System.Drawing.Size(129, 45);
            this.radioBtn60s.TabIndex = 7;
            this.radioBtn60s.TabStop = true;
            this.radioBtn60s.Text = "60 Second";
            this.radioBtn60s.UseVisualStyleBackColor = true;
            this.radioBtn60s.CheckedChanged += new System.EventHandler(this.radioBtn60s_CheckedChanged);
            // 
            // radioBtn120s
            // 
            this.radioBtn120s.AutoSize = true;
            this.radioBtn120s.Font = new System.Drawing.Font("Adobe Caslon Pro", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtn120s.Location = new System.Drawing.Point(295, 158);
            this.radioBtn120s.Name = "radioBtn120s";
            this.radioBtn120s.Size = new System.Drawing.Size(141, 45);
            this.radioBtn120s.TabIndex = 8;
            this.radioBtn120s.TabStop = true;
            this.radioBtn120s.Text = "120 Second";
            this.radioBtn120s.UseVisualStyleBackColor = true;
            // 
            // radioBtnUnlimited
            // 
            this.radioBtnUnlimited.AutoSize = true;
            this.radioBtnUnlimited.Font = new System.Drawing.Font("Adobe Caslon Pro", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnUnlimited.Location = new System.Drawing.Point(295, 209);
            this.radioBtnUnlimited.Name = "radioBtnUnlimited";
            this.radioBtnUnlimited.Size = new System.Drawing.Size(133, 45);
            this.radioBtnUnlimited.TabIndex = 9;
            this.radioBtnUnlimited.TabStop = true;
            this.radioBtnUnlimited.Text = "Unlimited";
            this.radioBtnUnlimited.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Beta Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(172, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car Racing ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(204, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 43);
            this.label3.TabIndex = 11;
            this.label3.Text = "Game 2D";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(484, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioBtnUnlimited);
            this.Controls.Add(this.radioBtn120s);
            this.Controls.Add(this.radioBtn60s);
            this.Controls.Add(this.radioBtn30s);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Car Racing Game";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioBtn30s;
        private System.Windows.Forms.RadioButton radioBtn60s;
        private System.Windows.Forms.RadioButton radioBtn120s;
        private System.Windows.Forms.RadioButton radioBtnUnlimited;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

