﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Modules {
    
    private ModulesModule[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("module", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public ModulesModule[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class ModulesModule {
    
    private string assemblyFileField;
    
    private string moduleTypeField;
    
    private string moduleNameField;
    
    private string startupLoadedField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string assemblyFile {
        get {
            return this.assemblyFileField;
        }
        set {
            this.assemblyFileField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moduleType {
        get {
            return this.moduleTypeField;
        }
        set {
            this.moduleTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string moduleName {
        get {
            return this.moduleNameField;
        }
        set {
            this.moduleNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string startupLoaded {
        get {
            return this.startupLoadedField;
        }
        set {
            this.startupLoadedField = value;
        }
    }
}
