using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace virk
{
    public partial class tank : Form
    {
        private Timer movementTimer;
        private Random random;
        private int direction;
        private int stepSize;
        private bool isFlipped;

        // Importação da API do Windows para alterar o estilo da janela
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowLong(IntPtr hWnd, int nIndex);

        // Constantes para manipulação do estilo da janela
        private const int GWL_EXSTYLE = -20;
        private const uint WS_EX_TOOLWINDOW = 0x00000080; // Define uma janela como "tool window"

        public tank()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.tank_Load);
        }

        private void tank_Load(object sender, EventArgs e)
        {
            // Definir a opacidade do formulário para 99%
            this.Opacity = 0.99;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

            // Definir para não aparecer na barra de tarefas
            this.ShowInTaskbar = false;

            // Obter o estilo atual da janela
            IntPtr handle = this.Handle;
            uint exStyle = GetWindowLong(handle, GWL_EXSTYLE);

            // Definir o estilo da janela como "tool window" para removê-la do Alt+Tab
            SetWindowLong(handle, GWL_EXSTYLE, exStyle | WS_EX_TOOLWINDOW);

            // Inicializar o temporizador e a lógica de movimento
            random = new Random();
            direction = random.Next(0, 2) == 0 ? -1 : 1;
            stepSize = random.Next(2, 6);
            isFlipped = direction == -1;

            movementTimer = new Timer();
            movementTimer.Interval = 100;
            movementTimer.Tick += new EventHandler(MovementTimer_Tick);
            movementTimer.Start();
        }

        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            if (this != null && !this.IsDisposed)
            {
                // Obter os limites da tela
                Rectangle screenBounds = Screen.FromControl(this).Bounds;

                // Calcular a nova posição do formulário
                int newX = this.Location.X + direction * stepSize;
                int newY = screenBounds.Bottom - this.Height - 32;

                // Verificar se o formulário atingiu as bordas e inverter a direção se necessário
                if (newX <= screenBounds.Left || newX + this.Width >= screenBounds.Right)
                {
                    direction *= -1;
                    stepSize = random.Next(2, 6);
                    newX = this.Location.X + direction * stepSize;
                    isFlipped = !isFlipped;
                    tanki.Invalidate();
                }

                // Mover o formulário para a nova posição
                this.Location = new Point(newX, newY);
            }
        }

        private void tanki_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);

            if (isFlipped)
            {
                e.Graphics.DrawImage(tanki.Image, new Rectangle(0, 0, tanki.Width, tanki.Height), new Rectangle(tanki.Image.Width, 0, -tanki.Image.Width, tanki.Image.Height), GraphicsUnit.Pixel);
            }
            else
            {
                e.Graphics.DrawImage(tanki.Image, 0, 0, tanki.Width, tanki.Height);
            }
        }

        private void tanki_Click(object sender, EventArgs e)
        {
            // Lógica para o clique
        }
    }
}
