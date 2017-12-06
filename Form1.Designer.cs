namespace lab_3_Rock_paper
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
            this.User = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scissorsButton = new System.Windows.Forms.Button();
            this.paperButton = new System.Windows.Forms.Button();
            this.rockButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compDisplayWinsLabel = new System.Windows.Forms.Label();
            this.userDisplayWinsLabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.User);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.scissorsButton);
            this.panel1.Controls.Add(this.paperButton);
            this.panel1.Controls.Add(this.rockButton);
            this.panel1.Location = new System.Drawing.Point(38, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 179);
            this.panel1.TabIndex = 0;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("AR BLANCA", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(91, 155);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(35, 16);
            this.User.TabIndex = 4;
            this.User.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::lab_3_Rock_paper.Properties.Resources.paper;
            this.pictureBox1.Image = global::lab_3_Rock_paper.Properties.Resources.rock;
            this.pictureBox1.Location = new System.Drawing.Point(94, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // scissorsButton
            // 
            this.scissorsButton.Location = new System.Drawing.Point(3, 107);
            this.scissorsButton.Name = "scissorsButton";
            this.scissorsButton.Size = new System.Drawing.Size(75, 41);
            this.scissorsButton.TabIndex = 2;
            this.scissorsButton.Text = "Scissors";
            this.scissorsButton.UseVisualStyleBackColor = true;
            this.scissorsButton.Click += new System.EventHandler(this.scissorsButton_Click);
            // 
            // paperButton
            // 
            this.paperButton.Location = new System.Drawing.Point(3, 53);
            this.paperButton.Name = "paperButton";
            this.paperButton.Size = new System.Drawing.Size(75, 39);
            this.paperButton.TabIndex = 1;
            this.paperButton.Text = "Paper";
            this.paperButton.UseVisualStyleBackColor = true;
            this.paperButton.Click += new System.EventHandler(this.paperButton_Click);
            // 
            // rockButton
            // 
            this.rockButton.Location = new System.Drawing.Point(3, 3);
            this.rockButton.Name = "rockButton";
            this.rockButton.Size = new System.Drawing.Size(75, 39);
            this.rockButton.TabIndex = 0;
            this.rockButton.Text = "Rock";
            this.rockButton.UseVisualStyleBackColor = true;
            this.rockButton.Click += new System.EventHandler(this.rockButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(271, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 179);
            this.panel2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("AR BLANCA", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Computer";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Scissors";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(135, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Paper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rock";
            // 
            // playAgainButton
            // 
            this.playAgainButton.Location = new System.Drawing.Point(213, 202);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(75, 42);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = true;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wins:";
            // 
            // compDisplayWinsLabel
            // 
            this.compDisplayWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compDisplayWinsLabel.Location = new System.Drawing.Point(377, 203);
            this.compDisplayWinsLabel.Name = "compDisplayWinsLabel";
            this.compDisplayWinsLabel.Size = new System.Drawing.Size(88, 27);
            this.compDisplayWinsLabel.TabIndex = 6;
            this.compDisplayWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userDisplayWinsLabel
            // 
            this.userDisplayWinsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDisplayWinsLabel.Location = new System.Drawing.Point(105, 203);
            this.userDisplayWinsLabel.Name = "userDisplayWinsLabel";
            this.userDisplayWinsLabel.Size = new System.Drawing.Size(93, 27);
            this.userDisplayWinsLabel.TabIndex = 7;
            this.userDisplayWinsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 261);
            this.Controls.Add(this.userDisplayWinsLabel);
            this.Controls.Add(this.compDisplayWinsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors...Shoot!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button scissorsButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button rockButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label compDisplayWinsLabel;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label userDisplayWinsLabel;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

