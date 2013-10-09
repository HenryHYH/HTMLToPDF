using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string Directory
        {
            get
            {
                var directory = new System.IO.DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
                return directory.Parent.FullName;
            }
        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            bool flag = HTMLtoPDFConverter.HtmlToPdf(txtUrl.Text.Trim(), string.Format(@"{0}\File\A.pdf", Directory));
            sw.Stop();
            lbMessage.Text = string.Format("Flag = {0}; Time = {1};", flag, sw.ElapsedMilliseconds);
        }

        protected void btnRunEO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var result = EO.Pdf.HtmlToPdf.ConvertUrl(txtUrl.Text.Trim(), string.Format(@"{0}\File\B.pdf", Directory));
            sw.Stop();
            lbMessage.Text = string.Format("Time = {0};", sw.ElapsedMilliseconds);
        }
    }
}