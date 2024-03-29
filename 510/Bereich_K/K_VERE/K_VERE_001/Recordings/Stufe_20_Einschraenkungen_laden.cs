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
    ///The Stufe_20_Einschraenkungen_laden recording.
    /// </summary>
    [TestModule("5aa2cc32-2742-49fa-80c3-5d024d96e3cc", ModuleType.Recording, 1)]
    public partial class Stufe_20_Einschraenkungen_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERE_001.K_VERE_001Repository repository.
        /// </summary>
        public static global::K_VERE_001.K_VERE_001Repository repo = global::K_VERE_001.K_VERE_001Repository.Instance;

        static Stufe_20_Einschraenkungen_laden instance = new Stufe_20_Einschraenkungen_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stufe_20_Einschraenkungen_laden()
        {
            Jahr = "2020";
            Periode = "1";
            Stufe_20 = "20";
            Art_STS = "STS";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stufe_20_Einschraenkungen_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("813520d3-9c63-426d-ac34-0954c1f1c536")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Periode;

        /// <summary>
        /// Gets or sets the value of variable Periode.
        /// </summary>
        [TestVariable("fa444ddd-9a68-437f-a1b7-f79633475a9f")]
        public string Periode
        {
            get { return _Periode; }
            set { _Periode = value; }
        }

        string _Stufe_20;

        /// <summary>
        /// Gets or sets the value of variable Stufe_20.
        /// </summary>
        [TestVariable("e09d1ec7-1dfd-46c2-b772-ca62ae7e332d")]
        public string Stufe_20
        {
            get { return _Stufe_20; }
            set { _Stufe_20 = value; }
        }

        string _Art_STS;

        /// <summary>
        /// Gets or sets the value of variable Art_STS.
        /// </summary>
        [TestVariable("29492eba-554d-41c6-8ec5-d3eb5ad7b31b")]
        public string Art_STS
        {
            get { return _Art_STS; }
            set { _Art_STS = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'TblVerr_K_VERE.ToolBar.PlanNr'.", repo.TblVerr_K_VERE.ToolBar.PlanNrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.PlanNrInfo, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblVerr_K_VERE.ToolBar.Jahr' at Center.", repo.TblVerr_K_VERE.ToolBar.JahrInfo, new RecordItemIndex(1));
            repo.TblVerr_K_VERE.ToolBar.Jahr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Jahr' with focus on 'TblVerr_K_VERE.ToolBar.Jahr'.", repo.TblVerr_K_VERE.ToolBar.JahrInfo, new RecordItemIndex(4));
            repo.TblVerr_K_VERE.ToolBar.Jahr.PressKeys(Jahr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(5));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Periode' with focus on 'TblVerr_K_VERE.ToolBar.Periode'.", repo.TblVerr_K_VERE.ToolBar.PeriodeInfo, new RecordItemIndex(6));
            repo.TblVerr_K_VERE.ToolBar.Periode.PressKeys(Periode);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Stufe_20' with focus on 'TblVerr_K_VERE.ToolBar.Stufe'.", repo.TblVerr_K_VERE.ToolBar.StufeInfo, new RecordItemIndex(8));
            repo.TblVerr_K_VERE.ToolBar.Stufe.PressKeys(Stufe_20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblVerr_K_VERE.PbDataAccessLoad' at Center.", repo.TblVerr_K_VERE.PbDataAccessLoadInfo, new RecordItemIndex(10));
            repo.TblVerr_K_VERE.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'TblVerr_K_VERE.ToolBar.Jahr'.", repo.TblVerr_K_VERE.ToolBar.JahrInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.JahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode) on item 'TblVerr_K_VERE.ToolBar.Periode'.", repo.TblVerr_K_VERE.ToolBar.PeriodeInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.PeriodeInfo, "Text", Periode);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Stufe_20) on item 'TblVerr_K_VERE.ToolBar.Stufe'.", repo.TblVerr_K_VERE.ToolBar.StufeInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.StufeInfo, "Text", Stufe_20);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Art_STS) on item 'TblVerr_K_VERE.ToolBar.TextArt'.", repo.TblVerr_K_VERE.ToolBar.TextArtInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.TextArtInfo, "Text", Art_STS);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Import Stundensatz') on item 'TblVerr_K_VERE.ToolBar.DfVestBez'.", repo.TblVerr_K_VERE.ToolBar.DfVestBezInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.DfVestBezInfo, "Text", "Import Stundensatz");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Stundensatz erfassen') on item 'TblVerr_K_VERE.ToolBar.DfVeraBez'.", repo.TblVerr_K_VERE.ToolBar.DfVeraBezInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.ToolBar.DfVeraBezInfo, "Text", "Stundensatz erfassen");
            
            // Auswahltabelle Konten Kostenstellen
            Report.Log(ReportLevel.Info, "Section", "Auswahltabelle Konten Kostenstellen", new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow1'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow1Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow1'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow1Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow1Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow2'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow2Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKtoNrRow2Info, "Text", "");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='') on item 'TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow2'.", repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow2Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Auswahltabelle_Konten_Kostenstellen.ColKs1NrRow2Info, "Text", "");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
