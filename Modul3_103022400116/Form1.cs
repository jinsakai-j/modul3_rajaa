namespace Modul3_103022400116
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(textBox1.Text, out double num1)) 
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;

            }else if(comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            string dariSuhu = comboBox1.SelectedItem?.ToString();
            string keSuhu = comboBox2.SelectedItem?.ToString();
            double hasil = 0;

            double celcius = 0;
            switch (dariSuhu)
            {
                case "Celcius":
                    celcius = num1;
                    break;
                case "Fahrenheit":
                    celcius = (num1 - 32) * 5 / 9;
                    break;
                case "Kelvin":
                    celcius = num1 - 273.15;
                    break;
                case "Reamur":
                    celcius = num1 * 5 / 4;
                    break;
            }

            switch (keSuhu)
            {
                case "Celcius":
                    hasil = celcius;
                    break;
                case "Fahrenheit":
                    hasil = (celcius * 9 / 5) + 32;
                    break;
                case "Kelvin":
                    hasil = celcius + 273.15;
                    break;
                case "Reamur":
                    hasil = celcius * 4 / 5;
                    break;
            }

            textBox2.Text = hasil.ToString();
        }
    }
}
