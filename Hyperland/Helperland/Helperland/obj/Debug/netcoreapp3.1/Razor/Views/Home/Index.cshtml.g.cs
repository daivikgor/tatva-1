#pragma checksum "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\_ViewImports.cshtml"
using Helperland.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5f94cf04a7ec23f27ac33992ef127038e0b3154", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/css/home.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d45015", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Home page</title>\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d45427", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\">\r\n    <link rel=\"icon\" href=\"Assets/image/white-logo-transparent-background-copy-4.png\" type=\"image/icon type\">\r\n  \r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d47559", async() => {
                WriteLiteral("\r\n    <section class=\"section-10\" style=\"background-image: url(Assets/image/group-35.png);\">\r\n\r\n        <nav class=\"navbar navbar-expand-lg trans\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 689, "\"", 723, 1);
#nullable restore
#line 24 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 696, Url.Action("Index","Home"), 696, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""navbar-logo"">
                <img src=""Assets/image/white-logo-transparent-background.png"" class=""helperland-logo"">
            </a>
            <button class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#collapsibleNavbar"">
                <i class=""fas fa-bars bar-btn""></i>
            </button>
            <div class=""collapse navbar-collapse"" id=""collapsibleNavbar"">
                <ul class=""navbar-nav ml-auto text-center"">
                    <li class=""nav-item Rounded-Rectangle"">
                        <a href=""#"" class=""nav-link"">
                            Book a cleaner
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 1468, "\"", 1503, 1);
#nullable restore
#line 38 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 1475, Url.Action("Prices","Home"), 1475, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link"">
                            Prices
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"" class=""nav-link"">
                            Our Guarantee
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#"" class=""nav-link"">
                            Blog
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 2073, "\"", 2112, 1);
#nullable restore
#line 53 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 2080, Url.Action("Contact","Contact"), 2080, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"nav-link\">\r\n                            Contact us\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item Rounded-Rectangle\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2317, "\"", 2324, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#loginModal\" class=\"nav-link\">\r\n                            login\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item Rounded-Rectangle\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2570, "\"", 2619, 1);
#nullable restore
#line 63 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 2577, Url.Action("BecomeHelper","becomehelper"), 2577, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""nav-link"">
                            Become a Helper
                        </a>
                    </li>

                </ul>
            </div>
        </nav>
        <!-- modal for login -->
        <div class=""modal fade"" id=""loginModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""loginModal"" aria-hidden=""true"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"" style=""max-width:370px;"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"" id=""loginModalTitle"">Log in</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d412553", async() => {
                    WriteLiteral(@"
                            <div class=""icon-text-box right"">
                                <input class=""form-control"" formcontrolname=""email"" id=""email"" type=""email"" placeholder=""E-Mail"" required>
                                <!-- <img src=""Assets/image/user-login.png""> -->
                            </div>
                            <div class=""icon-text-box right"">
                                <input class=""form-control"" placeholder=""password"" name=""password"" type=""password"" required>
                            </div>
                            <div class=""icon-text-box right-fl"">
                                
                                    <input type=""checkbox"">
                                    <label>Save on computer</label>
                                
                            </div>
                            <div style=""text-align: center;"">
                                <button class=""btn-login"">log in</button>
                            </div>
  ");
                    WriteLiteral("                      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div style=\"text-align: center;\">\r\n                            <div><a");
                BeginWriteAttribute("href", " href=\"", 4719, "\"", 4726, 0);
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#forgotModel\" data-dismiss=\"modal\">Forgot Password</a></div>\r\n                            <span>Don\'t have an account yet?</span>\r\n                            <div><a");
                BeginWriteAttribute("href", " href=\"", 4927, "\"", 4975, 1);
#nullable restore
#line 103 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 4934, Url.Action("createuser","Createaccount"), 4934, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">create Account</a></div>
                        </div>
                    </div>
                    <div class=""modal-footer"">

                    </div>
                </div>
            </div>
        </div>

        <!-- login modal over -->
        <!--Forget password Modal start-->
        <div class=""modal fade"" id=""forgotModel"">
            <div class=""modal-dialog modal-dialog-centered"" role=""document"" style=""max-width:370px;"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h3 class=""modal-title"" id=""forgotModalTitle"">Log in</h3>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54fd89fb9dac3e4ec4ab46cd188cb8f718adc7d416896", async() => {
                    WriteLiteral(@"
                            <div class=""icon-text-box right"">
                                <input class=""form-control"" formcontrolname=""email"" id=""email"" type=""email"" placeholder=""E-Mail-Address"" required>
                                <!-- <img src=""Assets/image/user-login.png""> -->
                            </div>
                            <div style=""text-align: center;"">
                                <button class=""btn-login"">Send</button>
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        <div class=\"text-center\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 6558, "\"", 6565, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""button"" data-toggle=""modal"" data-dismiss=""modal"" data-target=""#loginModal"">Login now</a>
                        </div>
                    </div>




            </div>

            </div>

            </div>

            <!-- forgot password modal over -->





            <div class=""txt mt-5"" >Lorem ipsum dolor ?</div>
            <ul class=""loreum"">
                <li>Lorem ipsum dolor sit amet, consectetur adipiscing</li>
                <li>Lorem ipsum dolor sit amet, consectetur adipiscing</li>
                <li>Lorem ipsum dolor sit amet, consectetur adipiscing</li>
            </ul>

            <div class='Btn-book-a-cleaner'>
                <a");
                BeginWriteAttribute("href", " href=\"", 7267, "\"", 7316, 1);
#nullable restore
#line 162 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 7274, Url.Action("BecomeHelper","becomehelper"), 7274, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""Rounded-Rectangle-6-copy-5"">
                    <span class=""Lets-Book-a-Cleaner-copy"">
                        Let’s Book a Cleaner
                    </span>
                </a>
            </div>
            <div class=""img-grp-holder"">
                <div class=""forma-1-copy"">
                    <img src=""Assets/image/forma-1-copy.png"" class=""img-grp"">
                    <span class=""pass-txt forma-2-copy"">Enter your postcode</span>
                </div>
                <img src=""Assets/image/step-arrow-1.png"" class=""img-grp-1 remove"">
                <div class=""forma-1-copy"">
                    <img src=""Assets/image/group-22.png"" class=""img-grp"">
                    <span class=""pass-txt"">Select Your plan</span>
                </div>
                <img src=""Assets/image/step-arrow-1-copy.png"" class=""img-grp-1 remove"">
                <div class=""forma-1-copy"">
                    <img src=""Assets/image/forma-1-co.png"" class=""img-grp"">
                    <span clas");
                WriteLiteral(@"s=""pass-txt"">pay securely online</span>
                </div>
                <img src=""Assets/image/step-arrow-1.png"" class=""img-grp-1 remove"">
                <div class=""forma-1-copy"">
                    <img src=""Assets/image/forma-1.png"" class=""img-grp"">
                    <span class=""pass-txt"">Enjoy amazing service</span>
                </div>
            </div>
            <div class=""elipse-shape"">
                <img src=""Assets/image/ellipse-525.png"" class=""elipse-525"">
                <img src=""Assets/image/shape-1.png"" class=""shape-1"">
            </div>
</section>
    <div class=""section-2"">
    
        <h2 class=""why-hyperland"">Why Helperland</h2>
        <div class=""img-grp-2-holder"">
            <div class=""img-smp-1"">
            <img src=""Assets/image/group-21.png"" class=""img-grp-2"">
            <span class=""pass-txt-2"">Experience & Vetted Professionals</span>
            <span class=""dominant"">
                dominate the industry in scale and scope with an adap");
                WriteLiteral(@"table, extensive network that consistently delivers exceptional results.
            </span>
            </div>
            
            <div class=""img-smp-1"">
            <img src=""Assets/image/group-23.png"" class=""img-grp-2"">
            <span class=""pass-txt-2"">Secure Online Payment</span>
            <span class=""dominant"">
                Payment is processed securely online. Customers pay safely online and
                 manage the booking.</span>
            </div>
           
            <div class=""img-smp-1"">
            <img src=""Assets/image/group-24.png"" class=""img-grp-2"">
            <span class=""pass-txt-2"">Dedicated Customer
                Services</span>
                <span class=""dominant"">
                    to our customers and are guided in all we do by their needs. The team is always happy to support you and offer all the information.
        
                </span>
            
            </div>
        </div>
        <div class=""lore-container"">
       ");
                WriteLiteral(@" 
            <div class=""item1"">
                <div class=""loreum-3"">
                    Lorem ipsum dolor sit amet,<br> consectetur
                </div>
                <div class=""loreum-4"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec nisi sapien,<br> sus cipit ut accumsan vitae, pulvinar ac libero.</p>
                    <p>

                        Aliquam erat volutpat. Nullam quis ex odio. Nam bibendum cursus purus, vel<br> efficitur urna finibus vitae. Nullam finibus aliquet pharetra. Morbi in sem dolor.<br> Integer pretium hendrerit ante quis vehicula.</p>
                    <p>
                     Mauris consequat ornare enim, sed lobortis quam ultrices sed.
                    </p>
                </div>
            </div>
                <img src=""Assets/image/group-36.png"" class=""group-36"">
            
        
        </div>

        
            <h2 class=""blog"">Our Blog</h2>
        

        <div class=""container-blog""");
                WriteLiteral(@">
            <div class=card-blog>
                <img src=""Assets/image/group-28.png"" class=img-grp-28>
                <div class=""txt-grp-28"">
                    Lorem ipsum dolor sit amet
                </div>
                <div class=""small-txt-grp-28"">
                    January 28, 2019
                </div>
                <div class=""s-txt-grp-28"">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.
                </div>
                <div class=""read-post"">
                    <span class=""read-post2"">Read the Post</span>
                    <img src=""Assets/image/shape-2.png"" class=""shape-2"">
                </div>
            </div>
            <div class=card-blog>
                <img src=""Assets/image/group-29.png"" class=img-grp-28>
                <div class=""txt-grp-28"">
                    Lorem ipsum dolor sit amet
                </div>
                <div class=""small-txt-grp-28"">
           ");
                WriteLiteral(@"         January 28, 2019
                </div>
                <div class=""s-txt-grp-28"">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.
                </div>
                <div class=""read-post"">
                    <span class=""read-post2"">Read the Post</span>
                    <img src=""Assets/image/shape-2.png"" class=""shape-2"">
                </div>
            </div>
            <div class=card-blog>
                <img src=""Assets/image/group-30.png"" class=img-grp-28>
                <div class=""txt-grp-28"">
                    Lorem ipsum dolor sit amet
                </div>
                <div class=""small-txt-grp-28"">
                    January 28, 2019
                </div>
                <div class=""s-txt-grp-28"">
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet.
                </div>
                <div class=""read-post"">
       ");
                WriteLiteral(@"             <span class=""read-post2"">Read the Post</span>
                    <img src=""Assets/image/shape-2.png"" class=""shape-2"">
                </div>
            </div>

        </div>
        
    </div>
    <div class=""section-3"">
        <div class=what-customer>
            <h2>What Our Customers Say</h2>
        </div>
        <div class=""container-customer"">
            <div class=""card-customer"">
                <div class=""txt-image"">
                    <img src=""Assets/image/group-31.png"" class=""img-group-31"">
                    
                    <div class=""info"">
                        
                        <div class=""txt-customer"">
                            Lary Watson
                        </div>
                        <div class=""small-txt"">
                            Manchester
                        </div>
                    </div>
                    
                </div>
                <div class=""main-txt-customer"">
                    ");
                WriteLiteral(@"<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh</p>
                    <p>
                        Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                </div>
                <div class=""read-post"">
                    <span class=""read-post2"">Read More</span>
                    <img src=""Assets/image/shape-2.png"" class=""shape-2"">
                </div>
            </div>
            <div class=""card-customer"">
                <div class=""txt-image"">
                    <img src=""Assets/image/group-32.png"" class=""img-group-31"">
                    <div class=""info"">
                        <div class=""txt-customer"">
                            Lary Watson
                        </div>
                        <div class=""small-txt"">
                            Manchester
                        </div>
                    </div>
                </div>
                ");
                WriteLiteral(@"<div class=""main-txt-customer"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh</p>
                    <p>
                        Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                </div>
                <div class=""read-post"">
                    <span class=""read-post2"">Read More</span>
                    <img src=""Assets/image/shape-2.png"" class=""shape-2"">
                </div>
            </div>
            <div class=""card-customer"">
                <div class=""txt-image"">
                    <img src=""Assets/image/group-33.png"" class=""img-group-31"">
                    <div class=""info"">
                        <div class=""txt-customer"">
                            Lary Watson
                        </div>
                        <div class=""small-txt"">
                            Manchester
                        </div>
               ");
                WriteLiteral(@"     </div>
                </div>
                <div class=""main-txt-customer"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed fermentum metus pulvinar aliquet consequat. Praesent nec malesuada nibh</p>
                    <p>
                        Nullam et metus congue, auctor augue sit amet, consectetur tortor.</p>
                </div>
                <div class=""read-post"">
                    <span class=""read-post2"">Read More</span>
                    <img src=""Assets/image/shape-2.png"" class=""shape-2"">
                </div>
            </div>
        </div>

        <div class=""get-newsletter"">
            <p>GET OUR NEWSLETTER</p>
        </div>
        <div class=""form1"">
            
                <input type=""email"" id=""email"" placeholder=""Your Email"" class=""email"">
                <button class=""submit"">submit
                </button> 
                <div class=""up-aero"">
                    <img src=""Assets/image/up-aero.png");
                WriteLiteral("\" style=\"margin-left: 14px; margin-top: 18px;\">\r\n                  </div>\r\n        </div>\r\n\r\n        <div class=\"container-fluid footer\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-3 logo-footer\" >\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 17802, "\"", 17836, 1);
#nullable restore
#line 395 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 17809, Url.Action("Index","Home"), 17809, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><img src=\"Assets/image/white-logo-transparent-background.png\" class=\"img-footer\"></a>\r\n                </div>\r\n                <div class=\"col-sm-6 footer-links-1\">\r\n                    <p class=\"footer-links\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 18076, "\"", 18110, 1);
#nullable restore
#line 399 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 18083, Url.Action("Index","Home"), 18083, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">HOME</a>   \r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 18151, "\"", 18185, 1);
#nullable restore
#line 400 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 18158, Url.Action("About","Home"), 18158, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ABOUT</a>   \r\n                        <a href=\"#\">TESTIMONIALS</a>   \r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 18284, "\"", 18316, 1);
#nullable restore
#line 402 "F:\Tatva\tatva project\tatva-1\Hyperland\Helperland\Helperland\Views\Home\Index.cshtml"
WriteAttributeValue("", 18291, Url.Action("Faq","Home"), 18291, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">FAQS</a>  
                        <a href=""#"">INSURANCE</a>   
                        <a href=""#"">POLICY</a>   
                        <a href=""#"">IMPRESSUM</a>     
                    </p>
                </div>
                <div class=""col-sm-3 social-footer"">
        
                        <a href=#><img src=""Assets/image/facebook.png"" style=""padding-right: 15px;""></a>
                        <a href=#><img src=""Assets/image/insta.png""></a>
                </div>
            </div>
            
            <div class=""footer-3"">
                <p>©2018 Helperland. All rights reserved. <a href=# style=""color: #9ba0a3;"">Terms and Conditions</a> | <a href=# style=""color: #9ba0a3;"">Privacy Policy</a></p>
                <button class=""btn-ok"">OK</button>
            </div>
            
            
            </div>
        </div>
    </div>
    
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
  <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js""></script>
  <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>
  <script src=""https://kit.fontawesome.com/3960232895.js""></script>

</html>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
