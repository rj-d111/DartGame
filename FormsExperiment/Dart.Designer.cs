namespace FormsExperiment
{
    partial class Dart
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_lives = new System.Windows.Forms.Label();
            this.freeze = new System.Windows.Forms.PictureBox();
            this.bomb = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.freeze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameEngine);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_score.Location = new System.Drawing.Point(95, 25);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(28, 25);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "__";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(32, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(67, 25);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Score:";
            // 
            // lbl_lives
            // 
            this.lbl_lives.AutoSize = true;
            this.lbl_lives.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_lives.Location = new System.Drawing.Point(384, 19);
            this.lbl_lives.Name = "lbl_lives";
            this.lbl_lives.Size = new System.Drawing.Size(116, 32);
            this.lbl_lives.TabIndex = 7;
            this.lbl_lives.Text = "❤️❤️❤️";
            // 
            // freeze
            // 
            this.freeze.Cursor = System.Windows.Forms.Cursors.Cross;
            this.freeze.Image = global::FormsExperiment.Properties.Resources.freeze;
            this.freeze.Location = new System.Drawing.Point(133, 12);
            this.freeze.Name = "freeze";
            this.freeze.Size = new System.Drawing.Size(68, 64);
            this.freeze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.freeze.TabIndex = 8;
            this.freeze.TabStop = false;
            this.freeze.Tag = "";
            this.freeze.Click += new System.EventHandler(this.freeze_ClickAsync);
            // 
            // bomb
            // 
            this.bomb.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bomb.Image = global::FormsExperiment.Properties.Resources.bomb;
            this.bomb.Location = new System.Drawing.Point(323, 227);
            this.bomb.Name = "bomb";
            this.bomb.Size = new System.Drawing.Size(84, 85);
            this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bomb.TabIndex = 4;
            this.bomb.TabStop = false;
            this.bomb.Tag = "Bomb";
            this.bomb.Click += new System.EventHandler(this.BombClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox4.Image = global::FormsExperiment.Properties.Resources.baloon1;
            this.pictureBox4.Location = new System.Drawing.Point(251, 227);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Balloon";
            this.pictureBox4.Click += new System.EventHandler(this.BalloonClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox3.Image = global::FormsExperiment.Properties.Resources.balloon2;
            this.pictureBox3.Location = new System.Drawing.Point(188, 227);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Balloon";
            this.pictureBox3.Click += new System.EventHandler(this.BalloonClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox2.Image = global::FormsExperiment.Properties.Resources.starballoon;
            this.pictureBox2.Location = new System.Drawing.Point(103, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Balloon";
            this.pictureBox2.Click += new System.EventHandler(this.BalloonClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = global::FormsExperiment.Properties.Resources.balloon3;
            this.pictureBox1.Location = new System.Drawing.Point(37, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Balloon";
            this.pictureBox1.Click += new System.EventHandler(this.BalloonClicked);
            // 
            // Dart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.freeze);
            this.Controls.Add(this.bomb);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_lives);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_score);
            this.Name = "Dart";
            this.Text = "Dart";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.freeze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox bomb;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_lives;
        private System.Windows.Forms.PictureBox freeze;
    }
}