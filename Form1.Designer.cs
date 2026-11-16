namespace FiguraAbst
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
            this.cmbFigura = new System.Windows.Forms.ComboBox();
            this.lblDato1 = new System.Windows.Forms.Label();
            this.lblDato2 = new System.Windows.Forms.Label();
            this.lblDato3 = new System.Windows.Forms.Label();
            this.lblDato4 = new System.Windows.Forms.Label();
            this.lblDato5 = new System.Windows.Forms.Label();
            this.txtDato1 = new System.Windows.Forms.TextBox();
            this.txtDato2 = new System.Windows.Forms.TextBox();
            this.txtDato3 = new System.Windows.Forms.TextBox();
            this.txtDato4 = new System.Windows.Forms.TextBox();
            this.txtDato5 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblFiguraRes = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbFigura
            // 
            this.cmbFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFigura.FormattingEnabled = true;
            this.cmbFigura.Items.AddRange(new object[] {
            "Cuadrado",
            "Círculo",
            "Triángulo"});
            this.cmbFigura.Location = new System.Drawing.Point(313, 76);
            this.cmbFigura.Name = "cmbFigura";
            this.cmbFigura.Size = new System.Drawing.Size(121, 21);
            this.cmbFigura.TabIndex = 0;
            this.cmbFigura.SelectedIndexChanged += new System.EventHandler(this.cmbFigura_SelectedIndexChanged);
            // 
            // lblDato1
            // 
            this.lblDato1.AutoSize = true;
            this.lblDato1.Location = new System.Drawing.Point(50, 134);
            this.lblDato1.Name = "lblDato1";
            this.lblDato1.Size = new System.Drawing.Size(34, 13);
            this.lblDato1.TabIndex = 1;
            this.lblDato1.Text = "Lado:";
            // 
            // lblDato2
            // 
            this.lblDato2.AutoSize = true;
            this.lblDato2.Location = new System.Drawing.Point(50, 165);
            this.lblDato2.Name = "lblDato2";
            this.lblDato2.Size = new System.Drawing.Size(37, 13);
            this.lblDato2.TabIndex = 2;
            this.lblDato2.Text = "Altura:";
            // 
            // lblDato3
            // 
            this.lblDato3.AutoSize = true;
            this.lblDato3.Location = new System.Drawing.Point(50, 201);
            this.lblDato3.Name = "lblDato3";
            this.lblDato3.Size = new System.Drawing.Size(43, 13);
            this.lblDato3.TabIndex = 3;
            this.lblDato3.Text = "Lado 1:";
            // 
            // lblDato4
            // 
            this.lblDato4.AutoSize = true;
            this.lblDato4.Location = new System.Drawing.Point(50, 229);
            this.lblDato4.Name = "lblDato4";
            this.lblDato4.Size = new System.Drawing.Size(43, 13);
            this.lblDato4.TabIndex = 4;
            this.lblDato4.Text = "Lado 2:";
            // 
            // lblDato5
            // 
            this.lblDato5.AutoSize = true;
            this.lblDato5.Location = new System.Drawing.Point(50, 261);
            this.lblDato5.Name = "lblDato5";
            this.lblDato5.Size = new System.Drawing.Size(43, 13);
            this.lblDato5.TabIndex = 5;
            this.lblDato5.Text = "Lado 3:";
            // 
            // txtDato1
            // 
            this.txtDato1.Location = new System.Drawing.Point(121, 131);
            this.txtDato1.Name = "txtDato1";
            this.txtDato1.Size = new System.Drawing.Size(100, 20);
            this.txtDato1.TabIndex = 6;
            // 
            // txtDato2
            // 
            this.txtDato2.Location = new System.Drawing.Point(121, 162);
            this.txtDato2.Name = "txtDato2";
            this.txtDato2.Size = new System.Drawing.Size(100, 20);
            this.txtDato2.TabIndex = 7;
            // 
            // txtDato3
            // 
            this.txtDato3.Location = new System.Drawing.Point(121, 198);
            this.txtDato3.Name = "txtDato3";
            this.txtDato3.Size = new System.Drawing.Size(100, 20);
            this.txtDato3.TabIndex = 8;
            // 
            // txtDato4
            // 
            this.txtDato4.Location = new System.Drawing.Point(121, 226);
            this.txtDato4.Name = "txtDato4";
            this.txtDato4.Size = new System.Drawing.Size(100, 20);
            this.txtDato4.TabIndex = 9;
            // 
            // txtDato5
            // 
            this.txtDato5.Location = new System.Drawing.Point(121, 261);
            this.txtDato5.Name = "txtDato5";
            this.txtDato5.Size = new System.Drawing.Size(100, 20);
            this.txtDato5.TabIndex = 10;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(294, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(426, 155);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblFiguraRes
            // 
            this.lblFiguraRes.AutoSize = true;
            this.lblFiguraRes.Location = new System.Drawing.Point(293, 227);
            this.lblFiguraRes.Name = "lblFiguraRes";
            this.lblFiguraRes.Size = new System.Drawing.Size(45, 13);
            this.lblFiguraRes.TabIndex = 13;
            this.lblFiguraRes.Text = "Figura: -";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(293, 261);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 13);
            this.lblArea.TabIndex = 14;
            this.lblArea.Text = "Area: -";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(293, 296);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(60, 13);
            this.lblPerimetro.TabIndex = 15;
            this.lblPerimetro.Text = "Perimetro: -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblFiguraRes);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDato5);
            this.Controls.Add(this.txtDato4);
            this.Controls.Add(this.txtDato3);
            this.Controls.Add(this.txtDato2);
            this.Controls.Add(this.txtDato1);
            this.Controls.Add(this.lblDato5);
            this.Controls.Add(this.lblDato4);
            this.Controls.Add(this.lblDato3);
            this.Controls.Add(this.lblDato2);
            this.Controls.Add(this.lblDato1);
            this.Controls.Add(this.cmbFigura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFigura;
        private System.Windows.Forms.Label lblDato1;
        private System.Windows.Forms.Label lblDato2;
        private System.Windows.Forms.Label lblDato3;
        private System.Windows.Forms.Label lblDato4;
        private System.Windows.Forms.Label lblDato5;
        private System.Windows.Forms.TextBox txtDato1;
        private System.Windows.Forms.TextBox txtDato2;
        private System.Windows.Forms.TextBox txtDato3;
        private System.Windows.Forms.TextBox txtDato4;
        private System.Windows.Forms.TextBox txtDato5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblFiguraRes;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}

