namespace WindowsFormsApplication1
{
    partial class frmPuzzleGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuzzleGame));
            this.gbCajaRompeCabezas = new System.Windows.Forms.GroupBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.btnBarajar = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMovimientosRealizados = new System.Windows.Forms.Label();
            this.lblTiempoTranscurrido = new System.Windows.Forms.Label();
            this.tmrTiempoTranscurrido = new System.Windows.Forms.Timer(this.components);
            this.btnPauseOContinuar = new System.Windows.Forms.Button();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbCajaRompeCabezas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCajaRompeCabezas
            // 
            this.gbCajaRompeCabezas.Controls.Add(this.pbx1);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx2);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx3);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx4);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx5);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx6);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx7);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx8);
            this.gbCajaRompeCabezas.Controls.Add(this.pbx9);
            this.gbCajaRompeCabezas.Location = new System.Drawing.Point(33, 13);
            this.gbCajaRompeCabezas.Name = "gbCajaRompeCabezas";
            this.gbCajaRompeCabezas.Size = new System.Drawing.Size(427, 433);
            this.gbCajaRompeCabezas.TabIndex = 0;
            this.gbCajaRompeCabezas.TabStop = false;
            this.gbCajaRompeCabezas.Text = "Rompecabezas";
            // 
            // pbx1
            // 
            this.pbx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx1.Location = new System.Drawing.Point(17, 23);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(130, 130);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx2
            // 
            this.pbx2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx2.Location = new System.Drawing.Point(149, 23);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(130, 130);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx3
            // 
            this.pbx3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx3.Location = new System.Drawing.Point(281, 23);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(130, 130);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx4
            // 
            this.pbx4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx4.Location = new System.Drawing.Point(17, 155);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(130, 130);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx5
            // 
            this.pbx5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx5.Location = new System.Drawing.Point(149, 155);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(130, 130);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx6
            // 
            this.pbx6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx6.Location = new System.Drawing.Point(281, 155);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(130, 130);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx7
            // 
            this.pbx7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx7.Location = new System.Drawing.Point(17, 287);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(130, 130);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx8
            // 
            this.pbx8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx8.Location = new System.Drawing.Point(149, 287);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(130, 130);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // pbx9
            // 
            this.pbx9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbx9.Location = new System.Drawing.Point(281, 287);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(130, 130);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.CambiarCuadroImagen);
            // 
            // btnBarajar
            // 
            this.btnBarajar.BackColor = System.Drawing.Color.White;
            this.btnBarajar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBarajar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBarajar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarajar.Location = new System.Drawing.Point(532, 456);
            this.btnBarajar.Name = "btnBarajar";
            this.btnBarajar.Size = new System.Drawing.Size(86, 32);
            this.btnBarajar.TabIndex = 1;
            this.btnBarajar.Text = "Barajar";
            this.btnBarajar.UseVisualStyleBackColor = false;
            this.btnBarajar.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.White;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(773, 456);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(86, 32);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Salir";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblMovimientosRealizados
            // 
            this.lblMovimientosRealizados.AutoSize = true;
            this.lblMovimientosRealizados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientosRealizados.ForeColor = System.Drawing.Color.Navy;
            this.lblMovimientosRealizados.Location = new System.Drawing.Point(31, 465);
            this.lblMovimientosRealizados.Name = "lblMovimientosRealizados";
            this.lblMovimientosRealizados.Size = new System.Drawing.Size(205, 19);
            this.lblMovimientosRealizados.TabIndex = 2;
            this.lblMovimientosRealizados.Text = "Movimientos Realizados: ";
            // 
            // lblTiempoTranscurrido
            // 
            this.lblTiempoTranscurrido.AutoSize = true;
            this.lblTiempoTranscurrido.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTranscurrido.Location = new System.Drawing.Point(561, 358);
            this.lblTiempoTranscurrido.Name = "lblTiempoTranscurrido";
            this.lblTiempoTranscurrido.Size = new System.Drawing.Size(279, 78);
            this.lblTiempoTranscurrido.TabIndex = 3;
            this.lblTiempoTranscurrido.Text = "00:00:00";
            // 
            // tmrTiempoTranscurrido
            // 
            this.tmrTiempoTranscurrido.Enabled = true;
            this.tmrTiempoTranscurrido.Interval = 900;
            this.tmrTiempoTranscurrido.Tick += new System.EventHandler(this.ActualizarTiempoTranscurrido);
            // 
            // btnPauseOContinuar
            // 
            this.btnPauseOContinuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPauseOContinuar.Enabled = false;
            this.btnPauseOContinuar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseOContinuar.Location = new System.Drawing.Point(651, 456);
            this.btnPauseOContinuar.Name = "btnPauseOContinuar";
            this.btnPauseOContinuar.Size = new System.Drawing.Size(100, 32);
            this.btnPauseOContinuar.TabIndex = 4;
            this.btnPauseOContinuar.Text = "Pausar ||";
            this.btnPauseOContinuar.UseVisualStyleBackColor = true;
            this.btnPauseOContinuar.Click += new System.EventHandler(this.PauseOContinuar);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbOriginal.BackgroundImage")));
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbOriginal.Location = new System.Drawing.Point(532, 60);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(350, 291);
            this.gbOriginal.TabIndex = 0;
            this.gbOriginal.TabStop = false;
            this.gbOriginal.Text = "Original";
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(574, 13);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(266, 29);
            this.btnSeleccionarImagen.TabIndex = 5;
            this.btnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            //this.btnSeleccionarImagen.Click += new System.EventHandler(this.SeleccionarImagen_Click);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "openFileDialog";
            this.OFDialog.Filter = "Archivos de imagen|*.jpg";
            // 
            // frmPuzzleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 503);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.btnPauseOContinuar);
            this.Controls.Add(this.lblTiempoTranscurrido);
            this.Controls.Add(this.lblMovimientosRealizados);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnBarajar);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.gbCajaRompeCabezas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuzzleGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imagen RompeCabezas-Juego";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskPermissionBeforeQuite);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCajaRompeCabezas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCajaRompeCabezas;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.Button btnBarajar;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMovimientosRealizados;
        private System.Windows.Forms.Label lblTiempoTranscurrido;
        private System.Windows.Forms.Timer tmrTiempoTranscurrido;
        private System.Windows.Forms.Button btnPauseOContinuar;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.OpenFileDialog OFDialog;
    }
}

