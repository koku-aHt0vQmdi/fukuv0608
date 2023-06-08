namespace fukuv0608
{
    public partial class Form1 : Form
    {
        int vx = -5;
        int vy = -5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Top <= 0 || ClientSize.Height <= label1.Bottom)
                vy *= -1;
            if (label1.Left <= 0 || ClientSize.Width <= label1.Right)
                vx *= -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "“cŸº";
        }
    }
}