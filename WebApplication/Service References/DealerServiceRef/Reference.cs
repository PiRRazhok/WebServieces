﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication.DealerServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Dealer", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class Dealer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApplication.DealerServiceRef.Car[] CarsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        private string email1;

        public Dealer(string name, string email)
        {
            Name = name;
            Email = email;
            Cars = new Car[0];
        }

        public Dealer(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Cars = new Car[0];
        }

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApplication.DealerServiceRef.Car[] Cars {
            get {
                return this.CarsField;
            }
            set {
                if ((object.ReferenceEquals(this.CarsField, value) != true)) {
                    this.CarsField = value;
                    this.RaisePropertyChanged("Cars");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/WcfServices")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DoorNumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ReleaseYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SeriesField;

        public Car(string id, string brand, string series, int releaseYear, int doorNum, string color, string bodyType)
        {
            Id = id;
            Brand = brand;
            Series = series;
            ReleaseYear = releaseYear;
            DoorNum = doorNum;
            Color = color;
            BodyType = bodyType;
        }

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BodyType {
            get {
                return this.BodyTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyTypeField, value) != true)) {
                    this.BodyTypeField = value;
                    this.RaisePropertyChanged("BodyType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoorNum {
            get {
                return this.DoorNumField;
            }
            set {
                if ((this.DoorNumField.Equals(value) != true)) {
                    this.DoorNumField = value;
                    this.RaisePropertyChanged("DoorNum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReleaseYear {
            get {
                return this.ReleaseYearField;
            }
            set {
                if ((this.ReleaseYearField.Equals(value) != true)) {
                    this.ReleaseYearField = value;
                    this.RaisePropertyChanged("ReleaseYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Series {
            get {
                return this.SeriesField;
            }
            set {
                if ((object.ReferenceEquals(this.SeriesField, value) != true)) {
                    this.SeriesField = value;
                    this.RaisePropertyChanged("Series");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DealerServiceRef.IDealerService")]
    public interface IDealerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/getAllDealers", ReplyAction="http://tempuri.org/IDealerService/getAllDealersResponse")]
        WebApplication.DealerServiceRef.Dealer[] getAllDealers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/getAllDealers", ReplyAction="http://tempuri.org/IDealerService/getAllDealersResponse")]
        System.Threading.Tasks.Task<WebApplication.DealerServiceRef.Dealer[]> getAllDealersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/getDealer", ReplyAction="http://tempuri.org/IDealerService/getDealerResponse")]
        WebApplication.DealerServiceRef.Dealer getDealer(string dealerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/getDealer", ReplyAction="http://tempuri.org/IDealerService/getDealerResponse")]
        System.Threading.Tasks.Task<WebApplication.DealerServiceRef.Dealer> getDealerAsync(string dealerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/addDealer", ReplyAction="http://tempuri.org/IDealerService/addDealerResponse")]
        void addDealer(WebApplication.DealerServiceRef.Dealer dealer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/addDealer", ReplyAction="http://tempuri.org/IDealerService/addDealerResponse")]
        System.Threading.Tasks.Task addDealerAsync(WebApplication.DealerServiceRef.Dealer dealer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/updateDealer", ReplyAction="http://tempuri.org/IDealerService/updateDealerResponse")]
        void updateDealer(WebApplication.DealerServiceRef.Dealer updatedDealer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/updateDealer", ReplyAction="http://tempuri.org/IDealerService/updateDealerResponse")]
        System.Threading.Tasks.Task updateDealerAsync(WebApplication.DealerServiceRef.Dealer updatedDealer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/deleteDealer", ReplyAction="http://tempuri.org/IDealerService/deleteDealerResponse")]
        void deleteDealer(string dealerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/deleteDealer", ReplyAction="http://tempuri.org/IDealerService/deleteDealerResponse")]
        System.Threading.Tasks.Task deleteDealerAsync(string dealerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/getDealerCars", ReplyAction="http://tempuri.org/IDealerService/getDealerCarsResponse")]
        WebApplication.DealerServiceRef.Car[] getDealerCars(string dealerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/getDealerCars", ReplyAction="http://tempuri.org/IDealerService/getDealerCarsResponse")]
        System.Threading.Tasks.Task<WebApplication.DealerServiceRef.Car[]> getDealerCarsAsync(string dealerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/addDealerCar", ReplyAction="http://tempuri.org/IDealerService/addDealerCarResponse")]
        void addDealerCar(string dealerId, WebApplication.DealerServiceRef.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/addDealerCar", ReplyAction="http://tempuri.org/IDealerService/addDealerCarResponse")]
        System.Threading.Tasks.Task addDealerCarAsync(string dealerId, WebApplication.DealerServiceRef.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/deleteDealerCar", ReplyAction="http://tempuri.org/IDealerService/deleteDealerCarResponse")]
        void deleteDealerCar(string dealerId, string carId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDealerService/deleteDealerCar", ReplyAction="http://tempuri.org/IDealerService/deleteDealerCarResponse")]
        System.Threading.Tasks.Task deleteDealerCarAsync(string dealerId, string carId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDealerServiceChannel : WebApplication.DealerServiceRef.IDealerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DealerServiceClient : System.ServiceModel.ClientBase<WebApplication.DealerServiceRef.IDealerService>, WebApplication.DealerServiceRef.IDealerService {
        
        public DealerServiceClient() {
        }
        
        public DealerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DealerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DealerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DealerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplication.DealerServiceRef.Dealer[] getAllDealers() {
            return base.Channel.getAllDealers();
        }
        
        public System.Threading.Tasks.Task<WebApplication.DealerServiceRef.Dealer[]> getAllDealersAsync() {
            return base.Channel.getAllDealersAsync();
        }
        
        public WebApplication.DealerServiceRef.Dealer getDealer(string dealerId) {
            return base.Channel.getDealer(dealerId);
        }
        
        public System.Threading.Tasks.Task<WebApplication.DealerServiceRef.Dealer> getDealerAsync(string dealerId) {
            return base.Channel.getDealerAsync(dealerId);
        }
        
        public void addDealer(WebApplication.DealerServiceRef.Dealer dealer) {
            base.Channel.addDealer(dealer);
        }
        
        public System.Threading.Tasks.Task addDealerAsync(WebApplication.DealerServiceRef.Dealer dealer) {
            return base.Channel.addDealerAsync(dealer);
        }
        
        public void updateDealer(WebApplication.DealerServiceRef.Dealer updatedDealer) {
            base.Channel.updateDealer(updatedDealer);
        }
        
        public System.Threading.Tasks.Task updateDealerAsync(WebApplication.DealerServiceRef.Dealer updatedDealer) {
            return base.Channel.updateDealerAsync(updatedDealer);
        }
        
        public void deleteDealer(string dealerId) {
            base.Channel.deleteDealer(dealerId);
        }
        
        public System.Threading.Tasks.Task deleteDealerAsync(string dealerId) {
            return base.Channel.deleteDealerAsync(dealerId);
        }
        
        public WebApplication.DealerServiceRef.Car[] getDealerCars(string dealerId) {
            return base.Channel.getDealerCars(dealerId);
        }
        
        public System.Threading.Tasks.Task<WebApplication.DealerServiceRef.Car[]> getDealerCarsAsync(string dealerId) {
            return base.Channel.getDealerCarsAsync(dealerId);
        }
        
        public void addDealerCar(string dealerId, WebApplication.DealerServiceRef.Car car) {
            base.Channel.addDealerCar(dealerId, car);
        }
        
        public System.Threading.Tasks.Task addDealerCarAsync(string dealerId, WebApplication.DealerServiceRef.Car car) {
            return base.Channel.addDealerCarAsync(dealerId, car);
        }
        
        public void deleteDealerCar(string dealerId, string carId) {
            base.Channel.deleteDealerCar(dealerId, carId);
        }
        
        public System.Threading.Tasks.Task deleteDealerCarAsync(string dealerId, string carId) {
            return base.Channel.deleteDealerCarAsync(dealerId, carId);
        }
    }
}
