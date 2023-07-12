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

namespace N_LISTEN_BULI_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bestaetigungsmeldung recording.
    /// </summary>
    [TestModule("f1e670fd-616c-4686-929b-5866c287de87", ModuleType.Recording, 1)]
    public partial class Bestaetigungsmeldung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static Bestaetigungsmeldung instance = new Bestaetigungsmeldung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bestaetigungsmeldung()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bestaetigungsmeldung Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.AVZAuswertungen'", repo.DlgMessageBox.AVZAuswertungenInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.DlgMessageBox.AVZAuswertungenInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Verbuchung in die Externe Schnittstelle jetzt durchführen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Verbuchung in die Externe Schnittstelle jetzt durchführen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.AVZAuswertungen'", repo.DlgMessageBox.AVZAuswertungenInfo, new ActionTimeout(5000), new RecordItemIndex(3));
            repo.DlgMessageBox.AVZAuswertungenInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Verbuchung erfolgreich durchgeführt.') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Verbuchung erfolgreich durchgeführt.");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(5));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'FrmBuchungsliste.TitleBar100AVZAuswertungenBuchungs'", repo.FrmBuchungsliste.TitleBar100AVZAuswertungenBuchungsInfo, new ActionTimeout(5000), new RecordItemIndex(6));
            repo.FrmBuchungsliste.TitleBar100AVZAuswertungenBuchungsInfo.WaitForExists(5000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
