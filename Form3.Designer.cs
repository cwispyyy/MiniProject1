namespace MiniProject1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.fish1 = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.fish2 = new System.Windows.Forms.PictureBox();
            this.fish3 = new System.Windows.Forms.PictureBox();
            this.scorelbl = new System.Windows.Forms.Label();
            this.missedlbl = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish3)).BeginInit();
            this.SuspendLayout();
            // 
            // fish1
            // 
            this.fish1.Image = global::MiniProject1.Properties.Resources.fish;
            this.fish1.Location = new System.Drawing.Point(40, 61);
            this.fish1.Name = "fish1";
            this.fish1.Size = new System.Drawing.Size(70, 70);
            this.fish1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish1.TabIndex = 0;
            this.fish1.TabStop = false;
            this.fish1.Tag = "fishes";
            // 
            // cat
            // 
            this.cat.Image = global::MiniProject1.Properties.Resources.popcatleft;
            this.cat.Location = new System.Drawing.Point(252, 594);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(118, 126);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 0;
            this.cat.TabStop = false;
            this.cat.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // fish2
            // 
            this.fish2.Image = global::MiniProject1.Properties.Resources.fish;
            this.fish2.Location = new System.Drawing.Point(266, 61);
            this.fish2.Name = "fish2";
            this.fish2.Size = new System.Drawing.Size(70, 70);
            this.fish2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish2.TabIndex = 0;
            this.fish2.TabStop = false;
            this.fish2.Tag = "fishes";
            // 
            // fish3
            // 
            this.fish3.Image = global::MiniProject1.Properties.Resources.fish;
            this.fish3.Location = new System.Drawing.Point(485, 61);
            this.fish3.Name = "fish3";
            this.fish3.Size = new System.Drawing.Size(70, 70);
            this.fish3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fish3.TabIndex = 0;
            this.fish3.TabStop = false;
            this.fish3.Tag = "fishes";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(13, 8);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(114, 40);
            this.scorelbl.TabIndex = 1;
            this.scorelbl.Text = "Score: 0";
            this.scorelbl.Click += new System.EventHandler(this.Scorelbl_Click);
            // 
            // missedlbl
            // 
            this.missedlbl.AutoSize = true;
            this.missedlbl.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missedlbl.Location = new System.Drawing.Point(475, 8);
            this.missedlbl.Name = "missedlbl";
            this.missedlbl.Size = new System.Drawing.Size(126, 40);
            this.missedlbl.TabIndex = 2;
            this.missedlbl.Text = "Missed: 0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGamerTimerEvent);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(612, 693);
            this.Controls.Add(this.missedlbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.fish3);
            this.Controls.Add(this.fish2);
            this.Controls.Add(this.fish1);
            this.Name = "Form3";
            this.Text = "FEED CHONK";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.fish1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fish3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fish1;
        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox fish2;
        private System.Windows.Forms.PictureBox fish3;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label missedlbl;
        private System.Windows.Forms.Timer GameTimer;
    }
}