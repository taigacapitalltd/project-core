#pragma checksum "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\Product\_AddEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ce42dd7037581d741c3d76f439b93ff35d813b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product__AddEditModal), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/_AddEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/_AddEditModal.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product__AddEditModal))]
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
#line 1 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp;

#line default
#line hidden
#line 3 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models;

#line default
#line hidden
#line 4 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Models.ManageViewModels;

#line default
#line hidden
#line 6 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.System;

#line default
#line hidden
#line 7 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.BlockChain;

#line default
#line hidden
#line 8 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Application.ViewModels.Valuesshare;

#line default
#line hidden
#line 9 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\_ViewImports.cshtml"
using BeCoreApp.Data.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ce42dd7037581d741c3d76f439b93ff35d813b7", @"/Areas/Admin/Views/Product/_AddEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68994ac50316bb5bc7adb5dd726610ea311dbfdf", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product__AddEditModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 752, true);
            WriteLiteral(@"<div id=""modal-add-edit"" class=""modal fade"" data-backdrop=""static"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title badge badge-secondary-light"" id=""exampleModalLabel"">
                    Thêm & cập nhật sản phẩm
                </h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">
                        &times;
                    </span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(752, 5900, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4abe4d24d44513b332b12e3a2fdff0", async() => {
                BeginContext(779, 935, true);
                WriteLiteral(@"
                    <div class=""form-group m-form__group"">
                        <input type=""hidden"" id=""hidId"" value=""0"" />
                        <label for=""txtName"" class=""form-control-label"">Tiêu đề sản phẩm</label>
                        <input type=""text"" name=""txtName"" class=""form-control m-input m-input--air"" id=""txtName"">
                    </div>

                    <div class=""form-group m-form__group"">
                        <label for=""ddlBlogCategoryId"" class=""form-control-label"">Loại sản phẩm</label>
                        <input id=""ddlBlogCategoryId"" class=""form-control m-input m-input--air"" name=""ddlBlogCategoryId"" value="""">
                    </div>

                    <div class=""form-group"">
                        <label for=""txtName"" class=""form-control-label"">Chủ Đề (Tags)</label>
                        <div class=""m-select2 m-select2--air"">
                            ");
                EndContext();
                BeginContext(1715, 111, false);
#line 30 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\Product\_AddEditModal.cshtml"
                       Write(Html.DropDownList("Tags", null, "", new { id = "ddlTags", multiple = true, @class = "form-control m-select2" }));

#line default
#line hidden
                EndContext();
                BeginContext(1826, 293, true);
                WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""txtName"" class=""form-control-label"">Hình Thức</label>
                        <div class=""m-select2 m-select2--air"">
                            ");
                EndContext();
                BeginContext(2120, 127, false);
#line 37 "C:\TongHop\Others\TaigaCapitalLtd\BeCoreApp.Web\Areas\Admin\Views\Product\_AddEditModal.cshtml"
                       Write(Html.DropDownList("ProductTypes", null, "", new { id = "ddlProductTypes", multiple = true, @class = "form-control m-select2" }));

#line default
#line hidden
                EndContext();
                BeginContext(2247, 4398, true);
                WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""form-group m-form__group"">
                        <label class=""form-control-label"">Giá Nhập</label>
                        <input type=""text"" name=""txtOriginalPrice"" class=""form-control m-input m-input--air"" id=""txtOriginalPrice"">
                    </div>

                    <div class=""form-group m-form__group"">
                        <label class=""form-control-label"">Giá Bán</label>
                        <input type=""text"" name=""txtPrice"" class=""form-control m-input m-input--air"" id=""txtPrice"">
                    </div>

                    <div class=""form-group m-form__group"">
                        <label class=""form-control-label"">Giá Khuyến Mãi</label>
                        <input type=""text"" name=""txtPromotionPrice"" class=""form-control m-input m-input--air"" id=""txtPromotionPrice"">
                    </div>

                    <div class=""form-group m-form__group"">
            ");
                WriteLiteral(@"            <label for=""txtImage"" class=""form-control-label"">Ảnh bìa</label>
                        <div class=""input-group"">
                            <input type=""text"" name=""txtImage"" class=""form-control m-input m-input--air"" id=""txtImage"" />
                            <input type=""file"" id=""fileInputImage"" style=""display:none"" />
                            <span class=""input-group-btn"">
                                <input type=""button"" id=""btnSelectImg"" class=""btn btn-default"" value=""Browser"" />
                            </span>
                        </div>
                    </div>

                    <div class=""form-group m-form__group"">
                        <label for=""txtDescription"" class=""form-control-label"">Tóm tắt</label>
                        <textarea rows=""10"" name=""txtDescription"" class=""form-control m-input m-input--air"" id=""txtDescription""></textarea>
                    </div>

                    <div class=""form-group m-form__group"">
                   ");
                WriteLiteral(@"     <label for=""txtContent"" class=""form-control-label"">Tổng quan</label>
                        <textarea id=""txtContent"" rows=""2"" class=""form-control m-input m-input--air""></textarea>
                    </div>

                    <div class=""form-group m-form__group"">
                        <label for=""txtSeoPageTitle"" class=""form-control-label""><span class=""m-badge m-badge--warning m-badge--dot""></span> Seo Page Title</label>
                        <input type=""text"" id=""txtSeoPageTitle"" class=""form-control m-input m-input--air"">
                    </div>

                    <div class=""form-group m-form__group"">
                        <label for=""txtSeoKeywords"" class=""form-control-label""><span class=""m-badge m-badge--warning m-badge--dot""></span> Seo Keywords</label>
                        <input type=""text"" id=""txtSeoKeywords"" class=""form-control m-input m-input--air"">
                    </div>



                    <div class=""form-group m-form__group"">
                     ");
                WriteLiteral(@"   <label for=""txtSeoDescription"" class=""form-control-label""><span class=""m-badge m-badge--warning m-badge--dot""></span> Seo Description</label>
                        <input type=""text"" id=""txtSeoDescription"" class=""form-control m-input m-input--air"">
                    </div>

                    <div class=""form-group m-form__group"">
                        <label class=""m-checkbox m-checkbox--bold m-checkbox--state-brand m--margin-right-10"">
                            <input type=""checkbox"" checked=""checked"" id=""ckStatus"">
                            Trạng thái
                            <span></span>
                        </label>

                        <label class=""m-checkbox m-checkbox--bold m-checkbox--state-brand m--margin-right-10"">
                            <input type=""checkbox"" checked=""checked"" id=""ckHot"">
                            Bài viết hot
                            <span></span>
                        </label>

                        <label class=""m-checkbo");
                WriteLiteral(@"x m-checkbox--bold m-checkbox--state-brand"">
                            <input type=""checkbox"" checked=""checked"" id=""ckShowHome"">
                            Hiển thị trang chủ
                            <span></span>
                        </label>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6652, 319, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Hủy</button>
                <button type=""button"" id=""btnSave"" class=""btn btn-success"">Lưu</button>
            </div>
        </div>
    </div>
</div>");
            EndContext();
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
