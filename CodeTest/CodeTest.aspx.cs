using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeTest
{
    public partial class CodeTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("first Number:" + Series.GetFirstNumber(1));

            var firstNumber = Series.GetFirstNumber(1);
            var growthRate = Series.GetGrowthRate(5062.5, firstNumber);

            //Response.Write("growthRate:" + growthRate);
            //Response.Write("<br>first Number:" + Series.getGrowthRate(5062.5,1.62));

            Response.Write(Series.CompleteSeries(firstNumber,growthRate,5));

            Response.Write("<br>" + Series.SpecialNumbers(1000,160));

        }
    }
}