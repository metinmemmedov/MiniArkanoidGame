namespace MiniArkanoidGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && panel1.Left > 0)
            {
                panel1.Left -= 40;
            }
            if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && panel1.Right < ClientSize.Width)
            {
                panel1.Left += 40;
            }

            if(e.KeyCode == Keys.Enter && gameOver)
            {
                restartGame();
            }
        }
        int dx = 5;
        int dy = -5;
        int score = 0;
        bool gameOver = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gameOver) return;
            ball.Left += dx;
            ball.Top += dy;

            if (ball.Left <= 0 || ball.Right >= this.ClientSize.Width)
            {
                dx = -dx;
            }

            if (ball.Top <= 0)
            {
                dy = -dy;
            }

            if (ball.Bounds.IntersectsWith(panel1.Bounds))
            {
                dy = -dy;
                dy--;
                score++;
            }

            if (ball.Bottom >= this.ClientSize.Height)
            {
                timer1.Stop();
                MessageBox.Show($"Game Over! Your score: {score}");
            }

        }
        private void restartGame()
        {
            gameOver = false;
            ball.Location = new Point(293, 12);
            panel1.Location = new Point(222, 479);
            dx = 5;
            dy = -5;
            score = 0;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
