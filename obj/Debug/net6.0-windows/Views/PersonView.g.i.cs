﻿#pragma checksum "..\..\..\..\Views\PersonView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38C28C76B40EED5CDE7D00CBC6A06423DB365367"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ.Views;


namespace _CPE106_FOPI01_DE_GUZMAN_MOD1_QUIZ.Views {
    
    
    /// <summary>
    /// PersonView
    /// </summary>
    public partial class PersonView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Person;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LastName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextLastName;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label GivenName;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextGivenName;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MiddleName;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextMiddleName;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeletePerson;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label IDLabel;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\Views\PersonView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextID;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CPE106-FOPI01-DE GUZMAN-MOD3-QUIZ;component/views/personview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\PersonView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Person = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 36 "..\..\..\..\Views\PersonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddPerson_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LastName = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.TextLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.GivenName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.TextGivenName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.MiddleName = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TextMiddleName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 98 "..\..\..\..\Views\PersonView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditPerson_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.DeletePerson = ((System.Windows.Controls.Button)(target));
            
            #line 108 "..\..\..\..\Views\PersonView.xaml"
            this.DeletePerson.Click += new System.Windows.RoutedEventHandler(this.DeletePerson_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.IDLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.TextID = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

