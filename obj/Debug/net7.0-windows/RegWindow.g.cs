﻿#pragma checksum "..\..\..\RegWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4829FE190D84A4754CF1C8B5E06A9F783D1E1E2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using DataBaseOnWPF;
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


namespace DataBaseOnWPF {
    
    
    /// <summary>
    /// RegWindow
    /// </summary>
    public partial class RegWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Login;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Password;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_RepeatPassword;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Name;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_LastName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\RegWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReg;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DataBaseOnWPF;component/regwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RegWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.textBox_Login = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\RegWindow.xaml"
            this.textBox_Login.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_Login_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBox_Password = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\RegWindow.xaml"
            this.textBox_Password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_Password_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBox_RepeatPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\RegWindow.xaml"
            this.textBox_RepeatPassword.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_RepeatPassword_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBox_Name = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\RegWindow.xaml"
            this.textBox_Name.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_Name_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBox_LastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\RegWindow.xaml"
            this.textBox_LastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBox_LastName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnReg = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\RegWindow.xaml"
            this.btnReg.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
