﻿#pragma checksum "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B0A0957FA639E4750957E022F6210829F33D1B5B"
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
    
    #line 329 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Configuration;
    
    #line default
    #line hidden
    
    #line 332 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
    
    #line 333 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 337 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Security;
    
    #line default
    #line hidden
    
    #line 341 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls.WebParts;
    
    #line default
    #line hidden
    
    #line 326 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 335 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.DynamicData;
    
    #line default
    #line hidden
    
    #line 327 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections.Specialized;
    
    #line default
    #line hidden
    
    #line 343 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Xml.Linq;
    
    #line default
    #line hidden
    
    #line 325 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 330 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 339 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI;
    
    #line default
    #line hidden
    
    #line 338 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Profile;
    
    #line default
    #line hidden
    
    #line 331 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 342 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.HtmlControls;
    
    #line default
    #line hidden
    
    #line 334 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.Caching;
    
    #line default
    #line hidden
    
    #line 324 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System;
    
    #line default
    #line hidden
    
    #line 340 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.UI.WebControls;
    
    #line default
    #line hidden
    
    #line 336 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.Web.SessionState;
    
    #line default
    #line hidden
    
    #line 328 "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\Config\web.config"
    using System.ComponentModel.DataAnnotations;
    
    #line default
    #line hidden
    
    
    [System.Runtime.CompilerServices.CompilerGlobalScopeAttribute()]
    public class controls_adminmenu_ascx : global::System.Web.UI.UserControl {
        
        
        #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl linkUser;
        
        #line default
        #line hidden
        
        
        #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl linkSumm;
        
        #line default
        #line hidden
        
        
        #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl linkDetails;
        
        #line default
        #line hidden
        
        private static bool @__initialized;
        
        
        #line 2 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
                       
	protected void Page_Load(object sender, EventArgs e)
	{
		/*if (!Convert.ToBoolean(Request.Cookies["Admin"].Value))
		{
			linkUser.Attributes["onclick"] = "javascript:alert('Only an Administrator can access the Users section.');";
			linkSumm.Attributes["onclick"] = "javascript:alert('Only an Administrator can access the Users section.');";
			linkDetails.Attributes["onclick"] = "javascript:alert('Only an Administrator can access the Users section.');";
		}*/
	}

        #line default
        #line hidden
        
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public controls_adminmenu_ascx() {
            ((global::System.Web.UI.UserControl)(this)).AppRelativeVirtualPath = "~/controls/adminmenu.ascx";
            if ((global::ASP.controls_adminmenu_ascx.@__initialized == false)) {
                global::ASP.controls_adminmenu_ascx.@__initialized = true;
            }
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
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControllinkUser() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            
            #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            
            #line default
            #line hidden
            this.linkUser = @__ctrl;
            
            #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "menuLink");
            
            #line default
            #line hidden
            
            #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("style", "width: 60px; margin-left: 30px; margin-top: 0");
            
            #line default
            #line hidden
            
            #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("onclick", "javascript:document.location.href=\'adminusers.aspx\';");
            
            #line default
            #line hidden
            
            #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl.ID = "linkUser";
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 14 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t\tUsers"));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControllinkSumm() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            
            #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            
            #line default
            #line hidden
            this.linkSumm = @__ctrl;
            
            #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "menuLink");
            
            #line default
            #line hidden
            
            #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("style", "width: 160px; margin-left: 30px; margin-top: 0");
            
            #line default
            #line hidden
            
            #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl.ID = "linkSumm";
            
            #line default
            #line hidden
            
            #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("onclick", "javascript:document.location.href=\'adminofccpsummary.aspx\';");
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 19 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t\tOFCCP Summary"));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControllinkDetails() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            
            #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            
            #line default
            #line hidden
            this.linkDetails = @__ctrl;
            
            #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("class", "menuLink");
            
            #line default
            #line hidden
            
            #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("style", "width: 140px; margin-left: 30px; margin-top: 0");
            
            #line default
            #line hidden
            
            #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl.ID = "linkDetails";
            
            #line default
            #line hidden
            
            #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            ((System.Web.UI.IAttributeAccessor)(@__ctrl)).SetAttribute("onclick", "javascript:document.location.href=\'adminshowofccp.aspx\';");
            
            #line default
            #line hidden
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 22 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t\tOFFCP Details"));
            
            #line default
            #line hidden
            return @__ctrl;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private void @__BuildControlTree(controls_adminmenu_ascx @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<div class=\"adminMenu\" style=\"margin-left: 25px\">\r\n\t"));
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl1;
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl1 = this.@__BuildControllinkUser();
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(@__ctrl1);
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t<div class=\"menuLink\" style=\"width: 60px; margin-left: 30px; margin-top: 0\" on" +
                        "click=\"javascript:document.location.href=\'adminjobs.aspx\';\">\r\n\t\tJobs</div>\r\n\t"));
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl2;
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl2 = this.@__BuildControllinkSumm();
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(@__ctrl2);
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t"));
            
            #line default
            #line hidden
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl3;
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__ctrl3 = this.@__BuildControllinkDetails();
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(@__ctrl3);
            
            #line default
            #line hidden
            
            #line 1 "C:\Inetpub\vhosts\agreatis.com\httpdocs\controls\adminmenu.ascx"
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\t<div class=\"menuLink\" style=\"width: 140px; margin-left: 30px; margin-top: 0\" o" +
                        "nclick=\"javascript:document.location.href=\'logoff.aspx\';\">\r\n\t\tLogoff</div>\r\n</di" +
                        "v>\r\n"));
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        protected override void FrameworkInitialize() {
            base.FrameworkInitialize();
            this.@__BuildControlTree(this);
        }
    }
}