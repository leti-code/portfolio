
namespace aplicacionFacturas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCreate = new System.Windows.Forms.Button();
            this.rightPic = new System.Windows.Forms.PictureBox();
            this.leftPic = new System.Windows.Forms.PictureBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bCreate
            // 
            this.bCreate.BackColor = System.Drawing.Color.ForestGreen;
            this.bCreate.Location = new System.Drawing.Point(417, 142);
            this.bCreate.Margin = new System.Windows.Forms.Padding(4);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(216, 36);
            this.bCreate.TabIndex = 1;
            this.bCreate.Text = "Crear nueva factura";
            this.bCreate.UseVisualStyleBackColor = false;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // rightPic
            // 
            this.rightPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPic.Image = ((System.Drawing.Image)(resources.GetObject("rightPic.Image")));
            this.rightPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("rightPic.InitialImage")));
            this.rightPic.Location = new System.Drawing.Point(655, 89);
            this.rightPic.Margin = new System.Windows.Forms.Padding(4);
            this.rightPic.Name = "rightPic";
            this.rightPic.Size = new System.Drawing.Size(359, 303);
            this.rightPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightPic.TabIndex = 2;
            this.rightPic.TabStop = false;
            // 
            // leftPic
            // 
            this.leftPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPic.Image = ((System.Drawing.Image)(resources.GetObject("leftPic.Image")));
            this.leftPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("leftPic.InitialImage")));
            this.leftPic.Location = new System.Drawing.Point(55, 100);
            this.leftPic.Margin = new System.Windows.Forms.Padding(4);
            this.leftPic.Name = "leftPic";
            this.leftPic.Size = new System.Drawing.Size(308, 268);
            this.leftPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftPic.TabIndex = 3;
            this.leftPic.TabStop = false;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.ForestGreen;
            this.bSearch.Location = new System.Drawing.Point(417, 261);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(216, 36);
            this.bSearch.TabIndex = 4;
            this.bSearch.Text = "Buscar una factura";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.ForestGreen;
            this.bCerrar.Location = new System.Drawing.Point(417, 374);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(216, 36);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar aplicación";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.leftPic);
            this.Controls.Add(this.rightPic);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "Bienvenido a la aplicación de facturas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.PictureBox rightPic;
        private System.Windows.Forms.PictureBox leftPic;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bCerrar;
    }
}

