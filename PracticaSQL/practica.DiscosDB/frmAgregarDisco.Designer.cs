namespace practica.DiscosDB
{
    partial class frmAgregarDisco
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
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblNombreDisco = new System.Windows.Forms.Label();
            this.lblFechaLanzamiento = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.lblUrlImagenTapa = new System.Windows.Forms.Label();
            this.pbxImagenDisco = new System.Windows.Forms.PictureBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.tbxArtista = new System.Windows.Forms.TextBox();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.tbxUrlImagenTapa = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.cboEstilo = new System.Windows.Forms.ComboBox();
            this.lblTipoEdicion = new System.Windows.Forms.Label();
            this.cboEdicion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Location = new System.Drawing.Point(31, 38);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(47, 16);
            this.lblArtista.TabIndex = 0;
            this.lblArtista.Text = "Artista:";
            // 
            // lblNombreDisco
            // 
            this.lblNombreDisco.AutoSize = true;
            this.lblNombreDisco.Location = new System.Drawing.Point(30, 66);
            this.lblNombreDisco.Name = "lblNombreDisco";
            this.lblNombreDisco.Size = new System.Drawing.Size(43, 16);
            this.lblNombreDisco.TabIndex = 1;
            this.lblNombreDisco.Text = "Título:";
            // 
            // lblFechaLanzamiento
            // 
            this.lblFechaLanzamiento.AutoSize = true;
            this.lblFechaLanzamiento.Location = new System.Drawing.Point(30, 93);
            this.lblFechaLanzamiento.Name = "lblFechaLanzamiento";
            this.lblFechaLanzamiento.Size = new System.Drawing.Size(142, 16);
            this.lblFechaLanzamiento.TabIndex = 2;
            this.lblFechaLanzamiento.Text = "Fecha de lanzamiento:";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(30, 125);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(150, 16);
            this.lblCantidadCanciones.TabIndex = 3;
            this.lblCantidadCanciones.Text = "Cantidad de Canciones:";
            // 
            // lblUrlImagenTapa
            // 
            this.lblUrlImagenTapa.AutoSize = true;
            this.lblUrlImagenTapa.Location = new System.Drawing.Point(30, 153);
            this.lblUrlImagenTapa.Name = "lblUrlImagenTapa";
            this.lblUrlImagenTapa.Size = new System.Drawing.Size(75, 16);
            this.lblUrlImagenTapa.TabIndex = 4;
            this.lblUrlImagenTapa.Text = "Url Imagen:";
            // 
            // pbxImagenDisco
            // 
            this.pbxImagenDisco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImagenDisco.Location = new System.Drawing.Point(408, 32);
            this.pbxImagenDisco.Name = "pbxImagenDisco";
            this.pbxImagenDisco.Size = new System.Drawing.Size(244, 230);
            this.pbxImagenDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenDisco.TabIndex = 5;
            this.pbxImagenDisco.TabStop = false;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(179, 88);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaLanzamiento.TabIndex = 6;
            // 
            // tbxArtista
            // 
            this.tbxArtista.Location = new System.Drawing.Point(84, 32);
            this.tbxArtista.Name = "tbxArtista";
            this.tbxArtista.Size = new System.Drawing.Size(100, 22);
            this.tbxArtista.TabIndex = 7;
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(84, 60);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(100, 22);
            this.tbxTitulo.TabIndex = 8;
            // 
            // tbxCantidadCanciones
            // 
            this.tbxCantidadCanciones.Location = new System.Drawing.Point(186, 119);
            this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
            this.tbxCantidadCanciones.Size = new System.Drawing.Size(100, 22);
            this.tbxCantidadCanciones.TabIndex = 9;
            // 
            // tbxUrlImagenTapa
            // 
            this.tbxUrlImagenTapa.Location = new System.Drawing.Point(113, 150);
            this.tbxUrlImagenTapa.Name = "tbxUrlImagenTapa";
            this.tbxUrlImagenTapa.Size = new System.Drawing.Size(100, 22);
            this.tbxUrlImagenTapa.TabIndex = 10;
            this.tbxUrlImagenTapa.Leave += new System.EventHandler(this.tbxUrlImagenTapa_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(33, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(93, 31);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(31, 186);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(43, 16);
            this.lblEstilo.TabIndex = 13;
            this.lblEstilo.Text = "Estilo:";
            // 
            // cboEstilo
            // 
            this.cboEstilo.FormattingEnabled = true;
            this.cboEstilo.Location = new System.Drawing.Point(84, 178);
            this.cboEstilo.Name = "cboEstilo";
            this.cboEstilo.Size = new System.Drawing.Size(121, 24);
            this.cboEstilo.TabIndex = 14;
            // 
            // lblTipoEdicion
            // 
            this.lblTipoEdicion.AutoSize = true;
            this.lblTipoEdicion.Location = new System.Drawing.Point(30, 216);
            this.lblTipoEdicion.Name = "lblTipoEdicion";
            this.lblTipoEdicion.Size = new System.Drawing.Size(55, 16);
            this.lblTipoEdicion.TabIndex = 15;
            this.lblTipoEdicion.Text = "Edición:";
            // 
            // cboEdicion
            // 
            this.cboEdicion.FormattingEnabled = true;
            this.cboEdicion.Location = new System.Drawing.Point(92, 207);
            this.cboEdicion.Name = "cboEdicion";
            this.cboEdicion.Size = new System.Drawing.Size(121, 24);
            this.cboEdicion.TabIndex = 16;
            // 
            // frmAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 291);
            this.Controls.Add(this.cboEdicion);
            this.Controls.Add(this.lblTipoEdicion);
            this.Controls.Add(this.cboEstilo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxUrlImagenTapa);
            this.Controls.Add(this.tbxCantidadCanciones);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.tbxArtista);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.pbxImagenDisco);
            this.Controls.Add(this.lblUrlImagenTapa);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblFechaLanzamiento);
            this.Controls.Add(this.lblNombreDisco);
            this.Controls.Add(this.lblArtista);
            this.Name = "frmAgregarDisco";
            this.Text = "frmAgregarDisco";
            this.Load += new System.EventHandler(this.frmAgregarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblNombreDisco;
        private System.Windows.Forms.Label lblFechaLanzamiento;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Label lblUrlImagenTapa;
        private System.Windows.Forms.PictureBox pbxImagenDisco;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.TextBox tbxArtista;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxCantidadCanciones;
        private System.Windows.Forms.TextBox tbxUrlImagenTapa;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.ComboBox cboEstilo;
        private System.Windows.Forms.Label lblTipoEdicion;
        private System.Windows.Forms.ComboBox cboEdicion;
    }
}