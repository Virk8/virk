using System;
using System.Drawing;
using System.Windows.Forms;

namespace fig_virk
{
    public partial class anime : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public anime()
        {
            InitializeComponent();
            this.Load += new EventHandler(this.anime_Load);

            // Adicionar eventos de mouse para permitir arrastar o formulário
            this.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new MouseEventHandler(this.Form_MouseUp);

            // Adicionar eventos de mouse ao PictureBox para permitir arrastar o formulário
            this.pictureBox1.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            this.pictureBox1.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            this.pictureBox1.MouseUp += new MouseEventHandler(this.Form_MouseUp);
        }

        private void anime_Load(object sender, EventArgs e)
        {
            // Definir a opacidade do formulário para 99%
            this.Opacity = 0.99; // Deve ser 0.99 para permitir a transparência sem bugs

            // Definir a cor de fundo e a chave de transparência para uma cor específica
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Código para tratar o clique no PictureBox, se necessário
        }
    }
}
