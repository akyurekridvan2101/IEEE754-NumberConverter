namespace IEEE754_NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formload();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            string binaryString = "";

            if(signCheckBox.Checked) { binaryString += "1"; } else { binaryString += "0"; }

            for (int i = 0; i < 8; i++)
                if(exponentCheckBoxes[i].Checked) { binaryString += "1"; } else { binaryString += "0"; }

            for (int i = 0; i < 23; i++)
                if (mantissaCheckBoxes[i].Checked) { binaryString += "1"; } else { binaryString += "0"; }

            ConvertToFloat(binaryString);
            this.label16.Text = binaryString;
        }

        private void ConvertToFloat(string binaryString)
        {
            string floatValue = "";

            if (binaryString[0] == '1') { floatValue += "-"; signValue.Text = "-1"; signEncoded.Text = "1";  } else { floatValue += "+"; }

            int exponent = 0;

            for(int i = 1 , j = 7; i < 9; i++ , j--)
            {
                if (binaryString[i] == '1')
                    exponent += (int)Math.Pow(2, j);
            }

            exponent -= 127;

            exponentValue.Text = "2^(" + exponent.ToString() + ")";
            exponentEncoded.Text = (exponent + 127).ToString();

            float mantissa = 1;

            for(int i = 9; i < 32; i++)
            {
                if (binaryString[i] == '1')
                    mantissa += (float)Math.Pow(2, (-i + 8));
            }

            mantissaValue.Text = "1 + " + (mantissa - 1).ToString();

            long mantissaEncodedValue = 0;
            for(int i = 31; i > 8; i--)
            {
                if (binaryString[i] == '1')
                    mantissaEncodedValue += (long)Math.Pow(2, (31 - i));
            }

            mantissaEncoded.Text = mantissaEncodedValue.ToString();

            floatValue += Convert.ToString((float)Math.Pow(2, exponent) * mantissa);
            floatNumber.Text = floatValue;
        }
    }
}
