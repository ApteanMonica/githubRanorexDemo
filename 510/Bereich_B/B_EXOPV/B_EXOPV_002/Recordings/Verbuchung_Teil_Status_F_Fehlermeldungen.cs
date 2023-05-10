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

namespace B_EXOPV_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Stapel recording.
    /// </summary>
    [TestModule("9ef13be6-d616-4781-860d-7a8a693472d1", ModuleType.Recording, 1)]
    public partial class Verbuchung_Teil_Status_F_Fehlermeldungen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_002.B_EXOPV_002Repository repository.
        /// </summary>
        public static global::B_EXOPV_002.B_EXOPV_002Repository repo = global::B_EXOPV_002.B_EXOPV_002Repository.Instance;

        static Verbuchung_Teil_Status_F_Fehlermeldungen instance = new Verbuchung_Teil_Status_F_Fehlermeldungen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchung_Teil_Status_F_Fehlermeldungen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchung_Teil_Status_F_Fehlermeldungen Instance
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4 Belege wurden verbucht  !\r\n\r\nEs wurden Fehler/Hinweise protokolliert!\r\nWollen Sie die Protokoll-Datei öffnen ? ') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "4 Belege wurden verbucht  !\r\n\r\nEs wurden Fehler/Hinweise protokolliert!\r\nWollen Sie die Protokoll-Datei öffnen ? ");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
