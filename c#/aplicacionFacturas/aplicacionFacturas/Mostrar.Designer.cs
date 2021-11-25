
namespace aplicacionFacturas
{
    partial class Mostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar));
            this.datosReceptor = new System.Windows.Forms.FlowLayoutPanel();
            this.lIdRec = new System.Windows.Forms.Label();
            this.lNomRec = new System.Windows.Forms.Label();
            this.lDirRec = new System.Windows.Forms.Label();
            this.datosEmisor = new System.Windows.Forms.FlowLayoutPanel();
            this.lIdEmi = new System.Windows.Forms.Label();
            this.lNomEmi = new System.Windows.Forms.Label();
            this.lDirEmi = new System.Windows.Forms.Label();
            this.datosFactura = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lFecFac = new System.Windows.Forms.Label();
            this.lNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lIvaE = new System.Windows.Forms.Label();
            this.lIrpfE = new System.Windows.Forms.Label();
            this.lTotConImp = new System.Windows.Forms.Label();
            this.lIvaP = new System.Windows.Forms.Label();
            this.lIrpfP = new System.Windows.Forms.Label();
            this.lFecCompra = new System.Windows.Forms.Label();
            this.bCrear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTotSinImp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tablaProductos = new System.Windows.Forms.TableLayoutPanel();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Button();
            this.datosReceptor.SuspendLayout();
            this.datosEmisor.SuspendLayout();
            this.datosFactura.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datosReceptor
            // 
            this.datosReceptor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.datosReceptor.Controls.Add(this.lIdRec);
            this.datosReceptor.Controls.Add(this.lNomRec);
            this.datosReceptor.Controls.Add(this.lDirRec);
            this.datosReceptor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.datosReceptor.Location = new System.Drawing.Point(587, 65);
            this.datosReceptor.Margin = new System.Windows.Forms.Padding(4);
            this.datosReceptor.Name = "datosReceptor";
            this.datosReceptor.Size = new System.Drawing.Size(367, 164);
            this.datosReceptor.TabIndex = 2;
            // 
            // lIdRec
            // 
            this.lIdRec.AutoSize = true;
            this.lIdRec.Location = new System.Drawing.Point(9, 25);
            this.lIdRec.Margin = new System.Windows.Forms.Padding(9, 25, 4, 0);
            this.lIdRec.Name = "lIdRec";
            this.lIdRec.Size = new System.Drawing.Size(65, 17);
            this.lIdRec.TabIndex = 3;
            this.lIdRec.Text = "CIF/NIF : ";
            // 
            // lNomRec
            // 
            this.lNomRec.AutoSize = true;
            this.lNomRec.Location = new System.Drawing.Point(9, 67);
            this.lNomRec.Margin = new System.Windows.Forms.Padding(9, 25, 4, 0);
            this.lNomRec.Name = "lNomRec";
            this.lNomRec.Size = new System.Drawing.Size(70, 17);
            this.lNomRec.TabIndex = 4;
            this.lNomRec.Text = "Nombre : ";
            // 
            // lDirRec
            // 
            this.lDirRec.AutoSize = true;
            this.lDirRec.Location = new System.Drawing.Point(9, 109);
            this.lDirRec.Margin = new System.Windows.Forms.Padding(9, 25, 4, 0);
            this.lDirRec.Name = "lDirRec";
            this.lDirRec.Size = new System.Drawing.Size(79, 17);
            this.lDirRec.TabIndex = 5;
            this.lDirRec.Text = "Dirección : ";
            // 
            // datosEmisor
            // 
            this.datosEmisor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.datosEmisor.Controls.Add(this.lIdEmi);
            this.datosEmisor.Controls.Add(this.lNomEmi);
            this.datosEmisor.Controls.Add(this.lDirEmi);
            this.datosEmisor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.datosEmisor.Location = new System.Drawing.Point(107, 65);
            this.datosEmisor.Margin = new System.Windows.Forms.Padding(4);
            this.datosEmisor.Name = "datosEmisor";
            this.datosEmisor.Size = new System.Drawing.Size(367, 164);
            this.datosEmisor.TabIndex = 3;
            // 
            // lIdEmi
            // 
            this.lIdEmi.AutoSize = true;
            this.lIdEmi.Location = new System.Drawing.Point(9, 25);
            this.lIdEmi.Margin = new System.Windows.Forms.Padding(9, 25, 4, 0);
            this.lIdEmi.Name = "lIdEmi";
            this.lIdEmi.Size = new System.Drawing.Size(65, 17);
            this.lIdEmi.TabIndex = 0;
            this.lIdEmi.Text = "CIF /NIF :";
            // 
            // lNomEmi
            // 
            this.lNomEmi.AutoSize = true;
            this.lNomEmi.Location = new System.Drawing.Point(9, 67);
            this.lNomEmi.Margin = new System.Windows.Forms.Padding(9, 25, 4, 0);
            this.lNomEmi.Name = "lNomEmi";
            this.lNomEmi.Size = new System.Drawing.Size(70, 17);
            this.lNomEmi.TabIndex = 1;
            this.lNomEmi.Text = "Nombre : ";
            // 
            // lDirEmi
            // 
            this.lDirEmi.AutoSize = true;
            this.lDirEmi.Location = new System.Drawing.Point(9, 109);
            this.lDirEmi.Margin = new System.Windows.Forms.Padding(9, 25, 4, 0);
            this.lDirEmi.Name = "lDirEmi";
            this.lDirEmi.Size = new System.Drawing.Size(79, 17);
            this.lDirEmi.TabIndex = 2;
            this.lDirEmi.Text = "Dirección : ";
            // 
            // datosFactura
            // 
            this.datosFactura.BackColor = System.Drawing.Color.YellowGreen;
            this.datosFactura.Controls.Add(this.label10);
            this.datosFactura.Controls.Add(this.label4);
            this.datosFactura.Controls.Add(this.label5);
            this.datosFactura.Controls.Add(this.label6);
            this.datosFactura.Controls.Add(this.label12);
            this.datosFactura.Controls.Add(this.label13);
            this.datosFactura.Controls.Add(this.label14);
            this.datosFactura.Location = new System.Drawing.Point(110, 270);
            this.datosFactura.Margin = new System.Windows.Forms.Padding(4);
            this.datosFactura.Name = "datosFactura";
            this.datosFactura.Size = new System.Drawing.Size(848, 31);
            this.datosFactura.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 5, 15, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ref";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 5, 40, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Concepto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(27, 5, 20, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Precio base";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 5, 27, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(486, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(29, 5, 51, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "IVA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(601, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(29, 5, 51, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "IRPF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(729, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(31, 5, 20, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATOS CLIENTE";
            // 
            // lFecFac
            // 
            this.lFecFac.AutoSize = true;
            this.lFecFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecFac.Location = new System.Drawing.Point(581, 21);
            this.lFecFac.Name = "lFecFac";
            this.lFecFac.Size = new System.Drawing.Size(174, 25);
            this.lFecFac.TabIndex = 6;
            this.lFecFac.Text = "Fecha de factura : ";
            // 
            // lNum
            // 
            this.lNum.AutoSize = true;
            this.lNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNum.Location = new System.Drawing.Point(101, 21);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(140, 25);
            this.lNum.TabIndex = 7;
            this.lNum.Text = "Nº de factura : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detalle";
            // 
            // lIvaE
            // 
            this.lIvaE.AutoSize = true;
            this.lIvaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIvaE.Location = new System.Drawing.Point(251, 58);
            this.lIvaE.Name = "lIvaE";
            this.lIvaE.Size = new System.Drawing.Size(43, 20);
            this.lIvaE.TabIndex = 13;
            this.lIvaE.Text = "     $";
            this.lIvaE.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lIrpfE
            // 
            this.lIrpfE.AutoSize = true;
            this.lIrpfE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIrpfE.Location = new System.Drawing.Point(251, 97);
            this.lIrpfE.Name = "lIrpfE";
            this.lIrpfE.Size = new System.Drawing.Size(43, 20);
            this.lIrpfE.TabIndex = 14;
            this.lIrpfE.Text = "     $";
            this.lIrpfE.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lTotConImp
            // 
            this.lTotConImp.AutoSize = true;
            this.lTotConImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotConImp.Location = new System.Drawing.Point(251, 159);
            this.lTotConImp.Name = "lTotConImp";
            this.lTotConImp.Size = new System.Drawing.Size(43, 20);
            this.lTotConImp.TabIndex = 15;
            this.lTotConImp.Text = "     $";
            this.lTotConImp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lIvaP
            // 
            this.lIvaP.AutoSize = true;
            this.lIvaP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIvaP.Location = new System.Drawing.Point(65, 58);
            this.lIvaP.Name = "lIvaP";
            this.lIvaP.Size = new System.Drawing.Size(51, 20);
            this.lIvaP.TabIndex = 16;
            this.lIvaP.Text = " (  %)";
            this.lIvaP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lIrpfP
            // 
            this.lIrpfP.AutoSize = true;
            this.lIrpfP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIrpfP.Location = new System.Drawing.Point(76, 97);
            this.lIrpfP.Name = "lIrpfP";
            this.lIrpfP.Size = new System.Drawing.Size(51, 20);
            this.lIrpfP.TabIndex = 17;
            this.lIrpfP.Text = " (  %)";
            this.lIrpfP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lFecCompra
            // 
            this.lFecCompra.AutoSize = true;
            this.lFecCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFecCompra.Location = new System.Drawing.Point(734, 245);
            this.lFecCompra.Name = "lFecCompra";
            this.lFecCompra.Size = new System.Drawing.Size(136, 18);
            this.lFecCompra.TabIndex = 18;
            this.lFecCompra.Text = "Fecha de compra : ";
            // 
            // bCrear
            // 
            this.bCrear.BackColor = System.Drawing.Color.ForestGreen;
            this.bCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrear.Location = new System.Drawing.Point(136, 610);
            this.bCrear.Margin = new System.Windows.Forms.Padding(4);
            this.bCrear.Name = "bCrear";
            this.bCrear.Size = new System.Drawing.Size(293, 39);
            this.bCrear.TabIndex = 20;
            this.bCrear.Text = "Ir a ventana de creación";
            this.bCrear.UseVisualStyleBackColor = false;
            this.bCrear.Click += new System.EventHandler(this.bCrear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lTotSinImp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lTotConImp);
            this.panel1.Controls.Add(this.lIrpfP);
            this.panel1.Controls.Add(this.lIrpfE);
            this.panel1.Controls.Add(this.lIvaP);
            this.panel1.Controls.Add(this.lIvaE);
            this.panel1.Location = new System.Drawing.Point(592, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 189);
            this.panel1.TabIndex = 21;
            // 
            // lTotSinImp
            // 
            this.lTotSinImp.AutoSize = true;
            this.lTotSinImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotSinImp.Location = new System.Drawing.Point(251, 21);
            this.lTotSinImp.Name = "lTotSinImp";
            this.lTotSinImp.Size = new System.Drawing.Size(43, 20);
            this.lTotSinImp.TabIndex = 18;
            this.lTotSinImp.Text = "     $";
            this.lTotSinImp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkGreen;
            this.label9.Location = new System.Drawing.Point(13, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(11, 5, 20, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(29, 5, 51, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "IRPF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(29, 5, 51, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "IVA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Total sin impuestos";
            // 
            // tablaProductos
            // 
            this.tablaProductos.AutoScroll = true;
            this.tablaProductos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tablaProductos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tablaProductos.ColumnCount = 7;
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tablaProductos.Location = new System.Drawing.Point(108, 299);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.RowCount = 1;
            this.tablaProductos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaProductos.Size = new System.Drawing.Size(849, 162);
            this.tablaProductos.TabIndex = 31;
            // 
            // bBuscar
            // 
            this.bBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(139, 556);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(293, 39);
            this.bBuscar.TabIndex = 32;
            this.bBuscar.Text = "Ir a ventana de búsqueda";
            this.bBuscar.UseVisualStyleBackColor = false;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.Color.ForestGreen;
            this.bInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(139, 498);
            this.bInicio.Margin = new System.Windows.Forms.Padding(4);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(293, 39);
            this.bInicio.TabIndex = 33;
            this.bInicio.Text = "Ir a inicio";
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // Mostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1067, 676);
            this.Controls.Add(this.bInicio);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bCrear);
            this.Controls.Add(this.lFecCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lNum);
            this.Controls.Add(this.lFecFac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datosFactura);
            this.Controls.Add(this.datosEmisor);
            this.Controls.Add(this.datosReceptor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mostrar";
            this.Text = "Visualizador de facturas";
            this.datosReceptor.ResumeLayout(false);
            this.datosReceptor.PerformLayout();
            this.datosEmisor.ResumeLayout(false);
            this.datosEmisor.PerformLayout();
            this.datosFactura.ResumeLayout(false);
            this.datosFactura.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel datosReceptor;
        private System.Windows.Forms.FlowLayoutPanel datosEmisor;
        private System.Windows.Forms.FlowLayoutPanel datosFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lIdEmi;
        private System.Windows.Forms.Label lNomEmi;
        private System.Windows.Forms.Label lDirEmi;
        private System.Windows.Forms.Label lIdRec;
        private System.Windows.Forms.Label lNomRec;
        private System.Windows.Forms.Label lDirRec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lFecFac;
        private System.Windows.Forms.Label lNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lIvaE;
        private System.Windows.Forms.Label lIrpfE;
        private System.Windows.Forms.Label lTotConImp;
        private System.Windows.Forms.Label lIvaP;
        private System.Windows.Forms.Label lIrpfP;
        private System.Windows.Forms.Label lFecCompra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bCrear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lTotSinImp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TableLayoutPanel tablaProductos;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bInicio;
    }
}