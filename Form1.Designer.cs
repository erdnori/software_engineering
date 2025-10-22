namespace gyak6
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            studentBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            orderBindingSource = new BindingSource(components);
            listBox3 = new ListBox();
            textbookBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textbookBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(597, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 360);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 402);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(256, 360);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(191, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(256, 402);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(191, 23);
            textBox6.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(502, 360);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(191, 23);
            textBox7.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 342);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 7;
            label1.Text = "Támogatás összérték";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 384);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 8;
            label2.Text = "Rendelések összértéke";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 342);
            label3.Name = "label3";
            label3.Size = new Size(159, 15);
            label3.TabIndex = 9;
            label3.Text = "Hallgató rendelésének értéke";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 384);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 10;
            label4.Text = "Támogatás forintonként";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 342);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 11;
            label5.Text = "Hallgatóra jutó támogatás";
            // 
            // listBox1
            // 
            listBox1.DataSource = studentBindingSource;
            listBox1.DisplayMember = "Name";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 274);
            listBox1.TabIndex = 12;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // listBox2
            // 
            listBox2.DataSource = orderBindingSource;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(242, 41);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(191, 274);
            listBox2.TabIndex = 13;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Models.Order);
            // 
            // listBox3
            // 
            listBox3.DataSource = textbookBindingSource;
            listBox3.DisplayMember = "Title";
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(597, 41);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(191, 274);
            listBox3.TabIndex = 14;
            // 
            // textbookBindingSource
            // 
            textbookBindingSource.DataSource = typeof(Models.Textbook);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)textbookBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private BindingSource studentBindingSource;
        private BindingSource orderBindingSource;
        private BindingSource textbookBindingSource;
    }
}
