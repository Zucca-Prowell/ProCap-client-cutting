﻿namespace PROCAP_CLIENT
{
    partial class Formchat
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            buttonsubmit = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonsubmit
            // 
            buttonsubmit.Location = new Point(274, 225);
            buttonsubmit.Name = "buttonsubmit";
            buttonsubmit.Size = new Size(75, 25);
            buttonsubmit.TabIndex = 1;
            buttonsubmit.Text = "提交";
            buttonsubmit.UseVisualStyleBackColor = true;
            buttonsubmit.Click += buttonsubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Location = new Point(51, 227);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "--------";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Formchat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonsubmit);
            Controls.Add(dataGridView1);
            Name = "Formchat";
            Text = "裁加產量登記";
            Load += Formchat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonsubmit;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        protected internal TextBox textBox1;
    }
}