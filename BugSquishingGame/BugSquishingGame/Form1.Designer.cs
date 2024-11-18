namespace BugSquishingGame
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
            this.bug = new System.Windows.Forms.PictureBox();
            this.Spawntimer = new System.Windows.Forms.Timer(this.components);
            this.timelabel = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.restartbutton = new System.Windows.Forms.Button();
            this.scoreLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bug)).BeginInit();
            this.SuspendLayout();
            // 
            // bug
            // 
            this.bug.BackColor = System.Drawing.Color.Transparent;
            this.bug.Image = global::BugSquishingGame.Properties.Resources.bug1;
            this.bug.Location = new System.Drawing.Point(537, 425);
            this.bug.Name = "bug";
            this.bug.Size = new System.Drawing.Size(73, 65);
            this.bug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bug.TabIndex = 0;
            this.bug.TabStop = false;
            this.bug.Click += new System.EventHandler(this.pictureBox1_Click);
            this.bug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SquishBug);
            // 
            // Spawntimer
            // 
            this.Spawntimer.Enabled = true;
            this.Spawntimer.Interval = 1000;
            this.Spawntimer.Tick += new System.EventHandler(this.spawnbug);
            // 
            // timelabel
            // 
            this.timelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timelabel.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.timelabel.Location = new System.Drawing.Point(0, 0);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(662, 74);
            this.timelabel.TabIndex = 2;
            this.timelabel.Text = "Time left:XX";
            this.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 1000;
            this.gametimer.Tick += new System.EventHandler(this.gametime);
            // 
            // restartbutton
            // 
            this.restartbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.restartbutton.BackColor = System.Drawing.Color.White;
            this.restartbutton.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartbutton.ForeColor = System.Drawing.Color.Green;
            this.restartbutton.Location = new System.Drawing.Point(266, 288);
            this.restartbutton.Name = "restartbutton";
            this.restartbutton.Size = new System.Drawing.Size(130, 99);
            this.restartbutton.TabIndex = 3;
            this.restartbutton.Text = "Play Again!";
            this.restartbutton.UseVisualStyleBackColor = false;
            this.restartbutton.Visible = false;
            this.restartbutton.Click += new System.EventHandler(this.restartGame);
            // 
            // scoreLable
            // 
            this.scoreLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.scoreLable.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLable.ForeColor = System.Drawing.Color.ForestGreen;
            this.scoreLable.Location = new System.Drawing.Point(0, 74);
            this.scoreLable.Name = "scoreLable";
            this.scoreLable.Size = new System.Drawing.Size(662, 63);
            this.scoreLable.TabIndex = 4;
            this.scoreLable.Text = "Squished 0 bugs";
            this.scoreLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreLable.Click += new System.EventHandler(this.scoreLable_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BugSquishingGame.Properties.Resources.tile;
            this.ClientSize = new System.Drawing.Size(662, 584);
            this.Controls.Add(this.scoreLable);
            this.Controls.Add(this.restartbutton);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.bug);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(687, 631);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BugSquishingGame-Kavya Ganatra";
            ((System.ComponentModel.ISupportInitialize)(this.bug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bug;
        private System.Windows.Forms.Timer Spawntimer;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Button restartbutton;
        private System.Windows.Forms.Label scoreLable;
    }
}

