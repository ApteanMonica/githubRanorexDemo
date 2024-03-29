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

namespace X_MUSTER_012.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_bestaetigen recording.
    /// </summary>
    [TestModule("cb66b055-f1a8-4641-85bd-4c89040205fe", ModuleType.Recording, 1)]
    public partial class Meldung_bestaetigen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_012.X_MUSTER_012Repository repository.
        /// </summary>
        public static global::X_MUSTER_012.X_MUSTER_012Repository repo = global::X_MUSTER_012.X_MUSTER_012Repository.Instance;

        static Meldung_bestaetigen instance = new Meldung_bestaetigen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_bestaetigen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_bestaetigen Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'(Buchung  OK ?)|(Buchung OK ? )') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(0));
            Validate.AttributeRegex(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", new Regex("(Buchung  OK ?)|(Buchung OK ? )"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
