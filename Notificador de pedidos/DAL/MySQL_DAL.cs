using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using Notificador_de_pedidos.Modelos;

namespace Notificador_de_pedidos.DAL
{
    public static class MySQL_DAL
    {
        private static MySqlConnection myConn = new MySqlConnection();
        private static MySqlCommand myComm = new MySqlCommand();
        private static MySqlDataAdapter myAdapter = new MySqlDataAdapter();

        private static string obtenerStringDeConexion()
        {
            var Config = Properties.Settings.Default;

            MySqlConnectionStringBuilder cs = new MySqlConnectionStringBuilder();
            cs.Server = Config.Servidor;
            cs.UserID = Config.Usuario;
            cs.Password = Config.Contraseña;
            cs.Port = Convert.ToUInt32(Config.Puerto);
            cs.Database = Config.BaseDeDatos;

            return cs.ToString();
        }

        public static List<string> ObtenerBasesDeDatos()
        {
            List<string> lstBasesDeDatos = new List<string>();

            try
            {
                myConn.ConnectionString = obtenerStringDeConexion();
                myConn.Open();
                
                myComm.Connection = myConn;
                myComm.CommandText = "Show Databases";
                
                DataTable dt = new DataTable();
                myAdapter.SelectCommand = myComm;
                myAdapter.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    lstBasesDeDatos.Add(Convert.ToString(fila[0]));
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
                throw ex;
            }

            return lstBasesDeDatos;
        }
        public static List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> lstSucursales = new List<Sucursal>();

            try
            {
                myConn.ConnectionString = obtenerStringDeConexion();
                myConn.Open();

                myComm.Connection = myConn;
                myComm.CommandText = "SELECT idsucursal, nombre FROM pedidos_sucursales WHERE status = 1";

                DataTable dt = new DataTable();
                myAdapter.SelectCommand = myComm;
                myAdapter.Fill(dt);

                Sucursal sucursal;
                foreach (DataRow fila in dt.Rows)
                {
                    sucursal = new Sucursal();
                    sucursal.ID = Convert.ToInt32(fila["idsucursal"]);
                    sucursal.Nombre = Convert.ToString(fila["nombre"]);
                    lstSucursales.Add(sucursal);
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
                throw ex;
            }

            return lstSucursales;
        }

        public static int ObtenerPedidosPendientes(int ID_Sucursal)
        {
            int iPedidos = 0;

            try
            {
                myConn.ConnectionString = obtenerStringDeConexion();
                myConn.Open();

                myComm.Connection = myConn;
                myComm.CommandText =
                        string.Format(@"SELECT COUNT(idsucursal) AS pedidos FROM pedidos_pedidos WHERE status = 2 AND idsucursal = {0}", ID_Sucursal);
                var respuesta = myComm.ExecuteScalar();
                iPedidos = respuesta == null ? 0 : Convert.ToInt32(respuesta);

                myConn.Close();
            }
            catch
            {
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
            }

            return iPedidos;
        }
    }
}
