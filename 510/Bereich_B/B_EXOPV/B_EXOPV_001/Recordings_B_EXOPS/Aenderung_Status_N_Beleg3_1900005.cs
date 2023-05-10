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

namespace B_EXOPV_001.Recordings_B_EXOPS
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Aenderung_Status_N_Beleg3_1900005 recording.
    /// </summary>
    [TestModule("a2c017d0-73e4-466a-b361-52438a710800", ModuleType.Recording, 1)]
    public partial class Aenderung_Status_N_Beleg3_1900005 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_001.B_EXOPV_001Repository repository.
        /// </summary>
        public static global::B_EXOPV_001.B_EXOPV_001Repository repo = global::B_EXOPV_001.B_EXOPV_001Repository.Instance;

        static Aenderung_Status_N_Beleg3_1900005 instance = new Aenderung_Status_N_Beleg3_1900005();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aenderung_Status_N_Beleg3_1900005()
        {
            Beleg3 = "1900005";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aenderung_Status_N_Beleg3_1900005 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beleg3.
        /// </summary>
        [TestVariable("d6867a27-35cb-4906-bc85-5f73b12c23e9")]
        public string Beleg3
        {
            get { return repo.Beleg3; }
            set { repo.Beleg3 = value; }
        }

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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmBEXOP_Verwalten_Schnittstelle.TitleBar100VerwaltenSchnittstelleE'", repo.FrmBEXOP_Verwalten_Schnittstelle.TitleBar100VerwaltenSchnittstelleEInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmBEXOP_Verwalten_Schnittstelle.TitleBar100VerwaltenSchnittstelleEInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Verwalten Schnittstelle EXOP') on item 'FrmBEXOP_Verwalten_Schnittstelle.TitleBar100VerwaltenSchnittstelleE'.", repo.FrmBEXOP_Verwalten_Schnittstelle.TitleBar100VerwaltenSchnittstelleEInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmBEXOP_Verwalten_Schnittstelle.TitleBar100VerwaltenSchnittstelleEInfo, "Text", "Verwalten Schnittstelle EXOP");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg3) on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg3Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopBelegnr_in_Zeile_mit_Beleg3Info, "Text", Beleg3);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='F') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3Info, "Text", "F");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.Column0_in_Zeile_mit_Beleg3' at Center.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.Column0_in_Zeile_mit_Beleg3Info, new RecordItemIndex(4));
            repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.Column0_in_Zeile_mit_Beleg3.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.Column0_in_Zeile_mit_Beleg3' at Center.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.Column0_in_Zeile_mit_Beleg3Info, new RecordItemIndex(5));
            repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.Column0_in_Zeile_mit_Beleg3.Click(System.Windows.Forms.MouseButtons.Right);
            
            // set search timeout +1.5m
            Report.Log(ReportLevel.Info, "Mouse", "set search timeout +1.5m\r\nMouse Left Click item 'BEXOPS.ZeilenWiederherstellenStatusN' at Center.", repo.BEXOPS.ZeilenWiederherstellenStatusNInfo, new RecordItemIndex(6));
            repo.BEXOPS.ZeilenWiederherstellenStatusN.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3'.", repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmBEXOP_Verwalten_Schnittstelle.FlexGrid_EXOP_Belege_mit_Variablen_Belegnr.ColExopStatus_in_Zeile_mit_Beleg3Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBEXOP_Verwalten_Schnittstelle.PbDataAccessSave' at Center.", repo.FrmBEXOP_Verwalten_Schnittstelle.PbDataAccessSaveInfo, new RecordItemIndex(8));
            repo.FrmBEXOP_Verwalten_Schnittstelle.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
