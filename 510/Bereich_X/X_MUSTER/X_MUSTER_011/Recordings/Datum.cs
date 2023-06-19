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

namespace X_MUSTER_011.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Datum recording.
    /// </summary>
    [TestModule("b9850c57-1b5b-4150-ae47-45f0526f2c88", ModuleType.Recording, 1)]
    public partial class Datum : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_011.X_MUSTER_011Repository repository.
        /// </summary>
        public static global::X_MUSTER_011.X_MUSTER_011Repository repo = global::X_MUSTER_011.X_MUSTER_011Repository.Instance;

        static Datum instance = new Datum();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Datum()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Datum Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[012])\\.(19|20)\\d\\d') on item 'TblB.ColDtAendgRow1'.", repo.TblB.ColDtAendgRow1Info, new RecordItemIndex(0));
            Validate.AttributeRegex(repo.TblB.ColDtAendgRow1Info, "Text", new Regex("^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[012])\\.(19|20)\\d\\d"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
