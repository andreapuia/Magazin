﻿#pragma checksum "..\..\..\Views\AddClient.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D297C4D43BB246C629591821194207CD111E45D40A1EA92F76C98A360DD56919"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CursMagazin.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CursMagazin.Views {
    
    
    /// <summary>
    /// AddClient
    /// </summary>
    public partial class AddClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAge;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAddress;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCNP;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvCLients;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\AddClient.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtId;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CursMagazin;component/views/addclient.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\AddClient.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtAge = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCNP = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 21 "..\..\..\Views\AddClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lvCLients = ((System.Windows.Controls.ListView)(target));
            
            #line 22 "..\..\..\Views\AddClient.xaml"
            this.lvCLients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.LvCLients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 36 "..\..\..\Views\AddClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 37 "..\..\..\Views\AddClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 38 "..\..\..\Views\AddClient.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
