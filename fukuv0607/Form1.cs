namespace fukuv0607
{
    public partial class Form1 : Form
    {
        int vx = -4;
        int vy = -4;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + vx;

            label1.Top = label1.Top + vy;

            if (label1.Left < 0)
            {
                vx = 4;
            }
            if (label1.Top < 0)
            {
                vy = 4;
            }
            if (label1.Right > 790)
            {
                vx = -4;
            }
            if (label1.Bottom > 449)
            {
                vy = -4;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            label1.Text = "ç≤ãvä‘ óIê∂";
        }
    }
}