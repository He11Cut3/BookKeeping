﻿#pragma checksum "..\..\..\Edit_Del\Edit_Del_Order.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FFEBF068B7AC76D91DF5B475EE58F224BAD78D890708F0FC5B92CAACD42492C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookKeeping.Edit_Del;
using FontAwesome.Sharp;
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


namespace BookKeeping.Edit_Del {
    
    
    /// <summary>
    /// Edit_Del_Order
    /// </summary>
    public partial class Edit_Del_Order : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox P_Article;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox P_Date;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox P_Stock;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox P_Total;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit_Order;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Del_Order;
        
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
            System.Uri resourceLocater = new System.Uri("/BookKeeping;component/edit_del/edit_del_order.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
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
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.P_Article = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.P_Date = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.P_Stock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.P_Total = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Edit_Order = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
            this.Edit_Order.Click += new System.Windows.RoutedEventHandler(this.Edit_Order_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Del_Order = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\Edit_Del\Edit_Del_Order.xaml"
            this.Del_Order.Click += new System.Windows.RoutedEventHandler(this.Del_Order_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

