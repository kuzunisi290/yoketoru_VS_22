﻿
namespace yoketoru_VS_22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlelabel = new System.Windows.Forms.Label();
            this.sutartbutton = new System.Windows.Forms.Button();
            this.crlabel = new System.Windows.Forms.Label();
            this.highscorelabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.starlabel = new System.Windows.Forms.Label();
            this.gameoverlabel = new System.Windows.Forms.Label();
            this.clearlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.ForeColor = System.Drawing.Color.Red;
            this.titlelabel.Location = new System.Drawing.Point(168, 77);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(465, 67);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "よけとる2022";
            // 
            // sutartbutton
            // 
            this.sutartbutton.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sutartbutton.Location = new System.Drawing.Point(237, 236);
            this.sutartbutton.Name = "sutartbutton";
            this.sutartbutton.Size = new System.Drawing.Size(327, 96);
            this.sutartbutton.TabIndex = 1;
            this.sutartbutton.Text = "スタート!!";
            this.sutartbutton.UseVisualStyleBackColor = true;
            // 
            // crlabel
            // 
            this.crlabel.AutoSize = true;
            this.crlabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crlabel.Location = new System.Drawing.Point(264, 400);
            this.crlabel.Name = "crlabel";
            this.crlabel.Size = new System.Drawing.Size(272, 20);
            this.crlabel.TabIndex = 2;
            this.crlabel.Text = "Copyright © 2022 葛西 達也";
            // 
            // highscorelabel
            // 
            this.highscorelabel.AutoSize = true;
            this.highscorelabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.highscorelabel.Location = new System.Drawing.Point(300, 176);
            this.highscorelabel.Name = "highscorelabel";
            this.highscorelabel.Size = new System.Drawing.Size(201, 27);
            this.highscorelabel.TabIndex = 3;
            this.highscorelabel.Text = "High Score 450";
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timelabel.Location = new System.Drawing.Point(12, 21);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(104, 20);
            this.timelabel.TabIndex = 4;
            this.timelabel.Text = "Time  100";
            // 
            // starlabel
            // 
            this.starlabel.AutoSize = true;
            this.starlabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.starlabel.Location = new System.Drawing.Point(701, 21);
            this.starlabel.Name = "starlabel";
            this.starlabel.Size = new System.Drawing.Size(60, 20);
            this.starlabel.TabIndex = 5;
            this.starlabel.Text = "★:10";
            // 
            // gameoverlabel
            // 
            this.gameoverlabel.AutoSize = true;
            this.gameoverlabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameoverlabel.ForeColor = System.Drawing.Color.Blue;
            this.gameoverlabel.Location = new System.Drawing.Point(203, 192);
            this.gameoverlabel.Name = "gameoverlabel";
            this.gameoverlabel.Size = new System.Drawing.Size(395, 67);
            this.gameoverlabel.TabIndex = 6;
            this.gameoverlabel.Text = "Game Over...";
            // 
            // clearlabel
            // 
            this.clearlabel.AutoSize = true;
            this.clearlabel.Font = new System.Drawing.Font("HGS創英角ｺﾞｼｯｸUB", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearlabel.ForeColor = System.Drawing.Color.Yellow;
            this.clearlabel.Location = new System.Drawing.Point(270, 192);
            this.clearlabel.Name = "clearlabel";
            this.clearlabel.Size = new System.Drawing.Size(261, 67);
            this.clearlabel.TabIndex = 7;
            this.clearlabel.Text = "CLEAR!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearlabel);
            this.Controls.Add(this.gameoverlabel);
            this.Controls.Add(this.starlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.highscorelabel);
            this.Controls.Add(this.crlabel);
            this.Controls.Add(this.sutartbutton);
            this.Controls.Add(this.titlelabel);
            this.Name = "Form1";
            this.Text = "よけとる2022";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Button sutartbutton;
        private System.Windows.Forms.Label crlabel;
        private System.Windows.Forms.Label highscorelabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label starlabel;
        private System.Windows.Forms.Label gameoverlabel;
        private System.Windows.Forms.Label clearlabel;
    }
}

