﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockExchangeTicker.StockExchangeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StockSymbol", Namespace="https://www.centralgps.net/")]
    [System.SerializableAttribute()]
    public partial class StockSymbol : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SymbolField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MarketCapField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IPOYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SectorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IndustryField;
        
        private System.DateTime Created_atField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Symbol {
            get {
                return this.SymbolField;
            }
            set {
                if ((object.ReferenceEquals(this.SymbolField, value) != true)) {
                    this.SymbolField = value;
                    this.RaisePropertyChanged("Symbol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string MarketCap {
            get {
                return this.MarketCapField;
            }
            set {
                if ((object.ReferenceEquals(this.MarketCapField, value) != true)) {
                    this.MarketCapField = value;
                    this.RaisePropertyChanged("MarketCap");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string IPOYear {
            get {
                return this.IPOYearField;
            }
            set {
                if ((object.ReferenceEquals(this.IPOYearField, value) != true)) {
                    this.IPOYearField = value;
                    this.RaisePropertyChanged("IPOYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Sector {
            get {
                return this.SectorField;
            }
            set {
                if ((object.ReferenceEquals(this.SectorField, value) != true)) {
                    this.SectorField = value;
                    this.RaisePropertyChanged("Sector");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Industry {
            get {
                return this.IndustryField;
            }
            set {
                if ((object.ReferenceEquals(this.IndustryField, value) != true)) {
                    this.IndustryField = value;
                    this.RaisePropertyChanged("Industry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.DateTime Created_at {
            get {
                return this.Created_atField;
            }
            set {
                if ((this.Created_atField.Equals(value) != true)) {
                    this.Created_atField = value;
                    this.RaisePropertyChanged("Created_at");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://www.centralgps.net/", ConfigurationName="StockExchangeService.StockQuoteServiceSoap")]
    public interface StockQuoteServiceSoap {
        
        // CODEGEN: Generating message contract since element name symbol from namespace https://www.centralgps.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="https://www.centralgps.net/GetActualStockPrice", ReplyAction="*")]
        StockExchangeTicker.StockExchangeService.GetActualStockPriceResponse GetActualStockPrice(StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.centralgps.net/GetActualStockPrice", ReplyAction="*")]
        System.Threading.Tasks.Task<StockExchangeTicker.StockExchangeService.GetActualStockPriceResponse> GetActualStockPriceAsync(StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest request);
        
        // CODEGEN: Generating message contract since element name GetStockListResult from namespace https://www.centralgps.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="https://www.centralgps.net/GetStockList", ReplyAction="*")]
        StockExchangeTicker.StockExchangeService.GetStockListResponse GetStockList(StockExchangeTicker.StockExchangeService.GetStockListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://www.centralgps.net/GetStockList", ReplyAction="*")]
        System.Threading.Tasks.Task<StockExchangeTicker.StockExchangeService.GetStockListResponse> GetStockListAsync(StockExchangeTicker.StockExchangeService.GetStockListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetActualStockPriceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetActualStockPrice", Namespace="https://www.centralgps.net/", Order=0)]
        public StockExchangeTicker.StockExchangeService.GetActualStockPriceRequestBody Body;
        
        public GetActualStockPriceRequest() {
        }
        
        public GetActualStockPriceRequest(StockExchangeTicker.StockExchangeService.GetActualStockPriceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://www.centralgps.net/")]
    public partial class GetActualStockPriceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string symbol;
        
        public GetActualStockPriceRequestBody() {
        }
        
        public GetActualStockPriceRequestBody(string symbol) {
            this.symbol = symbol;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetActualStockPriceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetActualStockPriceResponse", Namespace="https://www.centralgps.net/", Order=0)]
        public StockExchangeTicker.StockExchangeService.GetActualStockPriceResponseBody Body;
        
        public GetActualStockPriceResponse() {
        }
        
        public GetActualStockPriceResponse(StockExchangeTicker.StockExchangeService.GetActualStockPriceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://www.centralgps.net/")]
    public partial class GetActualStockPriceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double GetActualStockPriceResult;
        
        public GetActualStockPriceResponseBody() {
        }
        
        public GetActualStockPriceResponseBody(double GetActualStockPriceResult) {
            this.GetActualStockPriceResult = GetActualStockPriceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStockListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStockList", Namespace="https://www.centralgps.net/", Order=0)]
        public StockExchangeTicker.StockExchangeService.GetStockListRequestBody Body;
        
        public GetStockListRequest() {
        }
        
        public GetStockListRequest(StockExchangeTicker.StockExchangeService.GetStockListRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetStockListRequestBody {
        
        public GetStockListRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetStockListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetStockListResponse", Namespace="https://www.centralgps.net/", Order=0)]
        public StockExchangeTicker.StockExchangeService.GetStockListResponseBody Body;
        
        public GetStockListResponse() {
        }
        
        public GetStockListResponse(StockExchangeTicker.StockExchangeService.GetStockListResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="https://www.centralgps.net/")]
    public partial class GetStockListResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public StockExchangeTicker.StockExchangeService.StockSymbol[] GetStockListResult;
        
        public GetStockListResponseBody() {
        }
        
        public GetStockListResponseBody(StockExchangeTicker.StockExchangeService.StockSymbol[] GetStockListResult) {
            this.GetStockListResult = GetStockListResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StockQuoteServiceSoapChannel : StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockQuoteServiceSoapClient : System.ServiceModel.ClientBase<StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap>, StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap {
        
        public StockQuoteServiceSoapClient() {
        }
        
        public StockQuoteServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockQuoteServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockQuoteServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockExchangeTicker.StockExchangeService.GetActualStockPriceResponse StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap.GetActualStockPrice(StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest request) {
            return base.Channel.GetActualStockPrice(request);
        }
        
        public double GetActualStockPrice(string symbol) {
            StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest inValue = new StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest();
            inValue.Body = new StockExchangeTicker.StockExchangeService.GetActualStockPriceRequestBody();
            inValue.Body.symbol = symbol;
            StockExchangeTicker.StockExchangeService.GetActualStockPriceResponse retVal = ((StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap)(this)).GetActualStockPrice(inValue);
            return retVal.Body.GetActualStockPriceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockExchangeTicker.StockExchangeService.GetActualStockPriceResponse> StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap.GetActualStockPriceAsync(StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest request) {
            return base.Channel.GetActualStockPriceAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockExchangeTicker.StockExchangeService.GetActualStockPriceResponse> GetActualStockPriceAsync(string symbol) {
            StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest inValue = new StockExchangeTicker.StockExchangeService.GetActualStockPriceRequest();
            inValue.Body = new StockExchangeTicker.StockExchangeService.GetActualStockPriceRequestBody();
            inValue.Body.symbol = symbol;
            return ((StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap)(this)).GetActualStockPriceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        StockExchangeTicker.StockExchangeService.GetStockListResponse StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap.GetStockList(StockExchangeTicker.StockExchangeService.GetStockListRequest request) {
            return base.Channel.GetStockList(request);
        }
        
        public StockExchangeTicker.StockExchangeService.StockSymbol[] GetStockList() {
            StockExchangeTicker.StockExchangeService.GetStockListRequest inValue = new StockExchangeTicker.StockExchangeService.GetStockListRequest();
            inValue.Body = new StockExchangeTicker.StockExchangeService.GetStockListRequestBody();
            StockExchangeTicker.StockExchangeService.GetStockListResponse retVal = ((StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap)(this)).GetStockList(inValue);
            return retVal.Body.GetStockListResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<StockExchangeTicker.StockExchangeService.GetStockListResponse> StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap.GetStockListAsync(StockExchangeTicker.StockExchangeService.GetStockListRequest request) {
            return base.Channel.GetStockListAsync(request);
        }
        
        public System.Threading.Tasks.Task<StockExchangeTicker.StockExchangeService.GetStockListResponse> GetStockListAsync() {
            StockExchangeTicker.StockExchangeService.GetStockListRequest inValue = new StockExchangeTicker.StockExchangeService.GetStockListRequest();
            inValue.Body = new StockExchangeTicker.StockExchangeService.GetStockListRequestBody();
            return ((StockExchangeTicker.StockExchangeService.StockQuoteServiceSoap)(this)).GetStockListAsync(inValue);
        }
    }
}
