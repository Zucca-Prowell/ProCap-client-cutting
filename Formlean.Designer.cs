namespace PROCAP_CLIENT
{
    partial class Formlean
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
            radioButtonlean1 = new RadioButton();
            radioButtonlean2 = new RadioButton();
            radioButtonlean3 = new RadioButton();
            textBoxchat = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            textBoxstitch = new TextBox();
            textBoxassemble = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(368, 404);
            dataGridView1.TabIndex = 0;
            // 
            // buttonsubmit
            // 
            buttonsubmit.Location = new Point(473, 358);
            buttonsubmit.Name = "buttonsubmit";
            buttonsubmit.Size = new Size(75, 23);
            buttonsubmit.TabIndex = 2;
            buttonsubmit.Text = "提交";
            buttonsubmit.UseVisualStyleBackColor = true;
            buttonsubmit.Click += buttonsubmit_Click;
            // 
            // radioButtonlean1
            // 
            radioButtonlean1.AutoSize = true;
            radioButtonlean1.Location = new Point(479, 77);
            radioButtonlean1.Name = "radioButtonlean1";
            radioButtonlean1.Size = new Size(69, 19);
            radioButtonlean1.TabIndex = 3;
            radioButtonlean1.TabStop = true;
            radioButtonlean1.Text = "Lean1線";
            radioButtonlean1.UseVisualStyleBackColor = true;
            radioButtonlean1.CheckedChanged += radioButtonlean1_CheckedChanged;
            // 
            // radioButtonlean2
            // 
            radioButtonlean2.AutoSize = true;
            radioButtonlean2.Location = new Point(479, 102);
            radioButtonlean2.Name = "radioButtonlean2";
            radioButtonlean2.Size = new Size(69, 19);
            radioButtonlean2.TabIndex = 4;
            radioButtonlean2.TabStop = true;
            radioButtonlean2.Text = "Lean2線";
            radioButtonlean2.UseVisualStyleBackColor = true;
            // 
            // radioButtonlean3
            // 
            radioButtonlean3.AutoSize = true;
            radioButtonlean3.Location = new Point(479, 127);
            radioButtonlean3.Name = "radioButtonlean3";
            radioButtonlean3.Size = new Size(69, 19);
            radioButtonlean3.TabIndex = 5;
            radioButtonlean3.TabStop = true;
            radioButtonlean3.Text = "Lean3線";
            radioButtonlean3.UseVisualStyleBackColor = true;
            // 
            // textBoxchat
            // 
            textBoxchat.Location = new Point(457, 186);
            textBoxchat.Name = "textBoxchat";
            textBoxchat.Size = new Size(100, 23);
            textBoxchat.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(457, 149);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "-------";
            label1.Click += label1_Click;
            // 
            // textBoxstitch
            // 
            textBoxstitch.Location = new Point(457, 270);
            textBoxstitch.Name = "textBoxstitch";
            textBoxstitch.Size = new Size(100, 23);
            textBoxstitch.TabIndex = 8;
            // 
            // textBoxassemble
            // 
            textBoxassemble.Location = new Point(457, 312);
            textBoxassemble.Name = "textBoxassemble";
            textBoxassemble.Size = new Size(100, 23);
            textBoxassemble.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "針1組", "針2組", "針3組", "針4組" });
            comboBox1.Location = new Point(457, 227);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(396, 186);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 11;
            label2.Text = "裁加";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 227);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "針車";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 312);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 13;
            label4.Text = "成型";
            // 
            // Formlean
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(textBoxassemble);
            Controls.Add(textBoxstitch);
            Controls.Add(label1);
            Controls.Add(textBoxchat);
            Controls.Add(radioButtonlean3);
            Controls.Add(radioButtonlean2);
            Controls.Add(radioButtonlean1);
            Controls.Add(buttonsubmit);
            Controls.Add(dataGridView1);
            Name = "Formlean";
            Text = "Lean線產量";
            Load += Formlean_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonsubmit;
        private RadioButton radioButtonlean1;
        private RadioButton radioButtonlean2;
        private RadioButton radioButtonlean3;
        private TextBox textBoxchat;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private TextBox textBoxstitch;
        private TextBox textBoxassemble;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}