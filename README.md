# angular-aspmvc5
Angular + ASP MVC 5

Bước 1: Create project ASP MVC 5

Bước 2: Opent project ASP MVC 5, Create Project Angular 
```csharp
npm install -g @angular/cli
ng new ClientApp
```

Bước 3: Open BundleConfig.cs file in App_Start directory, continue change location (css,js) file
```csharp
using System.Web;
using System.Web.Optimization;

namespace Angular_mvc5
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/Script/Bundles").Include(
                     "~/dist/runtime-es2015.*",
                      "~/dist/runtime-es5.*",
                     "~/dist/polyfills-es2015.*",
                      "~/dist/polyfills-es5.*",
                     "~/dist/main-es2015.*",
                      "~/dist/main-es5.*"));

            bundles.Add(new StyleBundle("~/Content/Styles").Include(
                      "~/dist/style.*"));
        }
    }
}
```

Bước 4: Open angular.json file in ClientApp directory, configuration "outputPath": "../dist",

Bước 5: Open file _Layout.cshtml in Views/Shared 

```csharp
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/Styles")
 
</head>
<body>
   <div class="container">
       @RenderBody()
   </div>
   @Scripts.Render("~/Script/Bundles")
</body>
</html>
```

Bước 6: Open index.cshtml file in Views/Home/Index.cshtml
```csharp
@{
    ViewBag.Title = "Home Page";
}

<app-root></app-root>
```

# <app-root></app-root>

Bước 7: Run Project ASP MVC 5
