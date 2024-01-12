using System;
using System.Runtime.CompilerServices;

namespace wfaSnakeGame
{
    public partial class Form1 : Form
    {

        private List<Point> snake;
        private Point food;               
        private Random rnd;
        private bool isFoodEaten = false;
        private Button startButton;
        private Button restartButton;
        private Direction currentDirection;

        public Form1()
        {
            InitializeComponent();

            startButton = new Button();
            startButton.Text = "Начать игру";
            startButton.Size = new Size(100, 30);
            startButton.Location = new Point((panel1.Width - startButton.Width) / 2, (panel1.Height - startButton.Height) / 2);

            panel1.Controls.Add(startButton);

            startButton.Click += StartButton_Click;

            this.KeyPreview = true;

        }

        private void StartButton_Click(object? sender, EventArgs e)
        {
            panel1.Controls.Remove(startButton);

            snake = new List<Point>();
            snake.Add(new Point(panel1.Width / 2, panel1.Height / 2));

            rnd = new Random();
            food = new Point(rnd.Next(20, panel1.Width - 20), rnd.Next(20, panel1.Height - 20));


            // Запускаем игру
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            gameTimer.Interval = 10;

            panel1.Paint += Panel1_Paint;

            this.KeyDown += Form1_KeyDown;

            lb_Up.Click += (s, e) => Move(Direction.Up);
            lb_Down.Click += (s, e) => Move(Direction.Down);
            lb_Right.Click += (s, e) => Move(Direction.Right);
            lb_Left.Click += (s, e) => Move(Direction.Left);
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            // Отрисовка змейки
            foreach (var point in snake)
            {
                e.Graphics.FillRectangle(Brushes.Green, new Rectangle(point, new Size(20, 20)));
            }

            // Отрисовка еды
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(food, new Size(10, 10)));
        }
        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            Move(null);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    Move(Direction.Up);
                    break;
                case Keys.S:
                    Move(Direction.Down);
                    break;
                case Keys.A:
                    Move(Direction.Left);
                    break;
                case Keys.D:
                    Move(Direction.Right);
                    break;

                case Keys.Up:
                    Move(Direction.Up);
                    break;
                case Keys.Down:
                    Move(Direction.Down);
                    break;
                case Keys.Left:
                    Move(Direction.Left);
                    break;
                case Keys.Right:
                    Move(Direction.Right);
                    break;

                default: 
                    break;
            }
        }

        private void Move(Direction? direction)
        {
            // Добавление новой головы змейки
            var head = snake.First();
            var newHead = head;

            if (direction != null)
            {
                currentDirection = direction.Value;
            }
            switch (currentDirection)
            {
                case Direction.Up:
                    newHead.Y -= 1;
                    break;
                case Direction.Down:
                    newHead.Y += 1;
                    break;
                case Direction.Left:
                    newHead.X -= 1;
                    break;
                case Direction.Right:
                    newHead.X += 1;
                    break;
                default:
                    break;
            }

            snake.Insert(0, newHead);



            // Проверка на столкновение с едой
            if (((newHead.X >= food.X && newHead.X < (food.X + 10)) || 
                ((newHead.X + 10) >= food.X && (newHead.X + 10) < (food.X + 10))) && 
                ((newHead.Y >= food.Y && newHead.Y < (food.Y + 10)) ||
                ((newHead.Y + 10) >= food.Y && (newHead.Y + 10) < (food.Y + 10))))
            {
                // Генерация новой позиции для еды
                food = new Point(rnd.Next(20, panel1.Width-20), rnd.Next(20, panel1.Height-20));
                isFoodEaten = true;

                snake.Add(snake.Last());
            }
            else
            {
                if (!isFoodEaten)
                {
                    // Удаление последней части змейки
                    panel1.Invalidate(new Rectangle(snake.Last(), new Size(20, 20)));
                    snake.Remove(snake.Last());
                }
                isFoodEaten = false;
            }

            if (isFoodEaten)
            {
                if (gameTimer.Interval < 2)
                {
                    gameTimer.Interval = 1; // Минимальный интервал таймера
                }
                else
                {
                    gameTimer.Interval -= 1;
                }
            }

            // Проверка на столкновение со стенами или сама с собой
            if (newHead.X < -5 || newHead.X >= panel1.Width+5 ||
                newHead.Y < -5 || newHead.Y >= panel1.Height+5 ||
                (snake.Count > 1 && snake.Skip(1).Any(p => p == newHead)))
            {
                // Игра окончена, змейка столкнулась со стеной
                gameTimer.Stop();
                MessageBox.Show("Вы проиграли!");

                restartButton = new Button();
                restartButton.Text = "Начать заново";
                restartButton.Size = new Size(200, 30);
                restartButton.Location = new Point((panel1.Width - restartButton.Width) / 2, (panel1.Height - restartButton.Height) / 2);
                panel1.Controls.Add(restartButton);
                restartButton.Click += RestartButton_Click;
            }
            else
            {
                // Отрисовка змейки и еды
                panel1.Invalidate(new Rectangle(newHead, new Size(200, 20)));
                panel1.Invalidate(new Rectangle(food, new Size(10, 10)));
            }
            
        }

        private void RestartButton_Click(object? sender, EventArgs e)
        {
            panel1.Controls.Remove(restartButton);
            restartButton = null;

            panel1.Invalidate();

            snake.Clear();
            snake.Add(new Point(panel1.Width / 2, panel1.Height / 2));

            rnd = new Random();
            food = new Point(rnd.Next(20, panel1.Width - 20), rnd.Next(20, panel1.Height - 20));

            gameTimer.Start();
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
