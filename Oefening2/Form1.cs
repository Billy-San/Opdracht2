namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Sound_Click(object sender, EventArgs e)
        {

            Cow cowie = new Cow(225);
            Snake snakie = new Snake(25);
            Pig piggie = new Pig(95);

            if (Cow.Checked)
            {
                MessageBox.Show(cowie.ToString());
            }
            if (Snake.Checked)
            {
                MessageBox.Show(snakie.ToString());
            }
            if (Pig.Checked)
            {
                MessageBox.Show(piggie.ToString());
            }
        }
    }
}