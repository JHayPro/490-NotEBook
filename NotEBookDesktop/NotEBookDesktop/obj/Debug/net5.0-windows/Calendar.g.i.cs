﻿#pragma checksum "..\..\..\Calendar.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306B08194605AADB1FA94AFB10EAA0B81683D768"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NotEBookDesktop;
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


namespace NotEBookDesktop {
    
    
    /// <summary>
    /// Calendar
    /// </summary>
    public partial class Calendar : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Calendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar LeftCalendar;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Calendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EventDate;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Calendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView EventList;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Calendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Calendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EnterEventButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Calendar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveEventButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
<<<<<<< HEAD:NotEBookDesktop/NotEBookDesktop/obj/Debug/net5.0-windows/Calendar.g.i.cs
            System.Uri resourceLocater = new System.Uri("/NotEBookDesktop;V1.0.0.0;component/calendar.xaml", System.UriKind.Relative);
=======
            System.Uri resourceLocater = new System.Uri("/NotEBookDesktop;V1.0.0.0;component/login.xaml", System.UriKind.Relative);
>>>>>>> 998fd9c (desktop build):NotEBookDesktop/NotEBookDesktop/obj/Debug/net5.0-windows/Login.g.i.cs
            
            #line 1 "..\..\..\Calendar.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LeftCalendar = ((System.Windows.Controls.Calendar)(target));
            return;
            case 2:
            this.EventDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.EventList = ((System.Windows.Controls.ListView)(target));
            return;
            case 4:
            this.EventTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.EnterEventButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Calendar.xaml"
            this.EnterEventButton.Click += new System.Windows.RoutedEventHandler(this.EnterEvent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RemoveEventButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Calendar.xaml"
            this.RemoveEventButton.Click += new System.Windows.RoutedEventHandler(this.RemoveEvent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

