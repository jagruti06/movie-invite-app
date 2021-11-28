﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project5WebApp.LoginServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginServiceRef.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        string addUser(string username, string password, string userType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addUser", ReplyAction="http://tempuri.org/IService1/addUserResponse")]
        System.Threading.Tasks.Task<string> addUserAsync(string username, string password, string userType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUser", ReplyAction="http://tempuri.org/IService1/searchUserResponse")]
        string[] searchUser(string username, string password, string userType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchUser", ReplyAction="http://tempuri.org/IService1/searchUserResponse")]
        System.Threading.Tasks.Task<string[]> searchUserAsync(string username, string password, string userType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Project5WebApp.LoginServiceRef.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Project5WebApp.LoginServiceRef.IService1>, Project5WebApp.LoginServiceRef.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string addUser(string username, string password, string userType) {
            return base.Channel.addUser(username, password, userType);
        }
        
        public System.Threading.Tasks.Task<string> addUserAsync(string username, string password, string userType) {
            return base.Channel.addUserAsync(username, password, userType);
        }
        
        public string[] searchUser(string username, string password, string userType) {
            return base.Channel.searchUser(username, password, userType);
        }
        
        public System.Threading.Tasks.Task<string[]> searchUserAsync(string username, string password, string userType) {
            return base.Channel.searchUserAsync(username, password, userType);
        }
    }
}
