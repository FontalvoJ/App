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
            cls_usuarios objUsuarios = new cls_usuarios();
            objUsuarios.fnt_agregar(txt_codigo.Text, txt_nombre.Text, txt_contacto.Text, txt_correo.Text, txt_direccion.Text);
            lbl_mensaje.Text = objUsuarios.getMensaje();
        }

        protected void bnt_consultar_Click(object sender, EventArgs e)
        {
            cls_usuarios objconsultar = new cls_usuarios();
            objconsultar.fnt_consultar(txt_codigo.Text);
            txt_contacto.Text = objconsultar.getContacto();
            txt_correo.Text = objconsultar.getCorreo();
            txt_direccion.Text = objconsultar.getDireccion();
            txt_nombre.Text = objconsultar.getNombre();
        }

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_contacto.Text = "";
            txt_correo.Text = "";
            txt_direccion.Text = "";
            txt_nombre.Text = "";
            txt_codigo.Focus();//ubicar cursor de escritura
        }
    }
}