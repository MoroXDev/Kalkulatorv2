namespace Kalkulatorv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a_parsed = double.TryParse(textBox1.Text, out double a);
            bool b_parsed = double.TryParse(textBox2.Text, out double b);

            if (!a_parsed || (!b_parsed && textBox2.Visible))
            {
                MessageBox.Show("Nie wpisa³eœ poprawnie cyfr!");
                return;
            }

            switch (wzory.SelectedItem)
            {
                //Pola
                case "Prostok¹t_Pole":
                    wynik.Text = "wynik: " + Prostokat_Pole(a, b);

                    break;
                case "Trójk¹t_Pole":
                    wynik.Text = "wynik: " + Trojkat_Pole(b, a);
                    break;

                case "Ko³o_Pole":
                    wynik.Text = "wynik: " + Kolo_Pole(a);
                    break;

                case "Kwadrat_Pole":
                    wynik.Text = "wynik: " + Kwadrat_Pole(a);
                    break;
                //Obwody
                case "Prostok¹t_Obwód":
                    wynik.Text = "wynik: " + Prostokat_Obwod(a, b);
                    break;

                case "Ko³o_Obwód":
                    wynik.Text = "wynik: " + Kolo_Obwod(a);
                    break;

                case "Kwadrat_Obwód":
                    wynik.Text = "wynik: " + Kwadrat_Obwod(a);
                    break;
                default:
                    MessageBox.Show("Nie wybra³eœ wzoru!");
                    break;
            }
        }

        double Prostokat_Pole(double a, double b)
        {
            return a * b;
        }
        double Prostokat_Obwod(double a, double b)
        {
            return 2 * a + 2 * b;
        }

        double Trojkat_Pole(double a, double h)
        {
            return (a * h) / 2;
        }

        double Kwadrat_Pole(double a)
        {
            return a * a;
        }
        double Kwadrat_Obwod(double a)
        {
            return 4 * a;
        }

        double Kolo_Pole(double r)
        {
            return Math.PI * r * r;
        }

        double Kolo_Obwod(double r)
        {
            return 2 * Math.PI * r;
        }

        private void wzory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (wzory.SelectedItem)
            {
                case "Prostok¹t_Pole":
                case "Prostok¹t_Obwód":
                    label1.Text = "Bok1";
                    label2.Text = "Bok2";
                    label1.Show();
                    label2.Show();
                    textBox1.Show();
                    textBox2.Show();

                    break;
                case "Trójk¹t_Pole":
                case "Trójk¹t_Obwód":
                    label1.Text = "Wysokoœæ";
                    label2.Text = "Podstawa";
                    label1.Show();
                    label2.Show();
                    textBox1.Show();
                    textBox2.Show();
                    break;

                case "Ko³o_Pole":
                case "Ko³o_Obwód":
                    label1.Text = "Promieñ";
                    label1.Show();
                    label2.Hide();
                    textBox1.Show();
                    textBox2.Hide();
                    break;

                case "Kwadrat_Pole":
                case "Kwadrat_Obwód":
                    label1.Text = "Bok";
                    label1.Show();
                    label2.Hide();
                    textBox1.Show();
                    textBox2.Hide();
                    break;

            }
        }
    }
}
