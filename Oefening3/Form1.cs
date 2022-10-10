using System.Drawing;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertor_Click(object sender, EventArgs e)
        {


            if (tb_IRUPEES.Text != "")
            {
                double RupeesToUsd = double.Parse(tb_IRUPEES.Text) * 0.01;
                tb_USD.Text = RupeesToUsd.ToString();

            }

            else if (tb_ZFRANK.Text != "")
            {
                double FrankToUsd = double.Parse(tb_ZFRANK.Text) * 1.01;
                tb_USD.Text = FrankToUsd.ToString();


            }
            else if (tb_EURO.Text != "")
            {
                double EurToUsd = double.Parse(tb_EURO.Text) * 0.98;
                tb_USD.Text = EurToUsd.ToString();

            }
            else if (tb_JY.Text != "")
            {
                double ytd = double.Parse(tb_JY.Text) * 0.007;
                tb_USD.Text = ytd.ToString();

            }

            else if (tb_BP.Text != "")
            {
                double PoundToUsd = double.Parse(tb_BP.Text) * 1.11;
                tb_USD.Text = PoundToUsd.ToString();

            }

            if (tb_USD.Text != "")
            {

                USD dollar = new USD(double.Parse(tb_USD.Text));
                USD euro = new Euro(double.Parse(tb_USD.Text));
                USD franken = new Frank(double.Parse(tb_USD.Text));
                USD pounds = new Pounds(double.Parse(tb_USD.Text));
                USD yen = new JapaanseYen(double.Parse(tb_USD.Text));
                USD rupees = new Rupees(double.Parse(tb_USD.Text));

                tb_USD.Text = dollar.ToString();
                tb_EURO.Text = euro.ToString();
                tb_ZFRANK.Text = franken.ToString();
                tb_BP.Text = pounds.ToString();
                tb_JY.Text = yen.ToString();
                tb_IRUPEES.Text = rupees.ToString();
            }
        }
    }
}
