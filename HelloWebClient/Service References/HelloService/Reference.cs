﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWebClient.HelloService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://PragimTech.com/ServiceVersion1", ConfigurationName="HelloService.IHelloService")]
    public interface IHelloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/GetMessage", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/GetMessageResponse")]
        string GetMessage(string firstname, string lastname, string Mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/GetMessage", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(string firstname, string lastname, string Mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessData", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessDataResponse")]
        string ProcessData(string firstname, string lastname, string Mobile, string monthlypayment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessData", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessDataResponse")]
        System.Threading.Tasks.Task<string> ProcessDataAsync(string firstname, string lastname, string Mobile, string monthlypayment);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessDataAdd", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessDataAddResponse")]
        string ProcessDataAdd(string firstname, string lastname, string email, string Mobile, string debtlevel, string monthlypayment, string website);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessDataAdd", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/ProcessDataAddResponse")]
        System.Threading.Tasks.Task<string> ProcessDataAddAsync(string firstname, string lastname, string email, string Mobile, string debtlevel, string monthlypayment, string website);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/UrlIsValid", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/UrlIsValidResponse")]
        bool UrlIsValid(string url);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://PragimTech.com/ServiceVersion1/IHelloService/UrlIsValid", ReplyAction="http://PragimTech.com/ServiceVersion1/IHelloService/UrlIsValidResponse")]
        System.Threading.Tasks.Task<bool> UrlIsValidAsync(string url);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloServiceChannel : HelloWebClient.HelloService.IHelloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloServiceClient : System.ServiceModel.ClientBase<HelloWebClient.HelloService.IHelloService>, HelloWebClient.HelloService.IHelloService {
        
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
        
        public string GetMessage(string firstname, string lastname, string Mobile) {
            return base.Channel.GetMessage(firstname, lastname, Mobile);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(string firstname, string lastname, string Mobile) {
            return base.Channel.GetMessageAsync(firstname, lastname, Mobile);
        }
        
        public string ProcessData(string firstname, string lastname, string Mobile, string monthlypayment) {
            return base.Channel.ProcessData(firstname, lastname, Mobile, monthlypayment);
        }
        
        public System.Threading.Tasks.Task<string> ProcessDataAsync(string firstname, string lastname, string Mobile, string monthlypayment) {
            return base.Channel.ProcessDataAsync(firstname, lastname, Mobile, monthlypayment);
        }
        
        public string ProcessDataAdd(string firstname, string lastname, string email, string Mobile, string debtlevel, string monthlypayment, string website) {
            return base.Channel.ProcessDataAdd(firstname, lastname, email, Mobile, debtlevel, monthlypayment, website);
        }
        
        public System.Threading.Tasks.Task<string> ProcessDataAddAsync(string firstname, string lastname, string email, string Mobile, string debtlevel, string monthlypayment, string website) {
            return base.Channel.ProcessDataAddAsync(firstname, lastname, email, Mobile, debtlevel, monthlypayment, website);
        }
        
        public bool UrlIsValid(string url) {
            return base.Channel.UrlIsValid(url);
        }
        
        public System.Threading.Tasks.Task<bool> UrlIsValidAsync(string url) {
            return base.Channel.UrlIsValidAsync(url);
        }
    }
}
