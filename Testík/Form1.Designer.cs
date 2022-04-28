namespace Testík
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vajicko = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zajicek = new System.Windows.Forms.PictureBox();
            this.timerZajicek = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vajicko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zajicek)).BeginInit();
            this.SuspendLayout();
            // 
            // vajicko
            // 
            this.vajicko.BackColor = System.Drawing.Color.Transparent;
            this.vajicko.BackgroundImage = global::Testík.Properties.Resources._2600751;
            this.vajicko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vajicko.Location = new System.Drawing.Point(564, 123);
            this.vajicko.Name = "vajicko";
            this.vajicko.Size = new System.Drawing.Size(36, 48);
            this.vajicko.TabIndex = 1;
            this.vajicko.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(363, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // zajicek
            // 
            this.zajicek.BackColor = System.Drawing.Color.Transparent;
            this.zajicek.BackgroundImage = global::Testík.Properties.Resources.zajicek1;
            this.zajicek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zajicek.Location = new System.Drawing.Point(359, 204);
            this.zajicek.Name = "zajicek";
            this.zajicek.Size = new System.Drawing.Size(64, 50);
            this.zajicek.TabIndex = 2;
            this.zajicek.TabStop = false;
            // 
            // timerZajicek
            // 
            this.timerZajicek.Enabled = true;
            this.timerZajicek.Interval = 25;
            this.timerZajicek.Tick += new System.EventHandler(this.timerZajicek_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vajicko);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zajicek);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.vajicko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zajicek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox vajicko;
        private System.Windows.Forms.PictureBox zajicek;
        private System.Windows.Forms.Timer timerZajicek;
    }
}

