namespace Project4
{
    partial class Form2
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(506, 220);
            this.txtResult.TabIndex = 0;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 238);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(122, 105);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.number_click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(140, 238);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(122, 105);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.number_click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(268, 238);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(122, 105);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.number_click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(396, 238);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(122, 105);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.operator_click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(396, 349);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(122, 105);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "+";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.operator_click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(268, 349);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(122, 105);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.number_click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(140, 349);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(122, 105);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.number_click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 349);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(122, 105);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.number_click);
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(396, 460);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(122, 105);
            this.btSub.TabIndex = 12;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.operator_click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(268, 460);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(122, 105);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.number_click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(140, 460);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 105);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.number_click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 460);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(122, 105);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.number_click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(396, 571);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(122, 105);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.equal_click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(140, 571);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(122, 105);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.number_click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 571);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 105);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clear_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 105);
            this.button1.TabIndex = 17;
            this.button1.Text = "Break";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.breack_click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 680);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResult);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}