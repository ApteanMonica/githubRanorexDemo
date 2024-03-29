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

namespace B_ELSTER_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tagesdatum_ermitteln_eric recording.
    /// </summary>
    [TestModule("4b6cc238-73b7-4fb4-9ce4-91be03ded79b", ModuleType.Recording, 1)]
    public partial class Tagesdatum_ermitteln_eric : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_001.B_ELSTER_001Repository repository.
        /// </summary>
        public static global::B_ELSTER_001.B_ELSTER_001Repository repo = global::B_ELSTER_001.B_ELSTER_001Repository.Instance;

        static Tagesdatum_ermitteln_eric instance = new Tagesdatum_ermitteln_eric();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tagesdatum_ermitteln_eric()
        {
            Tagesdatum_yyyy_MM_dd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tagesdatum_ermitteln_eric Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum_yyyy_MM_dd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_yyyy_MM_dd.
        /// </summary>
        [TestVariable("035c526a-29eb-4ba6-8870-8a0e1f77f754")]
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

            Tagesdatum_yyyy_MM_dd = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("yyyy-MM-dd");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
