﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IYoyakuService")]
    public interface IYoyakuService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYoyakuService/GetData", ReplyAction="http://tempuri.org/IYoyakuService/GetDataResponse")]
        string GetData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYoyakuService/GetData", ReplyAction="http://tempuri.org/IYoyakuService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYoyakuService/GetStay", ReplyAction="http://tempuri.org/IYoyakuService/GetStayResponse")]
        string GetStay();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IYoyakuService/GetStay", ReplyAction="http://tempuri.org/IYoyakuService/GetStayResponse")]
        System.Threading.Tasks.Task<string> GetStayAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IYoyakuServiceChannel : TestClient.ServiceReference1.IYoyakuService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class YoyakuServiceClient : System.ServiceModel.ClientBase<TestClient.ServiceReference1.IYoyakuService>, TestClient.ServiceReference1.IYoyakuService {
        
        public YoyakuServiceClient() {
        }
        
        public YoyakuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public YoyakuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YoyakuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public YoyakuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData() {
            return base.Channel.GetData();
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync() {
            return base.Channel.GetDataAsync();
        }
        
        public string GetStay() {
            return base.Channel.GetStay();
        }
        
        public System.Threading.Tasks.Task<string> GetStayAsync() {
            return base.Channel.GetStayAsync();
        }
    }
}
