﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galaxy_Buds_Client.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
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
        public string RegisteredDevice {
            get {
                return ((string)(this["RegisteredDevice"]));
            }
            set {
                this["RegisteredDevice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseFahrenheit {
            get {
                return ((bool)(this["UseFahrenheit"]));
            }
            set {
                this["UseFahrenheit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool DisableSlideTransition {
            get {
                return ((bool)(this["DisableSlideTransition"]));
            }
            set {
                this["DisableSlideTransition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DevModeWarningShown {
            get {
                return ((bool)(this["DevModeWarningShown"]));
            }
            set {
                this["DevModeWarningShown"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SkippedUpdate {
            get {
                return ((string)(this["SkippedUpdate"]));
            }
            set {
                this["SkippedUpdate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Buds")]
        public global::Galaxy_Buds_Client.model.Constants.Model RegisteredDeviceModel {
            get {
                return ((global::Galaxy_Buds_Client.model.Constants.Model)(this["RegisteredDeviceModel"]));
            }
            set {
                this["RegisteredDeviceModel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool MinimizeTray {
            get {
                return ((bool)(this["MinimizeTray"]));
            }
            set {
                this["MinimizeTray"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LeftCustomActionParameter {
            get {
                return ((string)(this["LeftCustomActionParameter"]));
            }
            set {
                this["LeftCustomActionParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string RightCustomActionParameter {
            get {
                return ((string)(this["RightCustomActionParameter"]));
            }
            set {
                this["RightCustomActionParameter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int LeftCustomAction {
            get {
                return ((int)(this["LeftCustomAction"]));
            }
            set {
                this["LeftCustomAction"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int RightCustomAction {
            get {
                return ((int)(this["RightCustomAction"]));
            }
            set {
                this["RightCustomAction"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UpdateSettings {
            get {
                return ((bool)(this["UpdateSettings"]));
            }
            set {
                this["UpdateSettings"] = value;
            }
        }
    }
}
