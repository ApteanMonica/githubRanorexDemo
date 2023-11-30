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

namespace B_MNDR_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OP_entfernen recording.
    /// </summary>
    [TestModule("ca236fd4-cdab-454a-9dc2-aed36f8b32f4", ModuleType.Recording, 1)]
    public partial class OP_entfernen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_003.B_MNDR_003Repository repository.
        /// </summary>
        public static global::B_MNDR_003.B_MNDR_003Repository repo = global::B_MNDR_003.B_MNDR_003Repository.Instance;

        static OP_entfernen instance = new OP_entfernen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OP_entfernen()
        {
            Beschreibung = "B_MNDR_003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OP_entfernen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beschreibung.
        /// </summary>
        [TestVariable("a341d48a-e072-4868-a5ed-5e5a958ee89a")]
        public string Beschreibung
        {
            get { return repo.Beschreibung; }
            set { repo.Beschreibung = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_Beschreibung' at Center.", repo.TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_BeschreibungInfo, new RecordItemIndex(0));
            repo.TblMndt.FlexGrid_Tabelle.Column0_Zeile_mit_Beschreibung.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblMndt.PbCommonAEndern' at Center.", repo.TblMndt.PbCommonAEndernInfo, new RecordItemIndex(2));
            repo.TblMndt.PbCommonAEndern.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmVorschlagAEndern.TitleBar1003BMNDR003Mahnvorschla'", repo.FrmVorschlagAEndern.TitleBar1003BMNDR003MahnvorschlaInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.FrmVorschlagAEndern.TitleBar1003BMNDR003MahnvorschlaInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'ändern') on item 'FrmVorschlagAEndern.TitleBar1003BMNDR003Mahnvorschla'.", repo.FrmVorschlagAEndern.TitleBar1003BMNDR003MahnvorschlaInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmVorschlagAEndern.TitleBar1003BMNDR003MahnvorschlaInfo, "Text", "ändern");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Beschreibung) on item 'FrmVorschlagAEndern.TitleBar1003BMNDR003Mahnvorschla'.", repo.FrmVorschlagAEndern.TitleBar1003BMNDR003MahnvorschlaInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmVorschlagAEndern.TitleBar1003BMNDR003MahnvorschlaInfo, "Text", Beschreibung);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'B_MNDR_003_03') on item 'FrmVorschlagAEndern.FlexGrid_Tabelle.ColBelegRow3'.", repo.FrmVorschlagAEndern.FlexGrid_Tabelle.ColBelegRow3Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FrmVorschlagAEndern.FlexGrid_Tabelle.ColBelegRow3Info, "Text", "B_MNDR_003_03");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.Row3Column0' at Center.", repo.FrmVorschlagAEndern.Row3Column0Info, new RecordItemIndex(7));
            repo.FrmVorschlagAEndern.Row3Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmVorschlagAEndern.Row3Column0'.", repo.FrmVorschlagAEndern.Row3Column0Info, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.FrmVorschlagAEndern.Row3Column0);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.PbDataAccessSave' at Center.", repo.FrmVorschlagAEndern.PbDataAccessSaveInfo, new RecordItemIndex(9));
            repo.FrmVorschlagAEndern.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVorschlagAEndern.PbDataAccessLoad' at Center.", repo.FrmVorschlagAEndern.PbDataAccessLoadInfo, new RecordItemIndex(10));
            repo.FrmVorschlagAEndern.PbDataAccessLoad.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
