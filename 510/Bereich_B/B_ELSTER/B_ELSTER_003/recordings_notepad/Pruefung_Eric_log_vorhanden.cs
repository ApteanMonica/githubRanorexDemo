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

namespace B_ELSTER_003.recordings_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Eric_log_vorhanden recording.
    /// </summary>
    [TestModule("936b36f9-42d3-415e-8b68-56d6b9777088", ModuleType.Recording, 1)]
    public partial class Pruefung_Eric_log_vorhanden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_003.B_ELSTER_003Repository repository.
        /// </summary>
        public static global::B_ELSTER_003.B_ELSTER_003Repository repo = global::B_ELSTER_003.B_ELSTER_003Repository.Instance;

        static Pruefung_Eric_log_vorhanden instance = new Pruefung_Eric_log_vorhanden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Eric_log_vorhanden()
        {
            Tagesdatum_yyyy_MM_dd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Eric_log_vorhanden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum_yyyy_MM_dd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_yyyy_MM_dd.
        /// </summary>
        [TestVariable("ca604ab2-58e5-40c0-9c5f-4fc721767aae")]
        public string Tagesdatum_yyyy_MM_dd
        {
            get { return _Tagesdatum_yyyy_MM_dd; }
            set { _Tagesdatum_yyyy_MM_dd = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$Tagesdatum_yyyy_MM_dd) on item 'EricLogEditor.Text15'.", repo.EricLogEditor.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.EricLogEditor.Text15Info, "Text", Tagesdatum_yyyy_MM_dd, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
