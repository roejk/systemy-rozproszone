﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrackerClient.CrackerServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CrackerServiceReference.ICrackerService", CallbackContract=typeof(CrackerClient.CrackerServiceReference.ICrackerServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICrackerService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrackerService/Send")]
        void Send();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrackerService/Send")]
        System.Threading.Tasks.Task SendAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrackerService/Receive")]
        void Receive();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrackerService/Receive")]
        System.Threading.Tasks.Task ReceiveAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrackerServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICrackerService/Print")]
        void Print();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrackerServiceChannel : CrackerClient.CrackerServiceReference.ICrackerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CrackerServiceClient : System.ServiceModel.DuplexClientBase<CrackerClient.CrackerServiceReference.ICrackerService>, CrackerClient.CrackerServiceReference.ICrackerService {
        
        public CrackerServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CrackerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CrackerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CrackerServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CrackerServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Send() {
            base.Channel.Send();
        }
        
        public System.Threading.Tasks.Task SendAsync() {
            return base.Channel.SendAsync();
        }
        
        public void Receive() {
            base.Channel.Receive();
        }
        
        public System.Threading.Tasks.Task ReceiveAsync() {
            return base.Channel.ReceiveAsync();
        }
    }
}
