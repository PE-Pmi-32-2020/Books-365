﻿#pragma checksum "..\..\..\..\PL\AddBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5BC3C2CFE15C5B73ED1CFD61D13F30D6D678EF37"
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
    /// AddBook
    /// </summary>
    public partial class AddBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\PL\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridOfWindow;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\PL\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TitleText;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\PL\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YearText;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\PL\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AuthorText;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\PL\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\..\..\PL\AddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddBook;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Books365;V1.0.0.0;component/pl/addbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PL\AddBook.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GridOfWindow = ((System.Windows.Controls.Grid)(target));
            
            #line 14 "..\..\..\..\PL\AddBook.xaml"
            this.GridOfWindow.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GridOfWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 30 "..\..\..\..\PL\AddBook.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Minimize);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 35 "..\..\..\..\PL\AddBook.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TitleText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.YearText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AuthorText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\..\..\PL\AddBook.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ButtonAddBook = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\..\..\PL\AddBook.xaml"
            this.ButtonAddBook.Click += new System.Windows.RoutedEventHandler(this.ButtonAddBook_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

