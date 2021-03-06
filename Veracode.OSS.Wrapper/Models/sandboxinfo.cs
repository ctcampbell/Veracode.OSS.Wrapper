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

namespace Veracode.OSS.Wrapper.Models
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxinfo")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxinfo", IsNullable=false)]
public partial class sandboxinfo {
    
    private SandboxType sandboxField;
    
    private string sandboxinfo_versionField;
    
    private long account_idField;
    
    private long app_idField;
    
    private long build_idField;
    
    private bool build_idFieldSpecified;
    
    private long analysis_idField;
    
    private bool analysis_idFieldSpecified;
    
    private long analysis_unit_idField;
    
    private bool analysis_unit_idFieldSpecified;
    
    /// <remarks/>
    public SandboxType sandbox {
        get {
            return this.sandboxField;
        }
        set {
            this.sandboxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sandboxinfo_version {
        get {
            return this.sandboxinfo_versionField;
        }
        set {
            this.sandboxinfo_versionField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long build_id {
        get {
            return this.build_idField;
        }
        set {
            this.build_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool build_idSpecified {
        get {
            return this.build_idFieldSpecified;
        }
        set {
            this.build_idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long analysis_id {
        get {
            return this.analysis_idField;
        }
        set {
            this.analysis_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool analysis_idSpecified {
        get {
            return this.analysis_idFieldSpecified;
        }
        set {
            this.analysis_idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long analysis_unit_id {
        get {
            return this.analysis_unit_idField;
        }
        set {
            this.analysis_unit_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool analysis_unit_idSpecified {
        get {
            return this.analysis_unit_idFieldSpecified;
        }
        set {
            this.analysis_unit_idFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/sandboxinfo")]
public partial class SandboxType {
    
    private CustomFieldType[] customfieldField;
    
    private long sandbox_idField;
    
    private string sandbox_nameField;
    
    private string sandbox_statusField;
    
    private string ownerField;
    
    private string modified_dateField;
    
    private string created_dateField;
    
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
    public string sandbox_status {
        get {
            return this.sandbox_statusField;
        }
        set {
            this.sandbox_statusField = value;
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
    public string modified_date {
        get {
            return this.modified_dateField;
        }
        set {
            this.modified_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string created_date {
        get {
            return this.created_dateField;
        }
        set {
            this.created_dateField = value;
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

}

