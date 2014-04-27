﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp.MovieSearcher {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieSearcher.SearcherSoap")]
    public interface SearcherSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getMovieByID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebApp.MovieSearcher.Movie getMovieByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getMovieByID", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.MovieSearcher.Movie> getMovieByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAllMovies", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebApp.MovieSearcher.Movie[] getAllMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getAllMovies", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.MovieSearcher.Movie[]> getAllMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getMoviesByTitle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebApp.MovieSearcher.Movie[] getMoviesByTitle(string title);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getMoviesByTitle", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApp.MovieSearcher.Movie[]> getMoviesByTitleAsync(string title);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Movie : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string titleField;
        
        private string genreField;
        
        private int yearPublishedField;
        
        private string ageRatingField;
        
        private string directorNameField;
        
        private string[] actorsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("Id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
                this.RaisePropertyChanged("Title");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Genre {
            get {
                return this.genreField;
            }
            set {
                this.genreField = value;
                this.RaisePropertyChanged("Genre");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int YearPublished {
            get {
                return this.yearPublishedField;
            }
            set {
                this.yearPublishedField = value;
                this.RaisePropertyChanged("YearPublished");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string AgeRating {
            get {
                return this.ageRatingField;
            }
            set {
                this.ageRatingField = value;
                this.RaisePropertyChanged("AgeRating");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string DirectorName {
            get {
                return this.directorNameField;
            }
            set {
                this.directorNameField = value;
                this.RaisePropertyChanged("DirectorName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
        public string[] Actors {
            get {
                return this.actorsField;
            }
            set {
                this.actorsField = value;
                this.RaisePropertyChanged("Actors");
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
    public interface SearcherSoapChannel : WebApp.MovieSearcher.SearcherSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SearcherSoapClient : System.ServiceModel.ClientBase<WebApp.MovieSearcher.SearcherSoap>, WebApp.MovieSearcher.SearcherSoap {
        
        public SearcherSoapClient() {
        }
        
        public SearcherSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SearcherSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearcherSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearcherSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApp.MovieSearcher.Movie getMovieByID(int id) {
            return base.Channel.getMovieByID(id);
        }
        
        public System.Threading.Tasks.Task<WebApp.MovieSearcher.Movie> getMovieByIDAsync(int id) {
            return base.Channel.getMovieByIDAsync(id);
        }
        
        public WebApp.MovieSearcher.Movie[] getAllMovies() {
            return base.Channel.getAllMovies();
        }
        
        public System.Threading.Tasks.Task<WebApp.MovieSearcher.Movie[]> getAllMoviesAsync() {
            return base.Channel.getAllMoviesAsync();
        }
        
        public WebApp.MovieSearcher.Movie[] getMoviesByTitle(string title) {
            return base.Channel.getMoviesByTitle(title);
        }
        
        public System.Threading.Tasks.Task<WebApp.MovieSearcher.Movie[]> getMoviesByTitleAsync(string title) {
            return base.Channel.getMoviesByTitleAsync(title);
        }
    }
}
