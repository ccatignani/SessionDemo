using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SessionDemo.Classes;


namespace SessionDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtTeam.Text = string.Empty;
            txtDirection.Text = string.Empty;
        }
        //==========[ Session ]================================================================================
        protected void BtnSaveSessionVars_Click(object sender, EventArgs e)
        {
            SSS.Save(SSS.Name,txtName.Text);
            SSS.Save(SSS.Team,txtTeam.Text);
            SSS.Save(SSS.Direction,txtDirection.Text);
        }

        protected void BtnRetrieveSessionVars_Click(object sender, EventArgs e)
        {
            txtName.Text = SSS.Retrieve(SSS.Name);
            txtTeam.Text = SSS.Retrieve(SSS.Team);
            txtDirection.Text = SSS.Retrieve(SSS.Direction);
        }

        protected void BtnDeleteSessionVars_Click(object sender, EventArgs e)
        {
            SSS.DisoseAll();
        }

        //==========[ Cookie ]================================================================================
        protected void BtnSaveCookie_Click(object sender, EventArgs e)
        {
            Cookie.Save(SSS.Name, txtName.Text);
            Cookie.Save(SSS.Team, txtTeam.Text);
            Cookie.Save(SSS.Direction, txtDirection.Text);
        }

        protected void BtnRetrieveCookie_Click(object sender, EventArgs e)
        {
            txtName.Text = Cookie.Retrieve(SSS.Name);
            txtTeam.Text = Cookie.Retrieve(SSS.Team);
            txtDirection.Text = Cookie.Retrieve(SSS.Direction);
        }

        protected void BtnDeleteCookie_Click(object sender, EventArgs e)
        {
            Cookie.Delete(SSS.Name);
            Cookie.Delete(SSS.Team);
            Cookie.Delete(SSS.Direction);
        }

        //==========[ Hybrid ]================================================================================
        protected void BtnSaveHybrid_Click(object sender, EventArgs e)
        {
            Hybrid.Save(SSS.Name, txtName.Text);
            Hybrid.Save(SSS.Team, txtTeam.Text);
            Hybrid.Save(SSS.Direction, txtDirection.Text);
        }

        protected void BtnRetrieveHybrid_Click(object sender, EventArgs e)
        {
            txtName.Text = Hybrid.Retrieve(SSS.Name);
            txtTeam.Text = Hybrid.Retrieve(SSS.Team);
            txtDirection.Text = Hybrid.Retrieve(SSS.Direction);
        }

        protected void BtnDeleteHybrid_Click(object sender, EventArgs e)
        {
            Hybrid.Delete(SSS.Name);
            Hybrid.Delete(SSS.Team);
            Hybrid.Delete(SSS.Direction);
        }



    }
}