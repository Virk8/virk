namespace virk
{
    partial class tank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tank));
            this.tanki = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tanki)).BeginInit();
            this.SuspendLayout();
            // 
            // tanki
            // 
            this.tanki.BackColor = System.Drawing.Color.Transparent;
            this.tanki.Image = global::virk.Properties.Resources.Tank;
            this.tanki.Location = new System.Drawing.Point(-1, -1);
            this.tanki.Name = "tanki";
            this.tanki.Size = new System.Drawing.Size(101, 45);
            this.tanki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tanki.TabIndex = 0;
            this.tanki.TabStop = false;
            this.tanki.Click += new System.EventHandler(this.tanki_Click);
            this.tanki.Paint += new System.Windows.Forms.PaintEventHandler(this.tanki_Paint);
            // 
            // tank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(97, 40);
            this.Controls.Add(this.tanki);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tank";
            this.Opacity = 0.99D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "tank";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.tank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tanki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tanki;
    }
}
