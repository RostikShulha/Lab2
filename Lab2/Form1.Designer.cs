namespace Lab2
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
            ZavdA = new Button();
            ZavdB = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            richTextBox2 = new RichTextBox();
            buttonSpace = new Button();
            SuspendLayout();
            // 
            // ZavdA
            // 
            ZavdA.Location = new Point(114, 47);
            ZavdA.Name = "ZavdA";
            ZavdA.Size = new Size(171, 44);
            ZavdA.TabIndex = 0;
            ZavdA.Text = "Завдання А";
            ZavdA.UseVisualStyleBackColor = true;
            ZavdA.Click += ZavdA_Click;
            // 
            // ZavdB
            // 
            ZavdB.Location = new Point(409, 47);
            ZavdB.Name = "ZavdB";
            ZavdB.Size = new Size(171, 44);
            ZavdB.TabIndex = 1;
            ZavdB.Text = "Завдання Б";
            ZavdB.UseVisualStyleBackColor = true;
            ZavdB.Click += ZavdB_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(51, 160);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(608, 89);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 134);
            label1.Name = "label1";
            label1.Size = new Size(308, 20);
            label1.TabIndex = 3;
            label1.Text = "Оберіть завдання, яке необхідно виконати";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 329);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Результат:";
            // 
            // button1
            // 
            button1.Location = new Point(191, 275);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 253);
            label3.Name = "label3";
            label3.Size = new Size(213, 20);
            label3.TabIndex = 6;
            label3.Text = "Число, яке необхідно знайти:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(51, 276);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(51, 352);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(608, 89);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // buttonSpace
            // 
            buttonSpace.Location = new Point(51, 271);
            buttonSpace.Name = "buttonSpace";
            buttonSpace.Size = new Size(319, 37);
            buttonSpace.TabIndex = 9;
            buttonSpace.Text = "Прибрати зайві пробіли";
            buttonSpace.UseVisualStyleBackColor = true;
            buttonSpace.Click += buttonSpace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 504);
            Controls.Add(buttonSpace);
            Controls.Add(richTextBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(ZavdB);
            Controls.Add(ZavdA);
            Name = "Form1";
            Text = "Lab 2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ZavdA;
        private Button ZavdB;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox2;
        private Button buttonSpace;
    }
}
