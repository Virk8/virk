using System;
using System.Drawing;
using System.Windows.Forms;


namespace virk
{
    public partial class maincs : Form
    {
        private int closedFormsCounter = 0; // Contador de abas fechadas

        public maincs()
        {
            InitializeComponent();
        }

        // Método chamado ao abrir o Form de "patinho"
        private void button1_Click_1(object sender, EventArgs e)
        {
            patinho patinho = new patinho();
            patinho.FormClosed += SubFormClosed; // Adiciona o evento ao fechar o Form
            patinho.Show();
        }

        // Método chamado ao abrir o Form de "tank"
        private void button2_Click(object sender, EventArgs e)
        {
            tank tank1 = new tank();
            tank1.FormClosed += SubFormClosed; // Adiciona o evento ao fechar o Form
            tank1.Show();
        }

        // Método chamado ao abrir o Form de "rocket"
        private void button3_Click(object sender, EventArgs e)
        {
            rocket rocket1 = new rocket();
            rocket1.FormClosed += SubFormClosed; // Adiciona o evento ao fechar o Form
            rocket1.Show();
        }

        // Evento ao fechar qualquer formulário
        private void SubFormClosed(object sender, FormClosedEventArgs e)
        {
            // Incrementa o contador de formulários fechados
            closedFormsCounter++;

            // Atualiza o texto do Label para refletir o número de abas fechadas
            closedFormsLabel.Text = "Kills: " + closedFormsCounter;
        }

        // Método de inicialização do formulário principal
        private void maincs_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderSize = 3; // Espessura da borda
            Color borderColor = Color.FromArgb(128, 128, 255); // Cor da borda

            using (Pen pen = new Pen(borderColor, borderSize))
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));

            }
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void maincs_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void maincs_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void maincs_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


    }
}
