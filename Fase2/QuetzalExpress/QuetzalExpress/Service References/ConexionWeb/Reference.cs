﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuetzalExpress.ConexionWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConexionWeb.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        QuetzalExpress.ConexionWeb.HelloWorldResponse HelloWorld(QuetzalExpress.ConexionWeb.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nombre from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Guardar", ReplyAction="*")]
        QuetzalExpress.ConexionWeb.GuardarResponse Guardar(QuetzalExpress.ConexionWeb.GuardarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public QuetzalExpress.ConexionWeb.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(QuetzalExpress.ConexionWeb.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public QuetzalExpress.ConexionWeb.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(QuetzalExpress.ConexionWeb.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GuardarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Guardar", Namespace="http://tempuri.org/", Order=0)]
        public QuetzalExpress.ConexionWeb.GuardarRequestBody Body;
        
        public GuardarRequest() {
        }
        
        public GuardarRequest(QuetzalExpress.ConexionWeb.GuardarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GuardarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string apellido;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int dpi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int nit;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int telefono;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string direccion;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string fecnac;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int numtar;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string tiptar;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string fecex;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string banco;
        
        public GuardarRequestBody() {
        }
        
        public GuardarRequestBody(string nombre, string apellido, int dpi, int nit, int telefono, string direccion, string email, string fecnac, int numtar, string tiptar, string fecex, string banco) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dpi = dpi;
            this.nit = nit;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.fecnac = fecnac;
            this.numtar = numtar;
            this.tiptar = tiptar;
            this.fecex = fecex;
            this.banco = banco;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GuardarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GuardarResponse", Namespace="http://tempuri.org/", Order=0)]
        public QuetzalExpress.ConexionWeb.GuardarResponseBody Body;
        
        public GuardarResponse() {
        }
        
        public GuardarResponse(QuetzalExpress.ConexionWeb.GuardarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GuardarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool GuardarResult;
        
        public GuardarResponseBody() {
        }
        
        public GuardarResponseBody(bool GuardarResult) {
            this.GuardarResult = GuardarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : QuetzalExpress.ConexionWeb.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<QuetzalExpress.ConexionWeb.ServiceSoap>, QuetzalExpress.ConexionWeb.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuetzalExpress.ConexionWeb.HelloWorldResponse QuetzalExpress.ConexionWeb.ServiceSoap.HelloWorld(QuetzalExpress.ConexionWeb.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            QuetzalExpress.ConexionWeb.HelloWorldRequest inValue = new QuetzalExpress.ConexionWeb.HelloWorldRequest();
            inValue.Body = new QuetzalExpress.ConexionWeb.HelloWorldRequestBody();
            QuetzalExpress.ConexionWeb.HelloWorldResponse retVal = ((QuetzalExpress.ConexionWeb.ServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuetzalExpress.ConexionWeb.GuardarResponse QuetzalExpress.ConexionWeb.ServiceSoap.Guardar(QuetzalExpress.ConexionWeb.GuardarRequest request) {
            return base.Channel.Guardar(request);
        }
        
        public bool Guardar(string nombre, string apellido, int dpi, int nit, int telefono, string direccion, string email, string fecnac, int numtar, string tiptar, string fecex, string banco) {
            QuetzalExpress.ConexionWeb.GuardarRequest inValue = new QuetzalExpress.ConexionWeb.GuardarRequest();
            inValue.Body = new QuetzalExpress.ConexionWeb.GuardarRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.apellido = apellido;
            inValue.Body.dpi = dpi;
            inValue.Body.nit = nit;
            inValue.Body.telefono = telefono;
            inValue.Body.direccion = direccion;
            inValue.Body.email = email;
            inValue.Body.fecnac = fecnac;
            inValue.Body.numtar = numtar;
            inValue.Body.tiptar = tiptar;
            inValue.Body.fecex = fecex;
            inValue.Body.banco = banco;
            QuetzalExpress.ConexionWeb.GuardarResponse retVal = ((QuetzalExpress.ConexionWeb.ServiceSoap)(this)).Guardar(inValue);
            return retVal.Body.GuardarResult;
        }
    }
}
