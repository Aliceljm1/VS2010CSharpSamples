﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 4.0.20831.0
//
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

#pragma warning disable 414
namespace DataAnalysisExcel {
    
    
    /// 
    [Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(1)]
    [global::System.Security.Permissions.PermissionSetAttribute(global::System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class Sheet1 : Microsoft.Office.Tools.Excel.Worksheet {
        
        internal Microsoft.Office.Tools.Excel.ListObject DayInventory;
        
        internal Microsoft.Office.Tools.Excel.NamedRange TitleLabel;
        
        internal Microsoft.Office.Tools.Excel.NamedRange DateLabel;
        
        internal Microsoft.Office.Tools.Excel.NamedRange Sheet1_TitleLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        private global::System.Object missing = global::System.Type.Missing;
        
        internal Microsoft.Office.Tools.Excel.Controls.DateTimePicker DateSelector;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button newDateButton;
        
        internal Microsoft.Office.Tools.Excel.Controls.Button saveButton;
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Sheet1() : 
                base("Sheet1", "Sheet1") {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            Globals.Sheet1 = this;
            global::System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
            this.DayInventory.BeginInit();
            this.TitleLabel.BeginInit();
            this.DateLabel.BeginInit();
            this.Sheet1_TitleLabel.BeginInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.Sheet1_TitleLabel.EndInit();
            this.DateLabel.EndInit();
            this.TitleLabel.EndInit();
            this.DayInventory.EndInit();
            this.EndInit();
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeControls() {
            this.DayInventory = new Microsoft.Office.Tools.Excel.ListObject(this.ItemProvider, this.HostContext, "Sheet1:DayInventory", this, "DayInventory");
            this.TitleLabel = new Microsoft.Office.Tools.Excel.NamedRange(this.ItemProvider, this.HostContext, "TitleLabel", this, "TitleLabel");
            this.DateLabel = new Microsoft.Office.Tools.Excel.NamedRange(this.ItemProvider, this.HostContext, "DateLabel", this, "DateLabel");
            this.Sheet1_TitleLabel = new Microsoft.Office.Tools.Excel.NamedRange(this.ItemProvider, this.HostContext, "Sheet1!TitleLabel", this, "Sheet1_TitleLabel");
            this.DateSelector = new Microsoft.Office.Tools.Excel.Controls.DateTimePicker(this.ItemProvider, this.HostContext, "13F0570EE1C65B14D231B91D1FF48A03B3C881", "13F0570EE1C65B14D231B91D1FF48A03B3C881", this, "DateSelector");
            this.newDateButton = new Microsoft.Office.Tools.Excel.Controls.Button(this.ItemProvider, this.HostContext, "1D1E00CA416B0B1463D1B95B13A0D67E3EDD31", "1D1E00CA416B0B1463D1B95B13A0D67E3EDD31", this, "newDateButton");
            this.saveButton = new Microsoft.Office.Tools.Excel.Controls.Button(this.ItemProvider, this.HostContext, "1CFF0A45519D3714F7E1B951152AA2DB497CF1", "1CFF0A45519D3714F7E1B951152AA2DB497CF1", this, "saveButton");
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void InitializeComponents() {
            ((System.ComponentModel.ISupportInitialize)(this.DayInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sheet1_TitleLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // DateSelector
            // 
            this.DateSelector.Name = "DateSelector";
            // 
            // newDateButton
            // 
            this.newDateButton.Name = "newDateButton";
            this.newDateButton.Text = "Add New Date";
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Text = "Save Data";
            // 
            // Sheet1
            // 
            ((System.ComponentModel.ISupportInitialize)(this.DayInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sheet1_TitleLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.DateSelector.BindingContext = this.BindingContext;
            this.newDateButton.BindingContext = this.BindingContext;
            this.saveButton.BindingContext = this.BindingContext;
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
        
        /// 
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "10.0.0.0")]
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected override void OnShutdown() {
            this.Sheet1_TitleLabel.Dispose();
            this.DateLabel.Dispose();
            this.TitleLabel.Dispose();
            this.DayInventory.Dispose();
            base.OnShutdown();
        }
    }
    
    internal sealed partial class Globals {
        
        private static Sheet1 _Sheet1;
        
        internal static Sheet1 Sheet1 {
            get {
                return _Sheet1;
            }
            set {
                if ((_Sheet1 == null)) {
                    _Sheet1 = value;
                }
                else {
                    throw new System.NotSupportedException();
                }
            }
        }
    }
}
