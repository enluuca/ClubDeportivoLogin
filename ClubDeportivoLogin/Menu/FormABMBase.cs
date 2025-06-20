namespace ClubDeportivoLogin
{
    public partial class FormABMBase : Form
    {
        // Configuración de la entidad
        public class ConfigABM
        {
            public string TituloVentana { get; set; }
            public string Titulo { get; set; }
            public string Subtitulo { get; set; }
            public string Ayuda1 { get; set; }
            public string Ayuda2 { get; set; }
            public string EtiquetaCampo { get; set; }
            public Image Icono { get; set; }
            public Func<string, bool> Validacion { get; set; }
            public Action<string> AccionSiguiente { get; set; }
            public bool UsarModoPagos { get; set; } = false;
            public Func<string, IEnumerable<string>> ObtenerSugerencias { get; set; }
        }

        private ConfigABM config;
        private string usuario;
        private System.Windows.Forms.Timer timerBusqueda;
        private List<string> sugerenciasActuales = new List<string>();

        public FormABMBase(string usuario, ConfigABM config)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.config = config;
            ConfigurarInterfaz();
            btnSiguiente.Click += btnSiguiente_Click;
            btnSalir.Click += btnSalir_Click;
            

            // Configuración especial para ABM de Pagos
            if (config.UsarModoPagos)
            {
                cmbModo.Visible = true;
                lblmodo.Visible = true;
                lblFondo.Size = new Size(313, 90);
                cmbModo.Items.Clear();
                cmbModo.Items.Add("NUEVO PAGO");
                cmbModo.Items.Add("CONSULTAR PAGO");
                cmbModo.SelectedIndex = 0;
                cmbModo.SelectedIndexChanged += cmbModo_SelectedIndexChanged;

                txtCampoID.Visible = true;
                txtCentroID.Visible = false;
                txtComprobanteID.Visible = false;
            }
            else
            {
                cmbModo.Visible = false;
                txtCampoID.Visible = true;
                txtCentroID.Visible = false;
                txtComprobanteID.Visible = false;
                lblmodo.Visible = false;
                lblFondo.Size = new Size(313, 50);
            }

            // INICIALIZAR SISTEMA DE AUTOCOMPLETADO
            InicializarAutocompletado();
        }

        private void ConfigurarInterfaz()
        {
            this.Text = config.TituloVentana;
            lblTitulo.Text = config.Titulo;
            lblSubtitulo.Text = config.Subtitulo;
            lblAyuda1.Text = config.Ayuda1;
            lblAyuda2.Text = config.Ayuda2;
            lblCampoID.Text = config.EtiquetaCampo;
            pictureIcono.Image = config.Icono;
        }

        private void InicializarAutocompletado()
        {
            listSugerencia.Visible = false;

            listSugerencia.Leave += (s, e) => OcultarSugerencias();

            timerBusqueda = new System.Windows.Forms.Timer();
            timerBusqueda.Interval = 300;
            timerBusqueda.Tick += (s, e) => ActualizarSugerencias();

            txtCampoID.TextChanged += (s, e) =>
            {
                timerBusqueda.Stop();
                timerBusqueda.Start();
            };

            txtCampoID.KeyDown += txtCampoID_KeyDown;
            txtCampoID.Leave += (s, e) => OcultarSugerencias();
        }

        private void ActualizarSugerencias()
        {
            timerBusqueda.Stop();

            if (config?.ObtenerSugerencias == null)
            {
                OcultarSugerencias();
                return;
            }

            string texto = txtCampoID.Text.Trim();
            if (texto.Length < 2) 
            {
                OcultarSugerencias();
                return;
            }

            sugerenciasActuales = config.ObtenerSugerencias(texto).ToList();

            if (sugerenciasActuales.Count > 0)
            {
                MostrarSugerencias();
            }
            else
            {
                OcultarSugerencias();
            }
        }

        private void MostrarSugerencias()
        {
            listSugerencia.Location = new Point(
                txtCampoID.Left,
                txtCampoID.Bottom + 2
            );
            listSugerencia.Width = txtCampoID.Width;
            listSugerencia.Height = 120; 

            listSugerencia.DataSource = null;
            listSugerencia.DataSource = sugerenciasActuales;
            listSugerencia.Visible = true;
            listSugerencia.BringToFront();
        }

        private void OcultarSugerencias()
        {
            listSugerencia.Visible = false;
        }


        private void txtCampoID_KeyDown(object sender, KeyEventArgs e)
        {
            if (listSugerencia.Visible)
            {
                if (e.KeyCode == Keys.Down)
                {
                    if (listSugerencia.Items.Count > 0)
                    {
                        listSugerencia.SelectedIndex = 0;
                        listSugerencia.Focus();
                    }
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    if (listSugerencia.SelectedItem != null)
                    {
                    }
                    else if (sugerenciasActuales.Count > 0)
                    {
                        listSugerencia.SelectedIndex = 0;
                    }
                    e.Handled = true;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSiguiente.PerformClick();
                e.Handled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (config.UsarModoPagos && cmbModo.Visible && cmbModo.SelectedIndex == 1)
            {
                // CONSULTAR COMPROBANTE
                string centro = txtCentroID.Text.Trim();
                string comprobante = txtComprobanteID.Text.Trim();
                if (string.IsNullOrWhiteSpace(centro) || string.IsNullOrWhiteSpace(comprobante))
                {
                    MessageBox.Show("Ingrese centro y número de comprobante válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                config.AccionSiguiente($"{centro}|{comprobante}");
                txtCentroID.Clear();
                txtComprobanteID.Clear();
            }
            else
            {
                // NUEVO REGISTRO o modo clásico
                string input = txtCampoID.Text.Trim();
                if (!config.Validacion(input))
                {
                    MessageBox.Show($"Ingrese un {config.EtiquetaCampo} válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                config.AccionSiguiente(input);
                txtCampoID.Clear();
            }
        }

        private void cmbModo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModo.SelectedIndex == 0) // NUEVO REGISTRO
            {
                lblCampoID.Text = "DNI: ";
                txtCampoID.Visible = true;
                txtCentroID.Visible = false;
                txtComprobanteID.Visible = false;
                lblmodo.Visible = true;
                lblFondo.Size = new Size(313, 90);
            }
            else // CONSULTAR COMPROBANTE
            {
                lblCampoID.Text = "CENTRO Y N°: ";
                txtCampoID.Visible = false;
                txtCentroID.Visible = true;
                txtComprobanteID.Visible = true;
                lblmodo.Visible = true;
                lblFondo.Size = new Size(313, 90);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}