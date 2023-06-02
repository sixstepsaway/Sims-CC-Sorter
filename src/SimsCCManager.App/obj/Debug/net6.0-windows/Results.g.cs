﻿#pragma checksum "..\..\..\Results.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5155513C6DD9454A63F188BF79251D94CEA2B074"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SimsCCManager.SortingUIResults;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace SimsCCManager.SortingUIResults {
    
    
    /// <summary>
    /// ResultsWindow
    /// </summary>
    public partial class ResultsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 73 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel MenuBar;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ResultsView;
        
        #line default
        #line hidden
        
        
        #line 196 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButton_Sims2;
        
        #line default
        #line hidden
        
        
        #line 203 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButton_Sims3;
        
        #line default
        #line hidden
        
        
        #line 212 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButton_Sims4;
        
        #line default
        #line hidden
        
        
        #line 219 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton radioButton_None;
        
        #line default
        #line hidden
        
        
        #line 226 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowAllBt;
        
        #line default
        #line hidden
        
        
        #line 231 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBox;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxSearch;
        
        #line default
        #line hidden
        
        
        #line 241 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TagsList;
        
        #line default
        #line hidden
        
        
        #line 242 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ProgressBorder;
        
        #line default
        #line hidden
        
        
        #line 243 "..\..\..\Results.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView TagsListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SimsCCManager.App;component/results.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Results.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MenuBar = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            
            #line 74 "..\..\..\Results.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.menu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 77 "..\..\..\Results.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Kofi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResultsView = ((System.Windows.Controls.ListView)(target));
            
            #line 81 "..\..\..\Results.xaml"
            this.ResultsView.AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.ListViewHeader_Click));
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 131 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 136 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 141 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 146 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 151 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 156 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 161 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 166 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 171 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 176 "..\..\..\Results.xaml"
            ((System.Windows.Controls.GridViewColumnHeader)(target)).Click += new System.Windows.RoutedEventHandler(this.ListViewHeader_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.radioButton_Sims2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 196 "..\..\..\Results.xaml"
            this.radioButton_Sims2.Checked += new System.Windows.RoutedEventHandler(this.GameCheck);
            
            #line default
            #line hidden
            return;
            case 16:
            this.radioButton_Sims3 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 203 "..\..\..\Results.xaml"
            this.radioButton_Sims3.Checked += new System.Windows.RoutedEventHandler(this.GameCheck);
            
            #line default
            #line hidden
            return;
            case 17:
            this.radioButton_Sims4 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 212 "..\..\..\Results.xaml"
            this.radioButton_Sims4.Checked += new System.Windows.RoutedEventHandler(this.GameCheck);
            
            #line default
            #line hidden
            return;
            case 18:
            this.radioButton_None = ((System.Windows.Controls.RadioButton)(target));
            
            #line 219 "..\..\..\Results.xaml"
            this.radioButton_None.Checked += new System.Windows.RoutedEventHandler(this.GameCheck);
            
            #line default
            #line hidden
            return;
            case 19:
            this.ShowAllBt = ((System.Windows.Controls.Button)(target));
            
            #line 226 "..\..\..\Results.xaml"
            this.ShowAllBt.Click += new System.Windows.RoutedEventHandler(this.showallfiles_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 227 "..\..\..\Results.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.loadErrorFix_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.SearchBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 231 "..\..\..\Results.xaml"
            this.SearchBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 22:
            this.ComboBoxSearch = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 23:
            this.TagsList = ((System.Windows.Controls.Grid)(target));
            return;
            case 24:
            this.ProgressBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 25:
            this.TagsListBox = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

