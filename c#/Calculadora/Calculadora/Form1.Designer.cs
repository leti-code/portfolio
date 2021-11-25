
namespace Calculadora
{
    partial class Form1
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
            this.tb1 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bDec = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.lNum = new System.Windows.Forms.Label();
            this.bDelNum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bSign = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(46, 54);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(1092, 49);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "0";
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.Color.DarkBlue;
            this.b1.Location = new System.Drawing.Point(418, 221);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(106, 66);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.num_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.Color.DarkBlue;
            this.b2.Location = new System.Drawing.Point(521, 221);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(106, 66);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.num_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.ForeColor = System.Drawing.Color.DarkBlue;
            this.b5.Location = new System.Drawing.Point(521, 282);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(106, 66);
            this.b5.TabIndex = 3;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.num_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.Color.DarkBlue;
            this.b3.Location = new System.Drawing.Point(622, 221);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(106, 66);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.num_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.ForeColor = System.Drawing.Color.DarkBlue;
            this.b9.Location = new System.Drawing.Point(622, 344);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(106, 66);
            this.b9.TabIndex = 5;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.num_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.ForeColor = System.Drawing.Color.DarkBlue;
            this.b8.Location = new System.Drawing.Point(521, 344);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(106, 66);
            this.b8.TabIndex = 6;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.num_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.ForeColor = System.Drawing.Color.DarkBlue;
            this.b7.Location = new System.Drawing.Point(418, 344);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(106, 66);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.num_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.ForeColor = System.Drawing.Color.DarkBlue;
            this.b4.Location = new System.Drawing.Point(418, 282);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(106, 66);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.num_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.ForeColor = System.Drawing.Color.DarkBlue;
            this.b6.Location = new System.Drawing.Point(622, 282);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(106, 66);
            this.b6.TabIndex = 9;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.num_Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.ForeColor = System.Drawing.Color.DarkBlue;
            this.b0.Location = new System.Drawing.Point(521, 408);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(106, 66);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.num_Click);
            // 
            // bDec
            // 
            this.bDec.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDec.ForeColor = System.Drawing.Color.DarkBlue;
            this.bDec.Location = new System.Drawing.Point(622, 408);
            this.bDec.Name = "bDec";
            this.bDec.Size = new System.Drawing.Size(106, 66);
            this.bDec.TabIndex = 11;
            this.bDec.Text = ",";
            this.bDec.UseVisualStyleBackColor = false;
            this.bDec.Click += new System.EventHandler(this.num_Click);
            // 
            // bEq
            // 
            this.bEq.BackColor = System.Drawing.Color.RoyalBlue;
            this.bEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEq.ForeColor = System.Drawing.SystemColors.MenuText;
            this.bEq.Location = new System.Drawing.Point(726, 408);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(106, 66);
            this.bEq.TabIndex = 15;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = false;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bPlus
            // 
            this.bPlus.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bPlus.Location = new System.Drawing.Point(726, 344);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(106, 66);
            this.bPlus.TabIndex = 16;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = false;
            this.bPlus.Click += new System.EventHandler(this.ope_Click);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bDiv.Location = new System.Drawing.Point(726, 158);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(106, 66);
            this.bDiv.TabIndex = 17;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.ope_Click);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMul.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bMul.Location = new System.Drawing.Point(726, 221);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(106, 66);
            this.bMul.TabIndex = 18;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.ope_Click);
            // 
            // bMin
            // 
            this.bMin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMin.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bMin.Location = new System.Drawing.Point(726, 282);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(106, 66);
            this.bMin.TabIndex = 19;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = false;
            this.bMin.Click += new System.EventHandler(this.ope_Click);
            // 
            // bDel
            // 
            this.bDel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bDel.Location = new System.Drawing.Point(622, 158);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(106, 66);
            this.bDel.TabIndex = 20;
            this.bDel.Text = "C";
            this.bDel.UseVisualStyleBackColor = false;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // lNum
            // 
            this.lNum.AutoSize = true;
            this.lNum.Location = new System.Drawing.Point(1123, 22);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(0, 17);
            this.lNum.TabIndex = 21;
            this.lNum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bDelNum
            // 
            this.bDelNum.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bDelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelNum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bDelNum.Location = new System.Drawing.Point(521, 158);
            this.bDelNum.Name = "bDelNum";
            this.bDelNum.Size = new System.Drawing.Size(106, 66);
            this.bDelNum.TabIndex = 22;
            this.bDelNum.Text = "CE";
            this.bDelNum.UseVisualStyleBackColor = false;
            this.bDelNum.Click += new System.EventHandler(this.bDelNum_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(418, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 66);
            this.button1.TabIndex = 23;
            this.button1.Text = "del";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSign
            // 
            this.bSign.BackColor = System.Drawing.Color.LightSteelBlue;
            this.bSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSign.ForeColor = System.Drawing.Color.DarkBlue;
            this.bSign.Location = new System.Drawing.Point(418, 408);
            this.bSign.Name = "bSign";
            this.bSign.Size = new System.Drawing.Size(106, 66);
            this.bSign.TabIndex = 24;
            this.bSign.Text = "+/-";
            this.bSign.UseVisualStyleBackColor = false;
            this.bSign.Click += new System.EventHandler(this.bSign_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 550);
            this.Controls.Add(this.bSign);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bDelNum);
            this.Controls.Add(this.lNum);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bEq);
            this.Controls.Add(this.bDec);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bDec;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Label lNum;
        private System.Windows.Forms.Button bDelNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSign;
    }
}

