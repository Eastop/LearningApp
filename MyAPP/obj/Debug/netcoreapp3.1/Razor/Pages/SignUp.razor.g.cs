#pragma checksum "C:\inetpub\wwwroot\MyAPP\MyAPP\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5558f220c86824662f8f9e685b75677bfc02cbca"
// <auto-generated/>
#pragma warning disable 1591
namespace MyAPP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using MyAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\MyAPP\MyAPP\_Imports.razor"
using MyAPP.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\r\n");
            __builder.AddMarkupContent(1, "<html>\r\n<head>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <style>\r\n        * {\r\n            margin: 0;\r\n            padding: 0;\r\n            box-sizing: border-box;\r\n        }\r\n\r\n        html {\r\n            height: 100%;\r\n        }\r\n\r\n        body {\r\n            font-family: \'Segoe UI\', sans-serif;\r\n            ;\r\n            font-size: 1rem;\r\n            line-height: 1.6;\r\n            height: 100%;\r\n        }\r\n\r\n        .wrap {\r\n            width: 100%;\r\n            height: 100%;\r\n            display: flex;\r\n            justify-content: center;\r\n            align-items: center;\r\n            background: #fafafa;\r\n        }\r\n\r\n        .login-form {\r\n            width: 350px;\r\n            margin: 0 auto;\r\n            border: 1px solid #ddd;\r\n            padding: 2rem;\r\n            background: #ffffff;\r\n        }\r\n\r\n        .form-input {\r\n            background: #fafafa;\r\n            border: 1px solid #eeeeee;\r\n            padding: 12px;\r\n            width: 100%;\r\n        }\r\n\r\n        .form-group {\r\n            margin-bottom: 1rem;\r\n        }\r\n\r\n        .form-button {\r\n            background: #69d2e7;\r\n            border: 1px solid #ddd;\r\n            color: #ffffff;\r\n            padding: 10px;\r\n            width: 100%;\r\n            text-transform: uppercase;\r\n        }\r\n\r\n            .form-button:hover {\r\n                background: #69c8e7;\r\n            }\r\n\r\n        .form-header {\r\n            text-align: center;\r\n            margin-bottom: 2rem;\r\n        }\r\n\r\n        .form-footer {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class=\"wrap\">\r\n        <form class=\"login-form\" action>\r\n            <div class=\"form-header\">\r\n                <h3>Register</h3>\r\n                <p>Please fill in this form to create an account.</p>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"text\" class=\"form-input\" placeholder=\"email@example.com\" name=\"email\" required=\"required\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"password\" class=\"form-input\" placeholder=\"password\" name=\"pswd\" required=\"required\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"password\" class=\"form-input\" placeholder=\"Repeat Password\" name=\"psw-repeat\" required=\"required\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"text\" class=\"form-input\" placeholder=\"First Name\" name=\"fname\" required=\"required\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"password\" class=\"form-input\" placeholder=\"Last Name\" name=\"lname\" required=\"required\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"password\" class=\"form-input\" placeholder=\"Middle Name\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"password\" class=\"form-input\" placeholder=\"080xxxxx\" name=\"mobile\" required=\"required\">\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"file\" class=\"form-input\" placeholder=\".png or .jpg\" name=\"picture\" required>\r\n            </div>\r\n            \r\n\r\n\r\n\r\n\r\n            <p>By creating an account you agree to our <a href=\"#\">Terms & Privacy</a>.</p>\r\n\r\n            \r\n            <div class=\"form-group\">\r\n                <button class=\"form-button\" type=\"submit\">Register</button>\r\n            </div>\r\n\r\n            <div class=\"container signin\">\r\n                <p>Already have an account? <a href=\"https://localhost:44353/login\">Sign in</a>.</p>\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </form>\r\n    </div>\r\n</body>\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
