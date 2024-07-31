namespace CSharp_TinhDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double soStart = Convert.ToInt32(txtStart.Text);
            double soEnd = Convert.ToInt32(txtEnd.Text);

            double tong = 0;
            double tich = 1;
            double tongSoChan = 0;
            double tongSoLe = 0;

            for (double i = soStart; i <= soEnd; i++)
            {
                tong += i;
                tich *= i;

                if (i % 2 == 0)
                {
                    tongSoChan += i;
                }
                else
                {
                    tongSoLe += i;
                }

                txtTong.Text = tong.ToString();
                txtTich.Text = tich.ToString();
                txtTongChan.Text = tongSoChan.ToString();
                txtTongLe.Text = tongSoLe.ToString();
            }
        }


    }
}
