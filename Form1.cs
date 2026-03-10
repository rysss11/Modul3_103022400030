namespace Modul3_103022400030
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            if (!double.TryParse(textBox1.Text, out double value))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string dari = comboBox1.SelectedItem.ToString().Trim();
            string ke = comboBox2.SelectedItem.ToString().Trim();

            double celcius = KeCelcius(value, dari);
            double hasil = DariCelcius(celcius, ke);
            textBox2.Text = hasil.ToString();
        }

        private double KeCelcius(double value, string satuan)
        {
            switch (satuan)
            {
                case "Celcius": return value;

                case "Fahrenheit": return (value - 32) * 5 / 9;

                case "Reamur": return value * 5 / 4;

                case "Kelvin": return value - 273.15;

                default: return value;
            }
        }

        private double DariCelcius(double value, string satuan)
        {
            switch (satuan)
            {
                case "Celcius": return value;

                case "Fahrenheit": return (value * 9 / 5) + 32;

                case "Reamur": return value * 4 / 5;

                case "Kelvin": return value + 273.15;

                default: return value;
            }
        }
    }
}
