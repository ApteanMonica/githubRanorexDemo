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

namespace B_EXOPV_005.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_EXOPS_Status_von_F_auf_N_zuruecksetzen recording.
    /// </summary>
    [TestModule("0829892c-ee03-4722-a0ed-7d78e5ad829a", ModuleType.Recording, 1)]
    public partial class B_EXOPS_Status_von_F_auf_N_zuruecksetzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static B_EXOPS_Status_von_F_auf_N_zuruecksetzen instance = new B_EXOPS_Status_von_F_auf_N_zuruecksetzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_EXOPS_Status_von_F_auf_N_zuruecksetzen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_EXOPS_Status_von_F_auf_N_zuruecksetzen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Column0' at Center.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Column0Info, new RecordItemIndex(0));
            repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Column0.Click();
            
            // alle Zeilen markieren mit Shift+Bild nach unten
            Report.Log(ReportLevel.Info, "Keyboard", "alle Zeilen markieren mit Shift+Bild nach unten\r\nKey 'Shift+Next' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Next | System.Windows.Forms.Keys.Shift, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(2));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Column0' at Center.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Column0Info, new RecordItemIndex(3));
            repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Column0.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'BEXOPS'.", repo.BEXOPS.SelfInfo, new RecordItemIndex(4));
            Validate.Exists(repo.BEXOPS.SelfInfo);
            
            // Rechtsklick auf Element, linksklick funktioniert nicht richtig
            Report.Log(ReportLevel.Info, "Mouse", "Rechtsklick auf Element, linksklick funktioniert nicht richtig\r\nMouse Right Click item 'BEXOPS.ZeilenWiederherstellenStatusN' at Center.", repo.BEXOPS.ZeilenWiederherstellenStatusNInfo, new RecordItemIndex(5));
            repo.BEXOPS.ZeilenWiederherstellenStatusN.Click(System.Windows.Forms.MouseButtons.Right);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            //Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBEXOP_Verwalten_Schnittstelle.PbDataAccessSave' at Center.", repo.FrmBEXOP_Verwalten_Schnittstelle.PbDataAccessSaveInfo, new RecordItemIndex(8));
            repo.FrmBEXOP_Verwalten_Schnittstelle.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1'", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Info, new ActionTimeout(60000), new RecordItemIndex(9));
            repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.Row1Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_1.ColExopStatusRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_2.ColExopStatusRow2Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_3.ColExopStatusRow3Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_4.ColExopStatusRow4Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_5.ColExopStatusRow5Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_6.ColExopStatusRow6Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_7.ColExopStatusRow7Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_fixe_Zeilennr.Zeile_8.ColExopStatusRow8Info, "Text", "N");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
