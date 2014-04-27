using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.Controller;

namespace WebApp.EuropeBus
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtboxEmail.Text != "" && txtboxPassword.Text != "" && txtboxConfirmPassword.Text != "" && txtboxFirstName.Text != "" && txtboxSurname.Text != "" && txtboxPhoneNumber.Text != "" && txtboxAddress.Text != "" &&
                calDateOfBirth.SelectedDate != null)
            {
                if (txtboxPassword.Text == txtboxConfirmPassword.Text)
                {
                    if (CustomerHandler.addCustomer(txtboxFirstName.Text, txtboxSurname.Text, txtboxEmail.Text, txtboxPassword.Text, int.Parse(dropGender.SelectedValue), calDateOfBirth.SelectedDate, txtboxPhoneNumber.Text, txtboxAddress.Text))
                    {
                        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Registration successful! You will now be redirected.\")</SCRIPT>");
                        HttpContext.Current.Response.Redirect("../customer/RouteListing.aspx");
                        // Success
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"An error occurred during the creation of your account. Please try again.\")</SCRIPT>");
                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"Password mismatch. Please enter your passwords again.\")</SCRIPT>");
                    txtboxPassword.Text = "";
                    txtboxConfirmPassword.Text = "";
                }
            }
            else
            {
                HttpContext.Current.Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"All fields must be completed.\")</SCRIPT>");
            }

        }
    }
}