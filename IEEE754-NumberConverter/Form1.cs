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

            if(sign.Checked) { binaryString += "1"; } else { binaryString += "0"; }

            for (int i = 0; i < 8; i++)
            {
                if(exponentCheckBoxes[i].Checked) { binaryString += "1"; } else { binaryString += "0"; }

            }

            for (int i = 0; i < 23; i++)
            {
                if (mantissaCheckBoxes[i].Checked) { binaryString += "1"; } else { binaryString += "0"; }
            }

            uint uintValue = Convert.ToUInt32(binaryString, 2); // Binary stringi UInt32'ye dönüþtür
            byte[] bytes = BitConverter.GetBytes(uintValue); // UInt32'yi byte dizisine dönüþtür
            float floatValue = BitConverter.ToSingle(bytes, 0); // Byte dizisini float'a dönüþtür

            this.floatNumber.Text = floatValue.ToString();
            this.label16.Text = binaryString;
        }
    }
}
