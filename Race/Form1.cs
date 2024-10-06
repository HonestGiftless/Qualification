namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int n, n2, n3;
        // n - жук, n2 - жук2, n3 - жук3
        int x1, x2, x3;
        // x1 - таймер жук1, x2 - таймер жук2, x3 - таймер жук3
        int ip;
        // ip - определитель победы
        int l1, l2, l3;
        // l1 - кол-во кругов жук1, l2 - кол-во кругов жук2, l3 - кол-во кругов жук3
        int a1, a2, a3;
        // a1, a2, a3 - направления жуков

        Random rnd1 = new Random();
        Random rnd2 = new Random();
        Random rnd3 = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            n++;

            if (n > 4) n = 1;
            if (n == 1) pictureBox1.Image = Properties.Resources.ЖУК;
            if (n == 2) pictureBox1.Image = Properties.Resources.ЖУК_Л;
            if (n == 3) pictureBox1.Image = Properties.Resources.ЖУК;
            if (n == 4) pictureBox1.Image = Properties.Resources.ЖУК_П;

            if (a1 == 0) pictureBox1.Left += 10;
            if (a1 == 1) pictureBox1.Left -= 10;
            
            if (pictureBox1.Left < 0) pictureBox1.Left = 0;

            if ((pictureBox1.Left > Width - 100) && (l1 == 3))
            {
                timer1.Enabled = false;
                if (ip == 0)
                {
                    ip = 1;
                    label1.Text = "Победил красный";
                }
            }

            if ((pictureBox1.Left > Width + 100) && (l1 < 3))
            {
                pictureBox1.Left = 0;
                l1++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            n2++;

            if (n2 > 4) n2 = 1;
            if (n2 == 1) pictureBox2.Image = Properties.Resources.ЖУК2;
            if (n2 == 2) pictureBox2.Image = Properties.Resources.ЖУК_Л2;
            if (n2 == 3) pictureBox2.Image = Properties.Resources.ЖУК2;
            if (n2 == 4) pictureBox2.Image = Properties.Resources.ЖУК_П2;

            if (a2 == 0) pictureBox2.Left += 10;
            if (a2 == 1) pictureBox2.Left -= 10;

            if (pictureBox2.Left < 0) pictureBox2.Left = 0;

            if ((pictureBox2.Left > Width - 100) && (l2 == 3))
            {
                timer2.Enabled = false;
                if (ip == 0)
                {
                    ip = 2;
                    label1.Text = "Победил синий";
                }
            }

            if ((pictureBox2.Left > Width + 100) && (l2 < 3))
            {
                pictureBox2.Left = 0;
                l2++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            n3++;

            if (n3 > 4) n3 = 1;
            if (n3 == 1) pictureBox3.Image = Properties.Resources.ЖУК3;
            if (n3 == 2) pictureBox3.Image = Properties.Resources.ЖУК_Л3;
            if (n3 == 3) pictureBox3.Image = Properties.Resources.ЖУК3;
            if (n3 == 4) pictureBox3.Image = Properties.Resources.ЖУК_П3;

            if (a3 == 0) pictureBox3.Left += 10;
            if (a3 == 1) pictureBox3.Left -= 10;

            if (pictureBox3.Left < 0) pictureBox3.Left = 0;

            if ((pictureBox3.Left > Width - 100) && (l3 == 3))
            {
                timer3.Enabled = false;
                if (ip == 0)
                {
                    ip = 3;
                    label1.Text = "Победил розовый";
                }
            }

            if ((pictureBox3.Left > Width + 100) && (l3 < 3))
            {
                pictureBox3.Left = 0;
                l3++;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            x1 = rnd1.Next(10, 100);
            timer1.Interval = x1;

            x2 = rnd2.Next(10, 100);
            timer2.Interval = x2;

            x3 = rnd3.Next(10, 100);
            timer3.Interval = x3;

            if (x1 < 10)
            {
                a1++;
                if (a1 > 1) a1 = 0;
            }
            
            if (x2 < 10)
            {
                a2++;
                if (a2 > 1) a2 = 0;
            }

            if (x3 < 10)
            {
                a3++;
                if (a3 > 1) a3 = 0;
            }
        }
    }
}
