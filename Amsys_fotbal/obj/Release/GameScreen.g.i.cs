﻿#pragma checksum "..\..\GameScreen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F4D9AAFC5FF46B7899CABE470895818AA3DF3D9FD856AFD0D8AFD3586887865"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Amsys_fotbal;
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


namespace Amsys_fotbal {
    
    
    /// <summary>
    /// GameScreen
    /// </summary>
    public partial class GameScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelCurrent;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelNext;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextInput;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonGiveUp;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonHelp;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonInput;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPreviousWord;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPreviousLetter;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPreviousTwoLetter;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\GameScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelPreviousSyllable;
        
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
            System.Uri resourceLocater = new System.Uri("/Amsys_fotbal;component/gamescreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\GameScreen.xaml"
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
            this.LabelCurrent = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.LabelNext = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.TextInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ButtonGiveUp = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\GameScreen.xaml"
            this.ButtonGiveUp.Click += new System.Windows.RoutedEventHandler(this.ButtonGiveUp_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonHelp = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\GameScreen.xaml"
            this.ButtonHelp.Click += new System.Windows.RoutedEventHandler(this.ButtonHelp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonInput = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\GameScreen.xaml"
            this.ButtonInput.Click += new System.Windows.RoutedEventHandler(this.ButtonInput_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LabelPreviousWord = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.LabelPreviousLetter = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.LabelPreviousTwoLetter = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.LabelPreviousSyllable = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

