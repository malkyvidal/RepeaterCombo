using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RepeterWithCombo.Models;
namespace RepeterWithCombo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        const string POSTPL = "POSTPL";
        List<PostulacionPlaza> lista ;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }

        }

        //private void obtenerListaDeSession()
        //{
        //    if (Session[POSTPL] == null)
        //    {
        //        lista = new List<PostulacionPlaza>();
        //        Session[POSTPL] = lista;
        //    }

        //    lista = (List<PostulacionPlaza>)Session[POSTPL];

        //}

        private List<PostulacionPlaza> obtenerListaDeSession()
        {
            
            if (Session[POSTPL]==null)
            {
                List<PostulacionPlaza> lista = new List<PostulacionPlaza>();
                Session[POSTPL] = lista;
            }

            return (List<PostulacionPlaza>)Session[POSTPL];


        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            

            //obtenerListaDeSession().Add(obtenerPostulacionPlaza());

            GuardarPP(obtenerPostulacionPlaza(), obtenerListaDeSession());
            rp.DataSource = obtenerListaDeSession();
            rp.DataBind();

        }


        private void GuardarPP(PostulacionPlaza pp, List<PostulacionPlaza> lista)
        {
            
            if (lista.Count ==0)
            {
                lista.Add(pp);
            }
            else
            {
                verificarQuelAConvocatoria(pp, lista);
            }
        }


        private void verificarQuelAConvocatoria(PostulacionPlaza pp, List<PostulacionPlaza> lista)
        {

            if (lista.First().IdConvocatoria!=pp.IdConvocatoria)
            {
                plazaVal.InnerText = "Error UNo";
                
            }
            else
            {
                verificarPlazaNoEsta(pp, lista);
            }
        }

        private void verificarPlazaNoEsta(PostulacionPlaza pp, List<PostulacionPlaza> lista)
        {
            if (lista.Where(l=>l.IdConvocatoria==pp.IdConvocatoria&&l.IdPrograma==pp.IdPrograma&&l.IdUni==pp.IdUni).Count() > 0)
            {
                plazaVal.InnerText = "Error Dos";
            }
            else
            {
                lista.Add(pp);
            }

        }
        private PostulacionPlaza obtenerPostulacionPlaza()
        {
            PostulacionPlaza pp = new PostulacionPlaza();
            pp.IdConvocatoria = int.Parse(ddlCon.SelectedValue);
            pp.IdPrograma = int.Parse(ddlProg.SelectedValue);
            pp.IdUni = int.Parse(ddlUNi.SelectedValue);
            pp.NombrePrograna = ddlProg.SelectedItem.Text;
            pp.NombreUni = ddlUNi.SelectedItem.Text;
            return pp;
        }

        private void CargarComboConOpciones(DropDownList ddl, int cant)
        {
            Enumerable.Range(1, cant).ToList().ForEach(
                x => ddl.Items.Add(new ListItem { Value = x.ToString(), Text = x.ToString() })
                );
        }
        protected void rp_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                PostulacionPlaza pp = (PostulacionPlaza)e.Item.DataItem;
                Label programa = (Label)e.Item.FindControl("prograna");
                programa.Text = pp.NombrePrograna;
                Label ubi = (Label)e.Item.FindControl("uni");
                ubi.Text = pp.NombreUni;
                DropDownList com = (DropDownList)e.Item.FindControl("ddlop");
                CargarComboConOpciones(com, obtenerListaDeSession().Count);

            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cst.IsValid)
            {
                int f = 9;
            }
        }

       
    }
}