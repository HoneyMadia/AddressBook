using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DropDownList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCountry_Click(object sender, EventArgs e)
    {
        foreach (ListItem li in ddlCountry.Items)
        {
            if (li.Selected)
            {
                lblMessage.Text += "<strong>" + li.Value.Trim() + " - " + li.Text.Trim() + " </strong> <br /> ";
            }
            else
            {
                lblMessage.Text += li.Value.Trim() + " - " + li.Text.Trim() + " <br /> ";
            }
        }
    }
    protected void btnAddItem_Click(object sender, EventArgs e)
    {
        if(txtCountryCode.Text != "" && txtCountryName.Text != "")
        {
            ListItem li = new ListItem();
            li.Text = txtCountryName.Text;
            li.Value = txtCountryCode.Text;
            ddlCountry.Items.Add(li);
            lblMessage.Text = "";
            txtCountryCode.Text = "";
            txtCountryName.Text = "";
        }

        else if(txtCountryName.Text =="" && txtCountryCode.Text == "")
        {
            lblMessage.Text = "Please! Enter Country Name and Country Code";
        }
        else
        {
            if(txtCountryName.Text == "")
            {
                lblMessage.Text = "Please! Enter Contry Name";
            }
            else
            {
                lblMessage.Text = "Please! Enter Country Code";
            }
        }

        for (int i = 0; i < ddlCountry.Items.Count; i++)
        {
            ddlCountry.SelectedIndex = i;
            string str = ddlCountry.SelectedItem.ToString();
            for (int counter = i + 1; counter < ddlCountry.Items.Count; counter++)
            {
                ddlCountry.SelectedIndex = counter;
                string compareStr = ddlCountry.SelectedItem.ToString();
                if (str == compareStr)
                {
                    ddlCountry.Items.RemoveAt(counter);
                    counter = counter - 1;
                    lblMessage.Text = "Duplicate Data Found! Please try with another data";
                }
            }
        }
        
        txtCountryCode.Text = "";
        txtCountryName.Text = "";
        txtCountryCode.Focus();
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string strCountry = "";
        foreach (ListItem liCountry in ddlCountry.Items)
        {
            strCountry += liCountry.Value + "-" + liCountry.Text + "<br/>";
        }
        lblMessage.Text = strCountry;
    }
    protected void btnRemoveItem_Click(object sender, EventArgs e)
    {
        
        if (txtCountryCode.Text != "" && txtCountryName.Text != "")
        {
            ListItem li = new ListItem();
            li.Text = txtCountryName.Text;
            li.Value = txtCountryCode.Text;
            ddlCountry.Items.Remove(li);
            lblMessage.Text = "";
            txtCountryCode.Text = "";
            txtCountryName.Text = "";
        }

        else if (txtCountryName.Text == "" && txtCountryCode.Text == "")
        {
            lblMessage.Text = "Please! Enter Country Name and Country Code to Remove";
        }
        else
        {
            if (txtCountryName.Text == "")
            {
                lblMessage.Text = "Please! Enter Contry Name to Remove";
            }
            else
            {
                lblMessage.Text = "Please! Enter Country Code to Remove";
            }
        }
    }
}