
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calculadora2.Services;

namespace MvcWebFormEx
{
    public partial class Calculadora : System.Web.UI.Page
    {
        Calculator WS = new Calculator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Label1.Text = WS.Add(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = WS.Subtract(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = WS.Multiply(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = WS.Divide(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text)).ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
