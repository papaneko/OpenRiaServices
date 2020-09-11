'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Compare Binary
Option Infer On
Option Strict On
Option Explicit On



''' <summary>
''' Context for the RIA application.
''' </summary>
''' <remarks>
''' This context extends the base to make application services and types available
''' for consumption from code and xaml.
''' </remarks>
Partial Public NotInheritable Class WebContext
    Inherits Global.OpenRiaServices.Client.ApplicationServices.WebContextBase
    
    #Region "Extensibility Method Definitions"

    ''' <summary>
    ''' This method is invoked from the constructor once initialization is complete and
    ''' can be used for further object setup.
    ''' </summary>
    Private Partial Sub OnCreated()
    End Sub

    #End Region
    
    
    ''' <summary>
    ''' Initializes a new instance of the WebContext class.
    ''' </summary>
    Public Sub New()
        MyBase.New
        Me.OnCreated
    End Sub
    
    ''' <summary>
    ''' Gets the context that is registered as a lifetime object with the current application.
    ''' </summary>
    ''' <exception cref="System.InvalidOperationException"> is thrown if there is no current application,
    ''' no contexts have been added, or more than one context has been added.
    ''' </exception>
    ''' <seealso cref="System.Windows.Application.ApplicationLifetimeObjects"/>
    Public Shadows Shared ReadOnly Property Current() As Global.RootNamespace.WebContext
        Get
            Return CType(Global.OpenRiaServices.Client.ApplicationServices.WebContextBase.Current,Global.RootNamespace.WebContext)
        End Get
    End Property
End Class
