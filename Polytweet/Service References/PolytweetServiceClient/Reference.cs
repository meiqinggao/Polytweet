﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.34014
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Polytweet.PolytweetServiceClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/PolytweetService")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long javaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string loginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long[] walledChannelsField;
        
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
        public long javaId {
            get {
                return this.javaIdField;
            }
            set {
                if ((this.javaIdField.Equals(value) != true)) {
                    this.javaIdField = value;
                    this.RaisePropertyChanged("javaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string login {
            get {
                return this.loginField;
            }
            set {
                if ((object.ReferenceEquals(this.loginField, value) != true)) {
                    this.loginField = value;
                    this.RaisePropertyChanged("login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long[] walledChannels {
            get {
                return this.walledChannelsField;
            }
            set {
                if ((object.ReferenceEquals(this.walledChannelsField, value) != true)) {
                    this.walledChannelsField = value;
                    this.RaisePropertyChanged("walledChannels");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Channel", Namespace="http://schemas.datacontract.org/2004/07/PolytweetService")]
    [System.SerializableAttribute()]
    public partial class Channel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Polytweet.PolytweetServiceClient.Message[] msgListField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string visibilityField;
        
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
        public Polytweet.PolytweetServiceClient.Message[] msgList {
            get {
                return this.msgListField;
            }
            set {
                if ((object.ReferenceEquals(this.msgListField, value) != true)) {
                    this.msgListField = value;
                    this.RaisePropertyChanged("msgList");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string visibility {
            get {
                return this.visibilityField;
            }
            set {
                if ((object.ReferenceEquals(this.visibilityField, value) != true)) {
                    this.visibilityField = value;
                    this.RaisePropertyChanged("visibility");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Message", Namespace="http://schemas.datacontract.org/2004/07/PolytweetService")]
    [System.SerializableAttribute()]
    public partial class Message : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string authorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long fileIdField;
        
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
        public string author {
            get {
                return this.authorField;
            }
            set {
                if ((object.ReferenceEquals(this.authorField, value) != true)) {
                    this.authorField = value;
                    this.RaisePropertyChanged("author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string content {
            get {
                return this.contentField;
            }
            set {
                if ((object.ReferenceEquals(this.contentField, value) != true)) {
                    this.contentField = value;
                    this.RaisePropertyChanged("content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string date {
            get {
                return this.dateField;
            }
            set {
                if ((object.ReferenceEquals(this.dateField, value) != true)) {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long fileId {
            get {
                return this.fileIdField;
            }
            set {
                if ((this.fileIdField.Equals(value) != true)) {
                    this.fileIdField = value;
                    this.RaisePropertyChanged("fileId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PolytweetServiceClient.IPolytweetService")]
    public interface IPolytweetService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/initTestContext", ReplyAction="http://tempuri.org/IPolytweetService/initTestContextResponse")]
        void initTestContext();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/initTestContext", ReplyAction="http://tempuri.org/IPolytweetService/initTestContextResponse")]
        System.Threading.Tasks.Task initTestContextAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/connect", ReplyAction="http://tempuri.org/IPolytweetService/connectResponse")]
        Polytweet.PolytweetServiceClient.User connect(string login, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/connect", ReplyAction="http://tempuri.org/IPolytweetService/connectResponse")]
        System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.User> connectAsync(string login, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/addWalledChannel", ReplyAction="http://tempuri.org/IPolytweetService/addWalledChannelResponse")]
        void addWalledChannel(int userID, int channelID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/addWalledChannel", ReplyAction="http://tempuri.org/IPolytweetService/addWalledChannelResponse")]
        System.Threading.Tasks.Task addWalledChannelAsync(int userID, int channelID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/removeWalledChannel", ReplyAction="http://tempuri.org/IPolytweetService/removeWalledChannelResponse")]
        void removeWalledChannel(int userID, int channelID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/removeWalledChannel", ReplyAction="http://tempuri.org/IPolytweetService/removeWalledChannelResponse")]
        System.Threading.Tasks.Task removeWalledChannelAsync(int userID, int channelID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/getAllChannel", ReplyAction="http://tempuri.org/IPolytweetService/getAllChannelResponse")]
        Polytweet.PolytweetServiceClient.Channel[] getAllChannel();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/getAllChannel", ReplyAction="http://tempuri.org/IPolytweetService/getAllChannelResponse")]
        System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel[]> getAllChannelAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/findChannel", ReplyAction="http://tempuri.org/IPolytweetService/findChannelResponse")]
        Polytweet.PolytweetServiceClient.Channel findChannel(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/findChannel", ReplyAction="http://tempuri.org/IPolytweetService/findChannelResponse")]
        System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel> findChannelAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/getSubscribedChannels", ReplyAction="http://tempuri.org/IPolytweetService/getSubscribedChannelsResponse")]
        Polytweet.PolytweetServiceClient.Channel[] getSubscribedChannels(int uJavaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/getSubscribedChannels", ReplyAction="http://tempuri.org/IPolytweetService/getSubscribedChannelsResponse")]
        System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel[]> getSubscribedChannelsAsync(int uJavaID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/createChannel", ReplyAction="http://tempuri.org/IPolytweetService/createChannelResponse")]
        Polytweet.PolytweetServiceClient.Channel createChannel(int uJavaID, string cName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/createChannel", ReplyAction="http://tempuri.org/IPolytweetService/createChannelResponse")]
        System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel> createChannelAsync(int uJavaID, string cName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/publishMessage", ReplyAction="http://tempuri.org/IPolytweetService/publishMessageResponse")]
        void publishMessage(int uJavaID, string cname, string content, int fileID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/publishMessage", ReplyAction="http://tempuri.org/IPolytweetService/publishMessageResponse")]
        System.Threading.Tasks.Task publishMessageAsync(int uJavaID, string cname, string content, int fileID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/subscribeTo", ReplyAction="http://tempuri.org/IPolytweetService/subscribeToResponse")]
        void subscribeTo(int uJavaID, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPolytweetService/subscribeTo", ReplyAction="http://tempuri.org/IPolytweetService/subscribeToResponse")]
        System.Threading.Tasks.Task subscribeToAsync(int uJavaID, string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPolytweetServiceChannel : Polytweet.PolytweetServiceClient.IPolytweetService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PolytweetServiceClient : System.ServiceModel.ClientBase<Polytweet.PolytweetServiceClient.IPolytweetService>, Polytweet.PolytweetServiceClient.IPolytweetService {
        
        public PolytweetServiceClient() {
        }
        
        public PolytweetServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PolytweetServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolytweetServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PolytweetServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void initTestContext() {
            base.Channel.initTestContext();
        }
        
        public System.Threading.Tasks.Task initTestContextAsync() {
            return base.Channel.initTestContextAsync();
        }
        
        public Polytweet.PolytweetServiceClient.User connect(string login, string pwd) {
            return base.Channel.connect(login, pwd);
        }
        
        public System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.User> connectAsync(string login, string pwd) {
            return base.Channel.connectAsync(login, pwd);
        }
        
        public void addWalledChannel(int userID, int channelID) {
            base.Channel.addWalledChannel(userID, channelID);
        }
        
        public System.Threading.Tasks.Task addWalledChannelAsync(int userID, int channelID) {
            return base.Channel.addWalledChannelAsync(userID, channelID);
        }
        
        public void removeWalledChannel(int userID, int channelID) {
            base.Channel.removeWalledChannel(userID, channelID);
        }
        
        public System.Threading.Tasks.Task removeWalledChannelAsync(int userID, int channelID) {
            return base.Channel.removeWalledChannelAsync(userID, channelID);
        }
        
        public Polytweet.PolytweetServiceClient.Channel[] getAllChannel() {
            return base.Channel.getAllChannel();
        }
        
        public System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel[]> getAllChannelAsync() {
            return base.Channel.getAllChannelAsync();
        }
        
        public Polytweet.PolytweetServiceClient.Channel findChannel(string name) {
            return base.Channel.findChannel(name);
        }
        
        public System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel> findChannelAsync(string name) {
            return base.Channel.findChannelAsync(name);
        }
        
        public Polytweet.PolytweetServiceClient.Channel[] getSubscribedChannels(int uJavaID) {
            return base.Channel.getSubscribedChannels(uJavaID);
        }
        
        public System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel[]> getSubscribedChannelsAsync(int uJavaID) {
            return base.Channel.getSubscribedChannelsAsync(uJavaID);
        }
        
        public Polytweet.PolytweetServiceClient.Channel createChannel(int uJavaID, string cName) {
            return base.Channel.createChannel(uJavaID, cName);
        }
        
        public System.Threading.Tasks.Task<Polytweet.PolytweetServiceClient.Channel> createChannelAsync(int uJavaID, string cName) {
            return base.Channel.createChannelAsync(uJavaID, cName);
        }
        
        public void publishMessage(int uJavaID, string cname, string content, int fileID) {
            base.Channel.publishMessage(uJavaID, cname, content, fileID);
        }
        
        public System.Threading.Tasks.Task publishMessageAsync(int uJavaID, string cname, string content, int fileID) {
            return base.Channel.publishMessageAsync(uJavaID, cname, content, fileID);
        }
        
        public void subscribeTo(int uJavaID, string name) {
            base.Channel.subscribeTo(uJavaID, name);
        }
        
        public System.Threading.Tasks.Task subscribeToAsync(int uJavaID, string name) {
            return base.Channel.subscribeToAsync(uJavaID, name);
        }
    }
}
