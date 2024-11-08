namespace virk
{
    partial class rocket
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rocket));
            this.rocketi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rocketi)).BeginInit();
            this.SuspendLayout();
            // 
            // rocketi
            // 
            this.rocketi.BackColor = System.Drawing.Color.Transparent;
            this.rocketi.Image = global::virk.Properties.Resources.Rocket;
            this.rocketi.Location = new System.Drawing.Point(-2, -3);
            this.rocketi.Name = "rocketi";
            this.rocketi.Size = new System.Drawing.Size(90, 34);
            this.rocketi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rocketi.TabIndex = 0;
            this.rocketi.TabStop = false;
            this.rocketi.Click += new System.EventHandler(this.rocketi_Click);
            this.rocketi.Paint += new System.Windows.Forms.PaintEventHandler(this.rocketi_Paint);
            // 
            // rocket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(88, 31);
            this.ControlBox = false;
            this.Controls.Add(this.rocketi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rocket";
            this.Opacity = 0.99D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "rocket";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.rocket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rocketi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rocketi;
    }
}
