namespace CalculatorApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fnumbox = new TextBox();
            snumbox = new TextBox();
            operationbox = new ComboBox();
            answertext = new Label();
            calculatebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter first number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(8, 66);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter second number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(95, 98);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "Answer:";
            // 
            // fnumbox
            // 
            fnumbox.Location = new Point(178, 12);
            fnumbox.Name = "fnumbox";
            fnumbox.Size = new Size(192, 23);
            fnumbox.TabIndex = 3;
            // 
            // snumbox
            // 
            snumbox.Location = new Point(178, 65);
            snumbox.Name = "snumbox";
            snumbox.Size = new Size(192, 23);
            snumbox.TabIndex = 4;
            // 
            // operationbox
            // 
            operationbox.FormattingEnabled = true;
            operationbox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operationbox.Location = new Point(211, 39);
            operationbox.Name = "operationbox";
            operationbox.Size = new Size(121, 23);
            operationbox.TabIndex = 6;
            // 
            // answertext
            // 
            answertext.AutoSize = true;
            answertext.Font = new Font("Segoe UI", 12F);
            answertext.Location = new Point(178, 98);
            answertext.Name = "answertext";
            answertext.Size = new Size(28, 21);
            answertext.TabIndex = 8;
            answertext.Text = "00";
            // 
            // calculatebtn
            // 
            calculatebtn.Font = new Font("Segoe UI", 12F);
            calculatebtn.Location = new Point(230, 137);
            calculatebtn.Name = "calculatebtn";
            calculatebtn.Size = new Size(91, 28);
            calculatebtn.TabIndex = 9;
            calculatebtn.Text = "Calculate";
            calculatebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculatebtn);
            Controls.Add(answertext);
            Controls.Add(operationbox);
            Controls.Add(snumbox);
            Controls.Add(fnumbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox fnumbox;
        private TextBox snumbox;
        private ComboBox operationbox;
        private Label answertext;
        private Button calculatebtn;
    }
}
