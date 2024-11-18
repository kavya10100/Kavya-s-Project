namespace TicTacToe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Palyer2textBox = new System.Windows.Forms.TextBox();
            this.Player1textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Score2textBox = new System.Windows.Forms.TextBox();
            this.Score1textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.winnertextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WhatPlayerlabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Palyer2colourtextBox = new System.Windows.Forms.TextBox();
            this.Palyer1colourtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Palyer2textBox);
            this.panel1.Controls.Add(this.Player1textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 183);
            this.panel1.TabIndex = 0;
            // 
            // Palyer2textBox
            // 
            this.Palyer2textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Palyer2textBox.Location = new System.Drawing.Point(76, 125);
            this.Palyer2textBox.Name = "Palyer2textBox";
            this.Palyer2textBox.Size = new System.Drawing.Size(292, 37);
            this.Palyer2textBox.TabIndex = 4;
            this.Palyer2textBox.TextChanged += new System.EventHandler(this.Palyer2textBox_TextChanged);
            // 
            // Player1textBox
            // 
            this.Player1textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1textBox.Location = new System.Drawing.Point(76, 67);
            this.Player1textBox.Name = "Player1textBox";
            this.Player1textBox.Size = new System.Drawing.Size(292, 37);
            this.Player1textBox.TabIndex = 3;
            this.Player1textBox.TextChanged += new System.EventHandler(this.Player1textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "O";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Score2textBox);
            this.panel2.Controls.Add(this.Score1textBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(521, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 183);
            this.panel2.TabIndex = 1;
            // 
            // Score2textBox
            // 
            this.Score2textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2textBox.Location = new System.Drawing.Point(16, 125);
            this.Score2textBox.Name = "Score2textBox";
            this.Score2textBox.ReadOnly = true;
            this.Score2textBox.Size = new System.Drawing.Size(97, 37);
            this.Score2textBox.TabIndex = 6;
            this.Score2textBox.Text = "0";
            this.Score2textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Score2textBox.TextChanged += new System.EventHandler(this.Score2textBox_TextChanged);
            // 
            // Score1textBox
            // 
            this.Score1textBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1textBox.Location = new System.Drawing.Point(16, 67);
            this.Score1textBox.Name = "Score1textBox";
            this.Score1textBox.ReadOnly = true;
            this.Score1textBox.Size = new System.Drawing.Size(97, 37);
            this.Score1textBox.TabIndex = 5;
            this.Score1textBox.Text = "0";
            this.Score1textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Score";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.winnertextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(663, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 183);
            this.panel3.TabIndex = 2;
            // 
            // winnertextBox
            // 
            this.winnertextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnertextBox.Location = new System.Drawing.Point(25, 73);
            this.winnertextBox.Name = "winnertextBox";
            this.winnertextBox.ReadOnly = true;
            this.winnertextBox.Size = new System.Drawing.Size(87, 54);
            this.winnertextBox.TabIndex = 7;
            this.winnertextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.winnertextBox.TextChanged += new System.EventHandler(this.winnertextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Winner";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.WhatPlayerlabel);
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(12, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(745, 545);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.playbutton);
            // 
            // WhatPlayerlabel
            // 
            this.WhatPlayerlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WhatPlayerlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WhatPlayerlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhatPlayerlabel.Location = new System.Drawing.Point(96, 71);
            this.WhatPlayerlabel.Name = "WhatPlayerlabel";
            this.WhatPlayerlabel.Size = new System.Drawing.Size(581, 39);
            this.WhatPlayerlabel.TabIndex = 8;
            this.WhatPlayerlabel.Text = "Waiting for player\'s name";
            this.WhatPlayerlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.WhatPlayerlabel.Click += new System.EventHandler(this.Resetbutton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 404);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.playbutton);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(384, 272);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(180, 126);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(195, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 126);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 272);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 126);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(384, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 124);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(195, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 124);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 124);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(384, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 124);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(195, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 124);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 124);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game Board";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Palyer2colourtextBox);
            this.panel5.Controls.Add(this.Palyer1colourtextBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(387, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(130, 183);
            this.panel5.TabIndex = 7;
            // 
            // Palyer2colourtextBox
            // 
            this.Palyer2colourtextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Palyer2colourtextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Palyer2colourtextBox.Location = new System.Drawing.Point(23, 130);
            this.Palyer2colourtextBox.Name = "Palyer2colourtextBox";
            this.Palyer2colourtextBox.ReadOnly = true;
            this.Palyer2colourtextBox.Size = new System.Drawing.Size(97, 37);
            this.Palyer2colourtextBox.TabIndex = 6;
            this.Palyer2colourtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Palyer2colourtextBox.Click += new System.EventHandler(this.Palyer2colourtextBox_TextChanged);
            // 
            // Palyer1colourtextBox
            // 
            this.Palyer1colourtextBox.BackColor = System.Drawing.Color.Orchid;
            this.Palyer1colourtextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Palyer1colourtextBox.ForeColor = System.Drawing.Color.Orchid;
            this.Palyer1colourtextBox.Location = new System.Drawing.Point(23, 67);
            this.Palyer1colourtextBox.Name = "Palyer1colourtextBox";
            this.Palyer1colourtextBox.ReadOnly = true;
            this.Palyer1colourtextBox.Size = new System.Drawing.Size(97, 37);
            this.Palyer1colourtextBox.TabIndex = 5;
            this.Palyer1colourtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Palyer1colourtextBox.Click += new System.EventHandler(this.Palyer1colourtextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 36);
            this.label7.TabIndex = 5;
            this.label7.Text = "Colour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(835, 782);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTackToe- Kavya Ganatra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Player1textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Palyer2textBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Score2textBox;
        private System.Windows.Forms.TextBox Score1textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox winnertextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label WhatPlayerlabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Palyer2colourtextBox;
        private System.Windows.Forms.TextBox Palyer1colourtextBox;
        private System.Windows.Forms.Label label7;
    }
}

