//------------------------------------------------------------------------------
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class restaurant_reviews {
    
    private restaurant_reviewsRestaurant[] restaurantField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("restaurant")]
    public restaurant_reviewsRestaurant[] restaurant {
        get {
            return this.restaurantField;
        }
        set {
            this.restaurantField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurant {
    
    private string nameField;
    
    private restaurant_reviewsRestaurantLogo logoField;
    
    private restaurant_reviewsRestaurantContact contactField;
    
    private string websiteField;
    
    private string food_typeField;
    
    private restaurant_reviewsRestaurantPrice_scale price_scaleField;
    
    private restaurant_reviewsRestaurantReviews reviewsField;
    
    private restaurant_reviewsRestaurantMenu menuField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantLogo logo {
        get {
            return this.logoField;
        }
        set {
            this.logoField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantContact contact {
        get {
            return this.contactField;
        }
        set {
            this.contactField = value;
        }
    }
    
    /// <remarks/>
    public string website {
        get {
            return this.websiteField;
        }
        set {
            this.websiteField = value;
        }
    }
    
    /// <remarks/>
    public string food_type {
        get {
            return this.food_typeField;
        }
        set {
            this.food_typeField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantPrice_scale price_scale {
        get {
            return this.price_scaleField;
        }
        set {
            this.price_scaleField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantReviews reviews {
        get {
            return this.reviewsField;
        }
        set {
            this.reviewsField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantMenu menu {
        get {
            return this.menuField;
        }
        set {
            this.menuField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantLogo {
    
    private restaurant_reviewsRestaurantLogoWidth widthField;
    
    private restaurant_reviewsRestaurantLogoHeight heightField;
    
    private string srcField;
    
    /// <remarks/>
    public restaurant_reviewsRestaurantLogoWidth width {
        get {
            return this.widthField;
        }
        set {
            this.widthField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantLogoHeight height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string src {
        get {
            return this.srcField;
        }
        set {
            this.srcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantLogoWidth {
    
    private string unitField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantLogoHeight {
    
    private string unitField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string unit {
        get {
            return this.unitField;
        }
        set {
            this.unitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantContact {
    
    private address addressField;
    
    private string phoneField;
    
    /// <remarks/>
    public address address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
    
    /// <remarks/>
    public string phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class address {
    
    private ushort st_numberField;
    
    private string streetField;
    
    private string cityField;
    
    private province provinceField;
    
    private string postalField;
    
    private string countryField;
    
    /// <remarks/>
    public ushort st_number {
        get {
            return this.st_numberField;
        }
        set {
            this.st_numberField = value;
        }
    }
    
    /// <remarks/>
    public string street {
        get {
            return this.streetField;
        }
        set {
            this.streetField = value;
        }
    }
    
    /// <remarks/>
    public string city {
        get {
            return this.cityField;
        }
        set {
            this.cityField = value;
        }
    }
    
    /// <remarks/>
    public province province {
        get {
            return this.provinceField;
        }
        set {
            this.provinceField = value;
        }
    }
    
    /// <remarks/>
    public string postal {
        get {
            return this.postalField;
        }
        set {
            this.postalField = value;
        }
    }
    
    /// <remarks/>
    public string country {
        get {
            return this.countryField;
        }
        set {
            this.countryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public enum province {
    
    /// <remarks/>
    ON,
    
    /// <remarks/>
    QC,
    
    /// <remarks/>
    BC,
    
    /// <remarks/>
    ALBT,
    
    /// <remarks/>
    SK,
    
    /// <remarks/>
    MB,
    
    /// <remarks/>
    NL,
    
    /// <remarks/>
    PEI,
    
    /// <remarks/>
    NB,
    
    /// <remarks/>
    NS,
    
    /// <remarks/>
    NT,
    
    /// <remarks/>
    NV,
    
    /// <remarks/>
    YK,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantPrice_scale {
    
    private byte maxField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantReviews {
    
    private restaurant_reviewsRestaurantReviewsReviewer reviewerField;
    
    private System.DateTime dateField;
    
    private restaurant_reviewsRestaurantReviewsRating ratingField;
    
    private string summaryField;
    
    /// <remarks/>
    public restaurant_reviewsRestaurantReviewsReviewer reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    public restaurant_reviewsRestaurantReviewsRating rating {
        get {
            return this.ratingField;
        }
        set {
            this.ratingField = value;
        }
    }
    
    /// <remarks/>
    public string summary {
        get {
            return this.summaryField;
        }
        set {
            this.summaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantReviewsReviewer {
    
    private string first_nameField;
    
    private string middle_nameField;
    
    private string last_nameField;
    
    /// <remarks/>
    public string first_name {
        get {
            return this.first_nameField;
        }
        set {
            this.first_nameField = value;
        }
    }
    
    /// <remarks/>
    public string middle_name {
        get {
            return this.middle_nameField;
        }
        set {
            this.middle_nameField = value;
        }
    }
    
    /// <remarks/>
    public string last_name {
        get {
            return this.last_nameField;
        }
        set {
            this.last_nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantReviewsRating {
    
    private byte maxField;
    
    private byte valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte max {
        get {
            return this.maxField;
        }
        set {
            this.maxField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantMenu {
    
    private restaurant_reviewsRestaurantMenuAppetizer[] appetizersField;
    
    private restaurant_reviewsRestaurantMenuEntree[] entreesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("appetizer", IsNullable=false)]
    public restaurant_reviewsRestaurantMenuAppetizer[] appetizers {
        get {
            return this.appetizersField;
        }
        set {
            this.appetizersField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("entree", IsNullable=false)]
    public restaurant_reviewsRestaurantMenuEntree[] entrees {
        get {
            return this.entreesField;
        }
        set {
            this.entreesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantMenuAppetizer {
    
    private item itemField;
    
    /// <remarks/>
    public item item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.algonquincollege.com/cst8259/labs", IsNullable=false)]
public partial class item {
    
    private string titleField;
    
    private string descriptionField;
    
    private itemPrice[] priceField;
    
    /// <remarks/>
    public string title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("price")]
    public itemPrice[] price {
        get {
            return this.priceField;
        }
        set {
            this.priceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class itemPrice {
    
    private string currencyField;
    
    private byte quantityField;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string currency {
        get {
            return this.currencyField;
        }
        set {
            this.currencyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.algonquincollege.com/cst8259/labs")]
public partial class restaurant_reviewsRestaurantMenuEntree {
    
    private item itemField;
    
    /// <remarks/>
    public item item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}
