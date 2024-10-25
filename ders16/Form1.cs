namespace ders16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int uzaklýk1, uzaklýk2, uzaklýk3;
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


            int geniþlik1 = pictureBox1.Width;
            int geniþlik2 = pictureBox2.Width;
            int geniþlik3 = pictureBox3.Width;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(1, 11);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(1, 11);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(1, 11);
            int bitiþuzaklýðý = label6.Left;
            if (pictureBox1.Left > pictureBox2.Left + 1 && pictureBox1.Left > pictureBox3.Left)
                label9.Text = "1.At Ataða Kalkarak Yarýþý Önde Götürüyor..(!)";
            if (pictureBox2.Left > pictureBox3.Left + 1 && pictureBox2.Left > pictureBox3.Left)
                label9.Text = "2.At Ayrýlýp Geldi ve Þuan 1.Sýrada..(!)";
            if (pictureBox3.Left > pictureBox2.Left + 1 && pictureBox3.Left > pictureBox1.Left)
                label9.Text = "3.At Diðerlerinden Sýyrýldý ve Þuan 1.Konumda..(!)";
            if (geniþlik1 + pictureBox1.Left >= bitiþuzaklýðý)
            {
                timer1.Enabled = false; MessageBox.Show("1.At yarýþý kazandý.");

            }
            if (geniþlik2 + pictureBox2.Left >= bitiþuzaklýðý)
            {
                timer1.Enabled = false; MessageBox.Show("2.At yarýþý kazandý.");

            }
            if (geniþlik3 + pictureBox3.Left >= bitiþuzaklýðý)
            {
                timer1.Enabled = false; MessageBox.Show("3.At yarýþý kazandý.");

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
