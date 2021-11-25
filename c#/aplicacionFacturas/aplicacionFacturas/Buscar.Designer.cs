
namespace aplicacionFacturas
{
    partial class Buscar
    {
        de diseño que les hayamos dado*/
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.bVolver = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numFact = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFact)).BeginInit();
            this.SuspendLayout();
            // 
            // bVolver
            // 
            this.bVolver.BackColor = System.Drawing.Color.ForestGreen;
            this.bVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bVolver.Location = new System.Drawing.Point(325, 217);
            this.bVolver.Margin = new System.Windows.Forms.Padding(4);
            this.bVolver.Name = "bVolver";
            this.bVolver.Size = new System.Drawing.Size(139, 44);
            this.bVolver.TabIndex = 8;
            this.bVolver.Text = "Volver a inicio";
            this.bVolver.UseVisualStyleBackColor = false;
            this.bVolver.Click += new System.EventHandler(this.bVolver_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.bBuscar.Location = new System.Drawing.Point(102, 217);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(131, 44);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.numFact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(131, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 150);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce el número de la factura que desea consultar:";
            // 
            // numFact
            // 
            this.numFact.Location = new System.Drawing.Point(105, 84);
            this.numFact.Name = "numFact";
            this.numFact.Size = new System.Drawing.Size(83, 22);
            this.numFact.TabIndex = 2;
            this.numFact.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(564, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bVolver);
            this.Controls.Add(this.bBuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscar";
            this.Text = "Ventana de búsqueda";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFact)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVolver;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numFact;
        private System.Windows.Forms.Label label1;
    }
}