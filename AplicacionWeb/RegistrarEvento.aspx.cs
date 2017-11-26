using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace AplicacionWeb
{
    public partial class RegistrarEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MenuOrganizador.aspx");
        }

        protected void rbManana_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbTarde_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbNoche_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbComun_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void rbPremium_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}