﻿#pragma checksum "..\..\..\..\PL\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C63E15AE1159F84CEFC073C7E1524D4BF8FD633F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Books365.PL;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace Books365.PL {
    
    
    /// <summary>
    /// Register
    /// </summary>
    public partial class Register : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 53 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecretPinTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Books365;component/pl/register.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PL\Register.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 27 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Minimize);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\PL\Register.xaml"
            this.EmailTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EmailTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 91 "..\..\..\..\PL\Register.xaml"
            this.FirstNameTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FirstNameTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 117 "..\..\..\..\PL\Register.xaml"
            this.LastNameTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LastNameTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 143 "..\..\..\..\PL\Register.xaml"
            this.PasswordTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PasswordTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ConfirmPasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 171 "..\..\..\..\PL\Register.xaml"
            this.ConfirmPasswordTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ConfirmPasswordTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SecretPinTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 200 "..\..\..\..\PL\Register.xaml"
            this.SecretPinTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SecretPinTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 214 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Login);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

