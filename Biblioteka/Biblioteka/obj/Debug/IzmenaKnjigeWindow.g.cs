﻿#pragma checksum "..\..\IzmenaKnjigeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D64A4B0DAB6DB0E7D06EF65D26873A7C56064CFBD5B6D1B17D23C297DBA7E50D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Biblioteka;
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


namespace Biblioteka {
    
    
    /// <summary>
    /// IzmenaKnjigeWindow
    /// </summary>
    public partial class IzmenaKnjigeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\IzmenaKnjigeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sifraTextBox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\IzmenaKnjigeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox naslovKnjigeTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\IzmenaKnjigeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox autorTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\IzmenaKnjigeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox zanrTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\IzmenaKnjigeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox dostupnostCB;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\IzmenaKnjigeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox IkonicaTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Biblioteka;component/izmenaknjigewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\IzmenaKnjigeWindow.xaml"
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
            this.sifraTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.naslovKnjigeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.autorTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.zanrTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dostupnostCB = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            
            #line 50 "..\..\IzmenaKnjigeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OdabirIkonice_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.IkonicaTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 55 "..\..\IzmenaKnjigeWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SacuvajIzmene_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

