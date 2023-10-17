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

namespace B_ELSTER_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Elster_Plausipruefung_durchfuehren recording.
    /// </summary>
    [TestModule("67903054-b2ef-40dc-9cd9-789829382e09", ModuleType.Recording, 1)]
    public partial class Elster_Plausipruefung_durchfuehren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_004.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_004.B_ELSTER_004Repository repo = global::B_ELSTER_004.B_ELSTER_004Repository.Instance;

        static Elster_Plausipruefung_durchfuehren instance = new Elster_Plausipruefung_durchfuehren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Elster_Plausipruefung_durchfuehren()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Elster_Plausipruefung_durchfuehren Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmMain.ClientArea.PbPlausi'.", repo.FrmMain.ClientArea.PbPlausiInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmMain.ClientArea.PbPlausiInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'FrmMain.ClientArea.PbPlausi'.", repo.FrmMain.ClientArea.PbPlausiInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbPlausiInfo, "Enabled", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'FrmMain.ClientArea.PbDrucken'.", repo.FrmMain.ClientArea.PbDruckenInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbDruckenInfo, "Enabled", "False");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'FrmMain.ClientArea.PbSenden'.", repo.FrmMain.ClientArea.PbSendenInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbSendenInfo, "Enabled", "False");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(4));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain.ClientArea.PbPlausi' at Center.", repo.FrmMain.ClientArea.PbPlausiInfo, new RecordItemIndex(5));
            repo.FrmMain.ClientArea.PbPlausi.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(6));
            Delay.Duration(3000, false);
            
            // weil noch keine erfolgreich-Meldung (XP332) Prüfung ob keine eric-Fehlermeldung kommt
            //Report.Log(ReportLevel.Info, "Wait", "weil noch keine erfolgreich-Meldung (XP332) Prüfung ob keine eric-Fehlermeldung kommt\r\nWaiting 2m to not exist. Associated repository item: 'Frage.Fehlermeldung_Plausipruefung'", repo.Frage.Fehlermeldung_PlausipruefungInfo, new ActionTimeout(120000), new RecordItemIndex(7));
            //repo.Frage.Fehlermeldung_PlausipruefungInfo.WaitForNotExists(120000);
            
            // falls Fehler-Fenster aufgeht mit Enter (=Ja) bestätigen, dass Eric log im Editor geöffnet wird
            //Report.Log(ReportLevel.Info, "Keyboard", "falls Fehler-Fenster aufgeht mit Enter (=Ja) bestätigen, dass Eric log im Editor geöffnet wird\r\nKey 'Enter' Press.", new RecordItemIndex(8));
            //Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'FrmMain.ClientArea.Button_Druckvorschau_aktiv'", repo.FrmMain.ClientArea.Button_Druckvorschau_aktivInfo, new ActionTimeout(180000), new RecordItemIndex(9));
            repo.FrmMain.ClientArea.Button_Druckvorschau_aktivInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'FrmMain.ClientArea.PbPlausi'.", repo.FrmMain.ClientArea.PbPlausiInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbPlausiInfo, "Enabled", "True");
            
            // wenn erfolgreich, muss der Button aktiv sein
            Report.Log(ReportLevel.Info, "Validation", "wenn erfolgreich, muss der Button aktiv sein\r\nValidating AttributeEqual (Enabled='True') on item 'FrmMain.ClientArea.PbDrucken'.", repo.FrmMain.ClientArea.PbDruckenInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbDruckenInfo, "Enabled", "True");
            
            // wenn erfolgreich, muss der Button aktiv sein
            Report.Log(ReportLevel.Info, "Validation", "wenn erfolgreich, muss der Button aktiv sein\r\nValidating AttributeEqual (Enabled='True') on item 'FrmMain.ClientArea.PbSenden'.", repo.FrmMain.ClientArea.PbSendenInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmMain.ClientArea.PbSendenInfo, "Enabled", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
