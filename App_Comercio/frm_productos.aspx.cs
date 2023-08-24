using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_Comercio
{
    public partial class frm_usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
   

            cls_productos objproductos = new cls_productos();
            string codigo = txt_codigo.Text;
            string nombre = txt_nombre.Text;
            long existencia = Convert.ToInt64(txt_existencia.Text);
            double valorCompra = Convert.ToDouble(txt_valor_compra.Text);
            double ganancia = Convert.ToDouble(txt_ganancia.Text);
            long categoria = Convert.ToInt64(ddl_categoria.SelectedValue); // Use SelectedValue to get the selected value
            string especificaciones = txt_especificaciones.Text;
            long estado = Convert.ToInt64(ddl_estado.SelectedValue); // Use SelectedValue to get the selected value
            string usuario = lbl_usuarios.Text; // Update this to the appropriate source of the usuario

            objproductos.fnt_agregar(codigo, nombre, existencia, valorCompra, ganancia, categoria, especificaciones, estado, usuario);
            lbl_mensaje.Text = objproductos.getMensaje();



        }

        //protected void bnt_consultar_Click(object sender, EventArgs e)
        //{
        //    cls_usuarios objconsultar = new cls_usuarios();
        //    objconsultar.fnt_consultar(txt_codigo.Text);
        //    txt_contacto.Text = objconsultar.getContacto();
        //    txt_correo.Text = objconsultar.getCorreo();
        //    txt_direccion.Text = objconsultar.getDireccion();
        //    txt_nombre.Text = objconsultar.getNombre();
        //}

        //protected void btn_cancelar_Click(object sender, EventArgs e)
        //{
        //    txt_codigo.Text = "";
        //    txt_contacto.Text = "";
        //    txt_correo.Text = "";
        //    txt_direccion.Text = "";
        //    txt_nombre.Text = "";
        //    txt_codigo.Focus();//ubicar cursor de escritura
        //}
    }
}