namespace PinPongGame
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
            this.PlayGround = new System.Windows.Forms.Panel();
            this.GameOver_lbl = new System.Windows.Forms.Label();
            this.points_lbl = new System.Windows.Forms.Label();
            this.Score_lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.Racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PlayGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayGround
            // 
            this.PlayGround.Controls.Add(this.GameOver_lbl);
            this.PlayGround.Controls.Add(this.points_lbl);
            this.PlayGround.Controls.Add(this.Score_lbl);
            this.PlayGround.Controls.Add(this.ball);
            this.PlayGround.Controls.Add(this.Racket);
            this.PlayGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayGround.Location = new System.Drawing.Point(0, 0);
            this.PlayGround.Name = "PlayGround";
            this.PlayGround.Size = new System.Drawing.Size(1045, 583);
            this.PlayGround.TabIndex = 0;
            // 
            // GameOver_lbl
            // 
            this.GameOver_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOver_lbl.AutoSize = true;
            this.GameOver_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOver_lbl.Location = new System.Drawing.Point(307, 179);
            this.GameOver_lbl.Name = "GameOver_lbl";
            this.GameOver_lbl.Size = new System.Drawing.Size(160, 93);
            this.GameOver_lbl.TabIndex = 4;
            this.GameOver_lbl.Text = "Game Over \r\nF1 - Restart\r\nEsc - Exit\r\n";
            this.GameOver_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
            // 
            // points_lbl
            // 
            this.points_lbl.AutoSize = true;
            this.points_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.points_lbl.Location = new System.Drawing.Point(102, 13);
            this.points_lbl.Name = "points_lbl";
            this.points_lbl.Size = new System.Drawing.Size(26, 29);
            this.points_lbl.TabIndex = 3;
            this.points_lbl.Text = "0";
            // 
            // Score_lbl
            // 
            this.Score_lbl.AutoSize = true;
            this.Score_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_lbl.Location = new System.Drawing.Point(13, 13);
            this.Score_lbl.Name = "Score_lbl";
            this.Score_lbl.Size = new System.Drawing.Size(83, 29);
            this.Score_lbl.TabIndex = 2;
            this.Score_lbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(52, 71);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Racket.Location = new System.Drawing.Point(418, 542);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(200, 20);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 583);
            this.Controls.Add(this.PlayGround);
            this.Name = "Form1";
            this.Text = "Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.PlayGround.ResumeLayout(false);
            this.PlayGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PlayGround;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label points_lbl;
        private System.Windows.Forms.Label Score_lbl;
        private System.Windows.Forms.Label GameOver_lbl;
    }
}

