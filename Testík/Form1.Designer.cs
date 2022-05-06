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
            this.delo = new System.Windows.Forms.PictureBox();
            this.zajicek = new System.Windows.Forms.PictureBox();
            this.timerZajicek = new System.Windows.Forms.Timer(this.components);
            this.strela = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timerStrela = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vajicko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zajicek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strela)).BeginInit();
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
            // delo
            // 
            this.delo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.delo.Location = new System.Drawing.Point(363, 378);
            this.delo.Name = "delo";
            this.delo.Size = new System.Drawing.Size(60, 60);
            this.delo.TabIndex = 0;
            this.delo.TabStop = false;
            this.delo.Visible = false;
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
            // strela
            // 
            this.strela.Location = new System.Drawing.Point(628, 265);
            this.strela.Name = "strela";
            this.strela.Size = new System.Drawing.Size(20, 20);
            this.strela.TabIndex = 3;
            this.strela.TabStop = false;
            this.strela.Visible = false;
            this.strela.Paint += new System.Windows.Forms.PaintEventHandler(this.strela_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timerStrela
            // 
            this.timerStrela.Enabled = true;
            this.timerStrela.Interval = 10;
            this.timerStrela.Tick += new System.EventHandler(this.timerStrela_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strela);
            this.Controls.Add(this.vajicko);
            this.Controls.Add(this.delo);
            this.Controls.Add(this.zajicek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.vajicko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zajicek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox delo;
        private System.Windows.Forms.PictureBox vajicko;
        private System.Windows.Forms.PictureBox zajicek;
        private System.Windows.Forms.Timer timerZajicek;
        private System.Windows.Forms.PictureBox strela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerStrela;
    }
}

