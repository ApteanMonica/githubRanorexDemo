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

namespace B_BUCH_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Host_lesen recording.
    /// </summary>
    [TestModule("49c7f21e-1f9e-488f-b817-d1324318154b", ModuleType.Recording, 1)]
    public partial class Host_lesen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_006.B_BUCH_006Repository repository.
        /// </summary>
        public static global::B_BUCH_006.B_BUCH_006Repository repo = global::B_BUCH_006.B_BUCH_006Repository.Instance;

        static Host_lesen instance = new Host_lesen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Host_lesen()
        {
            computer = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Host_lesen Instance
        {
            get { return instance; }
        }

#region Variables

        string _computer;

        /// <summary>
        /// Gets or sets the value of variable computer.
        /// </summary>
        [TestVariable("431f76e2-98f1-4d1e-a676-89f14051b5ad")]
        public string computer
        {
            get { return _computer; }
            set { _computer = value; }
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

            computer = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetHost();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}