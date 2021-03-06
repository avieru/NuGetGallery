﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Users
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Microsoft.Web.Helpers;
    using NuGetGallery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Users/Edit.cshtml")]
    public class Edit : System.Web.Mvc.WebViewPage<EditProfileViewModel>
    {
        public Edit()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\Users\Edit.cshtml"
  
    ViewBag.Title = "Edit Profile";


            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h1 class=\"page-heading\">Edit Profile</h1>\r\n\r\n");


            
            #line 9 "..\..\Views\Users\Edit.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 11 "..\..\Views\Users\Edit.cshtml"
 if (!String.IsNullOrEmpty(Model.PendingNewEmailAddress)) {

            
            #line default
            #line hidden
WriteLiteral("    <p class=\"message\">\r\n        You recently requested to change your email addr" +
"ess to <strong>");


            
            #line 13 "..\..\Views\Users\Edit.cshtml"
                                                                  Write(Model.PendingNewEmailAddress);

            
            #line default
            #line hidden
WriteLiteral("</strong>. \r\n        This change will take effect when you confirm the address. C" +
"heck your inbox (or spam folder) for an \r\n        email with a confirmation link" +
".\r\n    </p>\r\n");


            
            #line 17 "..\..\Views\Users\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 19 "..\..\Views\Users\Edit.cshtml"
 using (Html.BeginForm()) {
    
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Users\Edit.cshtml"
Write(Html.AntiForgeryToken());

            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Users\Edit.cshtml"
                            


            
            #line default
            #line hidden
WriteLiteral("    <fieldset class=\"form\">\r\n        <legend>Edit Profile</legend>\r\n\r\n        <di" +
"v class=\"form-field\">\r\n            ");


            
            #line 26 "..\..\Views\Users\Edit.cshtml"
       Write(Html.LabelFor(m => m.EmailAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 27 "..\..\Views\Users\Edit.cshtml"
       Write(Html.EditorFor(m => m.EmailAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n            ");


            
            #line 28 "..\..\Views\Users\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.EmailAddress));

            
            #line default
            #line hidden
WriteLiteral("\r\n            <span class=\"field-hint-message\">If you change your email address, " +
"you will need to confirm \r\n                your new address for it to take effec" +
"t.</span>\r\n        </div>\r\n\r\n        <div class=\"form-field\">\r\n            ");


            
            #line 34 "..\..\Views\Users\Edit.cshtml"
       Write(Html.EditorFor(m => m.EmailAllowed));

            
            #line default
            #line hidden
WriteLiteral(@"
            <label for=""EmailAllowed"" class=""checkbox"">
                Receive Email Notifications 
            </label>
            <p>
                <strong>Important:</strong> This setting allows other <em>registered</em> users of the site to contact you 
                about packages that you own using the <em>Contact Owners</em> form, or to request that you become an owner 
                of their package. Unchecking this means users cannot contact you for these reasons.
            </p>

        </div>

        <img src=""");


            
            #line 46 "..\..\Views\Users\Edit.cshtml"
             Write(Url.Content("~/content/images/required.png"));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Blue border on left means required.\" />\r\n\r\n        <input type=\"submit\" va" +
"lue=\"Save\" title=\"Save Changes\" />\r\n        <a class=\"cancel\" href=\"");


            
            #line 49 "..\..\Views\Users\Edit.cshtml"
                           Write(Url.Action("Account"));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Cancel Changes and go back.\">Cancel</a>\r\n    </fieldset>\r\n");


            
            #line 51 "..\..\Views\Users\Edit.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("BottomScripts", () => {

WriteLiteral("\r\n    <script src=\"");


            
            #line 54 "..\..\Views\Users\Edit.cshtml"
            Write(Url.Content("~/Scripts/jquery.validate.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n    <script src=\"");


            
            #line 55 "..\..\Views\Users\Edit.cshtml"
            Write(Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text/javascript\"></script>\r\n");


});


        }
    }
}
#pragma warning restore 1591
