﻿#pragma checksum "E:\WP8 Apps\Kanjoos\Kanjoos\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "14D6ABC7958C17A70C868F5B8674D2CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;
using Telerik.Windows.Controls;


namespace Kanjoos {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock tb_balance;
        
        internal System.Windows.Controls.TextBlock tb_expenditure;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_top_expenses;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_expenses;
        
        internal Telerik.Windows.Controls.RadPieChart pie_breakup;
        
        internal Microsoft.Phone.Controls.LongListSelector lls_breakup;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton apb_btn_addTrans;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Kanjoos;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.tb_balance = ((System.Windows.Controls.TextBlock)(this.FindName("tb_balance")));
            this.tb_expenditure = ((System.Windows.Controls.TextBlock)(this.FindName("tb_expenditure")));
            this.lls_top_expenses = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_top_expenses")));
            this.lls_expenses = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_expenses")));
            this.pie_breakup = ((Telerik.Windows.Controls.RadPieChart)(this.FindName("pie_breakup")));
            this.lls_breakup = ((Microsoft.Phone.Controls.LongListSelector)(this.FindName("lls_breakup")));
            this.apb_btn_addTrans = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("apb_btn_addTrans")));
        }
    }
}

