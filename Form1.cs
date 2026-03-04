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
            if (double.TryParse(textBox1.Text, out double a))
            {
                if (double.TryParse(textBox2.Text, out double b))
                {

                    switch (wzory.SelectedItem)
                    {
                        //Pola
                        case "Prostokat_Pole":
                            wynik.Text = "wynik: " + Prostokat_Pole(a, b);

                            break;
                        case "Trojkat_Pole":
                            wynik.Text = "wynik: " + Trojkat_Pole(b, a);
                            break;

                        case "Kolo_Pole":
                            wynik.Text = "wynik: " + Kolo_Pole(a);
                            break;

                        case "Kwadrat_Pole":
                            wynik.Text = "wynik: " + Kwadrat_Pole(a);
                            break;
                        //Obwody
                        case "Prostokat_Obwod":
                            wynik.Text = "wynik: " + Prostokat_Obwod(a, b);
                            break;

                        case "Kolo_Obwod":
                            wynik.Text = "wynik: " + Kolo_Obwod(a);
                            break;

                        case "Kwadrat_Obwod":
                            wynik.Text = "wynik: " + Kwadrat_Obwod(a);
                            break;
                        default:
                            MessageBox.Show("Nie wybra³eœ wzoru!");
                            break;

                    }
                    return;
                }
            }
            MessageBox.Show("Nie wpisa³eœ tylko cyfr!");
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
                case "Prostokat_Pole":
                case "Prostokat_Obwod":
                    label1.Text = "Bok1";
                    label2.Text = "Bok2";
                    label1.Show();
                    label2.Show();
                    textBox1.Show();
                    textBox2.Show();

                    break;
                case "Trojkat_Pole":
                case "Trojkat_Obwod":
                    label1.Text = "Wysokoœæ";
                    label2.Text = "Podstawa";
                    label1.Show();
                    label2.Show();
                    textBox1.Show();
                    textBox2.Show();
                    break;

                case "Kolo_Pole":
                case "Kolo_Obwod":
                    label1.Text = "Promieñ";
                    label1.Show();
                    label2.Hide();
                    textBox1.Show();
                    textBox2.Hide();
                    break;

                case "Kwadrat_Pole":
                case "Kwadrat_Obwod":
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
