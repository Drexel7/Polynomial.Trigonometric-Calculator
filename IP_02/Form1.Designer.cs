
namespace IP_02
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(60, 42);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(162, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ecuatie polinomiala";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(60, 182);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(181, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Ecuatie trigonometrica";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 81);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 2;
            label1.Text = "x²+";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(197, 81);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 3;
            label2.Text = "x +";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 106);
            label3.Name = "label3";
            label3.Size = new Size(31, 20);
            label3.TabIndex = 4;
            label3.Text = "= 0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 231);
            label4.Name = "label4";
            label4.Size = new Size(19, 20);
            label4.TabIndex = 5;
            label4.Text = "=";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 23);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 6;
            label5.Text = "Solutie:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 27);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(264, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(54, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(179, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 27);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(29, 60);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(286, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "sin(x)", "cos(x)", "tan(x)" });
            comboBox1.Location = new Point(60, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 28);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(455, 123);
            button1.Name = "button1";
            button1.Size = new Size(112, 53);
            button1.TabIndex = 13;
            button1.Text = "Calculează";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 213);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 14;
            button2.Text = "Despre";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(455, 294);
            button3.Name = "button3";
            button3.Size = new Size(112, 43);
            button3.TabIndex = 15;
            button3.Text = "Iesire";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 151);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Location = new Point(31, 170);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 131);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Location = new Point(31, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(400, 131);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Calculator Ecuație Poli/Trig";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}

