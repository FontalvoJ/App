using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Drawing;


namespace App_Comercio
{
    internal interface cls_productos
    {
        private string str_mensaje;
        SqlCommand con; SqlDataReader Lectura;
        private string str_codigo;
        private string str_nombre;
        private long int_existencia;
        private double dbl_valor_compra;
        private double dbl_ganancia;
        private long int_categoria;
        private string str_especificaciones;
        private long int_estado;
        private string str_usuario;

        public void fnt_agregar(string codigo, string nombre, long existencia, double valorCompra, double ganancia,
                                long categoria, string especificaciones, long estado, string usuario)
        {
            try
            {
                cls_conexion objConecta = new cls_conexion();
                SqlCommand con = new SqlCommand("sp_agregarproducto", objConecta.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@codigo", codigo);
                con.Parameters.AddWithValue("@nombre", nombre);
                con.Parameters.AddWithValue("@existencia", existencia);
                con.Parameters.AddWithValue("@valor_compra", valorCompra);
                con.Parameters.AddWithValue("@ganancia", ganancia);
                con.Parameters.AddWithValue("@categoria", categoria);
                con.Parameters.AddWithValue("@especificaciones", especificaciones);
                con.Parameters.AddWithValue("@estado", estado);
                con.Parameters.AddWithValue("@usuario", usuario);
                objConecta.connection.Open();
                con.ExecuteNonQuery();
                objConecta.connection.Close();
                str_mensaje = "Registro exitoso";
            }
            catch (Exception)
            {
                str_mensaje = "Faltan campos / este registro ya existe";
            }
        }

        //public void fnt_consultar(string codigo)
        //{
        //    try
        //    {
        //        cls_conexion objConecta = new cls_conexion();
        //        SqlCommand con = new SqlCommand("SP_Consultar_Producto", objConecta.connection);
        //        con.CommandType = CommandType.StoredProcedure;
        //        con.Parameters.AddWithValue("@codigo", codigo);
        //        objConecta.connection.Open();
        //        SqlDataReader Lectura = con.ExecuteReader();
        //        if (Lectura.Read())
        //        {
        //            str_nombre = Convert.ToString(Lectura["nombre"]);
        //            int_existencia = Convert.ToInt64(Lectura["existencia"]);
        //            dbl_valor_compra = Convert.ToDouble(Lectura["valor_compra"]);
        //            dbl_ganancia = Convert.ToDouble(Lectura["ganancia"]);
        //            int_categoria = Convert.ToInt64(Lectura["categoria"]);
        //            str_especificaciones = Convert.ToString(Lectura["especificaciones"]);
        //            int_estado = Convert.ToInt64(Lectura["estado"]);
        //            str_usuario = Convert.ToString(Lectura["usuario"]);
        //            str_mensaje = "";
        //        }
        //        objConecta.connection.Close();
        //    }
        //    catch (Exception)
        //    {
        //        str_mensaje = "No se encontraron registros";
        //    }
        //}

        public string getMensaje() { return str_mensaje; }
        public string getNombre() { return str_nombre; }
        public long getExistencia() { return int_existencia; }
        public double getValorCompra() { return dbl_valor_compra; }
        public double getGanancia() { return dbl_ganancia; }
        public long getCategoria() { return int_categoria; }
        public string getEspecificaciones() { return str_especificaciones; }
        public long getEstado() { return int_estado; }
        public string getUsuario() { return str_usuario; }
    }
}
