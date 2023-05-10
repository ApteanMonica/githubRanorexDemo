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

namespace B_ZAHLV_001.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tagesdatum_ermitteln recording.
    /// </summary>
    [TestModule("a99d5db0-c2f1-437f-89a3-83e7ec8dd6ad", ModuleType.Recording, 1)]
    public partial class Tagesdatum_ermitteln : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static Tagesdatum_ermitteln instance = new Tagesdatum_ermitteln();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tagesdatum_ermitteln()
        {
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tagesdatum_ermitteln Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("27128d04-225a-49ea-8c3f-3ba7cb2dd595")]
        public string Tagesdatum
        {
            get { return repo.Tagesdatum; }
            set { repo.Tagesdatum = value; }
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

            Tagesdatum = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("dd.MM.yyyy");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
