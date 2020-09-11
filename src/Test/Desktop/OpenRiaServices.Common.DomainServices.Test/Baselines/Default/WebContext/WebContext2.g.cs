//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RootNamespace
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// Context for the RIA application.
    /// </summary>
    /// <remarks>
    /// This context extends the base to make application services and types available
    /// for consumption from code and xaml.
    /// </remarks>
    public sealed partial class WebContext : WebContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the WebContext class.
        /// </summary>
        public WebContext()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the context that is registered as a lifetime object with the current application.
        /// </summary>
        /// <exception cref="System.InvalidOperationException"> is thrown if there is no current application,
        /// no contexts have been added, or more than one context has been added.
        /// </exception>
        /// <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
        public new static WebContext Current
        {
            get
            {
                return ((WebContext)(WebContextBase.Current));
            }
        }
    }
}
namespace RootNamespace.TestNamespace
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Threading.Tasks;
    using OpenRiaServices;
    using OpenRiaServices.Client;
    using OpenRiaServices.Client.ApplicationServices;
    
    
    /// <summary>
    /// The DomainContext corresponding to the 'AuthenticationService1' DomainService.
    /// </summary>
    public sealed partial class AuthenticationService1 : global::OpenRiaServices.Client.ApplicationServices.AuthenticationDomainContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService1"/> class.
        /// </summary>
        public AuthenticationService1() : 
                this(new Uri("RootNamespace-TestNamespace-AuthenticationService1.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService1"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The AuthenticationService1 service URI.</param>
        public AuthenticationService1(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IAuthenticationService1Contract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService1"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public AuthenticationService1(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="User1"/> entity instances that have been loaded into this <see cref="AuthenticationService1"/> instance.
        /// </summary>
        public EntitySet<User1> User1s
        {
            get
            {
                return base.EntityContainer.GetEntitySet<User1>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'GetUser' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        public EntityQuery<User1> GetUserQuery()
        {
            this.ValidateMethod("GetUserQuery", null);
            return base.CreateQuery<User1>("GetUser", null, false, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'Login' query.
        /// </summary>
        /// <param name="userName">The value for the 'userName' parameter of the query.</param>
        /// <param name="password">The value for the 'password' parameter of the query.</param>
        /// <param name="isPersistent">The value for the 'isPersistent' parameter of the query.</param>
        /// <param name="customData">The value for the 'customData' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        public EntityQuery<User1> LoginQuery(string userName, string password, bool isPersistent, string customData)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("userName", userName);
            parameters.Add("password", password);
            parameters.Add("isPersistent", isPersistent);
            parameters.Add("customData", customData);
            this.ValidateMethod("LoginQuery", parameters);
            return base.CreateQuery<User1>("Login", parameters, true, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User1"/> entity instances using the 'Logout' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User1"/> entity instances.</returns>
        public EntityQuery<User1> LogoutQuery()
        {
            this.ValidateMethod("LogoutQuery", null);
            return base.CreateQuery<User1>("Logout", null, true, false);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new AuthenticationService1EntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'AuthenticationService1' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IAuthenticationService1Contract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetUser' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService1/GetUser", ReplyAction="http://tempuri.org/AuthenticationService1/GetUserResponse")]
            IAsyncResult BeginGetUser(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetUser'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetUser'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetUser' operation.</returns>
            QueryResult<User1> EndGetUser(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Login' operation.
            /// </summary>
            /// <param name="userName">The value for the 'userName' parameter of this action.</param>
            /// <param name="password">The value for the 'password' parameter of this action.</param>
            /// <param name="isPersistent">The value for the 'isPersistent' parameter of this action.</param>
            /// <param name="customData">The value for the 'customData' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService1/Login", ReplyAction="http://tempuri.org/AuthenticationService1/LoginResponse")]
            IAsyncResult BeginLogin(string userName, string password, bool isPersistent, string customData, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginLogin'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginLogin'.</param>
            /// <returns>The 'QueryResult' returned from the 'Login' operation.</returns>
            QueryResult<User1> EndLogin(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Logout' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService1/Logout", ReplyAction="http://tempuri.org/AuthenticationService1/LogoutResponse")]
            IAsyncResult BeginLogout(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginLogout'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginLogout'.</param>
            /// <returns>The 'QueryResult' returned from the 'Logout' operation.</returns>
            QueryResult<User1> EndLogout(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService1/SubmitChanges", ReplyAction="http://tempuri.org/AuthenticationService1/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class AuthenticationService1EntityContainer : EntityContainer
        {
            
            public AuthenticationService1EntityContainer()
            {
                this.CreateEntitySet<User1>(EntitySetOperations.Edit);
            }
        }
    }
    
    /// <summary>
    /// The DomainContext corresponding to the 'AuthenticationService2' DomainService.
    /// </summary>
    public sealed partial class AuthenticationService2 : global::OpenRiaServices.Client.ApplicationServices.AuthenticationDomainContextBase
    {
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService2"/> class.
        /// </summary>
        public AuthenticationService2() : 
                this(new Uri("RootNamespace-TestNamespace-AuthenticationService2.svc", UriKind.Relative))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService2"/> class with the specified service URI.
        /// </summary>
        /// <param name="serviceUri">The AuthenticationService2 service URI.</param>
        public AuthenticationService2(Uri serviceUri) : 
                this(DomainContext.CreateDomainClient(typeof(IAuthenticationService2Contract), serviceUri, false))
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationService2"/> class with the specified <paramref name="domainClient"/>.
        /// </summary>
        /// <param name="domainClient">The DomainClient instance to use for this DomainContext.</param>
        public AuthenticationService2(DomainClient domainClient) : 
                base(domainClient)
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets the set of <see cref="User2"/> entity instances that have been loaded into this <see cref="AuthenticationService2"/> instance.
        /// </summary>
        public EntitySet<User2> User2s
        {
            get
            {
                return base.EntityContainer.GetEntitySet<User2>();
            }
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User2"/> entity instances using the 'GetUser' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User2"/> entity instances.</returns>
        public EntityQuery<User2> GetUserQuery()
        {
            this.ValidateMethod("GetUserQuery", null);
            return base.CreateQuery<User2>("GetUser", null, false, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User2"/> entity instances using the 'Login' query.
        /// </summary>
        /// <param name="userName">The value for the 'userName' parameter of the query.</param>
        /// <param name="password">The value for the 'password' parameter of the query.</param>
        /// <param name="isPersistent">The value for the 'isPersistent' parameter of the query.</param>
        /// <param name="customData">The value for the 'customData' parameter of the query.</param>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User2"/> entity instances.</returns>
        public EntityQuery<User2> LoginQuery(string userName, string password, bool isPersistent, string customData)
        {
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("userName", userName);
            parameters.Add("password", password);
            parameters.Add("isPersistent", isPersistent);
            parameters.Add("customData", customData);
            this.ValidateMethod("LoginQuery", parameters);
            return base.CreateQuery<User2>("Login", parameters, true, false);
        }
        
        /// <summary>
        /// Gets an EntityQuery instance that can be used to load <see cref="User2"/> entity instances using the 'Logout' query.
        /// </summary>
        /// <returns>An EntityQuery that can be loaded to retrieve <see cref="User2"/> entity instances.</returns>
        public EntityQuery<User2> LogoutQuery()
        {
            this.ValidateMethod("LogoutQuery", null);
            return base.CreateQuery<User2>("Logout", null, true, false);
        }
        
        /// <summary>
        /// Creates a new EntityContainer for this DomainContext's EntitySets.
        /// </summary>
        /// <returns>A new container instance.</returns>
        protected override EntityContainer CreateEntityContainer()
        {
            return new AuthenticationService2EntityContainer();
        }
        
        /// <summary>
        /// Service contract for the 'AuthenticationService2' DomainService.
        /// </summary>
        [ServiceContract()]
        public interface IAuthenticationService2Contract
        {
            
            /// <summary>
            /// Asynchronously invokes the 'GetUser' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(false)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService2/GetUser", ReplyAction="http://tempuri.org/AuthenticationService2/GetUserResponse")]
            IAsyncResult BeginGetUser(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginGetUser'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginGetUser'.</param>
            /// <returns>The 'QueryResult' returned from the 'GetUser' operation.</returns>
            QueryResult<User2> EndGetUser(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Login' operation.
            /// </summary>
            /// <param name="userName">The value for the 'userName' parameter of this action.</param>
            /// <param name="password">The value for the 'password' parameter of this action.</param>
            /// <param name="isPersistent">The value for the 'isPersistent' parameter of this action.</param>
            /// <param name="customData">The value for the 'customData' parameter of this action.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService2/Login", ReplyAction="http://tempuri.org/AuthenticationService2/LoginResponse")]
            IAsyncResult BeginLogin(string userName, string password, bool isPersistent, string customData, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginLogin'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginLogin'.</param>
            /// <returns>The 'QueryResult' returned from the 'Login' operation.</returns>
            QueryResult<User2> EndLogin(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'Logout' operation.
            /// </summary>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [HasSideEffects(true)]
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService2/Logout", ReplyAction="http://tempuri.org/AuthenticationService2/LogoutResponse")]
            IAsyncResult BeginLogout(AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginLogout'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginLogout'.</param>
            /// <returns>The 'QueryResult' returned from the 'Logout' operation.</returns>
            QueryResult<User2> EndLogout(IAsyncResult result);
            
            /// <summary>
            /// Asynchronously invokes the 'SubmitChanges' operation.
            /// </summary>
            /// <param name="changeSet">The change-set to submit.</param>
            /// <param name="callback">Callback to invoke on completion.</param>
            /// <param name="asyncState">Optional state object.</param>
            /// <returns>An IAsyncResult that can be used to monitor the request.</returns>
            [OperationContract(AsyncPattern=true, Action="http://tempuri.org/AuthenticationService2/SubmitChanges", ReplyAction="http://tempuri.org/AuthenticationService2/SubmitChangesResponse")]
            IAsyncResult BeginSubmitChanges(IEnumerable<ChangeSetEntry> changeSet, AsyncCallback callback, object asyncState);
            
            /// <summary>
            /// Completes the asynchronous operation begun by 'BeginSubmitChanges'.
            /// </summary>
            /// <param name="result">The IAsyncResult returned from 'BeginSubmitChanges'.</param>
            /// <returns>The collection of change-set entry elements returned from 'SubmitChanges'.</returns>
            IEnumerable<ChangeSetEntry> EndSubmitChanges(IAsyncResult result);
        }
        
        internal sealed class AuthenticationService2EntityContainer : EntityContainer
        {
            
            public AuthenticationService2EntityContainer()
            {
                this.CreateEntitySet<User2>(EntitySetOperations.Edit);
            }
        }
    }
    
    /// <summary>
    /// The 'User1' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/RootNamespace.TestNamespace")]
    public sealed partial class User1 : Entity, global::System.Security.Principal.IIdentity, global::System.Security.Principal.IPrincipal
    {
        
        private string _name = string.Empty;
        
        private IEnumerable<string> _roles;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnRolesChanging(IEnumerable<string> value);
        partial void OnRolesChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="User1"/> class.
        /// </summary>
        public User1()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Name' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnNameChanging(value);
                    this.ValidateProperty("Name", value);
                    this._name = value;
                    this.RaisePropertyChanged("Name");
                    this.OnNameChanged();
                    this.RaisePropertyChanged("IsAuthenticated");
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Roles' value.
        /// </summary>
        [DataMember()]
        [Editable(false)]
        public IEnumerable<string> Roles
        {
            get
            {
                return this._roles;
            }
            set
            {
                if ((this._roles != value))
                {
                    this.OnRolesChanging(value);
                    this.ValidateProperty("Roles", value);
                    this._roles = value;
                    this.RaisePropertyChanged("Roles");
                    this.OnRolesChanged();
                }
            }
        }
        
        string global::System.Security.Principal.IIdentity.AuthenticationType
        {
            get
            {
                return string.Empty;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the identity is authenticated.
        /// </summary>
        /// <remarks>
        /// This value is <c>true</c> if <see cref="Name"/> is not <c>null</c> or empty.
        /// </remarks>
        public bool IsAuthenticated
        {
            get
            {
                return (true != string.IsNullOrEmpty(this.Name));
            }
        }
        
        string global::System.Security.Principal.IIdentity.Name
        {
            get
            {
                return this.Name;
            }
        }
        
        global::System.Security.Principal.IIdentity global::System.Security.Principal.IPrincipal.Identity
        {
            get
            {
                return this;
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._name;
        }
        
        /// <summary>
        /// Return whether the principal is in the role.
        /// </summary>
        /// <remarks>
        /// Returns whether the specified role is contained in the roles.
        /// This implementation is case sensitive.
        /// </remarks>
        /// <param name="role">The name of the role for which to check membership.</param>
        /// <returns>Whether the principal is in the role.</returns>
        public bool IsInRole(string role)
        {
            if ((this.Roles == null))
            {
                return false;
            }
            return global::System.Linq.Enumerable.Contains(this.Roles, role);
        }
    }
    
    /// <summary>
    /// The 'User2' entity class.
    /// </summary>
    [DataContract(Namespace="http://schemas.datacontract.org/2004/07/RootNamespace.TestNamespace")]
    public sealed partial class User2 : Entity, global::System.Security.Principal.IIdentity, global::System.Security.Principal.IPrincipal
    {
        
        private string _name = string.Empty;
        
        private IEnumerable<string> _roles;
        
        #region Extensibility Method Definitions

        /// <summary>
        /// This method is invoked from the constructor once initialization is complete and
        /// can be used for further object setup.
        /// </summary>
        partial void OnCreated();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnRolesChanging(IEnumerable<string> value);
        partial void OnRolesChanged();

        #endregion
        
        
        /// <summary>
        /// Initializes a new instance of the <see cref="User2"/> class.
        /// </summary>
        public User2()
        {
            this.OnCreated();
        }
        
        /// <summary>
        /// Gets or sets the 'Name' value.
        /// </summary>
        [DataMember()]
        [Editable(false, AllowInitialValue=true)]
        [Key()]
        [RoundtripOriginal()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    this.OnNameChanging(value);
                    this.ValidateProperty("Name", value);
                    this._name = value;
                    this.RaisePropertyChanged("Name");
                    this.OnNameChanged();
                    this.RaisePropertyChanged("IsAuthenticated");
                }
            }
        }
        
        /// <summary>
        /// Gets or sets the 'Roles' value.
        /// </summary>
        [DataMember()]
        [Editable(false)]
        public IEnumerable<string> Roles
        {
            get
            {
                return this._roles;
            }
            set
            {
                if ((this._roles != value))
                {
                    this.OnRolesChanging(value);
                    this.ValidateProperty("Roles", value);
                    this._roles = value;
                    this.RaisePropertyChanged("Roles");
                    this.OnRolesChanged();
                }
            }
        }
        
        string global::System.Security.Principal.IIdentity.AuthenticationType
        {
            get
            {
                return string.Empty;
            }
        }
        
        /// <summary>
        /// Gets a value indicating whether the identity is authenticated.
        /// </summary>
        /// <remarks>
        /// This value is <c>true</c> if <see cref="Name"/> is not <c>null</c> or empty.
        /// </remarks>
        public bool IsAuthenticated
        {
            get
            {
                return (true != string.IsNullOrEmpty(this.Name));
            }
        }
        
        string global::System.Security.Principal.IIdentity.Name
        {
            get
            {
                return this.Name;
            }
        }
        
        global::System.Security.Principal.IIdentity global::System.Security.Principal.IPrincipal.Identity
        {
            get
            {
                return this;
            }
        }
        
        /// <summary>
        /// Computes a value from the key fields that uniquely identifies this entity instance.
        /// </summary>
        /// <returns>An object instance that uniquely identifies this entity instance.</returns>
        public override object GetIdentity()
        {
            return this._name;
        }
        
        /// <summary>
        /// Return whether the principal is in the role.
        /// </summary>
        /// <remarks>
        /// Returns whether the specified role is contained in the roles.
        /// This implementation is case sensitive.
        /// </remarks>
        /// <param name="role">The name of the role for which to check membership.</param>
        /// <returns>Whether the principal is in the role.</returns>
        public bool IsInRole(string role)
        {
            if ((this.Roles == null))
            {
                return false;
            }
            return global::System.Linq.Enumerable.Contains(this.Roles, role);
        }
    }
}
