#pragma checksum "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CBE60111EFF991CF2982E4A40E15C5CE0D16C4F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP {
    
    #line 335 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.DynamicData;
    
    #line default
    #line hidden
    
    #line 325 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 331 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 339 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI;
    
    #line default
    #line hidden
    
    #line 326 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 330 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 343 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Xml.Linq;
    
    #line default
    #line hidden
    
    #line 336 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.SessionState;
    
    #line default
    #line hidden
    
    #line 5 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
    using System.IO;
    
    #line default
    #line hidden
    
    #line 333 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 340 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 334 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Caching;
    
    #line default
    #line hidden
    
    #line 338 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Profile;
    
    #line default
    #line hidden
    
    #line 328 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.ComponentModel.DataAnnotations;
    
    #line default
    #line hidden
    
    #line 327 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Specialized;
    
    #line default
    #line hidden
    
    #line 3 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 337 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Security;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 4 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
    using System.Data.SqlClient;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 329 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Configuration;
    
    #line default
    #line hidden
    
    #line 341 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 342 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.HtmlControls;
    
    #line default
    #line hidden
    
    
    [System.Runtime.CompilerServices.CompilerGlobalScopeAttribute()]
    public class adminresumedownload_aspx : global::System.Web.UI.Page, System.Web.SessionState.IRequiresSessionState, System.Web.IHttpHandler {
        
        
        #line 79 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl divResume;
        
        #line default
        #line hidden
        
        
        #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
        protected global::System.Web.UI.HtmlControls.HtmlForm form1;
        
        #line default
        #line hidden
        
        private static bool @__initialized;
        
        private static object @__stringResource;
        
        private static object @__fileDependencies;
        
        
        #line 7 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
                       
	protected void Page_Init(object sender, EventArgs e)
	{
		int _id;
		if (Request.QueryString["id"] == null || Request.QueryString["id"] == "")
		{
			return;
		}
		int.TryParse(Request.QueryString["id"], out _id);
		using (SqlConnection _con = new SqlConnection(ConfigurationManager.AppSettings["ConnStr"]))
		{
			using (SqlCommand _command = new SqlCommand("GetResumes", _con) //, _tran)
			{
				CommandType = CommandType.StoredProcedure
			})
			{
				_command.Parameters.AddWithValue("@Id", _id);
				_con.Open();
				using (SqlDataReader _read = _command.ExecuteReader())
				{
					while (_read.Read())
					{
						if (!_read.IsDBNull(0))
						{
							if (File.Exists(Server.MapPath("~/Resumes/" + _read.GetString(0))))
							{
								byte[] _content;
								using (BinaryReader _reader = new BinaryReader(File.Open(Server.MapPath("~/Resumes/" + _read.GetString(0)), FileMode.Open)))
								{
									_content = _reader.ReadBytes(Convert.ToInt32(_reader.BaseStream.Length));
								}
								Response.ContentType = "application/octet-stream";
								Response.AddHeader("Content-Disposition", string.Concat("attachment;filename=\"", _read.GetString(0), "\""));
								Response.BinaryWrite(_content);
								Response.End();
							}
							else
							{
								divResume.InnerHtml = "There is no Resume available for this Candidate";
							}
						}
						else if (!_read.IsDBNull(1))
						{
							divResume.InnerHtml = _read.GetString(1);
						}
						else
						{
							divResume.InnerHtml = "There is no Resume available for this Candidate";
						}
					}
				}
			}
		}
	}


        #line default
        #line hidden
        
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public adminresumedownload_aspx() {
            string[] dependencies;
            ((global::System.Web.UI.Page)(this)).AppRelativeVirtualPath = "~/adminresumedownload.aspx";
            if ((global::ASP.adminresumedownload_aspx.@__initialized == false)) {
                global::ASP.adminresumedownload_aspx.@__stringResource = this.ReadStringResource();
                dependencies = new string[1];
                dependencies[0] = "~/adminresumedownload.aspx";
                global::ASP.adminresumedownload_aspx.@__fileDependencies = this.GetWrappedFileDependencies(dependencies);
                global::ASP.adminresumedownload_aspx.@__initialized = true;
            }
            this.Server.ScriptTimeout = 30000000;
        }
        
        protected System.Web.Profile.DefaultProfile Profile {
            get {
                return ((System.Web.Profile.DefaultProfile)(this.Context.Profile));
            }
        }
        
        protected System.Web.HttpApplication ApplicationInstance {
            get {
                return ((System.Web.HttpApplication)(this.Context.ApplicationInstance));
            }
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlTitle @__BuildControl__control3() {
            global::System.Web.UI.HtmlControls.HtmlTitle @__ctrl;
            
            #line 65 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTitle();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 65 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("Resume"));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlHead @__BuildControl__control2() {
            global::System.Web.UI.HtmlControls.HtmlHead @__ctrl;
            
            #line 64 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlHead("head");
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlTitle @__ctrl1;
            
            #line 64 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl1 = this.@__BuildControl__control3();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 64 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            
            #line 64 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(this.CreateResourceBasedLiteralControl(41537, 485, true));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldivResume() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            
            #line 79 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            
            #line default
            #line hidden
            this.divResume = @__ctrl;
            
            #line 79 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl.ID = "divResume";
            
            #line default
            #line hidden
            
            #line 79 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("style", "width: 100%; margin: 15px");
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 79 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t"));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlForm @__BuildControlform1() {
            global::System.Web.UI.HtmlControls.HtmlForm @__ctrl;
            
            #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlForm();
            
            #line default
            #line hidden
            this.form1 = @__ctrl;
            
            #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl.ID = "form1";
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t"));
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl1;
            
            #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl1 = this.@__BuildControldivResume();
            
            #line default
            #line hidden
            
            #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            
            #line 78 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t"));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(adminresumedownload_aspx @__ctrl) {
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            this.InitializeCulture();
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.o" +
                        "rg/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n"));
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n"));
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlHead @__ctrl1;
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl1 = this.@__BuildControl__control2();
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<body>\r\n\t"));
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlForm @__ctrl2;
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__ctrl2 = this.@__BuildControlform1();
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\adminresumedownload.aspx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</body>\r\n</html>\r\n"));
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            base.FrameworkInitialize();
            this.SetStringResourcePointer(global::ASP.adminresumedownload_aspx.@__stringResource, 0);
            this.@__BuildControlTree(this);
            this.AddWrappedFileDependencies(global::ASP.adminresumedownload_aspx.@__fileDependencies);
            this.ValidateRequestMode = System.Web.UI.ValidateRequestMode.Disabled;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override int GetTypeHashCode() {
            return 598564011;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public override void ProcessRequest(System.Web.HttpContext context) {
            base.ProcessRequest(context);
        }
    }
}
