using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    partial class Form1
    {
        Boolean turn = true;
        string[] game = new string[9];
        int counter = 0;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A1.Location = new System.Drawing.Point(15, 39);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            this.A1.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.A1.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A3.Location = new System.Drawing.Point(227, 39);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 1;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            this.A3.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.A3.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A2.Location = new System.Drawing.Point(121, 39);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            this.A2.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.A2.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B1.Location = new System.Drawing.Point(15, 145);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            this.B1.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.B1.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B2.Location = new System.Drawing.Point(121, 145);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            this.B2.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.B2.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B3.Location = new System.Drawing.Point(227, 145);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            this.B3.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.B3.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C1.Location = new System.Drawing.Point(15, 251);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 6;
            this.C1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            this.C1.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.C1.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C2.Location = new System.Drawing.Point(121, 251);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            this.C2.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.C2.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C3.Location = new System.Drawing.Point(227, 251);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            this.C3.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.C3.MouseHover += new System.EventHandler(this.mouseEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(338, 34);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 29);
            this.toolStripButton1.Text = "Reset";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 354);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}

