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

namespace B_ELSTER_006_ZM.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tagesdatum_ermitteln_XML recording.
    /// </summary>
    [TestModule("77f02e05-0a73-4419-b9d7-efffe002e8f0", ModuleType.Recording, 1)]
    public partial class Tagesdatum_ermitteln_XML : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_006_ZM.B_ELSTER_006_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_006_ZM.B_ELSTER_006_ZMRepository repo = global::B_ELSTER_006_ZM.B_ELSTER_006_ZMRepository.Instance;

        static Tagesdatum_ermitteln_XML instance = new Tagesdatum_ermitteln_XML();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tagesdatum_ermitteln_XML()
        {
            Tagesdatum_yyyyMMdd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tagesdatum_ermitteln_XML Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum_yyyyMMdd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_yyyyMMdd.
        /// </summary>
        [TestVariable("76f823bf-f5fe-4d66-9b28-a44eceb52606")]
        public string Tagesdatum_yyyyMMdd
        {
            get { return _Tagesdatum_yyyyMMdd; }
            set { _Tagesdatum_yyyyMMdd = value; }
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

            Tagesdatum_yyyyMMdd = Ranorex.AutomationHelpers.UserCodeCollections.SystemLibrary.GetDateTimeAsString("yyyyMMdd");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
