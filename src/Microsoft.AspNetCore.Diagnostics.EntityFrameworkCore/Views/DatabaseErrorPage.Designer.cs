namespace Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore.RazorViews
{
    #line hidden
    using System;
    using System.Threading.Tasks;
#line 2 "DatabaseErrorPage.cshtml"
using System.Linq;

#line default
#line hidden
#line 3 "DatabaseErrorPage.cshtml"
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore;

#line default
#line hidden
#line 4 "DatabaseErrorPage.cshtml"
using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore.RazorViews;

#line default
#line hidden
    internal class DatabaseErrorPage : Microsoft.Extensions.RazorViews.BaseView
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "DatabaseErrorPage.cshtml"
  
    Response.StatusCode = 500;
    Response.ContentType = "text/html; charset=utf-8";
    Response.ContentLength = null; // Clear any prior Content-Length


#line default
#line hidden
            WriteLiteral(@"<!DOCTYPE html>

<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">
<head>
    <meta charset=""utf-8"" />
    <title>Internal Server Error</title>
    <style>
            body {
    font-family: 'Segoe UI', Tahoma, Arial, Helvetica, sans-serif;
    font-size: .813em;
    line-height: 1.4em;
    color: #222;
}

h1, h2, h3, h4, h5 {
    font-weight: 100;
}

h1 {
    color: #44525e;
    margin: 15px 0 15px 0;
}

h2 {
    margin: 10px 5px 0 0;
}

h3 {
    color: #363636;
    margin: 5px 5px 0 0;
}

code {
    font-family: Consolas, ""Courier New"", courier, monospace;
}

a {
    color: #1ba1e2;
    text-decoration: none;
}

    a:hover {
        color: #13709e;
        text-decoration: underline;
    }

hr {
    border: 1px #ddd solid;
}

body .titleerror {
    padding: 3px;
}

#applyMigrations {
    font-size: 14px;
    background: #44c5f2;
    color: #ffffff;
    display: inline-block;
    padding: 6px 12px;
    margin-bottom: 0;
    font-weight: norma");
            WriteLiteral(@"l;
    text-align: center;
    white-space: nowrap;
    vertical-align: middle;
    cursor: pointer;
    border: 1px solid transparent;
}

    #applyMigrations:disabled {
        background-color: #a9e4f9;
        border-color: #44c5f2;
    }

.error {
    color: red;
}

.expanded {
    display: block;
}

.collapsed {
    display: none;
}

    </style>
</head>
<body>
    <h1>");
#line 113 "DatabaseErrorPage.cshtml"
   Write(Strings.DatabaseErrorPage_Title);

#line default
#line hidden
            WriteLiteral("</h1>\r\n    <p>\r\n");
#line 115 "DatabaseErrorPage.cshtml"
         for (Exception ex = Model.Exception; ex != null; ex = ex.InnerException)
            {


#line default
#line hidden
            WriteLiteral("            <span>");
#line 117 "DatabaseErrorPage.cshtml"
             Write(ex.GetType().Name);

#line default
#line hidden
            WriteLiteral(": ");
#line 117 "DatabaseErrorPage.cshtml"
                                 Write(ex.Message);

#line default
#line hidden
            WriteLiteral("</span>\r\n            <br />\r\n");
#line 119 "DatabaseErrorPage.cshtml"
        }


#line default
#line hidden
            WriteLiteral("    </p>\r\n    <hr />\r\n\r\n");
#line 123 "DatabaseErrorPage.cshtml"
     if (!Model.DatabaseExists && !Model.PendingMigrations.Any())
    {


#line default
#line hidden
            WriteLiteral("        <h2>");
#line 125 "DatabaseErrorPage.cshtml"
       Write(Strings.FormatDatabaseErrorPage_NoDbOrMigrationsTitle(Model.ContextType.Name));

#line default
#line hidden
            WriteLiteral("</h2>\r\n        <p>");
#line 126 "DatabaseErrorPage.cshtml"
      Write(Strings.DatabaseErrorPage_NoDbOrMigrationsInfoPMC);

#line default
#line hidden
            WriteLiteral("</p>\r\n        <code> ");
#line 127 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_AddMigrationCommandPMC);

#line default
#line hidden
            WriteLiteral("</code>\r\n        <br />\r\n        <code> ");
#line 129 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_ApplyMigrationsCommandPMC);

#line default
#line hidden
            WriteLiteral("</code>\r\n        <p>");
#line 130 "DatabaseErrorPage.cshtml"
      Write(Strings.DatabaseErrorPage_NoDbOrMigrationsInfoCLI);

#line default
#line hidden
            WriteLiteral("</p>\r\n        <code> ");
#line 131 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_AddMigrationCommandCLI);

#line default
#line hidden
            WriteLiteral("</code>\r\n        <br />\r\n        <code> ");
#line 133 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_ApplyMigrationsCommandCLI);

#line default
#line hidden
            WriteLiteral("</code>\r\n        <hr />\r\n");
#line 135 "DatabaseErrorPage.cshtml"
    }
    else if (Model.PendingMigrations.Any())
    {


#line default
#line hidden
            WriteLiteral("        <div>\r\n            <h2>");
#line 139 "DatabaseErrorPage.cshtml"
           Write(Strings.FormatDatabaseErrorPage_PendingMigrationsTitle(Model.ContextType.Name));

#line default
#line hidden
            WriteLiteral("</h2>\r\n            <p>");
#line 140 "DatabaseErrorPage.cshtml"
          Write(Strings.FormatDatabaseErrorPage_PendingMigrationsInfo(Model.ContextType.Name));

#line default
#line hidden
            WriteLiteral("</p>\r\n\r\n            <ul>\r\n");
#line 143 "DatabaseErrorPage.cshtml"
                 foreach (var migration in Model.PendingMigrations)
                {


#line default
#line hidden
            WriteLiteral("                    <li>");
#line 145 "DatabaseErrorPage.cshtml"
                   Write(migration);

#line default
#line hidden
            WriteLiteral("</li>\r\n");
#line 146 "DatabaseErrorPage.cshtml"
                }


#line default
#line hidden
            WriteLiteral("            </ul>\r\n\r\n            <p>\r\n                <button id=\"applyMigrations\" onclick=\"ApplyMigrations()\">");
#line 150 "DatabaseErrorPage.cshtml"
                                                                    Write(Strings.DatabaseErrorPage_ApplyMigrationsButton);

#line default
#line hidden
            WriteLiteral(@"</button>
                <span id=""applyMigrationsError"" class=""error""></span>
                <span id=""applyMigrationsSuccess""></span>
            </p>
            <script>
                function ApplyMigrations() {
                    applyMigrations.disabled = true;
                    applyMigrationsError.innerHTML = """";
                    applyMigrations.innerHTML = """);
#line 158 "DatabaseErrorPage.cshtml"
                                            Write(JavaScriptEncode(Strings.DatabaseErrorPage_ApplyMigrationsButtonRunning));

#line default
#line hidden
            WriteLiteral("\";\r\n\r\n                    var req = new XMLHttpRequest();\r\n\r\n                    req.onload = function (e) {\r\n                        if (req.status === 204) {\r\n                            applyMigrations.innerHTML = \"");
#line 164 "DatabaseErrorPage.cshtml"
                                                    Write(JavaScriptEncode(Strings.DatabaseErrorPage_ApplyMigrationsButtonDone));

#line default
#line hidden
            WriteLiteral("\";\r\n                            applyMigrationsSuccess.innerHTML = \"");
#line 165 "DatabaseErrorPage.cshtml"
                                                           Write(JavaScriptEncode(Strings.DatabaseErrorPage_MigrationsAppliedRefresh));

#line default
#line hidden
            WriteLiteral(@""";
                        } else {
                            ErrorApplyingMigrations();
                        }
                    };

                    req.onerror = function (e) {
                        ErrorApplyingMigrations();
                    };

                    var formBody = ""context=");
#line 175 "DatabaseErrorPage.cshtml"
                                       Write(JavaScriptEncode(UrlEncode(Model.ContextType.AssemblyQualifiedName)));

#line default
#line hidden
            WriteLiteral("\";\r\n                    req.open(\"POST\", \"");
#line 176 "DatabaseErrorPage.cshtml"
                                 Write(JavaScriptEncode(Model.Options.MigrationsEndPointPath.Value));

#line default
#line hidden
            WriteLiteral(@""", true);
                    req.setRequestHeader(""Content-type"", ""application/x-www-form-urlencoded"");
                    req.setRequestHeader(""Content-length"", formBody.length);
                    req.setRequestHeader(""Connection"", ""close"");
                    req.send(formBody);
                }

                function ErrorApplyingMigrations() {
                    applyMigrations.innerHTML = """);
#line 184 "DatabaseErrorPage.cshtml"
                                            Write(JavaScriptEncode(Strings.DatabaseErrorPage_ApplyMigrationsButton));

#line default
#line hidden
            WriteLiteral("\";\r\n                    applyMigrationsError.innerHTML = \"");
#line 185 "DatabaseErrorPage.cshtml"
                                                 Write(JavaScriptEncode(Strings.DatabaseErrorPage_ApplyMigrationsFailed));

#line default
#line hidden
            WriteLiteral("\";\r\n                    applyMigrations.disabled = false;\r\n                }\r\n            </script>\r\n\r\n            <p>");
#line 190 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_HowToApplyFromPMC);

#line default
#line hidden
            WriteLiteral("</p>\r\n            <code>");
#line 191 "DatabaseErrorPage.cshtml"
             Write(Strings.DatabaseErrorPage_ApplyMigrationsCommandPMC);

#line default
#line hidden
            WriteLiteral("</code>\r\n            <p>");
#line 192 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_HowToApplyFromCLI);

#line default
#line hidden
            WriteLiteral("</p>\r\n            <code>");
#line 193 "DatabaseErrorPage.cshtml"
             Write(Strings.DatabaseErrorPage_ApplyMigrationsCommandCLI);

#line default
#line hidden
            WriteLiteral("</code>\r\n            <hr />\r\n        </div>\r\n");
#line 196 "DatabaseErrorPage.cshtml"
    }
    else if (Model.PendingModelChanges)
    {


#line default
#line hidden
            WriteLiteral("        <div>\r\n            <h2>");
#line 200 "DatabaseErrorPage.cshtml"
           Write(Strings.FormatDatabaseErrorPage_PendingChangesTitle(Model.ContextType.Name));

#line default
#line hidden
            WriteLiteral("</h2>\r\n            <p>");
#line 201 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_PendingChangesInfoPMC);

#line default
#line hidden
            WriteLiteral("</p>\r\n            <code>");
#line 202 "DatabaseErrorPage.cshtml"
             Write(Strings.DatabaseErrorPage_AddMigrationCommandPMC);

#line default
#line hidden
            WriteLiteral("</code>\r\n            <br />\r\n            <code>");
#line 204 "DatabaseErrorPage.cshtml"
             Write(Strings.DatabaseErrorPage_ApplyMigrationsCommandPMC);

#line default
#line hidden
            WriteLiteral("</code>\r\n            <p>");
#line 205 "DatabaseErrorPage.cshtml"
          Write(Strings.DatabaseErrorPage_PendingChangesInfoCLI);

#line default
#line hidden
            WriteLiteral("</p>\r\n            <code>");
#line 206 "DatabaseErrorPage.cshtml"
             Write(Strings.DatabaseErrorPage_AddMigrationCommandCLI);

#line default
#line hidden
            WriteLiteral("</code>\r\n            <br />\r\n            <code>");
#line 208 "DatabaseErrorPage.cshtml"
             Write(Strings.DatabaseErrorPage_ApplyMigrationsCommandCLI);

#line default
#line hidden
            WriteLiteral("</code>\r\n            <hr />\r\n        </div>\r\n");
#line 211 "DatabaseErrorPage.cshtml"
    }


#line default
#line hidden
            WriteLiteral("</body>\r\n</html>");
        }
        #pragma warning restore 1998
#line 11 "DatabaseErrorPage.cshtml"
 
    public DatabaseErrorPageModel Model { get; set; }

    public string UrlEncode(string content)
    {
        return UrlEncoder.Encode(content);
    }

    public string JavaScriptEncode(string content)
    {
        return JavaScriptEncoder.Encode(content);
    }


#line default
#line hidden
    }
}
