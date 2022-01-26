using AI.App_Code.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AI.Pages.PagesUsers
{
    public partial class ListUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                BindGrid();
            }

        }
        private void BindGrid()
        {
            GridViewUsers.AutoGenerateColumns = false;
            GridViewUsers.DataSource = DataAccessor.SelectUsers();
            GridViewUsers.DataBind();
        }
        protected void GridViewUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GridViewUsers.Rows[e.RowIndex].Cells[0].Text);
            DataAccessor.DeleteUser(id);
            BindGrid();
        }

        protected void GridViewUsers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int id = int.Parse(GridViewUsers.Rows[e.NewEditIndex].Cells[0].Text);
            Response.Redirect("~/Pages/PagesUsers/EditUser.aspx?id=" + id);
        }

        protected void GridViewUsers_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                ((LinkButton)e.Row.Cells[1].Controls[0]).OnClientClick = "return confirm('Вы уверены, что хотите удалить запись?')";
            }
        }
    }
}