using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dyertm_InClass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbFruits.Items.Add("Strawberry");
                // This should only run once when the page is initally loaded in the browser
            }
        }

        protected void lbFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            //This code runs when the user selects a new item from the lbFruits list box
            //copy the currently select item form the list box into our label
            lblChosenFruit.Text = lbFruits.SelectedValue;
        }
        // I need an avent that will run when the user,
        // in there browser, selects a fruit from the list box
        // event-driven programming
        // our event is the user selected an item from the list box
    }
}