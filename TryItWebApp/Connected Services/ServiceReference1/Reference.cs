﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TryItWebApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.lProjectService")]
    public interface lProjectService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/lProjectService/sendMail", ReplyAction="http://tempuri.org/lProjectService/sendMailResponse")]
        string sendMail(string to, string details);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/lProjectService/sendMail", ReplyAction="http://tempuri.org/lProjectService/sendMailResponse")]
        System.Threading.Tasks.Task<string> sendMailAsync(string to, string details);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface lProjectServiceChannel : TryItWebApp.ServiceReference1.lProjectService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class lProjectServiceClient : System.ServiceModel.ClientBase<TryItWebApp.ServiceReference1.lProjectService>, TryItWebApp.ServiceReference1.lProjectService {
        
        public lProjectServiceClient() {
        }
        
        public lProjectServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public lProjectServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public lProjectServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public lProjectServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string sendMail(string to, string details) {
            return base.Channel.sendMail(to, details);
        }
        
        public System.Threading.Tasks.Task<string> sendMailAsync(string to, string details) {
            return base.Channel.sendMailAsync(to, details);
        }
    }
}
