﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenRiaServices.Server.Authentication.AspNetMembership {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("OpenRiaServices.Server.Authentication.AspNetMembership.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user returned from {0}.CreateUser() cannot be null..
        /// </summary>
        internal static string ApplicationServices_CreateUserCannotBeNull {
            get {
                return ResourceManager.GetString("ApplicationServices_CreateUserCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user returned from {0}.GetUser(IIdentity) or {0}.GetAnonymousUser() cannot be null..
        /// </summary>
        internal static string ApplicationServices_GetUserCannotBeNull {
            get {
                return ResourceManager.GetString("ApplicationServices_GetUserCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login and Logout can only be invoked for Forms authentication..
        /// </summary>
        internal static string ApplicationServices_LoginLogoutOnlyForForms {
            get {
                return ResourceManager.GetString("ApplicationServices_LoginLogoutOnlyForForms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A profile property does not exist for {0}..
        /// </summary>
        internal static string ApplicationServices_ProfilePropertyDoesNotExist {
            get {
                return ResourceManager.GetString("ApplicationServices_ProfilePropertyDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The profile property is ReadOnly for {0}..
        /// </summary>
        internal static string ApplicationServices_ProfilePropertyReadOnly {
            get {
                return ResourceManager.GetString("ApplicationServices_ProfilePropertyReadOnly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The profile property type of {0} is different from the property type..
        /// </summary>
        internal static string ApplicationServices_ProfilePropertyTypeMismatch {
            get {
                return ResourceManager.GetString("ApplicationServices_ProfilePropertyTypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a failure using the default &apos;{0}Provider&apos;. Please make sure it is configured correctly. {1}.
        /// </summary>
        internal static string ApplicationServices_ProviderError {
            get {
                return ResourceManager.GetString("ApplicationServices_ProviderError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user cannot be updated. Users are only allowed to modify their own profile..
        /// </summary>
        internal static string ApplicationServices_UnauthorizedUpdate {
            get {
                return ResourceManager.GetString("ApplicationServices_UnauthorizedUpdate", resourceCulture);
            }
        }
    }
}
