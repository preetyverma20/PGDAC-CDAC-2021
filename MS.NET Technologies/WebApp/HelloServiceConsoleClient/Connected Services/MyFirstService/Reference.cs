﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloServiceConsoleClient.MyFirstService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyFirstService.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/DoWork", ReplyAction="http://tempuri.org/IHelloService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/DoWork", ReplyAction="http://tempuri.org/IHelloService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/message", ReplyAction="http://tempuri.org/IHelloService/messageResponse")]
        string message([System.ServiceModel.MessageParameterAttribute(Name="message")] string message1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/message", ReplyAction="http://tempuri.org/IHelloService/messageResponse")]
        System.Threading.Tasks.Task<string> messageAsync(string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Addnumbers", ReplyAction="http://tempuri.org/IHelloService/AddnumbersResponse")]
        int Addnumbers(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloService/Addnumbers", ReplyAction="http://tempuri.org/IHelloService/AddnumbersResponse")]
        System.Threading.Tasks.Task<int> AddnumbersAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : HelloServiceConsoleClient.MyFirstService.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<HelloServiceConsoleClient.MyFirstService.IHelloService>, HelloServiceConsoleClient.MyFirstService.IHelloService {
        
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
        
        public string message(string message1) {
            return base.Channel.message(message1);
        }
        
        public System.Threading.Tasks.Task<string> messageAsync(string message) {
            return base.Channel.messageAsync(message);
        }
        
        public int Addnumbers(int x, int y) {
            return base.Channel.Addnumbers(x, y);
        }
        
        public System.Threading.Tasks.Task<int> AddnumbersAsync(int x, int y) {
            return base.Channel.AddnumbersAsync(x, y);
        }
    }
}
