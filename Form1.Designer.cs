namespace PixelPong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.points_text = new System.Windows.Forms.Label();
            this.score_text = new System.Windows.Forms.Label();
            this.high_score_label = new System.Windows.Forms.Label(); // High score label definition
            this.rack = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.finishing_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.points_text);
            this.panel1.Controls.Add(this.score_text);
            this.panel1.Controls.Add(this.high_score_label); // Add high score label to panel
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 123);
            this.panel1.TabIndex = 0;
            // 
            // rack
            // 
            this.rack.BackColor = System.Drawing.Color.SteelBlue;
            this.rack.Location = new System.Drawing.Point(353, 511);
            this.rack.Name = "rack";
            this.rack.Size = new System.Drawing.Size(210, 20);
            this.rack.TabIndex = 1;
            this.rack.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Coral;
            this.ball.Location = new System.Drawing.Point(449, 195);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score_text
            // 
            this.score_text.AutoSize = true;
            this.score_text.Font = new System.Drawing.Font("Product Sans", 32F);
            this.score_text.Location = new System.Drawing.Point(12, 9);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(177, 69);
            this.score_text.TabIndex = 3;
            this.score_text.Text = "Score:";
            // 
            // points_text
            // 
            this.points_text.AutoSize = true;
            this.points_text.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Bold);
            this.points_text.Location = new System.Drawing.Point(186, 34);
            this.points_text.Name = "points_text";
            this.points_text.Size = new System.Drawing.Size(33, 34);
            this.points_text.TabIndex = 3;
            this.points_text.Text = "0";
            this.points_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // high_score_label
            // 
            this.high_score_label.AutoSize = true;
            this.high_score_label.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Bold);
            this.high_score_label.Location = new System.Drawing.Point(12, 78);
            this.high_score_label.Name = "high_score_label";
            this.high_score_label.Size = new System.Drawing.Size(166, 34);
            this.high_score_label.TabIndex = 4;
            this.high_score_label.Text = "High Score: 0";
            this.high_score_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finishing_lbl
            // 
            this.finishing_lbl.AutoSize = true;
            this.finishing_lbl.Font = new System.Drawing.Font("Product Sans", 15F, System.Drawing.FontStyle.Bold);
            this.finishing_lbl.Location = new System.Drawing.Point(-6, 137);
            this.finishing_lbl.Name = "finishing_lbl";
            this.finishing_lbl.Size = new System.Drawing.Size(311, 192);
            this.finishing_lbl.TabIndex = 3;
            this.finishing_lbl.Text = "Game over\r\n\r\n\r\nPress Enter key to restart.\r\n\r\nPress Esc to exit.";
            this.finishing_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 552);
            this.Controls.Add(this.finishing_lbl);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.rack);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PixelPong";
           
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox rack;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Label points_text;
        private System.Windows.Forms.Label finishing_lbl;
        private System.Windows.Forms.Label high_score_label; // High score label declaration
    }
}
