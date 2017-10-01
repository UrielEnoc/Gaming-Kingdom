using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
public partial class Ingreso : System.Web.UI.Page
{

    private CollectionProductos myProduc {
        get
        {
            if (Session["MiColeccion"] == null)
            {
                Session["MiColeccion"] = new CollectionProductos();
            }
            return (CollectionProductos)Session["MiColeccion"];
        }
        set {
            Session["MiColeccion"] = value;
        }
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["NAME"] == null)
            {
                lblTitulo.Text = "Registro de productos";
                btnIngreso.Visible = true;

                btnModificar.Visible = false;
            }
            else
            {
                lblTitulo.Text = "Modificar productos";
                btnIngreso.Visible = false;
                btnModificar.Visible = true;
                foreach (var x in myProduc)
                {
                    if (x.CodProd.Equals(Session["NAME"].ToString()))
                    {
                        txtCod.Text =x.CodProd.ToString();
                        txtNombre.Text = x.NombreProd.ToString();
                        txtPrecio.Text = x.PrecioProd.ToString();
                        ddlTipo.SelectedValue = x.TipoProd.ToString();
                    }
                }
            }
        }
    }

    protected void btnIngreso_Click(object sender, EventArgs e)
    {
        if ((int)Session["Valida"]==0)
        {
            Producto myProducto = new Producto();
            try
            {
                myProducto.CodProd = int.Parse(txtCod.Text);
                //Falta juntar con enumeracion
                //Enum.TryParse(ddlTipo.SelectedValue, out myProducto.TipoProd);
                myProducto.NombreProd = txtNombre.Text;
                myProducto.PrecioProd = int.Parse(txtPrecio.Text);
                //Se agrega el producto a la coleccion para poder efectuarle los cambios pertinentes.
                myProduc.Add(myProducto);
                lblMsg.Text = "Producto registrado con éxito";

            }
            catch (Exception ex)
            {

                lblMsg.Text = "Error : " + ex.Message;
            }
        }
      
      
    }


    protected void btnModificar_Click(object sender, EventArgs e)
    //int _codProd, int _precioProd
    {
        if (myProduc.Modifica(myProduc, int.Parse(txtCod.Text),int.Parse(txtPrecio.Text)))
        {
            Response.Redirect("Listar.aspx");
        }else
        {
            lblMsg.Text = "No modificado";
        }
    }
}