﻿#pragma checksum "..\..\..\..\PL\Register.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "662715FA2E5AAFB887AF23C1D4D028A5E2398E28"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
        
        
        #line 12 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridOfWindow;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EmailTextBox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ConfirmPasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\..\..\PL\Register.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SecretPinTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
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
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GridOfWindow = ((System.Windows.Controls.Grid)(target));
            
            #line 12 "..\..\..\..\PL\Register.xaml"
            this.GridOfWindow.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GridOfWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Minimize);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 33 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Return);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EmailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\..\PL\Register.xaml"
            this.EmailTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.EmailTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FirstNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 103 "..\..\..\..\PL\Register.xaml"
            this.FirstNameTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FirstNameTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LastNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 129 "..\..\..\..\PL\Register.xaml"
            this.LastNameTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.LastNameTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 155 "..\..\..\..\PL\Register.xaml"
            this.PasswordTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.PasswordTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ConfirmPasswordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 183 "..\..\..\..\PL\Register.xaml"
            this.ConfirmPasswordTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ConfirmPasswordTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SecretPinTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 212 "..\..\..\..\PL\Register.xaml"
            this.SecretPinTextBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.SecretPinTextBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 226 "..\..\..\..\PL\Register.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Login);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

