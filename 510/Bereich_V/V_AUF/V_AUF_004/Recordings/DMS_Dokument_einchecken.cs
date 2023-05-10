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

namespace V_AUF_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DMS_Dokument_einchecken recording.
    /// </summary>
    [TestModule("6c13663a-cd98-43c4-9b97-f71262ec8777", ModuleType.Recording, 1)]
    public partial class DMS_Dokument_einchecken : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_AUF_004.V_AUF_004Repository repository.
        /// </summary>
        public static global::V_AUF_004.V_AUF_004Repository repo = global::V_AUF_004.V_AUF_004Repository.Instance;

        static DMS_Dokument_einchecken instance = new DMS_Dokument_einchecken();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DMS_Dokument_einchecken()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DMS_Dokument_einchecken Instance
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
