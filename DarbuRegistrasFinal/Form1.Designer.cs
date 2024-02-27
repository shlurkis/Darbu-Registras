namespace DarbuRegistrasFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            menuStrip1 = new MenuStrip();
            infoToolStripMenuItem = new ToolStripMenuItem();
            instrukcijaToolStripMenuItem = new ToolStripMenuItem();
            kontaktaiToolStripMenuItem = new ToolStripMenuItem();
            button7 = new Button();
            button8 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(108, 30);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 0;
            button1.Text = "Darbai";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(204, 30);
            button2.Name = "button2";
            button2.Size = new Size(90, 29);
            button2.TabIndex = 1;
            button2.Text = "Šventės";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(300, 30);
            button3.Name = "button3";
            button3.Size = new Size(90, 29);
            button3.TabIndex = 2;
            button3.Text = "Kiti";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 65);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(378, 344);
            listBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(12, 417);
            button4.Name = "button4";
            button4.Size = new Size(130, 29);
            button4.TabIndex = 4;
            button4.Text = "Pridėti";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(260, 417);
            button5.Name = "button5";
            button5.Size = new Size(130, 29);
            button5.TabIndex = 5;
            button5.Text = "Ištrinti";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 30);
            button6.Name = "button6";
            button6.Size = new Size(90, 29);
            button6.TabIndex = 6;
            button6.Text = "Visi";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(405, 112);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 7;
            label1.Text = "Aprašymas:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(405, 135);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(309, 274);
            textBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 10;
            label2.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 59);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 12;
            label3.Text = "Sritis:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(405, 82);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(137, 27);
            textBox2.TabIndex = 13;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(725, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { instrukcijaToolStripMenuItem, kontaktaiToolStripMenuItem });
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(49, 24);
            infoToolStripMenuItem.Text = "Info";
            // 
            // instrukcijaToolStripMenuItem
            // 
            instrukcijaToolStripMenuItem.Name = "instrukcijaToolStripMenuItem";
            instrukcijaToolStripMenuItem.Size = new Size(158, 26);
            instrukcijaToolStripMenuItem.Text = "Instrukcija";
            instrukcijaToolStripMenuItem.Click += instrukcijaToolStripMenuItem_Click;
            // 
            // kontaktaiToolStripMenuItem
            // 
            kontaktaiToolStripMenuItem.Name = "kontaktaiToolStripMenuItem";
            kontaktaiToolStripMenuItem.Size = new Size(158, 26);
            kontaktaiToolStripMenuItem.Text = "Kontaktai";
            kontaktaiToolStripMenuItem.Click += kontaktaiToolStripMenuItem_Click;
            // 
            // button7
            // 
            button7.Location = new Point(620, 417);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 16;
            button7.Text = "Redaguoti";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(520, 417);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 17;
            button8.Text = "Išsaugoti";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(505, 32);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(209, 27);
            textBox4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 35);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 19;
            label4.Text = "Pavadinimas:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Darbas", "Šventė", "Kita" });
            comboBox1.Location = new Point(577, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 28);
            comboBox1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 458);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Darbu Registras";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem instrukcijaToolStripMenuItem;
        private ToolStripMenuItem kontaktaiToolStripMenuItem;
        private Button button7;
        private Button button8;
        private TextBox textBox4;
        private Label label4;
        private ComboBox comboBox1;
    }
}
