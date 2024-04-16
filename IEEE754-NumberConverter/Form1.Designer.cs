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
            signEncoded = new Label();
            signValue = new Label();
            label1 = new Label();
            mantissaPanel = new Panel();
            label7 = new Label();
            mantissaValue = new Label();
            mantissaEncoded = new Label();
            exponentPanel = new Panel();
            label4 = new Label();
            exponentValue = new Label();
            exponentEncoded = new Label();
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
            signPanel.Controls.Add(signEncoded);
            signPanel.Controls.Add(signValue);
            signPanel.Controls.Add(label1);
            signPanel.Location = new Point(164, 40);
            signPanel.Name = "signPanel";
            signPanel.Size = new Size(76, 169);
            signPanel.TabIndex = 27;
            // 
            // signEncoded
            // 
            signEncoded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            signEncoded.Location = new Point(0, 84);
            signEncoded.Name = "signEncoded";
            signEncoded.Size = new Size(76, 25);
            signEncoded.TabIndex = 0;
            signEncoded.Text = "0";
            signEncoded.TextAlign = ContentAlignment.TopCenter;
            // 
            // signValue
            // 
            signValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            signValue.Location = new Point(0, 44);
            signValue.Name = "signValue";
            signValue.Size = new Size(76, 25);
            signValue.TabIndex = 1;
            signValue.Text = "+1";
            signValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 35);
            label1.TabIndex = 2;
            label1.Text = "Sign";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // mantissaPanel
            // 
            mantissaPanel.BackColor = Color.FromArgb(255, 192, 128);
            mantissaPanel.Controls.Add(label7);
            mantissaPanel.Controls.Add(mantissaValue);
            mantissaPanel.Controls.Add(mantissaEncoded);
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
            label7.TabIndex = 0;
            label7.Text = "Mantissa";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // mantissaValue
            // 
            mantissaValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mantissaValue.Location = new Point(0, 44);
            mantissaValue.Name = "mantissaValue";
            mantissaValue.Size = new Size(625, 25);
            mantissaValue.TabIndex = 1;
            mantissaValue.Text = "0";
            mantissaValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // mantissaEncoded
            // 
            mantissaEncoded.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            mantissaEncoded.Location = new Point(0, 84);
            mantissaEncoded.Name = "mantissaEncoded";
            mantissaEncoded.Size = new Size(625, 25);
            mantissaEncoded.TabIndex = 2;
            mantissaEncoded.Text = "0";
            mantissaEncoded.TextAlign = ContentAlignment.TopCenter;
            // 
            // exponentPanel
            // 
            exponentPanel.BackColor = Color.FromArgb(128, 255, 128);
            exponentPanel.Controls.Add(label4);
            exponentPanel.Controls.Add(exponentValue);
            exponentPanel.Controls.Add(exponentEncoded);
            exponentPanel.Location = new Point(240, 40);
            exponentPanel.Name = "exponentPanel";
            exponentPanel.Size = new Size(255, 169);
            exponentPanel.TabIndex = 26;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(255, 35);
            label4.TabIndex = 0;
            label4.Text = "Exponent";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // exponentValue
            // 
            exponentValue.Font = new Font("Segoe UI", 12F);
            exponentValue.Location = new Point(0, 44);
            exponentValue.Name = "exponentValue";
            exponentValue.Size = new Size(255, 25);
            exponentValue.TabIndex = 1;
            exponentValue.Text = "2^(-126)";
            exponentValue.TextAlign = ContentAlignment.TopCenter;
            // 
            // exponentEncoded
            // 
            exponentEncoded.Font = new Font("Segoe UI", 12F);
            exponentEncoded.Location = new Point(0, 84);
            exponentEncoded.Name = "exponentEncoded";
            exponentEncoded.Size = new Size(255, 25);
            exponentEncoded.TabIndex = 2;
            exponentEncoded.Text = "0";
            exponentEncoded.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label13.Location = new Point(25, 84);
            label13.Name = "label13";
            label13.Size = new Size(76, 35);
            label13.TabIndex = 25;
            label13.Text = "Value :";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label14.Location = new Point(25, 124);
            label14.Name = "label14";
            label14.Size = new Size(133, 35);
            label14.TabIndex = 24;
            label14.Text = "Encoded as :";
            label14.TextAlign = ContentAlignment.TopCenter;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(25, 165);
            label15.Name = "label15";
            label15.Size = new Size(87, 35);
            label15.TabIndex = 23;
            label15.Text = "Binary :";
            label15.TextAlign = ContentAlignment.TopCenter;
            // 
            // Calculate
            // 
            Calculate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Calculate.Location = new Point(507, 262);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(176, 51);
            Calculate.TabIndex = 22;
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
            label10.TabIndex = 21;
            label10.Text = "Binary Representation :";
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(25, 426);
            label11.Name = "label11";
            label11.Size = new Size(272, 32);
            label11.TabIndex = 20;
            label11.Text = "Value actually stored in float :";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(316, 380);
            label16.Name = "label16";
            label16.Size = new Size(255, 25);
            label16.TabIndex = 19;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            signPanel.ResumeLayout(false);
            mantissaPanel.ResumeLayout(false);
            exponentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion


        private void formload()
        {
            label1 = new Label();
            label11 = new Label();
            label10 = new Label();
            label4 = new Label();
            label7 = new Label();

            signPanel.SuspendLayout();
            mantissaPanel.SuspendLayout();
            exponentPanel.SuspendLayout();
            SuspendLayout();


            // 
            // signCheckBox
            // 
            signCheckBox = new CheckBox();
            signCheckBox.AutoSize = true;
            signCheckBox.Location = new Point(30, 138);
            signCheckBox.Name = "sign";
            signCheckBox.Size = new Size(18, 17);
            signCheckBox.UseVisualStyleBackColor = true;
            signPanel.Controls.Add(signCheckBox);

            // 
            // exponentCheckBoxes
            // 
            exponentCheckBoxes = new CheckBox[8];
            for (int i = 0; i < 8; i++)
            {
                exponentCheckBoxes[i] = new CheckBox();
                exponentCheckBoxes[i].Location = new Point(30 + i * 25, 135);
                exponentCheckBoxes[i].Size = new Size(18, 17);
                exponentPanel.Controls.Add(exponentCheckBoxes[i]);
            }

            // 
            // mantissaCheckBoxes
            // 
            mantissaCheckBoxes = new CheckBox[23];
            for (int i = 0; i < 23; i++)
            {
                mantissaCheckBoxes[i] = new CheckBox();
                mantissaCheckBoxes[i].Location = new Point(30 + i * 25, 135);
                mantissaCheckBoxes[i].Size = new Size(18, 17);
                mantissaPanel.Controls.Add(mantissaCheckBoxes[i]);
            }

        }

        private Panel signPanel;
        private Panel mantissaPanel;
        private Panel exponentPanel;


        private CheckBox signCheckBox;
        private CheckBox[] exponentCheckBoxes;
        private CheckBox[] mantissaCheckBoxes;
        private Label label11;

        private Label label1;
        private Label signValue;
        private Label signEncoded;
        private Label label4;
        private Label exponentValue;
        private Label exponentEncoded;
        private Label label7;
        private Label mantissaValue;
        private Label mantissaEncoded;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label15;

        private Button Calculate;
        private Label floatNumber;
        private Label label16;
    }

}
