// Copyright (c) 2012, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace WebsitePanel.Providers
{
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "ServiceProviderSoap", Namespace = "http://smbsaas/websitepanel/server/")]
    public partial class ServiceProvider : Microsoft.Web.Services3.WebServicesClientProtocol
    {

        public ServiceProviderSettingsSoapHeader ServiceProviderSettingsSoapHeaderValue;

        private System.Threading.SendOrPostCallback InstallOperationCompleted;

        private System.Threading.SendOrPostCallback GetProviderDefaultSettingsOperationCompleted;

        private System.Threading.SendOrPostCallback UninstallOperationCompleted;

        private System.Threading.SendOrPostCallback IsInstalledOperationCompleted;

        private System.Threading.SendOrPostCallback ChangeServiceItemsStateOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteServiceItemsOperationCompleted;

        private System.Threading.SendOrPostCallback GetServiceItemsDiskSpaceOperationCompleted;

        private System.Threading.SendOrPostCallback GetServiceItemsBandwidthOperationCompleted;

        /// <remarks/>
        public ServiceProvider()
        {
            this.Url = "http://localhost/WebsitePanelServer/ServiceProvider.asmx";
        }

        /// <remarks/>
        public event InstallCompletedEventHandler InstallCompleted;

        /// <remarks/>
        public event GetProviderDefaultSettingsCompletedEventHandler GetProviderDefaultSettingsCompleted;

        /// <remarks/>
        public event UninstallCompletedEventHandler UninstallCompleted;

        /// <remarks/>
        public event IsInstalledCompletedEventHandler IsInstalledCompleted;

        /// <remarks/>
        public event ChangeServiceItemsStateCompletedEventHandler ChangeServiceItemsStateCompleted;

        /// <remarks/>
        public event DeleteServiceItemsCompletedEventHandler DeleteServiceItemsCompleted;

        /// <remarks/>
        public event GetServiceItemsDiskSpaceCompletedEventHandler GetServiceItemsDiskSpaceCompleted;

        /// <remarks/>
        public event GetServiceItemsBandwidthCompletedEventHandler GetServiceItemsBandwidthCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/Install", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Install()
        {
            object[] results = this.Invoke("Install", new object[0]);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginInstall(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Install", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public string[] EndInstall(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }

        /// <remarks/>
        public void InstallAsync()
        {
            this.InstallAsync(null);
        }

        /// <remarks/>
        public void InstallAsync(object userState)
        {
            if ((this.InstallOperationCompleted == null))
            {
                this.InstallOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInstallOperationCompleted);
            }
            this.InvokeAsync("Install", new object[0], this.InstallOperationCompleted, userState);
        }

        private void OnInstallOperationCompleted(object arg)
        {
            if ((this.InstallCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InstallCompleted(this, new InstallCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetProviderDefaultSettings", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public SettingPair[] GetProviderDefaultSettings()
        {
            object[] results = this.Invoke("GetProviderDefaultSettings", new object[0]);
            return ((SettingPair[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetProviderDefaultSettings(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetProviderDefaultSettings", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public SettingPair[] EndGetProviderDefaultSettings(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((SettingPair[])(results[0]));
        }

        /// <remarks/>
        public void GetProviderDefaultSettingsAsync()
        {
            this.GetProviderDefaultSettingsAsync(null);
        }

        /// <remarks/>
        public void GetProviderDefaultSettingsAsync(object userState)
        {
            if ((this.GetProviderDefaultSettingsOperationCompleted == null))
            {
                this.GetProviderDefaultSettingsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetProviderDefaultSettingsOperationCompleted);
            }
            this.InvokeAsync("GetProviderDefaultSettings", new object[0], this.GetProviderDefaultSettingsOperationCompleted, userState);
        }

        private void OnGetProviderDefaultSettingsOperationCompleted(object arg)
        {
            if ((this.GetProviderDefaultSettingsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetProviderDefaultSettingsCompleted(this, new GetProviderDefaultSettingsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/Uninstall", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Uninstall()
        {
            this.Invoke("Uninstall", new object[0]);
        }

        /// <remarks/>
        public System.IAsyncResult BeginUninstall(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Uninstall", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public void EndUninstall(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void UninstallAsync()
        {
            this.UninstallAsync(null);
        }

        /// <remarks/>
        public void UninstallAsync(object userState)
        {
            if ((this.UninstallOperationCompleted == null))
            {
                this.UninstallOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUninstallOperationCompleted);
            }
            this.InvokeAsync("Uninstall", new object[0], this.UninstallOperationCompleted, userState);
        }

        private void OnUninstallOperationCompleted(object arg)
        {
            if ((this.UninstallCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UninstallCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/IsInstalled", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsInstalled()
        {
            object[] results = this.Invoke("IsInstalled", new object[0]);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginIsInstalled(System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("IsInstalled", new object[0], callback, asyncState);
        }

        /// <remarks/>
        public bool EndIsInstalled(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }

        /// <remarks/>
        public void IsInstalledAsync()
        {
            this.IsInstalledAsync(null);
        }

        /// <remarks/>
        public void IsInstalledAsync(object userState)
        {
            if ((this.IsInstalledOperationCompleted == null))
            {
                this.IsInstalledOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsInstalledOperationCompleted);
            }
            this.InvokeAsync("IsInstalled", new object[0], this.IsInstalledOperationCompleted, userState);
        }

        private void OnIsInstalledOperationCompleted(object arg)
        {
            if ((this.IsInstalledCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsInstalledCompleted(this, new IsInstalledCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/ChangeServiceItemsState", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ChangeServiceItemsState(SoapServiceProviderItem[] items, bool enabled)
        {
            this.Invoke("ChangeServiceItemsState", new object[] {
                        items,
                        enabled});
        }

        /// <remarks/>
        public System.IAsyncResult BeginChangeServiceItemsState(SoapServiceProviderItem[] items, bool enabled, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("ChangeServiceItemsState", new object[] {
                        items,
                        enabled}, callback, asyncState);
        }

        /// <remarks/>
        public void EndChangeServiceItemsState(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void ChangeServiceItemsStateAsync(SoapServiceProviderItem[] items, bool enabled)
        {
            this.ChangeServiceItemsStateAsync(items, enabled, null);
        }

        /// <remarks/>
        public void ChangeServiceItemsStateAsync(SoapServiceProviderItem[] items, bool enabled, object userState)
        {
            if ((this.ChangeServiceItemsStateOperationCompleted == null))
            {
                this.ChangeServiceItemsStateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnChangeServiceItemsStateOperationCompleted);
            }
            this.InvokeAsync("ChangeServiceItemsState", new object[] {
                        items,
                        enabled}, this.ChangeServiceItemsStateOperationCompleted, userState);
        }

        private void OnChangeServiceItemsStateOperationCompleted(object arg)
        {
            if ((this.ChangeServiceItemsStateCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ChangeServiceItemsStateCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/DeleteServiceItems", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteServiceItems(SoapServiceProviderItem[] items)
        {
            this.Invoke("DeleteServiceItems", new object[] {
                        items});
        }

        /// <remarks/>
        public System.IAsyncResult BeginDeleteServiceItems(SoapServiceProviderItem[] items, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("DeleteServiceItems", new object[] {
                        items}, callback, asyncState);
        }

        /// <remarks/>
        public void EndDeleteServiceItems(System.IAsyncResult asyncResult)
        {
            this.EndInvoke(asyncResult);
        }

        /// <remarks/>
        public void DeleteServiceItemsAsync(SoapServiceProviderItem[] items)
        {
            this.DeleteServiceItemsAsync(items, null);
        }

        /// <remarks/>
        public void DeleteServiceItemsAsync(SoapServiceProviderItem[] items, object userState)
        {
            if ((this.DeleteServiceItemsOperationCompleted == null))
            {
                this.DeleteServiceItemsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteServiceItemsOperationCompleted);
            }
            this.InvokeAsync("DeleteServiceItems", new object[] {
                        items}, this.DeleteServiceItemsOperationCompleted, userState);
        }

        private void OnDeleteServiceItemsOperationCompleted(object arg)
        {
            if ((this.DeleteServiceItemsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteServiceItemsCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetServiceItemsDiskSpace", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ServiceProviderItemDiskSpace[] GetServiceItemsDiskSpace(SoapServiceProviderItem[] items)
        {
            object[] results = this.Invoke("GetServiceItemsDiskSpace", new object[] {
                        items});
            return ((ServiceProviderItemDiskSpace[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetServiceItemsDiskSpace(SoapServiceProviderItem[] items, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetServiceItemsDiskSpace", new object[] {
                        items}, callback, asyncState);
        }

        /// <remarks/>
        public ServiceProviderItemDiskSpace[] EndGetServiceItemsDiskSpace(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ServiceProviderItemDiskSpace[])(results[0]));
        }

        /// <remarks/>
        public void GetServiceItemsDiskSpaceAsync(SoapServiceProviderItem[] items)
        {
            this.GetServiceItemsDiskSpaceAsync(items, null);
        }

        /// <remarks/>
        public void GetServiceItemsDiskSpaceAsync(SoapServiceProviderItem[] items, object userState)
        {
            if ((this.GetServiceItemsDiskSpaceOperationCompleted == null))
            {
                this.GetServiceItemsDiskSpaceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServiceItemsDiskSpaceOperationCompleted);
            }
            this.InvokeAsync("GetServiceItemsDiskSpace", new object[] {
                        items}, this.GetServiceItemsDiskSpaceOperationCompleted, userState);
        }

        private void OnGetServiceItemsDiskSpaceOperationCompleted(object arg)
        {
            if ((this.GetServiceItemsDiskSpaceCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServiceItemsDiskSpaceCompleted(this, new GetServiceItemsDiskSpaceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("ServiceProviderSettingsSoapHeaderValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/server/GetServiceItemsBandwidth", RequestNamespace = "http://smbsaas/websitepanel/server/", ResponseNamespace = "http://smbsaas/websitepanel/server/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public ServiceProviderItemBandwidth[] GetServiceItemsBandwidth(SoapServiceProviderItem[] items, System.DateTime since)
        {
            object[] results = this.Invoke("GetServiceItemsBandwidth", new object[] {
                        items,
                        since});
            return ((ServiceProviderItemBandwidth[])(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginGetServiceItemsBandwidth(SoapServiceProviderItem[] items, System.DateTime since, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("GetServiceItemsBandwidth", new object[] {
                        items,
                        since}, callback, asyncState);
        }

        /// <remarks/>
        public ServiceProviderItemBandwidth[] EndGetServiceItemsBandwidth(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((ServiceProviderItemBandwidth[])(results[0]));
        }

        /// <remarks/>
        public void GetServiceItemsBandwidthAsync(SoapServiceProviderItem[] items, System.DateTime since)
        {
            this.GetServiceItemsBandwidthAsync(items, since, null);
        }

        /// <remarks/>
        public void GetServiceItemsBandwidthAsync(SoapServiceProviderItem[] items, System.DateTime since, object userState)
        {
            if ((this.GetServiceItemsBandwidthOperationCompleted == null))
            {
                this.GetServiceItemsBandwidthOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServiceItemsBandwidthOperationCompleted);
            }
            this.InvokeAsync("GetServiceItemsBandwidth", new object[] {
                        items,
                        since}, this.GetServiceItemsBandwidthOperationCompleted, userState);
        }

        private void OnGetServiceItemsBandwidthOperationCompleted(object arg)
        {
            if ((this.GetServiceItemsBandwidthCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServiceItemsBandwidthCompleted(this, new GetServiceItemsBandwidthCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }







    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void InstallCompletedEventHandler(object sender, InstallCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstallCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal InstallCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetProviderDefaultSettingsCompletedEventHandler(object sender, GetProviderDefaultSettingsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetProviderDefaultSettingsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetProviderDefaultSettingsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public SettingPair[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((SettingPair[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void UninstallCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void IsInstalledCompletedEventHandler(object sender, IsInstalledCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsInstalledCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal IsInstalledCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void ChangeServiceItemsStateCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void DeleteServiceItemsCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetServiceItemsDiskSpaceCompletedEventHandler(object sender, GetServiceItemsDiskSpaceCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServiceItemsDiskSpaceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetServiceItemsDiskSpaceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ServiceProviderItemDiskSpace[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ServiceProviderItemDiskSpace[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetServiceItemsBandwidthCompletedEventHandler(object sender, GetServiceItemsBandwidthCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServiceItemsBandwidthCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetServiceItemsBandwidthCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState)
            :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public ServiceProviderItemBandwidth[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((ServiceProviderItemBandwidth[])(this.results[0]));
            }
        }
    }
}
