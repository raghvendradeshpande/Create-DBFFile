﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASPNetDemo.RestServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/RestService")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BonusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalaryField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bonus {
            get {
                return this.BonusField;
            }
            set {
                if ((object.ReferenceEquals(this.BonusField, value) != true)) {
                    this.BonusField = value;
                    this.RaisePropertyChanged("Bonus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Company {
            get {
                return this.CompanyField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyField, value) != true)) {
                    this.CompanyField = value;
                    this.RaisePropertyChanged("Company");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((object.ReferenceEquals(this.SalaryField, value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RestServiceReference2.IRestServiceImpl")]
    public interface IRestServiceImpl {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestServiceImpl/getJSON", ReplyAction="http://tempuri.org/IRestServiceImpl/getJSONResponse")]
        string getJSON(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestServiceImpl/getEmployeeByID", ReplyAction="http://tempuri.org/IRestServiceImpl/getEmployeeByIDResponse")]
        ASPNetDemo.RestServiceReference2.Employee[] getEmployeeByID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestServiceImpl/getAllEmployee", ReplyAction="http://tempuri.org/IRestServiceImpl/getAllEmployeeResponse")]
        ASPNetDemo.RestServiceReference2.Employee[] getAllEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestServiceImpl/updateEmployee", ReplyAction="http://tempuri.org/IRestServiceImpl/updateEmployeeResponse")]
        string updateEmployee(string id, ASPNetDemo.RestServiceReference2.Employee[] emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRestServiceImpl/InsertEmployee", ReplyAction="http://tempuri.org/IRestServiceImpl/InsertEmployeeResponse")]
        string InsertEmployee(ASPNetDemo.RestServiceReference2.Employee[] emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRestServiceImplChannel : ASPNetDemo.RestServiceReference2.IRestServiceImpl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RestServiceImplClient : System.ServiceModel.ClientBase<ASPNetDemo.RestServiceReference2.IRestServiceImpl>, ASPNetDemo.RestServiceReference2.IRestServiceImpl {
        
        public RestServiceImplClient() {
        }
        
        public RestServiceImplClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RestServiceImplClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestServiceImplClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RestServiceImplClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string getJSON(string id) {
            return base.Channel.getJSON(id);
        }
        
        public ASPNetDemo.RestServiceReference2.Employee[] getEmployeeByID(string id) {
            return base.Channel.getEmployeeByID(id);
        }
        
        public ASPNetDemo.RestServiceReference2.Employee[] getAllEmployee() {
            return base.Channel.getAllEmployee();
        }
        
        public string updateEmployee(string id, ASPNetDemo.RestServiceReference2.Employee[] emp) {
            return base.Channel.updateEmployee(id, emp);
        }
        
        public string InsertEmployee(ASPNetDemo.RestServiceReference2.Employee[] emp) {
            return base.Channel.InsertEmployee(emp);
        }
    }
}
