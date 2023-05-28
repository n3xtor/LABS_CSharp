using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PopTheBall
{
    public partial class MainForm : Form
    {
        private int score;
        private int penalty;
        private Random random;
        private Timer timer;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            score = 0;
            penalty = 0;
            random = new Random();
            timer = new Timer();
            timer.Interval = 700;
            timer.Tick += Timer_Tick;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GenerateBall();
        }

        private void GenerateBall()
        {
            int diameter = random.Next(70, 100); // Випадковий діаметр кульки
            int x = random.Next(0, ClientSize.Width - diameter); // Випадкове положення по осі X
            int y = random.Next(0, ClientSize.Height - diameter); // Випадкове положення по осі Y

            Ball ball = new Ball(x, y, diameter, this); // Передаємо поточний об'єкт MainForm як аргумент
            ball.Click += Ball_Click;
            Controls.Add(ball);

            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Yellow };
            Color color = colors[random.Next(colors.Length)];
            ball.BackColor = color;

            ball.StartAnimation();
        }

        private void Ball_Click(object sender, EventArgs e)
        {
            Ball ball = (Ball)sender;
            ball.StopAnimation();
            Controls.Remove(ball);

            score++;
            scoreLabel.Text = $"Score: {score}";
        }

        private void penaltyTimer_Tick(object sender, EventArgs e)
        {
            penalty++;
            penaltyLabel.Text = $"Penalty: {penalty}";

            if (penalty >= 10) // Якщо штраф досягне 10, гра завершується
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            timer.Stop();
            MessageBox.Show($"Game Over! Your score: {score}");
            Close();
        }
    }

    public class Ball : PictureBox
    {
        private Timer animationTimer;
        private int animationDuration;
        private MainForm parentForm;

        public Ball(int x, int y, int diameter, MainForm parentForm)
        {
            Location = new Point(x, y);
            Size = new Size(diameter, diameter);
            BackColor = Color.Red;
            BorderStyle = BorderStyle.FixedSingle;
            animationDuration = 700; // Тривалість анімації кульки
            animationTimer = new Timer();
            animationTimer.Interval = animationDuration;
            animationTimer.Tick += AnimationTimer_Tick;
            this.parentForm = parentForm;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(0, 0, Width/2+20, Height));
                Region = new Region(path);
            }
        }

        public void StartAnimation()
        {
            animationTimer.Start();
        }

        public void StopAnimation()
        {
            animationTimer.Stop();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            StopAnimation();
            parentForm.Invoke((MethodInvoker)delegate
            {
                parentForm.PenaltyTimer_Tick(null, null);
                parentForm.Controls.Remove(this);
            });
        }
    }
}
