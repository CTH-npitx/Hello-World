﻿namespace Hello_World
{
    partial class frm_HelloWorld
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Blue;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_close.Location = new System.Drawing.Point(286, 212);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseMnemonic = false;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // btn_go
            // 
            this.btn_go.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btn_go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_go.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_go.Location = new System.Drawing.Point(411, 212);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // txt_output
            // 
            this.txt_output.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txt_output.Location = new System.Drawing.Point(175, 12);
            this.txt_output.MaxLength = 20;
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(407, 44);
            this.txt_output.TabIndex = 2;
            this.txt_output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(735, 483);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_HelloWorld";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.TextBox txt_output;
    }
}

