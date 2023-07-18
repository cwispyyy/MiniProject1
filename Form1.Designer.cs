namespace MiniProject1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pinkbackground = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.catmeowpic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pinkbackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catmeowpic)).BeginInit();
            this.SuspendLayout();
            // 
            // pinkbackground
            // 
            this.pinkbackground.Image = ((System.Drawing.Image)(resources.GetObject("pinkbackground.Image")));
            this.pinkbackground.Location = new System.Drawing.Point(-333, -174);
            this.pinkbackground.Name = "pinkbackground";
            this.pinkbackground.Size = new System.Drawing.Size(1466, 960);
            this.pinkbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pinkbackground.TabIndex = 1;
            this.pinkbackground.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(270, 36);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(645, 77);
            this.Title.TabIndex = 3;
            this.Title.Text = "Chonk is HUNGRY";
            // 
            // catmeowpic
            // 
            this.catmeowpic.Image = ((System.Drawing.Image)(resources.GetObject("catmeowpic.Image")));
            this.catmeowpic.Location = new System.Drawing.Point(172, 143);
            this.catmeowpic.Name = "catmeowpic";
            this.catmeowpic.Size = new System.Drawing.Size(773, 603);
            this.catmeowpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catmeowpic.TabIndex = 4;
            this.catmeowpic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 770);
            this.Controls.Add(this.catmeowpic);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pinkbackground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinkbackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catmeowpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pinkbackground;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox catmeowpic;
    }
}

