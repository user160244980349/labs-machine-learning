﻿#pragma checksum "..\..\..\Views\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6779E19FC03B6D1E2276AD13F7B722068BDE11F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OxyPlot.Wpf;
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


namespace ML1.Views {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox X;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Y;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Epoches;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Speed;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LearnNoise;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Six;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Seven;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Zhe;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Sche;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Views\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TestNoise;
        
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
            System.Uri resourceLocater = new System.Uri("/ML1;component/views/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\MainWindow.xaml"
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
            
            #line 9 "..\..\..\Views\MainWindow.xaml"
            ((ML1.Views.MainWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.X = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Views\MainWindow.xaml"
            this.X.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.X_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Y = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Views\MainWindow.xaml"
            this.Y.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Y_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Epoches = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Views\MainWindow.xaml"
            this.Epoches.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Epoches_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Speed = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\Views\MainWindow.xaml"
            this.Speed.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Speed_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LearnNoise = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\Views\MainWindow.xaml"
            this.LearnNoise.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.LearnNoise_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 44 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LearnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Six = ((System.Windows.Controls.RadioButton)(target));
            
            #line 66 "..\..\..\Views\MainWindow.xaml"
            this.Six.Checked += new System.Windows.RoutedEventHandler(this.Six_Checked);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Seven = ((System.Windows.Controls.RadioButton)(target));
            
            #line 69 "..\..\..\Views\MainWindow.xaml"
            this.Seven.Checked += new System.Windows.RoutedEventHandler(this.Seven_Checked);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Zhe = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\..\Views\MainWindow.xaml"
            this.Zhe.Checked += new System.Windows.RoutedEventHandler(this.Zhe_Checked);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Sche = ((System.Windows.Controls.RadioButton)(target));
            
            #line 77 "..\..\..\Views\MainWindow.xaml"
            this.Sche.Checked += new System.Windows.RoutedEventHandler(this.Sche_Checked);
            
            #line default
            #line hidden
            return;
            case 12:
            this.TestNoise = ((System.Windows.Controls.TextBox)(target));
            
            #line 83 "..\..\..\Views\MainWindow.xaml"
            this.TestNoise.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TestNoise_TextChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 84 "..\..\..\Views\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TestClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

