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

namespace Z_UHR_004.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einlesen_des_Ranoagent recording.
    /// </summary>
    [TestModule("2f4d2357-6403-402d-b60a-96aa028bfea6", ModuleType.Recording, 1)]
    public partial class Einlesen_des_Ranoagent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_004.Z_UHR_004Repository repository.
        /// </summary>
        public static global::Z_UHR_004.Z_UHR_004Repository repo = global::Z_UHR_004.Z_UHR_004Repository.Instance;

        static Einlesen_des_Ranoagent instance = new Einlesen_des_Ranoagent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einlesen_des_Ranoagent()
        {
            computerName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einlesen_des_Ranoagent Instance
        {
            get { return instance; }
        }

#region Variables

        string _computerName;

        /// <summary>
        /// Gets or sets the value of variable computerName.
        /// </summary>
        [TestVariable("f3ef2bff-f2e4-40aa-b29a-58e58a317d8a")]
        public string computerName
        {
            get { return _computerName; }
            set { _computerName = value; }
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

            computerName = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetHost();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}