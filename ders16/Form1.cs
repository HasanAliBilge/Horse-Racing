namespace ders16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int uzakl�k1, uzakl�k2, uzakl�k3;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label11.Text);
            derece++;
            double saniye = (derece * 3) / 100;
            label11.Text = derece.ToString();
            label12.Text = saniye.ToString();
            label11.Visible = false;


            int geni�lik1 = pictureBox1.Width;
            int geni�lik2 = pictureBox2.Width;
            int geni�lik3 = pictureBox3.Width;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(1, 11);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(1, 11);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(1, 11);
            int biti�uzakl��� = label6.Left;
            if (pictureBox1.Left > pictureBox2.Left + 1 && pictureBox1.Left > pictureBox3.Left)
                label9.Text = "1.At Ata�a Kalkarak Yar��� �nde G�t�r�yor..(!)";
            if (pictureBox2.Left > pictureBox3.Left + 1 && pictureBox2.Left > pictureBox3.Left)
                label9.Text = "2.At Ayr�l�p Geldi ve �uan 1.S�rada..(!)";
            if (pictureBox3.Left > pictureBox2.Left + 1 && pictureBox3.Left > pictureBox1.Left)
                label9.Text = "3.At Di�erlerinden S�yr�ld� ve �uan 1.Konumda..(!)";
            if (geni�lik1 + pictureBox1.Left >= biti�uzakl���)
            {
                timer1.Enabled = false; MessageBox.Show("1.At yar��� kazand�.");

            }
            if (geni�lik2 + pictureBox2.Left >= biti�uzakl���)
            {
                timer1.Enabled = false; MessageBox.Show("2.At yar��� kazand�.");

            }
            if (geni�lik3 + pictureBox3.Left >= biti�uzakl���)
            {
                timer1.Enabled = false; MessageBox.Show("3.At yar��� kazand�.");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
