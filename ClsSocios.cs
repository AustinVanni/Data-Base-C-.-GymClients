using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Data.OleDb;

namespace IEFI_PROGRAMACION_LOGICA
{
    internal class ClsSocios
    {

        private String NombreArchivo = "Socios.csv";
        private Decimal deuda;


        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD_Clientes.mdb";
        private string tabla = "Socio";
        private string Barrio = "Barrio";
        private string Actividad = "Actividad";

       
        private Int32 cantidad;
        


        private Int32 idCli;
        private Int32 idAct;
        private String dire;
        private String nom;
        private Decimal deu;
        
        private Decimal lim;
        private Int32 idCiu;
        private Int32 idBar;


        public Int32 IdCliente
        {
            get { return idCli; }
            set { idCli = value; }
        }


        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }
        public Decimal Deuda
        {
            get { return deu; }
            set { deu = value; }
        }
        
        public Int32 IdBarrio
        {
            get { return idBar; }
            set { idBar = value; }
        }
        public string Direccion
        {
            get { return  dire; }
            set { dire = value; }
        }

        public Int32 IdActividad
        {
            get { return idAct; }
            set { idAct = value; }
        }

        public Decimal TotalDeuda
        {
            get { return deuda; }
        }

        public Decimal PromedioDeuda
        {
            get
            {
                Decimal promedio = 0;
                if (cantidad != 0) promedio = deuda / cantidad;
                return promedio;
            }
        }
        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }




        public void ListarTodos(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();

                deuda = 0;


                while (DR.Read())
                {
                    
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));

                        deuda = deuda + DR.GetDecimal(5);


                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }




        public void GrabarDatos()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);

                DataTable Table = DS.Tables[tabla];
                DataRow fila = Table.NewRow();

                fila["IdSocio"] = idCli;
                fila["Nombre"] = nom;
                fila["Deuda"] = deu;
                fila["Direccion"] = dire;
                fila["idBarrio"] = idBar;
                fila["idActividad"] = idAct;



                Table.Rows.Add(fila);
                OleDbCommandBuilder ConciliaCambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, tabla);
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        public void ListarDeudores(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                
                deuda = 0;


                while (DR.Read())
                {
                    if (DR.GetDecimal(5) > 0)
                    {
                        Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));
                        
                        deuda = deuda + DR.GetDecimal(5);
                         

                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void BuscarSocio(Int32 IdCliente)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                idCli = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdCliente)
                        {
                            idCli = DR.GetInt32(0);
                            nom = DR.GetString(1);
                            deu = DR.GetDecimal(5);
                            dire = DR.GetString(2);
                            
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Modificar(Int32 IdCliente)
        {
            try
            {
                String sql = "";
                sql = "UPDATE Socio  SET Deuda = ";
                sql = sql + Convert.ToDecimal(Deuda.ToString());
                sql = sql + " WHERE IdSocio = ";
                sql = sql + IdCliente.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public String Buscar(Int32 IdSocio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                String Resultado = "";
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(0) == IdSocio)
                        {
                            Resultado = DR.GetString(1);
                        }
                    }
                }
                conexion.Close();
                return Resultado;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public void Listar(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Barrio;    
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Barrio);
                Combo.DataSource = DS.Tables[Barrio];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "idBarrio";
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void ListarActividad(ComboBox Combo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Actividad;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();

                adaptador.Fill(DS, Actividad);
                Combo.DataSource = DS.Tables[Actividad];
                Combo.DisplayMember = "Nombre";
                Combo.ValueMember = "idActividad";
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }


        public void Eliminar(Int32 IdCliente)
        {
             try
            {
                String sql = "DELETE * FROM Socio WHERE IdSocio = " + IdCliente.ToString();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void LIstarClientesPorBarrio(DataGridView Grilla, Int32 IdBarrio)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                deuda = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(3) == IdBarrio)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));
                            deuda = deuda + DR.GetDecimal(5);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Imprimir(PrintPageEventArgs Reporte)
        {
            try
            {
                Font Titulo1 = new Font("Arial", 16);
                Font Titulo2 = new Font("Arial", 12);
                Font LetraNormal = new Font("Arial", 10); 
                Int32 cantidad = 0;
                Int32 f = 170;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);
                Reporte.Graphics.DrawString("Listado de clientes", Titulo1, Brushes.Black, 100, 100);
                Reporte.Graphics.DrawString("DNI", Titulo2, Brushes.Black, 100, 150);
                Reporte.Graphics.DrawString("Nombre", Titulo2, Brushes.Black, 200, 150);
                Reporte.Graphics.DrawString("Deuda", Titulo2, Brushes.Black, 500, 150);

                if (DS.Tables[tabla].Rows.Count > 0)
                {
                    foreach (DataRow Reg in DS.Tables[tabla].Rows)
                    {
                        Reporte.Graphics.DrawString(Reg["IdSocio"].ToString(), LetraNormal, Brushes.Black, 100, f);
                        Reporte.Graphics.DrawString(Reg["Nombre"].ToString(), LetraNormal, Brushes.Black, 200, f);
                        Reporte.Graphics.DrawString(Reg["Deuda"].ToString(), LetraNormal, Brushes.Black, 500, f);
                        f = f + 15;
                        cantidad++;
                    }
                }
                conexion.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(m.ToString()); ;
            }
        }

        public void ImprimirDeudores(System.Drawing.Printing.PrintPageEventArgs Reporte, DataGridView GrillaListado, String titulo)
        {
            Font Titulo1 = new Font("Arial", 16);
            Font Titulo2 = new Font("Arial", 12);
            Font LetraNormal = new Font("Arial", 10);
            Int32 cantidad = 0;
            Int32 f = 170;
            Reporte.Graphics.DrawString("Listado de clientes", Titulo1, Brushes.Black, 100, 100);
            Reporte.Graphics.DrawString("DNI", Titulo2, Brushes.Black, 100, 150);
            Reporte.Graphics.DrawString("Nombre", Titulo2, Brushes.Black, 200, 150);
            Reporte.Graphics.DrawString("Deuda", Titulo2, Brushes.Black, 500, 150);

            Int32 i = 0;
            while (i < GrillaListado.RowCount)
            {

                Reporte.Graphics.DrawString(Convert.ToString(GrillaListado.Rows[i].Cells[0].Value), LetraNormal, Brushes.Black, 100, f);
                Reporte.Graphics.DrawString(Convert.ToString(GrillaListado.Rows[i].Cells[1].Value), LetraNormal, Brushes.Black, 200, f);
                Reporte.Graphics.DrawString(Convert.ToString(GrillaListado.Rows[i].Cells[2].Value), LetraNormal, Brushes.Black, 500, f);
                f = f + 20;
                i++;

            }

        }

        public void ReporteSocioBarrio(Int32 IdBarrio)
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);
                StreamWriter archivo = new StreamWriter("ReporteSOCIOSbarrio.csv", false, Encoding.UTF8);
                archivo.WriteLine("Listado de socios de un barrio");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Deuda");
                if (DS.Tables[tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdBarrio"]) == IdBarrio)
                        {
                            archivo.Write(fila["IdSocio"]);
                            archivo.Write(";");
                            archivo.Write(fila["Nombre"]);
                            archivo.Write(";");
                            archivo.WriteLine(fila["Deuda"]);
                            cantidad++;
                            total = total + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Deuda:;");
                archivo.WriteLine(total);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public void ReporteDeActividad(Int32 IdActividad)
        {
            try
            {
                Int32 cantidad = 0;
                Decimal total = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, tabla);
                StreamWriter archivo = new StreamWriter("ReporteDeActividad.csv", false, Encoding.UTF8);
                archivo.WriteLine("Listado de Socios de una Actividad");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Deuda");
                if (DS.Tables[tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["idActividad"]) == IdActividad)
                        {
                            archivo.Write(fila["IdSocio"]);
                            archivo.Write(";");
                            archivo.Write(fila["Nombre"]);
                            archivo.Write(";");
                            archivo.WriteLine(fila["Deuda"]);
                            cantidad++;
                            total = total + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                }
                archivo.WriteLine();
                archivo.Write("Cantidad:;");
                archivo.WriteLine(cantidad);
                archivo.Write("Total Deuda:;");
                archivo.WriteLine(total);
                archivo.Close();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

       public void ListarClientesPorActividad(DataGridView Grilla, Int32 IdActividad)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                OleDbDataReader DR = comando.ExecuteReader();
                Grilla.Rows.Clear();
                deuda = 0;
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        if (DR.GetInt32(4) == IdActividad)
                        {
                            Grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(5));
                            deuda = deuda + DR.GetDecimal(5);
                        }
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
            
            
 }
 

   

