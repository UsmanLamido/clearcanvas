﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClearCanvas.Ris.Client {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class FolderExplorerComponentSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static FolderExplorerComponentSettings defaultInstance = ((FolderExplorerComponentSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new FolderExplorerComponentSettings())));
        
        public static FolderExplorerComponentSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// XML document that describes the default ordering of folders in folder systems.
        /// </summary>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that describes the default ordering of folders in folder systems.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FolderExplorerComponentSettings.xml")]
        public string DefaultConfigurationXml {
            get {
                return ((string)(this["DefaultConfigurationXml"]));
            }
        }
        
        /// <summary>
        /// XML document that describes user-customizations to folder system display.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("XML document that describes user-customizations to folder system display.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FolderExplorerComponentUserSettings.xml")]
        public string UserConfigurationXml {
            get {
                return ((string)(this["UserConfigurationXml"]));
            }
            set {
                this["UserConfigurationXml"] = value;
            }
        }
    }
}