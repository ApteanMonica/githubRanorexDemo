﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace B_BUKA_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle_Fibu_Saldo_Fusszeile recording.
    /// </summary>
    [TestModule("fb236ab2-e279-4509-9176-fa0074714a78", ModuleType.Recording, 1)]
    public partial class Kontrolle_Fibu_Saldo_Fusszeile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUKA_003.B_BUKA_003Repository repository.
        /// </summary>
        public static global::B_BUKA_003.B_BUKA_003Repository repo = global::B_BUKA_003.B_BUKA_003Repository.Instance;

        static Kontrolle_Fibu_Saldo_Fusszeile instance = new Kontrolle_Fibu_Saldo_Fusszeile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle_Fibu_Saldo_Fusszeile()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle_Fibu_Saldo_Fusszeile Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'False' on item 'TblBuka.ToolBar.CbFibuSaldo'.", repo.TblBuka.ToolBar.CbFibuSaldoInfo, new RecordItemIndex(0));
            repo.TblBuka.ToolBar.CbFibuSaldo.Element.SetAttributeValue("Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.ToolBar.CbFibuSaldo' at Center.", repo.TblBuka.ToolBar.CbFibuSaldoInfo, new RecordItemIndex(1));
            repo.TblBuka.ToolBar.CbFibuSaldo.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'TblBuka.ToolBar.CbFibuSaldo'.", repo.TblBuka.ToolBar.CbFibuSaldoInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.CbFibuSaldoInfo, "Checked", "True");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='0,00') on item 'TblBuka.ColFibuSaldoRow1'.", repo.TblBuka.ColFibuSaldoRow1Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.TblBuka.ColFibuSaldoRow1Info, "Text", "0,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Fusszeilen
            try {
                Report.Log(ReportLevel.Info, "Section", "Fusszeilen", new RecordItemIndex(4));
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='Summe lt. Kassabuch (aktuell)') on item 'TblBuka.Fusszeile.ColTextRow0'.", repo.TblBuka.Fusszeile.ColTextRow0Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColTextRow0Info, "Text", "Summe lt. Kassabuch (aktuell)", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='10.250,00') on item 'TblBuka.Fusszeile.ColEingangRow0'.", repo.TblBuka.Fusszeile.ColEingangRow0Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColEingangRow0Info, "Text", "10.250,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='500,00') on item 'TblBuka.Fusszeile.ColAusgangRow0'.", repo.TblBuka.Fusszeile.ColAusgangRow0Info, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColAusgangRow0Info, "Text", "500,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='9.750,00') on item 'TblBuka.Fusszeile.ColSaldoLfdRow0'.", repo.TblBuka.Fusszeile.ColSaldoLfdRow0Info, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColSaldoLfdRow0Info, "Text", "9.750,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='Saldo per Monatsende (gespeichert)') on item 'TblBuka.Fusszeile.ColTextRow1'.", repo.TblBuka.Fusszeile.ColTextRow1Info, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColTextRow1Info, "Text", "Saldo per Monatsende (gespeichert)", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='9.750,00') on item 'TblBuka.Fusszeile.ColSaldoLfdRow1'.", repo.TblBuka.Fusszeile.ColSaldoLfdRow1Info, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColSaldoLfdRow1Info, "Text", "9.750,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='0,00') on item 'TblBuka.Fusszeile.ColFibuSaldoRow1'.", repo.TblBuka.Fusszeile.ColFibuSaldoRow1Info, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.TblBuka.Fusszeile.ColFibuSaldoRow1Info, "Text", "0,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            // Fibu-Saldo deaktivieren
            Report.Log(ReportLevel.Info, "Section", "Fibu-Saldo deaktivieren", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'TblBuka.ToolBar.CbFibuSaldo'.", repo.TblBuka.ToolBar.CbFibuSaldoInfo, new RecordItemIndex(13));
            repo.TblBuka.ToolBar.CbFibuSaldo.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuka.ToolBar.CbFibuSaldo' at Center.", repo.TblBuka.ToolBar.CbFibuSaldoInfo, new RecordItemIndex(14));
            repo.TblBuka.ToolBar.CbFibuSaldo.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'TblBuka.ToolBar.CbFibuSaldo'.", repo.TblBuka.ToolBar.CbFibuSaldoInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblBuka.ToolBar.CbFibuSaldoInfo, "Checked", "False");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
