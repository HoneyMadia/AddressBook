using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class List_Box_ListBox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAddItem_Click(object sender, EventArgs e)
    {
         if (txtCountryName.Text != "" && txtCountryCode.Text != "")
        {
           ListItem li = new ListItem();
           li.Text = txtCountryName.Text;
           li.Value = txtCountryCode.Text;
            lbCountry1.Items.Add(li);
            lblMessage.Text = "";

        }
        else if (txtCountryName.Text == "" && txtCountryCode.Text == "")
        {
            lblMessage.Text = "Enter Country Name and Country Code.";
        }
        else
        {
            if (txtCountryName.Text == "")
            {
                lblMessage.Text = "Enter Contry Name";
            }
            else
            {
                lblMessage.Text = "Enter Country Code";
            }
        }
        for (int i = 0; i < lbCountry1.Items.Count; i++)
        {
            lbCountry1.SelectedIndex = i;
            string str = lbCountry1.SelectedItem.ToString();
            for (int counter = i + 1; counter < lbCountry1.Items.Count; counter++)
            {
                lbCountry1.SelectedIndex = counter;
                string compareStr = lbCountry1.SelectedItem.ToString();
                if (str == compareStr)
                {
                    lbCountry1.Items.RemoveAt(counter);
                    counter = counter - 1;
                    lblMessage.Text = "Duplicate Data Found! Please try with another data";
                }
            }
        }
        txtCountryCode.Text = "";
        txtCountryName.Text = "";
        txtCountryCode.Focus();
    }
    protected void btnAddAll_Click(object sender, EventArgs e)
    {
        foreach (ListItem liCountry in lbCountry1.Items)
        {

            lbCountry2.Items.Add(liCountry);
        }

        lbCountry1.Items.Clear();
    }
    protected void btnAddOne_Click(object sender, EventArgs e)
    {
        foreach (ListItem liCountry in lbCountry1.Items)
        {

            if (liCountry.Selected == true)
            {
                lbCountry2.Items.Add(liCountry);

            }

        }

        for (int i = 0; i < lbCountry1.Items.Count; i++)
        {
            if (lbCountry1.Items[i].Selected)
            {
                lbCountry1.Items.Remove(lbCountry1.Items[i]);
                i--;
            }
        }
    }
    protected void btnRemoveOne_Click(object sender, EventArgs e)
    {
        foreach (ListItem liCountry in lbCountry2.Items)
        {

            if (liCountry.Selected == true)
            {
                lbCountry1.Items.Add(liCountry);

            }

        }

        for (int i = 0; i < lbCountry2.Items.Count; i++)
        {
            if (lbCountry2.Items[i].Selected)
            {
                lbCountry2.Items.Remove(lbCountry2.Items[i]);
                i--;
            }
        }
    }
    protected void btnRemoveAll_Click(object sender, EventArgs e)
    {
        foreach (ListItem liCountry in lbCountry2.Items)
        {

            lbCountry1.Items.Add(liCountry);
        }

        lbCountry2.Items.Clear();
    }
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        if (txtCountryCode.Text != "" && txtCountryName.Text != "")
        {
            ListItem li = new ListItem();
            li.Text = txtCountryName.Text;
            li.Value = txtCountryCode.Text;
            lbCountry1.Items.Remove(li);
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
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string strCountry = "";
        foreach (ListItem liCountry in lbCountry1.Items)
        {
            strCountry += liCountry.Value + "-" + liCountry.Text + "<br/>";
        }
        lblMessage1.Text = strCountry;
    }
}