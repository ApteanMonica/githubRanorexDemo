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
    ///The Stufe_20_Werte_erfassen recording.
    /// </summary>
    [TestModule("ff9f24aa-a6fe-45c5-bae8-54c713008c4a", ModuleType.Recording, 1)]
    public partial class Stufe_20_Werte_erfassen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_VERE_001.K_VERE_001Repository repository.
        /// </summary>
        public static global::K_VERE_001.K_VERE_001Repository repo = global::K_VERE_001.K_VERE_001Repository.Instance;

        static Stufe_20_Werte_erfassen instance = new Stufe_20_Werte_erfassen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stufe_20_Werte_erfassen()
        {
            von_KST_10 = "10";
            Text_20 = "Import Stundenerfassung";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stufe_20_Werte_erfassen Instance
        {
            get { return instance; }
        }

#region Variables

        string _von_KST_10;

        /// <summary>
        /// Gets or sets the value of variable von_KST_10.
        /// </summary>
        [TestVariable("3307ff82-a8b5-4685-95ae-03dc8335b22b")]
        public string von_KST_10
        {
            get { return _von_KST_10; }
            set { _von_KST_10 = value; }
        }

        string _Text_20;

        /// <summary>
        /// Gets or sets the value of variable Text_20.
        /// </summary>
        [TestVariable("c7f12762-ec41-4605-b09b-e4f46d994007")]
        public string Text_20
        {
            get { return _Text_20; }
            set { _Text_20 = value; }
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

            // Werte erfassen
            Report.Log(ReportLevel.Info, "Section", "Werte erfassen", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$von_KST_10' with focus on 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrVonRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrVonRow2Info, new RecordItemIndex(1));
            repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColKs1NrVonRow2.PressKeys(von_KST_10);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100,1256' with focus on 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2Info, new RecordItemIndex(3));
            repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2.PressKeys("100,1256");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100,1256') on item 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrBetragRow2Info, "Text", "100,1256");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Text_20' with focus on 'TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrTextRow2'.", repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrTextRow2Info, new RecordItemIndex(6));
            repo.TblVerr_K_VERE.Row2_erste_Erfassungszeile.ColVerrTextRow2.PressKeys(Text_20);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblVerr_K_VERE.PbDataAccessSave' at Center.", repo.TblVerr_K_VERE.PbDataAccessSaveInfo, new RecordItemIndex(8));
            repo.TblVerr_K_VERE.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
