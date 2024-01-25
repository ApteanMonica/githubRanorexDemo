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

namespace S_AGR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Aendern_Artikelstruktur_Neu recording.
    /// </summary>
    [TestModule("ef924714-691d-415f-9098-0d3c2408f3fb", ModuleType.Recording, 1)]
    public partial class Aendern_Artikelstruktur_Neu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repo = global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository.Instance;

        static Aendern_Artikelstruktur_Neu instance = new Aendern_Artikelstruktur_Neu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aendern_Artikelstruktur_Neu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aendern_Artikelstruktur_Neu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ARTIKELSTRUKTUR_CD_NEU.
        /// </summary>
        [TestVariable("49bf77b1-8a23-4bef-86c2-847823453f60")]
        public string ARTIKELSTRUKTUR_CD_NEU
        {
            get { return repo.ARTIKELSTRUKTUR_CD_NEU; }
            set { repo.ARTIKELSTRUKTUR_CD_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1Repzmenge'.", repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1RepzmengeInfo, new RecordItemIndex(0));
            repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1Repzmenge.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'STD{Tab}' with focus on 'FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1Repzeh'.", repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1RepzehInfo, new RecordItemIndex(2));
            repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1Repzeh.PressKeys("STD{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAs.RibbonBar.PbDataAccessSave' at Center.", repo.FrmAs.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(3));
            repo.FrmAs.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1Repzmenge'.", repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1RepzmengeInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1RepzmengeInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='STD') on item 'FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1Repzeh'.", repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1RepzehInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmAs.FlexGrid_Tabelle_links.Row_mit_Variable_CD_Neu.ColAs1RepzehInfo, "Text", "STD");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}