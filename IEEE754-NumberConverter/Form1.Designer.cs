namespace IEEE754_NumberConverter
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
            signPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mantissaPanel = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            exponentPanel = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            Calculate = new Button();
            label10 = new Label();
            label11 = new Label();
            label16 = new Label();
            floatNumber = new Label();
            signPanel.SuspendLayout();
            mantissaPanel.SuspendLayout();
            exponentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // signPanel
            // 
            signPanel.BackColor = Color.Lavender;
            signPanel.Controls.Add(label3);
            signPanel.Controls.Add(label2);
            signPanel.Controls.Add(label1);
            signPanel.Location = new Point(164, 40);
            signPanel.Name = "signPanel";
            signPanel.Size = new Size(76, 169);
            signPanel.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(0, 84);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 11;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 44);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 10;
            label2.Text = "+1";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 35);
            label1.TabIndex = 9;
            label1.Text = "Sign";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // mantissaPanel
            // 
            mantissaPanel.BackColor = Color.FromArgb(255, 192, 128);
            mantissaPanel.Controls.Add(label7);
            mantissaPanel.Controls.Add(label8);
            mantissaPanel.Controls.Add(label9);
            mantissaPanel.Location = new Point(495, 40);
            mantissaPanel.Name = "mantissaPanel";
            mantissaPanel.Size = new Size(625, 169);
            mantissaPanel.TabIndex = 1;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(625, 35);
            label7.TabIndex = 14;
            label7.Text = "Mantissa";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(0, 44);
            label8.Name = "label8";
            label8.Size = new Size(625, 25);
            label8.TabIndex = 13;
            label8.Text = "0";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(0, 84);
            label9.Name = "label9";
            label9.Size = new Size(625, 25);
            label9.TabIndex = 12;
            label9.Text = "0";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // exponentPanel
            // 
            exponentPanel.BackColor = Color.FromArgb(128, 255, 128);
            exponentPanel.Controls.Add(label4);
            exponentPanel.Controls.Add(label5);
            exponentPanel.Controls.Add(label6);
            exponentPanel.Location = new Point(240, 40);
            exponentPanel.Name = "exponentPanel";
            exponentPanel.Size = new Size(255, 169);
            exponentPanel.TabIndex = 0;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(255, 35);
            label4.TabIndex = 14;
            label4.Text = "Exponent";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(0, 44);
            label5.Name = "label5";
            label5.Size = new Size(255, 25);
            label5.TabIndex = 13;
            label5.Text = "2^(-126)";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(0, 84);
            label6.Name = "label6";
            label6.Size = new Size(255, 25);
            label6.TabIndex = 12;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(25, 84);
            label13.Name = "label13";
            label13.Size = new Size(76, 35);
            label13.TabIndex = 10;
            label13.Text = "Value :";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(25, 124);
            label14.Name = "label14";
            label14.Size = new Size(133, 35);
            label14.TabIndex = 11;
            label14.Text = "Encoded as :";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(25, 165);
            label15.Name = "label15";
            label15.Size = new Size(87, 35);
            label15.TabIndex = 12;
            label15.Text = "Binary :";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Calculate.Location = new Point(507, 262);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(176, 51);
            Calculate.TabIndex = 13;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(25, 380);
            label10.Name = "label10";
            label10.Size = new Size(255, 34);
            label10.TabIndex = 14;
            label10.Text = "Binary Representation :";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(25, 426);
            label11.Name = "label11";
            label11.Size = new Size(272, 32);
            label11.TabIndex = 15;
            label11.Text = "Value actually stored in float :";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(316, 380);
            label16.Name = "label16";
            label16.Size = new Size(255, 25);
            label16.TabIndex = 17;
            label16.Text = "...";
            // 
            // floatNumber
            // 
            floatNumber.Font = new Font("Segoe UI", 12F);
            floatNumber.Location = new Point(316, 426);
            floatNumber.Name = "floatNumber";
            floatNumber.Size = new Size(255, 25);
            floatNumber.TabIndex = 18;
            floatNumber.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 530);
            Controls.Add(floatNumber);
            Controls.Add(label16);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Calculate);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(exponentPanel);
            Controls.Add(mantissaPanel);
            Controls.Add(signPanel);
            Name = "Form1";
            Text = "Form1";
            signPanel.ResumeLayout(false);
            mantissaPanel.ResumeLayout(false);
            exponentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        public Panel signPanel;
        public Panel mantissaPanel;
        public Panel exponentPanel;


        public CheckBox sign;
        public CheckBox[] exponentCheckBoxes;
        public CheckBox[] mantissaCheckBoxes;
        public Label label11;


        public void formload()
        {

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            signPanel.SuspendLayout();
            mantissaPanel.SuspendLayout();
            exponentPanel.SuspendLayout();
            SuspendLayout();

            this.sign = new CheckBox();
            this.exponentCheckBoxes = new CheckBox[8];
            this.mantissaCheckBoxes = new CheckBox[23];

            // 
            // sign
            // 
            sign.AutoSize = true;
            sign.Location = new Point(30, 138);
            sign.Name = "sign";
            sign.Size = new Size(18, 17);
            sign.UseVisualStyleBackColor = true;
            signPanel.Controls.Add(sign);

            for (int i = 0; i < 8; i++)
            {
                exponentCheckBoxes[i] = new CheckBox();
                exponentCheckBoxes[i].Location = new Point(30 + i * 25, 135);
                exponentCheckBoxes[i].Size = new Size(18, 17);

                exponentPanel.Controls.Add(exponentCheckBoxes[i]);
            }

            for (int i = 0; i < 23; i++)
            {
                mantissaCheckBoxes[i] = new CheckBox();
                mantissaCheckBoxes[i].Location = new Point(30 + i * 25, 135);
                mantissaCheckBoxes[i].Size = new Size(18, 17);

                mantissaPanel.Controls.Add(mantissaCheckBoxes[i]);
            }

            



            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(17, 87);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.Text = "Value :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 126);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.Text = "Encoded as :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(17, 167);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.Text = "Binary :";




            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(8, 0);
            label4.Name = "label4";
            label4.Size = new Size(signPanel.Width, 28);
            label4.Text = "Sign";
            label5.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // label5
            // 
            label5.Location = new Point(signPanel.Width, 86);
            label5.Name = "label5";
            label5.Size = new Size(signPanel.Width, 20);
            label5.Text = "L";
            label5.TextAlign = ContentAlignment.MiddleCenter;




            
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label15;

        private Button Calculate;
        private Label floatNumber;
        private Label label16;

    }




}
