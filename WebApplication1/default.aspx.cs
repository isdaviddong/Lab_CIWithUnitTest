using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //建立個人資料
            BO.PersonalInfo Person = new BO.PersonalInfo();
            //取得並設定個人資料
            Person.Height = int.Parse(this.TextBoxHeight.Text);
            Person.Weight = int.Parse(this.TextBoxWeight.Text);
            //顯示BMI
            this.Label1.Text = $"BMI : {Person.BMI}";
        }
    }
}