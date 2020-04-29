using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Pdf.Live.Demos.UI.Config;
using Aspose.Pdf.Live.Demos.UI.Helpers;
using Aspose.Pdf.Live.Demos.UI.Models;

namespace Aspose.Pdf.Live.Demos.UI
{
    public partial class Editor : BasePage
    {
		public string AsposeEditorApi = Configuration.AsposeAppLiveDemosPath + "api/AsposePDFEditor/";
		protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["Product"] == null)
            {
                Page.RouteData.Values["Product"] = "pdf";
            }
            var productTitle = "Aspose" + TitleCase(Product);

            Page.Title = "Edit PDF document online";

			Page.MetaDescription = "Free online PDF document editor. View, edit, convert PDF documents with advanced WYSIWYG editor.";

			AsposeProductTitle.InnerText = "Aspose.PDF Editor";

			ProductTitle.InnerText = "PDF Editor";

			ProductTitleSub.InnerText = "Edit PDF document online";

			ProductImage.Src = "~/img/aspose-" + Product + "-app.png";

			string EditorValidationExpression = ".pdf";
            //SetValidationExpression(EditorValidationExpression, ValidateFileType);

            
        }

        protected void BtnEditor_Click(object sender, EventArgs e)
        {
            //if (IsValid)
            //{
            //    if (CheckFileInputs(UploadFileInput))
            //    {
            //        EditorPlaceHolder.Visible = false;
            //        DownloadPlaceHolder.Visible = true;
            //    }
            //    else
            //        ShowErrorMessage(EditorMessage, Resources["FileSelectMessage"]);
            //}
        }
    }
}
