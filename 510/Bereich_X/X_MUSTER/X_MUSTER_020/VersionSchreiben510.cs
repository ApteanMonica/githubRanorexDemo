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

namespace X_MUSTER_020
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VersionSchreiben510 recording.
    /// </summary>
    [TestModule("b9111e55-0a17-4a8a-98a3-dd9d839787b8", ModuleType.Recording, 1)]
    public partial class VersionSchreiben510 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the X_MUSTER_020Repository repository.
        /// </summary>
        public static X_MUSTER_020Repository repo = X_MUSTER_020Repository.Instance;

        static VersionSchreiben510 instance = new VersionSchreiben510();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VersionSchreiben510()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VersionSchreiben510 Instance
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

            Report.Log(ReportLevel.Info, "User", "510", new RecordItemIndex(0));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
