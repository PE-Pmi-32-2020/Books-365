﻿#pragma checksum "..\..\..\..\PL\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B6E384C7C545AFF2AB0395E8C7A43F01D277B6B"
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
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridOfWindow;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse profile_picture_circle;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_textbox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock user_name_text_block;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add_book_button;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button simple_search_button;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button advanced_search_button;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button log_out_button;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button notifications_button;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\PL\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BooksGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Books365;component/pl/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PL\Window1.xaml"
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
            
            #line 13 "..\..\..\..\PL\Window1.xaml"
            this.GridOfWindow.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GridOfWindow_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.profile_picture_circle = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 3:
            this.search_textbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.user_name_text_block = ((System.Windows.Controls.TextBlock)(target));
            
            #line 33 "..\..\..\..\PL\Window1.xaml"
            this.user_name_text_block.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.User_name_text_block_MouseDown);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\PL\Window1.xaml"
            this.user_name_text_block.MouseEnter += new System.Windows.Input.MouseEventHandler(this.User_name_text_block_MouseEnter);
            
            #line default
            #line hidden
            
            #line 33 "..\..\..\..\PL\Window1.xaml"
            this.user_name_text_block.MouseLeave += new System.Windows.Input.MouseEventHandler(this.User_name_text_block_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 5:
            this.add_book_button = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\PL\Window1.xaml"
            this.add_book_button.Click += new System.Windows.RoutedEventHandler(this.Add_book_button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.simple_search_button = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\PL\Window1.xaml"
            this.simple_search_button.Click += new System.Windows.RoutedEventHandler(this.Simple_search_button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.advanced_search_button = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\PL\Window1.xaml"
            this.advanced_search_button.Click += new System.Windows.RoutedEventHandler(this.Advanced_search_button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.log_out_button = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\..\PL\Window1.xaml"
            this.log_out_button.Click += new System.Windows.RoutedEventHandler(this.Log_out_button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.notifications_button = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\PL\Window1.xaml"
            this.notifications_button.Click += new System.Windows.RoutedEventHandler(this.Notifications_button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BooksGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

