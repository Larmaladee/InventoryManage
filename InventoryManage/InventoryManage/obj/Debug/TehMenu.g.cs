﻿#pragma checksum "..\..\TehMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C16CB473495420D5F0B1C6E8A10C41958774DF71BFB984EAFD5B5EBC63083258"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using InventoryManage;
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


namespace InventoryManage {
    
    
    /// <summary>
    /// TehMenu
    /// </summary>
    public partial class TehMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\TehMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\TehMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Applications;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\TehMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox status;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\TehMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox classes;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\TehMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox statusChange;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\TehMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button change;
        
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
            System.Uri resourceLocater = new System.Uri("/InventoryManage;component/tehmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TehMenu.xaml"
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
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\TehMenu.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Applications = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\TehMenu.xaml"
            this.Applications.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Applications_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.status = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\TehMenu.xaml"
            this.status.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.status_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.classes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\TehMenu.xaml"
            this.classes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.class_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.statusChange = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.change = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\TehMenu.xaml"
            this.change.Click += new System.Windows.RoutedEventHandler(this.change_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

