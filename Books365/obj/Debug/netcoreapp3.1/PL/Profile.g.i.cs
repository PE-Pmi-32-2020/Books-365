﻿#pragma checksum "..\..\..\..\PL\Profile.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AB877C9F2E5B7A4C263EA0169E6AD09D117BE838"
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
using OxyPlot.Wpf;
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
    /// Profile
    /// </summary>
    public partial class Profile : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\..\..\PL\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Username;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\PL\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Total;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\PL\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Booksfinished;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\PL\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock favouriteautor;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\PL\Profile.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.Plot myPlot;
        
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
            System.Uri resourceLocater = new System.Uri("/Books365;component/pl/profile.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PL\Profile.xaml"
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
            
            #line 27 "..\..\..\..\PL\Profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Minimize);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 32 "..\..\..\..\PL\Profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Exit);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Username = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Total = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Booksfinished = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.favouriteautor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 54 "..\..\..\..\PL\Profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit_Profile_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 55 "..\..\..\..\PL\Profile.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Main_Menu_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.myPlot = ((OxyPlot.Wpf.Plot)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

