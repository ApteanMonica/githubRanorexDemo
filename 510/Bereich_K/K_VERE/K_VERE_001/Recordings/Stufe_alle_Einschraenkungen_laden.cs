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

namespace K_VERE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Stufe_alle_Einschraenkungen_laden recording.
    /// </summary>
    [TestModule("c6f1cb6b-daa1-4842-9d31-b0e9aaca66c9", ModuleType.Recording, 1)]
    public partial class Stufe_alle_Einschraenkungen_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERE_001.K_VERE_001Repository repository.
        /// </summary>
        public static global::K_VERE_001.K_VERE_001Repository repo = global::K_VERE_001.K_VERE_001Repository.Instance;

        static Stufe_alle_Einschraenkungen_laden instance = new Stufe_alle_Einschraenkungen_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stufe_alle_Einschraenkungen_laden()
        {
            Jahr = "2020";
            Periode = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stufe_alle_Einschraenkungen_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("5a5323f8-1ee3-4934-9983-bd5af05be488")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Periode;

        /// <summary>
        /// Gets or sets the value of variable Periode.
        /// </summary>
        [TestVariable("478bd8c7-12c4-4ecb-a84b-47f07d5bb3a5")]
        public string Periode
        {
            get { return _Periode; }
            set { _Periode = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblVerr_K_VERE.PbDataAccessNew' at Center.", repo.TblVerr_K_VERE.PbDataAccessNewInfo, new RecordItemIndex(0));
            repo.TblVerr_K_VERE.PbDataAccessNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblVerr_K_VERE.ToolBar.Stufe' at Center.", repo.TblVerr_K_VERE.ToolBar.StufeInfo, new RecordItemIndex(1));
            repo.TblVerr_K_VERE.ToolBar.Stufe.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblVerr_K_VERE.PbDataAccessLoad' at Center.", repo.TblVerr_K_VERE.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.TblVerr_K_VERE.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'TblVerr_K_VERE.ToolBar.Jahr'.", repo.TblVerr_K_VERE.ToolBar.JahrInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.JahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode) on item 'TblVerr_K_VERE.ToolBar.Periode'.", repo.TblVerr_K_VERE.ToolBar.PeriodeInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.PeriodeInfo, "Text", Periode);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.ToolBar.Stufe'.", repo.TblVerr_K_VERE.ToolBar.StufeInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.StufeInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.ToolBar.TextArt'.", repo.TblVerr_K_VERE.ToolBar.TextArtInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.TextArtInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.ToolBar.DfVestBez'.", repo.TblVerr_K_VERE.ToolBar.DfVestBezInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.DfVestBezInfo, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.ToolBar.DfVeraBez'.", repo.TblVerr_K_VERE.ToolBar.DfVeraBezInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.DfVeraBezInfo, "Text", "");
            
            // Auswahltabelle Konten Kostenstellen
            Report.Log(ReportLevel.Info, "Section", "Auswahltabelle Konten Kostenstellen", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow1'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow1'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow2'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow2Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow2'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow2Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow2Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
