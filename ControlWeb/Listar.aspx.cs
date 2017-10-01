using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
public partial class Listar : System.Web.UI.Page
{
    private CollectionProductos myProduc {
        get
        {
            return (CollectionProductos)Session["MiColeccion"];
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MiColeccion"] == null)
        {
            Response.Redirect("Principal.aspx");
        }else
        {
            //El bind no lo entendi muy bien jeje.
            gdvProductos.DataSource = myProduc;
            gdvProductos.DataBind();
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
        }
    }

    protected void gdvProductos_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["NAME"] = gdvProductos.SelectedRow.Cells[1].Text;
        btnEliminar.Visible = true;
        btnModificar.Visible = true;
    }


    protected void btnModificar_Click(object sender, EventArgs e)
    {
        if(Session["NAME"] != null)
        {
            Response.Redirect("Ingreso.aspx");
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Session["NAME"] != null)
        {
            if(myProduc.Elimina(myProduc, int.Parse(Session["NAME"].ToString())))
            {
                //La cantidad de celdas para eliminar debe aumentar al parecer, no solo 3 quizas uno por cada atributo de "Producto"
                lblMsg.Text = "Eliminado con Éxito";
                Response.AppendHeader("Refresh", "3");

            }else
            {
                lblMsg.Text = "Error";
            }
        }
    }
}