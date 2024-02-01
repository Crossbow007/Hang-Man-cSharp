
namespace FinalHangMan
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
            this.label8 = new System.Windows.Forms.Label();
            this.getLastTxt = new System.Windows.Forms.TextBox();
            this.getFirstTxt = new System.Windows.Forms.TextBox();
            this.playerInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.loseTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.winTxt = new System.Windows.Forms.TextBox();
            this.areaCode = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guessTxt = new System.Windows.Forms.MaskedTextBox();
            this.reset = new System.Windows.Forms.Button();
            this.inputGuessTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 25);
            this.label8.TabIndex = 45;
            this.label8.Text = "Hi!";
            // 
            // getLastTxt
            // 
            this.getLastTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getLastTxt.Location = new System.Drawing.Point(199, 388);
            this.getLastTxt.Name = "getLastTxt";
            this.getLastTxt.Size = new System.Drawing.Size(85, 30);
            this.getLastTxt.TabIndex = 43;
            // 
            // getFirstTxt
            // 
            this.getFirstTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getFirstTxt.Location = new System.Drawing.Point(107, 388);
            this.getFirstTxt.Name = "getFirstTxt";
            this.getFirstTxt.Size = new System.Drawing.Size(86, 30);
            this.getFirstTxt.TabIndex = 42;
            // 
            // playerInfo
            // 
            this.playerInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.playerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInfo.Location = new System.Drawing.Point(422, 165);
            this.playerInfo.Name = "playerInfo";
            this.playerInfo.Size = new System.Drawing.Size(144, 40);
            this.playerInfo.TabIndex = 41;
            this.playerInfo.Text = "Submitt Info";
            this.playerInfo.UseVisualStyleBackColor = false;
            this.playerInfo.Click += new System.EventHandler(this.playerInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(588, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = " , Lose";
            // 
            // loseTxt
            // 
            this.loseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseTxt.Location = new System.Drawing.Point(672, 389);
            this.loseTxt.Name = "loseTxt";
            this.loseTxt.ReadOnly = true;
            this.loseTxt.Size = new System.Drawing.Size(57, 30);
            this.loseTxt.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = " , Your score is : Win";
            // 
            // winTxt
            // 
            this.winTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winTxt.Location = new System.Drawing.Point(523, 389);
            this.winTxt.Name = "winTxt";
            this.winTxt.ReadOnly = true;
            this.winTxt.Size = new System.Drawing.Size(57, 30);
            this.winTxt.TabIndex = 37;
            // 
            // areaCode
            // 
            this.areaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaCode.Location = new System.Drawing.Point(347, 118);
            this.areaCode.Mask = "LLL-000";
            this.areaCode.Name = "areaCode";
            this.areaCode.Size = new System.Drawing.Size(110, 30);
            this.areaCode.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Area Code:";
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.Location = new System.Drawing.Point(610, 67);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(110, 30);
            this.lastNameTxt.TabIndex = 34;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.Location = new System.Drawing.Point(347, 66);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(108, 30);
            this.firstNameTxt.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(504, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "First Name:";
            // 
            // guess
            // 
            this.guess.BackColor = System.Drawing.Color.Red;
            this.guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(306, 303);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(144, 52);
            this.guess.TabIndex = 30;
            this.guess.Text = "Guess";
            this.guess.UseVisualStyleBackColor = false;
            this.guess.Click += new System.EventHandler(this.guess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(549, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Guess Letter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Target Words";
            // 
            // guessTxt
            // 
            this.guessTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTxt.Location = new System.Drawing.Point(377, 235);
            this.guessTxt.Name = "guessTxt";
            this.guessTxt.Size = new System.Drawing.Size(158, 53);
            this.guessTxt.TabIndex = 27;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(474, 303);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(230, 52);
            this.reset.TabIndex = 48;
            this.reset.Text = "Reset!  Play again!";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // inputGuessTxt
            // 
            this.inputGuessTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputGuessTxt.Location = new System.Drawing.Point(679, 235);
            this.inputGuessTxt.Name = "inputGuessTxt";
            this.inputGuessTxt.Size = new System.Drawing.Size(70, 53);
            this.inputGuessTxt.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(41, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(699, 48);
            this.label10.TabIndex = 50;
            this.label10.Text = "Welcome to Play HangMan Guess Words Game!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalHangMan.Properties.Resources.Load1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.inputGuessTxt);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.getLastTxt);
            this.Controls.Add(this.getFirstTxt);
            this.Controls.Add(this.playerInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loseTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.winTxt);
            this.Controls.Add(this.areaCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessTxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox getLastTxt;
        private System.Windows.Forms.TextBox getFirstTxt;
        private System.Windows.Forms.Button playerInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox loseTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox winTxt;
        private System.Windows.Forms.MaskedTextBox areaCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox guessTxt;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox inputGuessTxt;
        private System.Windows.Forms.Label label10;
    }
}

