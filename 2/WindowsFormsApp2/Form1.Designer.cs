namespace Individual_Assignment_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.class_a_input = new System.Windows.Forms.TextBox();
            this.class_b_input = new System.Windows.Forms.TextBox();
            this.class_c_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.all_output = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.class_c_output = new System.Windows.Forms.TextBox();
            this.class_b_output = new System.Windows.Forms.TextBox();
            this.class_a_output = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculatebtn
            // 
            this.calculatebtn.Location = new System.Drawing.Point(9, 247);
            this.calculatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(169, 47);
            this.calculatebtn.TabIndex = 0;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(190, 247);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(152, 47);
            this.clearbtn.TabIndex = 1;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(354, 247);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(154, 47);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // class_a_input
            // 
            this.class_a_input.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.class_a_input.Location = new System.Drawing.Point(57, 29);
            this.class_a_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_a_input.Name = "class_a_input";
            this.class_a_input.Size = new System.Drawing.Size(76, 20);
            this.class_a_input.TabIndex = 3;
            this.class_a_input.TextChanged += new System.EventHandler(this.class_a_input_TextChanged);
            // 
            // class_b_input
            // 
            this.class_b_input.Location = new System.Drawing.Point(57, 52);
            this.class_b_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_b_input.Name = "class_b_input";
            this.class_b_input.Size = new System.Drawing.Size(76, 20);
            this.class_b_input.TabIndex = 4;
            this.class_b_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // class_c_input
            // 
            this.class_c_input.Location = new System.Drawing.Point(57, 75);
            this.class_c_input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_c_input.Name = "class_c_input";
            this.class_c_input.Size = new System.Drawing.Size(76, 20);
            this.class_c_input.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.class_a_input);
            this.groupBox1.Controls.Add(this.class_b_input);
            this.groupBox1.Controls.Add(this.class_c_input);
            this.groupBox1.Location = new System.Drawing.Point(37, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(169, 136);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets sold";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class C:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Class B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Class A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.all_output);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.class_c_output);
            this.groupBox2.Controls.Add(this.class_b_output);
            this.groupBox2.Controls.Add(this.class_a_output);
            this.groupBox2.Location = new System.Drawing.Point(266, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(192, 136);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Revenue generated";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // all_output
            // 
            this.all_output.Location = new System.Drawing.Point(54, 112);
            this.all_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.all_output.Name = "all_output";
            this.all_output.ReadOnly = true;
            this.all_output.Size = new System.Drawing.Size(76, 20);
            this.all_output.TabIndex = 9;
            this.all_output.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Class C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class A:";
            // 
            // class_c_output
            // 
            this.class_c_output.Location = new System.Drawing.Point(54, 84);
            this.class_c_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_c_output.Name = "class_c_output";
            this.class_c_output.ReadOnly = true;
            this.class_c_output.Size = new System.Drawing.Size(76, 20);
            this.class_c_output.TabIndex = 2;
            // 
            // class_b_output
            // 
            this.class_b_output.Location = new System.Drawing.Point(54, 59);
            this.class_b_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_b_output.Name = "class_b_output";
            this.class_b_output.ReadOnly = true;
            this.class_b_output.Size = new System.Drawing.Size(76, 20);
            this.class_b_output.TabIndex = 1;
            // 
            // class_a_output
            // 
            this.class_a_output.Location = new System.Drawing.Point(56, 29);
            this.class_a_output.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.class_a_output.Name = "class_a_output";
            this.class_a_output.ReadOnly = true;
            this.class_a_output.Size = new System.Drawing.Size(76, 20);
            this.class_a_output.TabIndex = 0;
            this.class_a_output.TextChanged += new System.EventHandler(this.class_a_output_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.calculatebtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox class_a_input;
        private System.Windows.Forms.TextBox class_b_input;
        private System.Windows.Forms.TextBox class_c_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox class_c_output;
        private System.Windows.Forms.TextBox class_b_output;
        private System.Windows.Forms.TextBox class_a_output;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox all_output;
    }
}

