﻿#pragma checksum "..\..\PlayerSelection.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E4E1B98B5702E9D394749ADCC48A1D965B2E5B5A036F9B708699FDEB283D616F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using Amsys_fotbal;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
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
    /// PlayerSelection
    /// </summary>
    public partial class PlayerSelection : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\PlayerSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddPlayer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\PlayerSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonAddComputer;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\PlayerSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonRemovePlayer;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\PlayerSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFinished;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\PlayerSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListPlayers;
        
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
            System.Uri resourceLocater = new System.Uri("/Amsys_fotbal;component/playerselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PlayerSelection.xaml"
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
            this.ButtonAddPlayer = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\PlayerSelection.xaml"
            this.ButtonAddPlayer.Click += new System.Windows.RoutedEventHandler(this.ButtonAddPlayer_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonAddComputer = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\PlayerSelection.xaml"
            this.ButtonAddComputer.Click += new System.Windows.RoutedEventHandler(this.ButtonAddComputer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ButtonRemovePlayer = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\PlayerSelection.xaml"
            this.ButtonRemovePlayer.Click += new System.Windows.RoutedEventHandler(this.ButtonRemovePlayer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonFinished = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\PlayerSelection.xaml"
            this.ButtonFinished.Click += new System.Windows.RoutedEventHandler(this.ButtonFinished_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListPlayers = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

