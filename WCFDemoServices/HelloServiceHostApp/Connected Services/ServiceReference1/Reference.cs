﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloServiceHostApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/DoWork", ReplyAction="http://tempuri.org/IHelloService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/DoWork", ReplyAction="http://tempuri.org/IHelloService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Message", ReplyAction="http://tempuri.org/IHelloService/MessageResponse")]
        string Message([System.ServiceModel.MessageParameterAttribute(Name="message")] string message1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Message", ReplyAction="http://tempuri.org/IHelloService/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/AddNumber", ReplyAction="http://tempuri.org/IHelloService/AddNumberResponse")]
        int AddNumber(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/AddNumber", ReplyAction="http://tempuri.org/IHelloService/AddNumberResponse")]
        System.Threading.Tasks.Task<int> AddNumberAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : HelloServiceHostApp.ServiceReference1.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<HelloServiceHostApp.ServiceReference1.IHelloService>, HelloServiceHostApp.ServiceReference1.IHelloService {
        
        public HelloServiceClient() {
        }
        
        public HelloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string Message(string message1) {
            return base.Channel.Message(message1);
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync(string message) {
            return base.Channel.MessageAsync(message);
        }
        
        public int AddNumber(int x, int y) {
            return base.Channel.AddNumber(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddNumberAsync(int x, int y) {
            return base.Channel.AddNumberAsync(x, y);
        }
    }
}