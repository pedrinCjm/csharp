﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ListaJogosModelView", Namespace="http://tempuri.org/")]
    public partial class ListaJogosModelView : object
    {
        
        private ServiceReference1.JogoModelView[] JogoModelViewField;
        
        private string NoJogoField;
        
        private string DsJogoField;
        
        private int TipoJogoIdField;
        
        private double JogadoresRegistradosField;
        
        private double JogadoresOnlineField;
        
        private string CodigoPromocionalField;
        
        private System.Nullable<System.DateTime> DtInicialField;
        
        private System.Nullable<System.DateTime> DtFinalField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public ServiceReference1.JogoModelView[] JogoModelView
        {
            get
            {
                return this.JogoModelViewField;
            }
            set
            {
                this.JogoModelViewField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NoJogo
        {
            get
            {
                return this.NoJogoField;
            }
            set
            {
                this.NoJogoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DsJogo
        {
            get
            {
                return this.DsJogoField;
            }
            set
            {
                this.DsJogoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int TipoJogoId
        {
            get
            {
                return this.TipoJogoIdField;
            }
            set
            {
                this.TipoJogoIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public double JogadoresRegistrados
        {
            get
            {
                return this.JogadoresRegistradosField;
            }
            set
            {
                this.JogadoresRegistradosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public double JogadoresOnline
        {
            get
            {
                return this.JogadoresOnlineField;
            }
            set
            {
                this.JogadoresOnlineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string CodigoPromocional
        {
            get
            {
                return this.CodigoPromocionalField;
            }
            set
            {
                this.CodigoPromocionalField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=7)]
        public System.Nullable<System.DateTime> DtInicial
        {
            get
            {
                return this.DtInicialField;
            }
            set
            {
                this.DtInicialField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=8)]
        public System.Nullable<System.DateTime> DtFinal
        {
            get
            {
                return this.DtFinalField;
            }
            set
            {
                this.DtFinalField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JogoModelView", Namespace="http://tempuri.org/")]
    public partial class JogoModelView : object
    {
        
        private int JogoModelViewIdField;
        
        private string NoJogoField;
        
        private string DsJogoField;
        
        private int TipoJogoIdField;
        
        private double JogadoresRegistradosField;
        
        private double JogadoresOnlineField;
        
        private string CodigoPromocionalField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int JogoModelViewId
        {
            get
            {
                return this.JogoModelViewIdField;
            }
            set
            {
                this.JogoModelViewIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NoJogo
        {
            get
            {
                return this.NoJogoField;
            }
            set
            {
                this.NoJogoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string DsJogo
        {
            get
            {
                return this.DsJogoField;
            }
            set
            {
                this.DsJogoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int TipoJogoId
        {
            get
            {
                return this.TipoJogoIdField;
            }
            set
            {
                this.TipoJogoIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public double JogadoresRegistrados
        {
            get
            {
                return this.JogadoresRegistradosField;
            }
            set
            {
                this.JogadoresRegistradosField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public double JogadoresOnline
        {
            get
            {
                return this.JogadoresOnlineField;
            }
            set
            {
                this.JogadoresOnlineField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string CodigoPromocional
        {
            get
            {
                return this.CodigoPromocionalField;
            }
            set
            {
                this.CodigoPromocionalField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.serviceSoap")]
    public interface serviceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.HelloWorldResponse> HelloWorldAsync(ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AcessaJogos", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceReference1.AcessaJogosResponse> AcessaJogosAsync(ServiceReference1.AcessaJogosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest()
        {
        }
        
        public HelloWorldRequest(ServiceReference1.HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody
    {
        
        public HelloWorldRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse()
        {
        }
        
        public HelloWorldResponse(ServiceReference1.HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody()
        {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AcessaJogosRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AcessaJogos", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.AcessaJogosRequestBody Body;
        
        public AcessaJogosRequest()
        {
        }
        
        public AcessaJogosRequest(ServiceReference1.AcessaJogosRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AcessaJogosRequestBody
    {
        
        public AcessaJogosRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AcessaJogosResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AcessaJogosResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceReference1.AcessaJogosResponseBody Body;
        
        public AcessaJogosResponse()
        {
        }
        
        public AcessaJogosResponse(ServiceReference1.AcessaJogosResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AcessaJogosResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServiceReference1.ListaJogosModelView AcessaJogosResult;
        
        public AcessaJogosResponseBody()
        {
        }
        
        public AcessaJogosResponseBody(ServiceReference1.ListaJogosModelView AcessaJogosResult)
        {
            this.AcessaJogosResult = AcessaJogosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface serviceSoapChannel : ServiceReference1.serviceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class serviceSoapClient : System.ServiceModel.ClientBase<ServiceReference1.serviceSoap>, ServiceReference1.serviceSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public serviceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(serviceSoapClient.GetBindingForEndpoint(endpointConfiguration), serviceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(serviceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(serviceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public serviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.HelloWorldResponse> ServiceReference1.serviceSoap.HelloWorldAsync(ServiceReference1.HelloWorldRequest request)
        {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.HelloWorldResponse> HelloWorldAsync()
        {
            ServiceReference1.HelloWorldRequest inValue = new ServiceReference1.HelloWorldRequest();
            inValue.Body = new ServiceReference1.HelloWorldRequestBody();
            return ((ServiceReference1.serviceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceReference1.AcessaJogosResponse> ServiceReference1.serviceSoap.AcessaJogosAsync(ServiceReference1.AcessaJogosRequest request)
        {
            return base.Channel.AcessaJogosAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReference1.AcessaJogosResponse> AcessaJogosAsync()
        {
            ServiceReference1.AcessaJogosRequest inValue = new ServiceReference1.AcessaJogosRequest();
            inValue.Body = new ServiceReference1.AcessaJogosRequestBody();
            return ((ServiceReference1.serviceSoap)(this)).AcessaJogosAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.serviceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.serviceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpsTransportBindingElement httpsBindingElement = new System.ServiceModel.Channels.HttpsTransportBindingElement();
                httpsBindingElement.AllowCookies = true;
                httpsBindingElement.MaxBufferSize = int.MaxValue;
                httpsBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.serviceSoap))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44308/service.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.serviceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("https://localhost:44308/service.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            serviceSoap,
            
            serviceSoap12,
        }
    }
}
