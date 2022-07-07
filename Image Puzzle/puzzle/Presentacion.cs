using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class frmPuzzleGame : Form
    {

        // Declaro las varibales
        //string foto;
        //Panel[] panel = new Panel[9];
        //PictureBox[] picturebox = new PictureBox[9];
        //int np;        

        int EnIndiceNulo, EnMovimientos = 0;
        List<Bitmap> listaFotosOriginal = new List<Bitmap>();
        System.Diagnostics.Stopwatch tiempo = new System.Diagnostics.Stopwatch();
        ToolTip tooltip = new ToolTip();
        
        public frmPuzzleGame()
        {
            InitializeComponent();
            listaFotosOriginal.AddRange(new Bitmap[] { Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, Properties.Resources._null });
            lblMovimientosRealizados.Text += EnMovimientos;
            lblTiempoTranscurrido.Text = "00:00:00";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Barajar();
            btnPauseOContinuar.BackColor = Color.LightGreen;
            tooltip.SetToolTip(gbOriginal, "Imagen original");
            tooltip.SetToolTip(lblTiempoTranscurrido, "Tiempo consumido");
            tooltip.SetToolTip(lblMovimientosRealizados, "Movimientos realizados");
            tooltip.SetToolTip(btnBarajar, "Barajar");
            tooltip.SetToolTip(btnPauseOContinuar, "Pausar");
            tooltip.SetToolTip(btnQuit, "Salir del Juego");

        }

        void Barajar()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 }); // 8 No está presente, ya que es la última
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbCajaRompeCabezas.Controls[i]).Image = listaFotosOriginal[j];
                    if (j == 9) EnIndiceNulo = i; // Almacenar cuadro de imagen vacío
                }
            } while (ComprobarAcierto());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult SiONo = new DialogResult();     
            if (lblTiempoTranscurrido.Text != "00:00:00")
            {
                SiONo = MessageBox.Show("Está seguro de REINICIAR?", "Imagen Rompecabezas-Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (SiONo == DialogResult.Yes || lblTiempoTranscurrido.Text == "00:00:00")
            {
                Barajar();
                tiempo.Reset();
                lblTiempoTranscurrido.Text = "00:00:00";
                EnMovimientos = 0;
                lblMovimientosRealizados.Text = "Movimientos Realizados: 0";
            }
        }

        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult SiONo = MessageBox.Show("Está seguro de Salir del Juego ?", "Imagen Rompecabezas-Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && SiONo == DialogResult.No) e.Cancel = true;
            if (sender as Button == btnQuit && SiONo == DialogResult.Yes) Environment.Exit(0);
            
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }

        private void CambiarCuadroImagen(object sender, EventArgs e)
        {
            if (lblTiempoTranscurrido.Text == "00:00:00")
                tiempo.Start();
            int EnCuadroIndice = gbCajaRompeCabezas.Controls.IndexOf(sender as Control);

            if (EnIndiceNulo != EnCuadroIndice)
            {
                List<int> CuatroHermanos = new List<int>(new int[] { ((EnCuadroIndice % 3 == 0) ? -1 : EnCuadroIndice - 1), EnCuadroIndice - 3, (EnCuadroIndice % 3 == 2) ? -1 : EnCuadroIndice + 1, EnCuadroIndice + 3 });

                if (CuatroHermanos.Contains(EnIndiceNulo))
                {
                    ((PictureBox)gbCajaRompeCabezas.Controls[EnIndiceNulo]).Image = ((PictureBox)gbCajaRompeCabezas.Controls[EnCuadroIndice]).Image;
                    ((PictureBox)gbCajaRompeCabezas.Controls[EnCuadroIndice]).Image = listaFotosOriginal[9];
                    EnIndiceNulo = EnCuadroIndice;
                    lblMovimientosRealizados.Text = "Movimientos Realizados: " + (++EnMovimientos);

                    if (ComprobarAcierto())
                    {
                        tiempo.Stop();
                        (gbCajaRompeCabezas.Controls[8] as PictureBox).Image = listaFotosOriginal[8];
                        MessageBox.Show("Felicitaciones...\n\nTu RompeCabezas ha sido armado correctamente.\n\nTiempo Transcurrido : " + tiempo.Elapsed.ToString().Remove(8) + "\n\nTotal Movimientos Realizados: " + EnMovimientos, "Imagen RompeCabezas-Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EnMovimientos = 0;
                        lblMovimientosRealizados.Text = "Movimientos Realizados: 0";
                        lblTiempoTranscurrido.Text = "00:00:00";
                        tiempo.Reset();
                        Barajar();
                    }
                }
            }
        }

        public bool ComprobarAcierto()
        {
            int i;

            for (i = 0; i < 8; i++)
            {
                if ((gbCajaRompeCabezas.Controls[i] as PictureBox).Image != listaFotosOriginal[i])
                    break;
            }
            if (i == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ActualizarTiempoTranscurrido(object sender, EventArgs e)
        {
            if (tiempo.Elapsed.ToString() != "00:00:00")
            {
                
                lblTiempoTranscurrido.Text = tiempo.Elapsed.ToString().Remove(8);
            }

            if (tiempo.Elapsed.ToString() == "00:00:00")
            {
                lblTiempoTranscurrido.ForeColor = Color.Red;
                btnPauseOContinuar.Enabled = false;
            }

            else
            { 
                btnPauseOContinuar.Enabled = true;
                lblTiempoTranscurrido.ForeColor = Color.Green;
            }

            if (tiempo.Elapsed.Minutes.ToString() == "2")
            {
                tiempo.Reset();
                lblMovimientosRealizados.Text = "Moviminetos Realizados: 0";
                lblTiempoTranscurrido.Text = "00:00:00";
                EnMovimientos = 0;
                btnPauseOContinuar.Enabled = false;
                MessageBox.Show("El Tiempo se agotó.\n\nInténtalo de Nuevo", "Imagen RompeCabezas-Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Barajar();
            }
        }

        // Metodo Cargar Foto
        //private void SeleccionarImagen_Click(object sender, EventArgs e)
        //{
        //    foto = "";
        //    while (foto == "")
        //    {
        //        OFDialog.ShowDialog();
        //        foto = OFDialog.FileName;
        //    }

        //    gbOriginal.Load();
        //    Romper(); 
        //}

        //public void Romper()
        //{
        //    Bitmap bitOriginal, bit;
        //    int ancho, largo, x, y, i;
        //    Rectangle area;

        //    bitOriginal = new Bitmap(foto);
        //    ancho = bitOriginal.Width / 3;
        //    largo = bitOriginal.Height / 3;
        //    i = 0;
        //    x = 0;
        //    y = 0;

        //    do
        //    {
        //        area = new Rectangle(x, y, ancho, largo);
        //        bit = new Bitmap(ancho, largo);
        //        bit = bitOriginal.Clone(area, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        //        picturebox[i].Image = bit;

        //        if ((i + 1) % 3 == 0)
        //        {
        //            y = y + largo;
        //            x = 0;
        //        }
        //        else
        //        {
        //            x = x + ancho;

        //        }
        //        i++;

        //    } while (i < 9);
        //    Barajar();
        //}

        private void PauseOContinuar(object sender, EventArgs e)
        {
            if (btnPauseOContinuar.Text == "Pausar ||")
            {
                tiempo.Stop();
                btnBarajar.Enabled = false;
                btnPauseOContinuar.BackColor = Color.PaleVioletRed;
                tooltip.SetToolTip(btnPauseOContinuar, "Continuar");
                gbCajaRompeCabezas.Visible = false;
                btnPauseOContinuar.Text = "Continuar ||⏵";
            }
            else
            {
                tiempo.Start();
                gbCajaRompeCabezas.Visible = true; //muestra el rompecabezas
                btnBarajar.Enabled = true;
                btnPauseOContinuar.BackColor = Color.LightGreen;
                btnPauseOContinuar.Text = "Pausar ||";
                tooltip.SetToolTip(btnPauseOContinuar, "Pausar");
            }
        }
    }
}
