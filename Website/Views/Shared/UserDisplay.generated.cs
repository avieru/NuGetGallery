﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/UserDisplay.cshtml")]
    public class UserDisplay : System.Web.Mvc.WebViewPage<dynamic>
    {
        public UserDisplay()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div class=\"user-display\">\r\n");


            
            #line 2 "..\..\Views\Shared\UserDisplay.cshtml"
     if (!User.Identity.IsAuthenticated)
    {

            
            #line default
            #line hidden
WriteLiteral("        <span class=\"welcome\"><a href=\"");


            
            #line 4 "..\..\Views\Shared\UserDisplay.cshtml"
                                  Write(Url.LogOn());

            
            #line default
            #line hidden
WriteLiteral("\">Log On</a></span> \r\n");



WriteLiteral("        <a href=\"");


            
            #line 5 "..\..\Views\Shared\UserDisplay.cshtml"
            Write(Url.Action(MVC.Users.Register()));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"register\">Register</a>\r\n");


            
            #line 6 "..\..\Views\Shared\UserDisplay.cshtml"
    }
    else {

            
            #line default
            #line hidden
WriteLiteral("        <span class=\"welcome\"><a href=\"");


            
            #line 8 "..\..\Views\Shared\UserDisplay.cshtml"
                                  Write(Url.Action(MVC.Users.Account()));

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 8 "..\..\Views\Shared\UserDisplay.cshtml"
                                                                    Write(User.Identity.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></span>\r\n");



WriteLiteral("        <span class=\"user-actions\">\r\n            <a href=\"");


            
            #line 10 "..\..\Views\Shared\UserDisplay.cshtml"
                Write(Url.LogOff());

            
            #line default
            #line hidden
WriteLiteral("\">Log Off</a> \r\n        </span>\r\n");


            
            #line 12 "..\..\Views\Shared\UserDisplay.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");


        }
    }
}
#pragma warning restore 1591
