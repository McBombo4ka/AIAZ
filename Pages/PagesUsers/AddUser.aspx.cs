using AI.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI.Pages.PagesUsers
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListPosition.DataSource = DataAccessor.SelectPositions();
                DropDownListPosition.DataValueField = "NamePosition";
                DropDownListPosition.DataTextField = "NamePosition";
                DropDownListPosition.DataBind();
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.IdPosition = int.Parse(DropDownListPosition.SelectedValue); //перечислить все поля таблицы. Age не нужно вызывать
            user.NameUser = TextBoxNameUser.Text;
            user.BirthDateUser = DateTime.Parse(TextBoxBirthDateUser.Text);
        }
    }
}