namespace Harapan_Sehat
{
    partial class Form3
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            button6 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button3 = new Button();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 37);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 31);
            button1.TabIndex = 0;
            button1.Text = "<< Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 113);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(284, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 152);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(284, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(389, 50);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 27);
            textBox3.TabIndex = 3;
            textBox3.Visible = false;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 229);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(284, 27);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(472, 449);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(207, 27);
            textBox5.TabIndex = 5;
            textBox5.Text = "cari data dokter";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(317, 353);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(140, 35);
            button2.TabIndex = 7;
            button2.Text = "Simpan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 117);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 156);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 9;
            label2.Text = "NIK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 195);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 10;
            label3.Text = "Tanggal Lahir";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 233);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 11;
            label4.Text = "Tempat Lahir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 272);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 12;
            label5.Text = "Jenis Kelamin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 311);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 13;
            label6.Text = "Spesialisasi";
            // 
            // button4
            // 
            button4.Location = new Point(816, 449);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(100, 35);
            button4.TabIndex = 18;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(927, 447);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(100, 35);
            button5.TabIndex = 19;
            button5.Text = "Hapus";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(472, 113);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(555, 328);
            dataGridView1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(681, 72);
            label7.Name = "label7";
            label7.Size = new Size(200, 28);
            label7.TabIndex = 21;
            label7.Text = "Table Daftar Dokter";
            // 
            // button6
            // 
            button6.Location = new Point(685, 449);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(85, 31);
            button6.TabIndex = 22;
            button6.Text = "Cari";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(173, 270);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 24);
            radioButton1.TabIndex = 23;
            radioButton1.TabStop = true;
            radioButton1.Text = "Laki-laki";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(301, 270);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(104, 24);
            radioButton2.TabIndex = 24;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perempuan";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(171, 353);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(118, 35);
            button3.TabIndex = 26;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(173, 303);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(173, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // button7
            // 
            button7.Location = new Point(927, 75);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 28;
            button7.Text = "Export";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 600);
            ControlBox = false;
            Controls.Add(button7);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Dokter";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button7;
    }
}