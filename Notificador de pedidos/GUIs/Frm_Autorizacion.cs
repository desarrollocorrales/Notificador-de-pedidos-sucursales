using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Notificador_de_pedidos.GUIs
{
    public partial class Frm_Autorizacion : Form
    {
        private Frm_Lanzador frmLanzador;

        public Frm_Autorizacion(Frm_Lanzador frmLanzador)
        {
            InitializeComponent();
            this.frmLanzador = frmLanzador;
        }

        //Obtener Hash MD5
        private string ObtenerMd5Hash(string input)
        {
            // Crear un Stringbuilder para colexionar los bytes y crear un nuevo string.
            StringBuilder sBuilder = new StringBuilder();

            using (MD5 md5Hash = MD5.Create())
            {
                // Convertir el string a un arreglo de bytes
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Ciclo a traves de cada byte para formar el string en Hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }
            }

            // Regresar el String en Hexadecimal
            return sBuilder.ToString();
        }
        private string ObtenerContraseñaDelSistema()
        {
            string sPass = string.Empty;

            var archivo = new StreamReader("system.pw");
            sPass = archivo.ReadLine();

            return sPass;
        }
        private bool Autorizar()
        {
            string pass = txbPass.Text.ToUpper().Trim();
            string passCifrada = ObtenerMd5Hash(pass);
            string passComparacion = ObtenerContraseñaDelSistema();

            if (passCifrada.ToUpper() == passComparacion.ToUpper())
                return true;

            return false;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (Autorizar() == true)
            {
                frmLanzador.tmAccion.Stop();
                frmLanzador.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Autorizar() == true)
            {
                frmLanzador.tmAccion.Stop();
                frmLanzador.Show();
                this.Close();
            }
        }

        private void Frm_Autorizacion_Load(object sender, EventArgs e)
        {

        }
    }
}
