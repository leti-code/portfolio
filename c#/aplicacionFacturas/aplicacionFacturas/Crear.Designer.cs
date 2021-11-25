
namespace aplicacionFacturas
{
    partial class Crear
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear));
            this.l1 = new System.Windows.Forms.Label();
            this.tpContenido = new System.Windows.Forms.TabPage();
            this.bNuevoProd = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tPrecio = new System.Windows.Forms.TextBox();
            this.tCant = new System.Windows.Forms.TextBox();
            this.tRef = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.lCant = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lRef = new System.Windows.Forms.Label();
            this.tpReceptor = new System.Windows.Forms.TabPage();
            this.tDireccionReceptor = new System.Windows.Forms.TextBox();
            this.tNombreReceptor = new System.Windows.Forms.TextBox();
            this.tIdReceptor = new System.Windows.Forms.TextBox();
            this.lDireccionReceptor = new System.Windows.Forms.Label();
            this.lNombreReceptor = new System.Windows.Forms.Label();
            this.lIdReceptor = new System.Windows.Forms.Label();
            this.tpEmisor = new System.Windows.Forms.TabPage();
            this.tDireccionEmisor = new System.Windows.Forms.TextBox();
            this.tNombreEmisor = new System.Windows.Forms.TextBox();
            this.tIdEmisor = new System.Windows.Forms.TextBox();
            this.lDireccionEmisor = new System.Windows.Forms.Label();
            this.lNombreEmisor = new System.Windows.Forms.Label();
            this.lIdEmisor = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tpImpuestos = new System.Windows.Forms.TabPage();
            this.lCompra = new System.Windows.Forms.Label();
            this.tCompra = new System.Windows.Forms.DateTimePicker();
            this.lPercentage = new System.Windows.Forms.Label();
            this.cbIrpf = new System.Windows.Forms.ComboBox();
            this.cbIva = new System.Windows.Forms.ComboBox();
            this.lIrpf = new System.Windows.Forms.Label();
            this.lIva = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.tNum = new System.Windows.Forms.TextBox();
            this.l3 = new System.Windows.Forms.Label();
            this.tDate = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Button();
            this.tpContenido.SuspendLayout();
            this.tpReceptor.SuspendLayout();
            this.tpEmisor.SuspendLayout();
            this.tab.SuspendLayout();
            this.tpImpuestos.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Pristina", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.l1.Location = new System.Drawing.Point(79, 41);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(324, 32);
            this.l1.TabIndex = 1;
            this.l1.Text = "Introduzca los datos para la factura";
            // 
            // tpContenido
            // 
            this.tpContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpContenido.Controls.Add(this.bNuevoProd);
            this.tpContenido.Controls.Add(this.tNombre);
            this.tpContenido.Controls.Add(this.tPrecio);
            this.tpContenido.Controls.Add(this.tCant);
            this.tpContenido.Controls.Add(this.tRef);
            this.tpContenido.Controls.Add(this.lPrecio);
            this.tpContenido.Controls.Add(this.lCant);
            this.tpContenido.Controls.Add(this.lNombre);
            this.tpContenido.Controls.Add(this.lRef);
            this.tpContenido.Location = new System.Drawing.Point(4, 25);
            this.tpContenido.Margin = new System.Windows.Forms.Padding(4);
            this.tpContenido.Name = "tpContenido";
            this.tpContenido.Padding = new System.Windows.Forms.Padding(4);
            this.tpContenido.Size = new System.Drawing.Size(659, 349);
            this.tpContenido.TabIndex = 3;
            this.tpContenido.Text = "Datos factura";
            // 
            // bNuevoProd
            // 
            this.bNuevoProd.BackColor = System.Drawing.Color.ForestGreen;
            this.bNuevoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNuevoProd.Location = new System.Drawing.Point(164, 258);
            this.bNuevoProd.Name = "bNuevoProd";
            this.bNuevoProd.Size = new System.Drawing.Size(287, 45);
            this.bNuevoProd.TabIndex = 10;
            this.bNuevoProd.Text = "Introducir nuevo producto";
            this.bNuevoProd.UseVisualStyleBackColor = false;
            this.bNuevoProd.Click += new System.EventHandler(this.bNuevoProd_Click);
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(284, 61);
            this.tNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(275, 26);
            this.tNombre.TabIndex = 7;
            // 
            // tPrecio
            // 
            this.tPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPrecio.Location = new System.Drawing.Point(284, 144);
            this.tPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.tPrecio.Name = "tPrecio";
            this.tPrecio.Size = new System.Drawing.Size(275, 26);
            this.tPrecio.TabIndex = 9;
            // 
            // tCant
            // 
            this.tCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCant.Location = new System.Drawing.Point(284, 102);
            this.tCant.Margin = new System.Windows.Forms.Padding(4);
            this.tCant.Name = "tCant";
            this.tCant.Size = new System.Drawing.Size(275, 26);
            this.tCant.TabIndex = 8;
            // 
            // tRef
            // 
            this.tRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRef.Location = new System.Drawing.Point(284, 23);
            this.tRef.Margin = new System.Windows.Forms.Padding(4);
            this.tRef.Name = "tRef";
            this.tRef.Size = new System.Drawing.Size(275, 26);
            this.tRef.TabIndex = 6;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(28, 147);
            this.lPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(142, 20);
            this.lPrecio.TabIndex = 4;
            this.lPrecio.Text = "Precio/unidad : ";
            // 
            // lCant
            // 
            this.lCant.AutoSize = true;
            this.lCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCant.Location = new System.Drawing.Point(28, 106);
            this.lCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCant.Name = "lCant";
            this.lCant.Size = new System.Drawing.Size(95, 20);
            this.lCant.TabIndex = 2;
            this.lCant.Text = "Cantidad :";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(28, 64);
            this.lNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(165, 20);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre producto :";
            // 
            // lRef
            // 
            this.lRef.AutoSize = true;
            this.lRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRef.Location = new System.Drawing.Point(28, 23);
            this.lRef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRef.Name = "lRef";
            this.lRef.Size = new System.Drawing.Size(166, 20);
            this.lRef.TabIndex = 0;
            this.lRef.Text = "Ref. de producto : ";
            // 
            // tpReceptor
            // 
            this.tpReceptor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpReceptor.Controls.Add(this.tDireccionReceptor);
            this.tpReceptor.Controls.Add(this.tNombreReceptor);
            this.tpReceptor.Controls.Add(this.tIdReceptor);
            this.tpReceptor.Controls.Add(this.lDireccionReceptor);
            this.tpReceptor.Controls.Add(this.lNombreReceptor);
            this.tpReceptor.Controls.Add(this.lIdReceptor);
            this.tpReceptor.Location = new System.Drawing.Point(4, 25);
            this.tpReceptor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpReceptor.Name = "tpReceptor";
            this.tpReceptor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpReceptor.Size = new System.Drawing.Size(659, 349);
            this.tpReceptor.TabIndex = 1;
            this.tpReceptor.Text = "Datos receptor";
            // 
            // tDireccionReceptor
            // 
            this.tDireccionReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccionReceptor.Location = new System.Drawing.Point(307, 252);
            this.tDireccionReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.tDireccionReceptor.Name = "tDireccionReceptor";
            this.tDireccionReceptor.Size = new System.Drawing.Size(273, 26);
            this.tDireccionReceptor.TabIndex = 11;
            // 
            // tNombreReceptor
            // 
            this.tNombreReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreReceptor.Location = new System.Drawing.Point(307, 158);
            this.tNombreReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.tNombreReceptor.Name = "tNombreReceptor";
            this.tNombreReceptor.Size = new System.Drawing.Size(273, 26);
            this.tNombreReceptor.TabIndex = 10;
            // 
            // tIdReceptor
            // 
            this.tIdReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdReceptor.Location = new System.Drawing.Point(307, 69);
            this.tIdReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.tIdReceptor.Name = "tIdReceptor";
            this.tIdReceptor.Size = new System.Drawing.Size(273, 26);
            this.tIdReceptor.TabIndex = 9;
            // 
            // lDireccionReceptor
            // 
            this.lDireccionReceptor.AutoSize = true;
            this.lDireccionReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccionReceptor.Location = new System.Drawing.Point(39, 256);
            this.lDireccionReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDireccionReceptor.Name = "lDireccionReceptor";
            this.lDireccionReceptor.Size = new System.Drawing.Size(108, 20);
            this.lDireccionReceptor.TabIndex = 8;
            this.lDireccionReceptor.Text = "Dirección : ";
            // 
            // lNombreReceptor
            // 
            this.lNombreReceptor.AutoSize = true;
            this.lNombreReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreReceptor.Location = new System.Drawing.Point(39, 161);
            this.lNombreReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreReceptor.Name = "lNombreReceptor";
            this.lNombreReceptor.Size = new System.Drawing.Size(174, 20);
            this.lNombreReceptor.TabIndex = 7;
            this.lNombreReceptor.Text = "Nombre completo : ";
            // 
            // lIdReceptor
            // 
            this.lIdReceptor.AutoSize = true;
            this.lIdReceptor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdReceptor.Location = new System.Drawing.Point(39, 69);
            this.lIdReceptor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIdReceptor.Name = "lIdReceptor";
            this.lIdReceptor.Size = new System.Drawing.Size(91, 20);
            this.lIdReceptor.TabIndex = 6;
            this.lIdReceptor.Text = "CIF/NIF : ";
            // 
            // tpEmisor
            // 
            this.tpEmisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpEmisor.Controls.Add(this.tDireccionEmisor);
            this.tpEmisor.Controls.Add(this.tNombreEmisor);
            this.tpEmisor.Controls.Add(this.tIdEmisor);
            this.tpEmisor.Controls.Add(this.lDireccionEmisor);
            this.tpEmisor.Controls.Add(this.lNombreEmisor);
            this.tpEmisor.Controls.Add(this.lIdEmisor);
            this.tpEmisor.Location = new System.Drawing.Point(4, 25);
            this.tpEmisor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmisor.Name = "tpEmisor";
            this.tpEmisor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpEmisor.Size = new System.Drawing.Size(659, 349);
            this.tpEmisor.TabIndex = 0;
            this.tpEmisor.Text = "Datos empresa emisora";
            // 
            // tDireccionEmisor
            // 
            this.tDireccionEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccionEmisor.Location = new System.Drawing.Point(307, 252);
            this.tDireccionEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.tDireccionEmisor.Name = "tDireccionEmisor";
            this.tDireccionEmisor.Size = new System.Drawing.Size(273, 26);
            this.tDireccionEmisor.TabIndex = 5;
            // 
            // tNombreEmisor
            // 
            this.tNombreEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombreEmisor.Location = new System.Drawing.Point(307, 158);
            this.tNombreEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.tNombreEmisor.Name = "tNombreEmisor";
            this.tNombreEmisor.Size = new System.Drawing.Size(273, 26);
            this.tNombreEmisor.TabIndex = 4;
            // 
            // tIdEmisor
            // 
            this.tIdEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIdEmisor.Location = new System.Drawing.Point(307, 69);
            this.tIdEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.tIdEmisor.Name = "tIdEmisor";
            this.tIdEmisor.Size = new System.Drawing.Size(273, 26);
            this.tIdEmisor.TabIndex = 3;
            // 
            // lDireccionEmisor
            // 
            this.lDireccionEmisor.AutoSize = true;
            this.lDireccionEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccionEmisor.Location = new System.Drawing.Point(39, 256);
            this.lDireccionEmisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDireccionEmisor.Name = "lDireccionEmisor";
            this.lDireccionEmisor.Size = new System.Drawing.Size(108, 20);
            this.lDireccionEmisor.TabIndex = 2;
            this.lDireccionEmisor.Text = "Dirección : ";
            // 
            // lNombreEmisor
            // 
            this.lNombreEmisor.AutoSize = true;
            this.lNombreEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreEmisor.Location = new System.Drawing.Point(39, 161);
            this.lNombreEmisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreEmisor.Name = "lNombreEmisor";
            this.lNombreEmisor.Size = new System.Drawing.Size(174, 20);
            this.lNombreEmisor.TabIndex = 1;
            this.lNombreEmisor.Text = "Nombre completo : ";
            // 
            // lIdEmisor
            // 
            this.lIdEmisor.AutoSize = true;
            this.lIdEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdEmisor.Location = new System.Drawing.Point(39, 69);
            this.lIdEmisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIdEmisor.Name = "lIdEmisor";
            this.lIdEmisor.Size = new System.Drawing.Size(91, 20);
            this.lIdEmisor.TabIndex = 0;
            this.lIdEmisor.Text = "CIF/NIF : ";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tpEmisor);
            this.tab.Controls.Add(this.tpReceptor);
            this.tab.Controls.Add(this.tpContenido);
            this.tab.Controls.Add(this.tpImpuestos);
            this.tab.Location = new System.Drawing.Point(287, 89);
            this.tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(667, 378);
            this.tab.TabIndex = 0;
            // 
            // tpImpuestos
            // 
            this.tpImpuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tpImpuestos.Controls.Add(this.lCompra);
            this.tpImpuestos.Controls.Add(this.tCompra);
            this.tpImpuestos.Controls.Add(this.lPercentage);
            this.tpImpuestos.Controls.Add(this.cbIrpf);
            this.tpImpuestos.Controls.Add(this.cbIva);
            this.tpImpuestos.Controls.Add(this.lIrpf);
            this.tpImpuestos.Controls.Add(this.lIva);
            this.tpImpuestos.Location = new System.Drawing.Point(4, 25);
            this.tpImpuestos.Margin = new System.Windows.Forms.Padding(4);
            this.tpImpuestos.Name = "tpImpuestos";
            this.tpImpuestos.Padding = new System.Windows.Forms.Padding(4);
            this.tpImpuestos.Size = new System.Drawing.Size(659, 349);
            this.tpImpuestos.TabIndex = 4;
            this.tpImpuestos.Text = "Datos de impuestos";
            // 
            // lCompra
            // 
            this.lCompra.AutoSize = true;
            this.lCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompra.Location = new System.Drawing.Point(52, 292);
            this.lCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCompra.Name = "lCompra";
            this.lCompra.Size = new System.Drawing.Size(146, 20);
            this.lCompra.TabIndex = 7;
            this.lCompra.Text = "Fecha compra : ";
            // 
            // tCompra
            // 
            this.tCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tCompra.Location = new System.Drawing.Point(308, 292);
            this.tCompra.Margin = new System.Windows.Forms.Padding(4);
            this.tCompra.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.tCompra.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.tCompra.Name = "tCompra";
            this.tCompra.Size = new System.Drawing.Size(275, 26);
            this.tCompra.TabIndex = 6;
            // 
            // lPercentage
            // 
            this.lPercentage.AutoSize = true;
            this.lPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPercentage.Location = new System.Drawing.Point(333, 206);
            this.lPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPercentage.Name = "lPercentage";
            this.lPercentage.Size = new System.Drawing.Size(32, 26);
            this.lPercentage.TabIndex = 4;
            this.lPercentage.Text = "%";
            // 
            // cbIrpf
            // 
            this.cbIrpf.FormattingEnabled = true;
            this.cbIrpf.Items.AddRange(new object[] {
            "19",
            "24",
            "30",
            "37",
            "45"});
            this.cbIrpf.Location = new System.Drawing.Point(247, 208);
            this.cbIrpf.Margin = new System.Windows.Forms.Padding(4);
            this.cbIrpf.Name = "cbIrpf";
            this.cbIrpf.Size = new System.Drawing.Size(69, 24);
            this.cbIrpf.TabIndex = 3;
            // 
            // cbIva
            // 
            this.cbIva.FormattingEnabled = true;
            this.cbIva.Items.AddRange(new object[] {
            "Sin_IVA: 0 %",
            "Superreducido: 4 %",
            "Reducido: 10 %",
            "General: 21 %"});
            this.cbIva.Location = new System.Drawing.Point(223, 78);
            this.cbIva.Margin = new System.Windows.Forms.Padding(4);
            this.cbIva.Name = "cbIva";
            this.cbIva.Size = new System.Drawing.Size(184, 24);
            this.cbIva.TabIndex = 2;
            // 
            // lIrpf
            // 
            this.lIrpf.AutoSize = true;
            this.lIrpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIrpf.Location = new System.Drawing.Point(79, 208);
            this.lIrpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIrpf.Name = "lIrpf";
            this.lIrpf.Size = new System.Drawing.Size(76, 20);
            this.lIrpf.TabIndex = 1;
            this.lIrpf.Text = "I.R.P.F.:";
            // 
            // lIva
            // 
            this.lIva.AutoSize = true;
            this.lIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIva.Location = new System.Drawing.Point(79, 82);
            this.lIva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIva.Name = "lIva";
            this.lIva.Size = new System.Drawing.Size(65, 20);
            this.lIva.TabIndex = 0;
            this.lIva.Text = "I.V.A. :";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.l2);
            this.panelInfo.Controls.Add(this.tNum);
            this.panelInfo.Controls.Add(this.l3);
            this.panelInfo.Controls.Add(this.tDate);
            this.panelInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInfo.Location = new System.Drawing.Point(33, 89);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(224, 378);
            this.panelInfo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información de la factura";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(4, 54);
            this.l2.Margin = new System.Windows.Forms.Padding(4, 37, 4, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(130, 17);
            this.l2.TabIndex = 1;
            this.l2.Text = "Número de factura:";
            // 
            // tNum
            // 
            this.tNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNum.Enabled = false;
            this.tNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNum.Location = new System.Drawing.Point(9, 96);
            this.tNum.Margin = new System.Windows.Forms.Padding(9, 25, 4, 4);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(133, 16);
            this.tNum.TabIndex = 2;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(4, 165);
            this.l3.Margin = new System.Windows.Forms.Padding(4, 49, 4, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(119, 17);
            this.l3.TabIndex = 3;
            this.l3.Text = "Fecha de factura:";
            // 
            // tDate
            // 
            this.tDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDate.Enabled = false;
            this.tDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDate.Location = new System.Drawing.Point(9, 207);
            this.tDate.Margin = new System.Windows.Forms.Padding(9, 25, 4, 4);
            this.tDate.Name = "tDate";
            this.tDate.Size = new System.Drawing.Size(133, 16);
            this.tDate.TabIndex = 4;
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.bGuardar.Location = new System.Drawing.Point(248, 503);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(131, 44);
            this.bGuardar.TabIndex = 3;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bSalir
            // 
            this.bSalir.BackColor = System.Drawing.Color.ForestGreen;
            this.bSalir.Location = new System.Drawing.Point(689, 503);
            this.bSalir.Margin = new System.Windows.Forms.Padding(4);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(139, 44);
            this.bSalir.TabIndex = 4;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = false;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.Color.ForestGreen;
            this.bInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bInicio.Location = new System.Drawing.Point(471, 503);
            this.bInicio.Margin = new System.Windows.Forms.Padding(4);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(139, 44);
            this.bInicio.TabIndex = 5;
            this.bInicio.Text = "Volver a inicio";
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // Crear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Crear";
            this.Text = "Datos de facturación";
            this.tpContenido.ResumeLayout(false);
            this.tpContenido.PerformLayout();
            this.tpReceptor.ResumeLayout(false);
            this.tpReceptor.PerformLayout();
            this.tpEmisor.ResumeLayout(false);
            this.tpEmisor.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tpImpuestos.ResumeLayout(false);
            this.tpImpuestos.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.TabPage tpContenido;
        private System.Windows.Forms.TabPage tpReceptor;
        private System.Windows.Forms.TabPage tpEmisor;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tpImpuestos;
        private System.Windows.Forms.FlowLayoutPanel panelInfo;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l2;
        public System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.Label l3;
        public System.Windows.Forms.TextBox tDate;
        private System.Windows.Forms.Label lDireccionEmisor;
        private System.Windows.Forms.Label lNombreEmisor;
        private System.Windows.Forms.Label lIdEmisor;
        public System.Windows.Forms.TextBox tDireccionReceptor;
        public System.Windows.Forms.TextBox tNombreReceptor;
        public System.Windows.Forms.TextBox tIdReceptor;
        private System.Windows.Forms.Label lDireccionReceptor;
        private System.Windows.Forms.Label lNombreReceptor;
        private System.Windows.Forms.Label lIdReceptor;
        public System.Windows.Forms.TextBox tDireccionEmisor;
        public System.Windows.Forms.TextBox tNombreEmisor;
        public System.Windows.Forms.TextBox tIdEmisor;
        public System.Windows.Forms.ComboBox cbIva;
        private System.Windows.Forms.Label lIrpf;
        private System.Windows.Forms.Label lIva;
        public System.Windows.Forms.ComboBox cbIrpf;
        private System.Windows.Forms.Label lPercentage;
        public System.Windows.Forms.TextBox tNombre;
        public System.Windows.Forms.TextBox tPrecio;
        public System.Windows.Forms.TextBox tCant;
        public System.Windows.Forms.TextBox tRef;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label lCant;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lRef;
        private System.Windows.Forms.Button bNuevoProd;
        private System.Windows.Forms.Label lCompra;
        public System.Windows.Forms.DateTimePicker tCompra;
        private System.Windows.Forms.Button bInicio;
    }
}