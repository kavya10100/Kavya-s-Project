namespace StrongPasswordGenerator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.RevealCheckBox = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LowerCaselabel = new System.Windows.Forms.Label();
            this.UpperCaselabel = new System.Windows.Forms.Label();
            this.Digitlabel = new System.Windows.Forms.Label();
            this.SpecialCharlabel = new System.Windows.Forms.Label();
            this.Lengthlabel = new System.Windows.Forms.Label();
            this.HintToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.PasswordtextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Password:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Requirements:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(878, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Strength:";
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordtextBox.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordtextBox.Location = new System.Drawing.Point(13, 69);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(878, 51);
            this.PasswordtextBox.TabIndex = 3;
            this.PasswordtextBox.UseSystemPasswordChar = true;
            this.PasswordtextBox.TextChanged += new System.EventHandler(this.PasswordtextBox_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Generatebutton);
            this.flowLayoutPanel1.Controls.Add(this.RevealCheckBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 125);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(878, 50);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Generatebutton
            // 
            this.Generatebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Generatebutton.BackColor = System.Drawing.Color.Transparent;
            this.Generatebutton.BackgroundImage = global::StrongPasswordGenerator.Properties.Resources.Random;
            this.Generatebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Generatebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generatebutton.FlatAppearance.BorderSize = 0;
            this.Generatebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Generatebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Generatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generatebutton.Location = new System.Drawing.Point(3, 3);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(61, 46);
            this.Generatebutton.TabIndex = 0;
            this.Generatebutton.UseVisualStyleBackColor = false;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // RevealCheckBox
            // 
            this.RevealCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.RevealCheckBox.BackgroundImage = global::StrongPasswordGenerator.Properties.Resources.Conceal;
            this.RevealCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RevealCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevealCheckBox.FlatAppearance.BorderSize = 0;
            this.RevealCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.RevealCheckBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RevealCheckBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RevealCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevealCheckBox.Location = new System.Drawing.Point(70, 3);
            this.RevealCheckBox.Name = "RevealCheckBox";
            this.RevealCheckBox.Size = new System.Drawing.Size(104, 46);
            this.RevealCheckBox.TabIndex = 1;
            this.RevealCheckBox.UseVisualStyleBackColor = true;
            this.RevealCheckBox.CheckedChanged += new System.EventHandler(this.ReveaPassword);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(13, 237);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(878, 50);
            this.progressBar1.TabIndex = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LowerCaselabel);
            this.flowLayoutPanel2.Controls.Add(this.UpperCaselabel);
            this.flowLayoutPanel2.Controls.Add(this.Digitlabel);
            this.flowLayoutPanel2.Controls.Add(this.SpecialCharlabel);
            this.flowLayoutPanel2.Controls.Add(this.Lengthlabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 349);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(870, 56);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // LowerCaselabel
            // 
            this.LowerCaselabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LowerCaselabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowerCaselabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerCaselabel.Location = new System.Drawing.Point(0, 0);
            this.LowerCaselabel.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.LowerCaselabel.Name = "LowerCaselabel";
            this.LowerCaselabel.Size = new System.Drawing.Size(100, 57);
            this.LowerCaselabel.TabIndex = 7;
            this.LowerCaselabel.Text = "a-z";
            this.LowerCaselabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HintToolTip.SetToolTip(this.LowerCaselabel, "Password must contain at least 1 lower case letter");
            // 
            // UpperCaselabel
            // 
            this.UpperCaselabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UpperCaselabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpperCaselabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperCaselabel.Location = new System.Drawing.Point(130, 0);
            this.UpperCaselabel.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.UpperCaselabel.Name = "UpperCaselabel";
            this.UpperCaselabel.Size = new System.Drawing.Size(131, 57);
            this.UpperCaselabel.TabIndex = 8;
            this.UpperCaselabel.Text = "A-Z";
            this.UpperCaselabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HintToolTip.SetToolTip(this.UpperCaselabel, "Password must contain at least 1 upper case letter");
            // 
            // Digitlabel
            // 
            this.Digitlabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Digitlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Digitlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digitlabel.Location = new System.Drawing.Point(291, 0);
            this.Digitlabel.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Digitlabel.Name = "Digitlabel";
            this.Digitlabel.Size = new System.Drawing.Size(119, 57);
            this.Digitlabel.TabIndex = 9;
            this.Digitlabel.Text = "0-9";
            this.Digitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HintToolTip.SetToolTip(this.Digitlabel, "Password must contain at least 1 number");
            // 
            // SpecialCharlabel
            // 
            this.SpecialCharlabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SpecialCharlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecialCharlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialCharlabel.Location = new System.Drawing.Point(440, 0);
            this.SpecialCharlabel.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.SpecialCharlabel.Name = "SpecialCharlabel";
            this.SpecialCharlabel.Size = new System.Drawing.Size(127, 57);
            this.SpecialCharlabel.TabIndex = 6;
            this.SpecialCharlabel.Text = "!@#";
            this.SpecialCharlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HintToolTip.SetToolTip(this.SpecialCharlabel, "Password must contain at least 1 special character");
            // 
            // Lengthlabel
            // 
            this.Lengthlabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lengthlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lengthlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lengthlabel.Location = new System.Drawing.Point(597, 0);
            this.Lengthlabel.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.Lengthlabel.Name = "Lengthlabel";
            this.Lengthlabel.Size = new System.Drawing.Size(238, 57);
            this.Lengthlabel.TabIndex = 7;
            this.Lengthlabel.Text = "10 chars";
            this.Lengthlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HintToolTip.SetToolTip(this.Lengthlabel, "Password must contain at least 10 character");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 418);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator & Strength Checker- Kavya Ganatra";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Generatebutton;
        private System.Windows.Forms.CheckBox RevealCheckBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label SpecialCharlabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LowerCaselabel;
        private System.Windows.Forms.Label UpperCaselabel;
        private System.Windows.Forms.Label Digitlabel;
        private System.Windows.Forms.Label Lengthlabel;
        private System.Windows.Forms.ToolTip HintToolTip;
    }
}

