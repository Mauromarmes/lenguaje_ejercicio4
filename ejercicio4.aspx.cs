using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejercicio_4
{
    public partial class ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int edad;
            double pulsaciones;
            edad = Convert.ToInt16(txtedad.Text);
            pulsaciones = (220 - edad) / 10;
            lblpulsa.Text = System.Convert.ToString(pulsaciones);
        }
    }
}