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

namespace B_ZAHL_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ZV_B_ZAHL_001_A_loeschen recording.
    /// </summary>
    [TestModule("7761bd6a-66bf-4f59-bb94-a98644d4ed22", ModuleType.Recording, 1)]
    public partial class ZV_B_ZAHL_001_A_loeschen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_001.B_ZAHL_001Repository repository.
        /// </summary>
        public static global::B_ZAHL_001.B_ZAHL_001Repository repo = global::B_ZAHL_001.B_ZAHL_001Repository.Instance;

        static ZV_B_ZAHL_001_A_loeschen instance = new ZV_B_ZAHL_001_A_loeschen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ZV_B_ZAHL_001_A_loeschen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ZV_B_ZAHL_001_A_loeschen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ZV_TEXT_A.
        /// </summary>
        [TestVariable("cf2d2b15-b764-4b79-853f-bf4a013a8a24")]
        public string ZV_TEXT_A
        {
            get { return repo.ZV_TEXT_A; }
            set { repo.ZV_TEXT_A = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'.", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new RecordItemIndex(0));
            Keyboard.PrepareFocus(repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.TitleBar100LieferantenZahlungsver'", repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten - Zahlungsverkehr') on item 'FrmZahlMain.TitleBar100LieferantenZahlungsver'.", repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, "Text", "Lieferanten - Zahlungsverkehr");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_001_A'", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_001_AInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_001_AInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_001_A' at Center.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_001_AInfo, new RecordItemIndex(4));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_001_A.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_001_A'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_001_AInfo, new RecordItemIndex(5));
            Keyboard.PrepareFocus(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_001_A);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.PbDataAcessSpeichern' at Center.", repo.FrmZahlMain.PbDataAcessSpeichernInfo, new RecordItemIndex(6));
            repo.FrmZahlMain.PbDataAcessSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.PbDataAcessLaden' at Center.", repo.FrmZahlMain.PbDataAcessLadenInfo, new RecordItemIndex(8));
            repo.FrmZahlMain.PbDataAcessLaden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
