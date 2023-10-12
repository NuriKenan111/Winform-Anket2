namespace Anket2
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
            panel1 = new Panel();
            button3 = new Button();
            pic1 = new DateTimePicker();
            label6 = new Label();
            button2 = new Button();
            phone = new TextBox();
            email = new TextBox();
            surname = new TextBox();
            name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pic1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(phone);
            panel1.Controls.Add(email);
            panel1.Controls.Add(surname);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(12, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 334);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(248, 295);
            button3.Name = "button3";
            button3.Size = new Size(90, 31);
            button3.TabIndex = 14;
            button3.Text = "Change";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pic1
            // 
            pic1.Location = new Point(88, 196);
            pic1.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            pic1.MinDate = new DateTime(1975, 12, 31, 0, 0, 0, 0);
            pic1.Name = "pic1";
            pic1.Size = new Size(191, 23);
            pic1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 204);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 12;
            label6.Text = "Datetime";
            // 
            // button2
            // 
            button2.Location = new Point(562, 333);
            button2.Name = "button2";
            button2.Size = new Size(90, 31);
            button2.TabIndex = 11;
            button2.Text = "Load";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // phone
            // 
            phone.Location = new Point(88, 149);
            phone.Name = "phone";
            phone.Size = new Size(184, 23);
            phone.TabIndex = 9;
            // 
            // email
            // 
            email.Location = new Point(88, 107);
            email.Name = "email";
            email.Size = new Size(184, 23);
            email.TabIndex = 7;
            // 
            // surname
            // 
            surname.Location = new Point(88, 61);
            surname.Name = "surname";
            surname.Size = new Size(184, 23);
            surname.TabIndex = 6;
            // 
            // name
            // 
            name.Location = new Point(88, 22);
            name.Name = "name";
            name.Size = new Size(184, 23);
            name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 149);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 157);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 107);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(456, 333);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(456, 30);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(196, 289);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 388);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private TextBox phone;
        private TextBox email;
        private TextBox surname;
        private TextBox name;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private DateTimePicker pic1;
        private Label label6;
        private Button button3;
    }
}