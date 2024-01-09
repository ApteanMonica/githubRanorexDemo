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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Verbuchung_Meldungen_verbucht_Fehler recording.
    /// </summary>
    [TestModule("446f3ba0-459f-43fd-8aff-78cb4a17eea7", ModuleType.Recording, 1)]
    public partial class Verbuchung_Meldungen_verbucht_Fehler : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Verbuchung_Meldungen_verbucht_Fehler instance = new Verbuchung_Meldungen_verbucht_Fehler();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchung_Meldungen_verbucht_Fehler()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchung_Meldungen_verbucht_Fehler Instance
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(180000), new RecordItemIndex(0));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Belege, die schon als OP vorhanden waren,\r\nwurden mit Status = <F> gekennzeichnet,\r\nkontrollieren Sie diese mit dem Programm\r\n<Bearbeiten Externe Fakturen>  -\r\n7 Belege wurden verbucht  !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Belege, die schon als OP vorhanden waren,\r\nwurden mit Status = <F> gekennzeichnet,\r\nkontrollieren Sie diese mit dem Programm\r\n<Bearbeiten Externe Fakturen>  -\r\n7 Belege wurden verbucht  !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(3));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgMessageBox.FakturenPruefung'.", repo.DlgMessageBox.FakturenPruefungInfo, new RecordItemIndex(4));
            Validate.Exists(repo.DlgMessageBox.FakturenPruefungInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'7 Belege wurden verbucht') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "7 Belege wurden verbucht");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'\r\r\n\r\nEs wurden Fehler/Hinweise protokolliert!\r\nWollen Sie die Protokoll-Datei öffnen ') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "\r\r\n\r\nEs wurden Fehler/Hinweise protokolliert!\r\nWollen Sie die Protokoll-Datei öffnen ");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(7));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Form100ExterneBuchungenVerbuchen.VerbuchenBeendet'.", repo.Form100ExterneBuchungenVerbuchen.VerbuchenBeendetInfo, new RecordItemIndex(8));
            Validate.Exists(repo.Form100ExterneBuchungenVerbuchen.VerbuchenBeendetInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
