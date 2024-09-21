using System;

namespace AreaCircle2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bCircum = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            this.laCircum = new System.Windows.Forms.Label();
            this.laArea = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรมคำนวณวงกลม";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "รัศมี";
            // 
            // tRadius
            // 
            this.tRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRadius.Location = new System.Drawing.Point(319, 121);
            this.tRadius.Name = "tRadius";
            this.tRadius.Size = new System.Drawing.Size(117, 38);
            this.tRadius.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "เส้นรอบวง";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "พื้นที่วงกลม";
            // 
            // bCircum
            // 
            this.bCircum.Location = new System.Drawing.Point(452, 208);
            this.bCircum.Name = "bCircum";
            this.bCircum.Size = new System.Drawing.Size(55, 41);
            this.bCircum.TabIndex = 6;
            this.bCircum.Text = "OK";
            this.bCircum.UseVisualStyleBackColor = true;
            this.bCircum.Click += new System.EventHandler(this.bCircum_Click);
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(452, 283);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(55, 41);
            this.bArea.TabIndex = 7;
            this.bArea.Text = "OK";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // laCircum
            // 
            this.laCircum.AutoSize = true;
            this.laCircum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCircum.Location = new System.Drawing.Point(292, 212);
            this.laCircum.Name = "laCircum";
            this.laCircum.Size = new System.Drawing.Size(107, 37);
            this.laCircum.TabIndex = 8;
            this.laCircum.Text = "..........";
            // 
            // laArea
            // 
            this.laArea.AutoSize = true;
            this.laArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laArea.Location = new System.Drawing.Point(292, 287);
            this.laArea.Name = "laArea";
            this.laArea.Size = new System.Drawing.Size(107, 37);
            this.laArea.TabIndex = 9;
            this.laArea.Text = "..........";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.laArea);
            this.Controls.Add(this.laCircum);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.bCircum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "โปรแกรมคำนวณวงกลม";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCircum;
        private System.Windows.Forms.Button bArea;
        private EventHandler pictureBox1_Click;
        private EventHandler Form1_Load;
        private System.Windows.Forms.Label laCircum;
        private System.Windows.Forms.Label laArea;
    }
}

