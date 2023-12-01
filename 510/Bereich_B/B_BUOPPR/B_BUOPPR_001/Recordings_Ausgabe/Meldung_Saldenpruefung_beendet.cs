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

namespace B_BUOPPR_001.Recordings_Ausgabe
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_Saldenpruefung_beendet recording.
    /// </summary>
    [TestModule("ddc12f3d-e878-4b5d-8b99-c7762402c42b", ModuleType.Recording, 1)]
    public partial class Meldung_Saldenpruefung_beendet : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Meldung_Saldenpruefung_beendet instance = new Meldung_Saldenpruefung_beendet();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_Saldenpruefung_beendet()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_Saldenpruefung_beendet Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(0));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='OP-Saldenprüfung beendet !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "OP-Saldenprüfung beendet !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0_OK' at Center.", repo.DlgMessageBox.Button0_OKInfo, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0_OK.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
