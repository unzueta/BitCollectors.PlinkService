﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BitCollectors.PlinkService.Service.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PlinkExecutable {
            get {
                return ((string)(this["PlinkExecutable"]));
            }
            set {
                this["PlinkExecutable"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshUsername {
            get {
                return ((string)(this["SshUsername"]));
            }
            set {
                this["SshUsername"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshPassword {
            get {
                return ((string)(this["SshPassword"]));
            }
            set {
                this["SshPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SshHostname {
            get {
                return ((string)(this["SshHostname"]));
            }
            set {
                this["SshHostname"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("22")]
        public int SshPort {
            get {
                return ((int)(this["SshPort"]));
            }
            set {
                this["SshPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableCompression {
            get {
                return ((bool)(this["EnableCompression"]));
            }
            set {
                this["EnableCompression"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableVerbose {
            get {
                return ((bool)(this["EnableVerbose"]));
            }
            set {
                this["EnableVerbose"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool EnableDynamicSocks {
            get {
                return ((bool)(this["EnableDynamicSocks"]));
            }
            set {
                this["EnableDynamicSocks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DynamicSocksHost {
            get {
                return ((string)(this["DynamicSocksHost"]));
            }
            set {
                this["DynamicSocksHost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int DynamicSocksPort {
            get {
                return ((int)(this["DynamicSocksPort"]));
            }
            set {
                this["DynamicSocksPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UiStartWithWindows {
            get {
                return ((bool)(this["UiStartWithWindows"]));
            }
            set {
                this["UiStartWithWindows"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UiStartMinimized {
            get {
                return ((bool)(this["UiStartMinimized"]));
            }
            set {
                this["UiStartMinimized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UiMinimizedToSysTray {
            get {
                return ((bool)(this["UiMinimizedToSysTray"]));
            }
            set {
                this["UiMinimizedToSysTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UiShowSysTrayNotifications {
            get {
                return ((bool)(this["UiShowSysTrayNotifications"]));
            }
            set {
                this["UiShowSysTrayNotifications"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableTunnelValidation {
            get {
                return ((bool)(this["EnableTunnelValidation"]));
            }
            set {
                this["EnableTunnelValidation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12011")]
        public int TunnelValidationLocalPort {
            get {
                return ((int)(this["TunnelValidationLocalPort"]));
            }
            set {
                this["TunnelValidationLocalPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12012")]
        public int TunnelValidationRemotePort {
            get {
                return ((int)(this["TunnelValidationRemotePort"]));
            }
            set {
                this["TunnelValidationRemotePort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("120")]
        public int TunnelValidationPingInterval {
            get {
                return ((int)(this["TunnelValidationPingInterval"]));
            }
            set {
                this["TunnelValidationPingInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public int TunnelValidationPingTimeout {
            get {
                return ((int)(this["TunnelValidationPingTimeout"]));
            }
            set {
                this["TunnelValidationPingTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LocalTunnels {
            get {
                return ((string)(this["LocalTunnels"]));
            }
            set {
                this["LocalTunnels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RemoteTunnels {
            get {
                return ((string)(this["RemoteTunnels"]));
            }
            set {
                this["RemoteTunnels"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableIcmpValidation {
            get {
                return ((bool)(this["EnableIcmpValidation"]));
            }
            set {
                this["EnableIcmpValidation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("www.google.com\r\nwww.yahoo.com\r\nping.symantec.com\r\n8.8.8.8 # Google name server\r\n8" +
            ".8.4.4 # Google name server\r\n139.130.4.5 # Telstra (Australia)\r\n208.67.222.222 #" +
            " OpenDNS\r\n208.67.220.220 # OpenDNS\r\n198.153.192.1 # Norton\r\n198.153.194.2 # Nort" +
            "on")]
        public string IcmpValidationHostnames {
            get {
                return ((string)(this["IcmpValidationHostnames"]));
            }
            set {
                this["IcmpValidationHostnames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IcmpValidationPingSshServer {
            get {
                return ((bool)(this["IcmpValidationPingSshServer"]));
            }
            set {
                this["IcmpValidationPingSshServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int CurrentTunnelStatus {
            get {
                return ((int)(this["CurrentTunnelStatus"]));
            }
            set {
                this["CurrentTunnelStatus"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpgradeRequired {
            get {
                return ((bool)(this["UpgradeRequired"]));
            }
            set {
                this["UpgradeRequired"] = value;
            }
        }
    }
}
