using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxy.#Create`2()", Justification = "API Design")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxy.#Create`2(OpenRiaServices.Server.DomainServiceContext)", Justification = "API Design")]
[assembly: SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxy.#Create`2(System.Web.HttpContextBase)", Justification = "API Design")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "OpenRiaServices.Hosting.Local", Justification = "This type may eventually merge into the OpenRiaServices.Server assembly. Using that namespace now avoids breaking changes.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1032:ImplementStandardExceptionConstructors", Scope = "type", Target = "OpenRiaServices.Hosting.Local.OperationException", Justification = "API Design")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxyGenerator.#.cctor()", Justification = "Initialization order needs to be controlled.")]
[assembly: SuppressMessage("Microsoft.Portability", "CA1903:UseOnlyApiFromTargetedFramework", MessageId = "System.Web.Abstractions, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", Justification = "API Design")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxyHelper.#Invoke(System.Type,OpenRiaServices.Server.DomainServiceContext,System.Collections.Generic.IList`1<OpenRiaServices.Server.DomainService>,System.String,System.Object[])", Justification = "DomainService instance disposal is managed by the generated proxy.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxyHelper.#Query(System.Type,OpenRiaServices.Server.DomainServiceContext,System.Collections.Generic.IList`1<OpenRiaServices.Server.DomainService>,System.String,System.Object[])", Justification = "DomainService instance disposal is managed by the generated proxy.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "OpenRiaServices.Hosting.Local.DomainServiceProxyHelper.#Submit(System.Type,OpenRiaServices.Server.DomainServiceContext,System.Collections.Generic.IList`1<OpenRiaServices.Server.DomainService>,System.Collections.Generic.IDictionary`2<System.Object,System.Object>,System.Object,System.String,System.Object[],OpenRiaServices.Server.DomainOperation)", Justification = "DomainService instance disposal is managed by the generated proxy.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2240:ImplementISerializableCorrectly", Scope = "type", Target = "OpenRiaServices.Hosting.Local.OperationException", Justification = "GetObjectData cannot be overridden in SecurityTransparent code.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Assemblies are delay-signed.")]
