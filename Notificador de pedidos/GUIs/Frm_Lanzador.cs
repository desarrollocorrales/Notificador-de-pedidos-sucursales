using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using System.Diagnostics;
using Notificador_de_pedidos.DAL;

namespace Notificador_de_pedidos.GUIs
{
    public partial class Frm_Lanzador : Form
    {
        private int iPedidosPendientes;

        public Frm_Lanzador()
        {
            InitializeComponent();
        }

        private void alrtPedidos_AlertClick(object sender, AlertClickEventArgs e)
        {
            var url = Properties.Settings.Default.UrlPedidos;

            Process.Start(url);
        }

        private void CrearNotificacion()
        {
            if (iPedidosPendientes > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(string.Format("Tiene {0} pedidos pendientes", iPedidosPendientes));
                sb.AppendLine("Haga clic aqui para verlos");

                AlertInfo info = new AlertInfo("Alerta de Pedidos", sb.ToString());

                alrtPedidos.Show(this, info);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                GuardarParametros();
                CargarBasesDeDatos();
            }
            catch (Exception ex)
            {
                var Mensaje = ex.Message;
                var Tipo = ex.GetType().ToString();
                MessageBox.Show(Mensaje, Tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarBasesDeDatos()
        {
             cmbBasesDeDatos.DataSource = MySQL_DAL.ObtenerBasesDeDatos();
        }
        private void GuardarParametros()
        {
            try
            {
                var Config = Properties.Settings.Default;

                Config.Segundos = Convert.ToInt32(txbSegundos.Text);
                Config.UrlPedidos = txbURL.Text.Trim();
                Config.Servidor = txbServidor.Text.Trim();
                Config.Usuario = txbUsuario.Text.Trim();
                Config.Contraseña = txbContraseña.Text.Trim();
                Config.Puerto = txbPuerto.Text;
                Config.BaseDeDatos = (string)cmbBasesDeDatos.SelectedItem;
                Config.ID_Sucursal = (cmbSucursales.SelectedValue == null) ? 0 : Convert.ToInt32(cmbSucursales.SelectedValue);

                Config.Save();
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                var tipo = ex.GetType().ToString();
                MessageBox.Show(mensaje, tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tmAccion_Tick(object sender, EventArgs e)
        {
            if (bgwConsultar.IsBusy == false)
            {
                bgwConsultar.RunWorkerAsync();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBasesDeDatos.Items.Count > 0)
                {
                    if (cmbSucursales.Items.Count > 0)
                    {
                        GuardarParametros();
                        GuardarIniciar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado la sucursal...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado la base de datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                var Mensaje = ex.Message;
                var Tipo = ex.GetType().ToString();
                MessageBox.Show(Mensaje, Tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GuardarIniciar()
        {
            var Config = Properties.Settings.Default;

            tmAccion.Interval = Config.Segundos * 1000;
            tmAccion.Start();

            this.Hide();
        }

        private void Frm_Lanzador_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
        private void Inicializar()
        {
            var Config = Properties.Settings.Default;

            txbSegundos.Text = Config.Segundos.ToString();
            txbURL.Text = Config.UrlPedidos;
            
            txbServidor.Text = Config.Servidor;
            txbUsuario.Text = Config.Usuario;
            txbContraseña.Text = Config.Contraseña;
            txbPuerto.Text = Config.Puerto;
        }

        private void niIcono_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MostrarConfiguracion();
        }
        private void MostrarConfiguracion()
        {
            new Frm_Autorizacion(this).Show();
        }

        private void Frm_Lanzador_Shown(object sender, EventArgs e)
        {
            this.Hide();
            tmAccion.Start();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargarSucursales_Click(object sender, EventArgs e)
        {
            try
            {
                CargarSucursales();
            }
            catch (Exception ex)
            {
                var Mensaje = ex.Message;
                var Tipo = ex.GetType().ToString();
                MessageBox.Show(Mensaje, Tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarSucursales()
        {
            GuardarParametros();
            cmbSucursales.DataSource = MySQL_DAL.ObtenerSucursales();
            cmbSucursales.DisplayMember = "Nombre";
            cmbSucursales.ValueMember = "ID";
        }

        private void bgwConsultar_DoWork(object sender, DoWorkEventArgs e)
        {
            var idSucursal = Properties.Settings.Default.ID_Sucursal;
            iPedidosPendientes = MySQL_DAL.ObtenerPedidosPendientes(idSucursal);
        }

        private void bgwConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CrearNotificacion();
        }

        private void alrtPedidos_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            e.AlertForm.Size = new Size(500, 200);
        }
    }
}
