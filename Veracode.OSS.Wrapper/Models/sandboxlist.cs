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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxlist")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxlist", IsNullable=false)]
public partial class sandboxlist {
    
    private SandboxType[] sandboxField;
    
    private string sandboxlist_versionField;
    
    private long account_idField;
    
    private long app_idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("sandbox")]
    public SandboxType[] sandbox {
        get {
            return this.sandboxField;
        }
        set {
            this.sandboxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sandboxlist_version {
        get {
            return this.sandboxlist_versionField;
        }
        set {
            this.sandboxlist_versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long account_id {
        get {
            return this.account_idField;
        }
        set {
            this.account_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long app_id {
        get {
            return this.app_idField;
        }
        set {
            this.app_idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxlist")]
public partial class SandboxType {
    
    private CustomFieldType[] customfieldField;
    
    private long sandbox_idField;
    
    private string sandbox_nameField;
    
    private string ownerField;
    
    private string last_modifiedField;
    
    private string expiresField;
    
    private bool auto_recreateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customfield")]
    public CustomFieldType[] customfield {
        get {
            return this.customfieldField;
        }
        set {
            this.customfieldField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long sandbox_id {
        get {
            return this.sandbox_idField;
        }
        set {
            this.sandbox_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sandbox_name {
        get {
            return this.sandbox_nameField;
        }
        set {
            this.sandbox_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string owner {
        get {
            return this.ownerField;
        }
        set {
            this.ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string last_modified {
        get {
            return this.last_modifiedField;
        }
        set {
            this.last_modifiedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string expires {
        get {
            return this.expiresField;
        }
        set {
            this.expiresField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool auto_recreate {
        get {
            return this.auto_recreateField;
        }
        set {
            this.auto_recreateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxlist")]
public partial class CustomFieldType {
    
    private string nameField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}
