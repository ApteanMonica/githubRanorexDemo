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

namespace X_MUSTER_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Get_Computer_Name recording.
    /// </summary>
    [TestModule("1efbe4d3-3d7a-472a-b7ad-77ef7ff2bb8b", ModuleType.Recording, 1)]
    public partial class Get_Computer_Name : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_007.X_MUSTER_007Repository repository.
        /// </summary>
        public static global::X_MUSTER_007.X_MUSTER_007Repository repo = global::X_MUSTER_007.X_MUSTER_007Repository.Instance;

        static Get_Computer_Name instance = new Get_Computer_Name();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Get_Computer_Name()
        {
            computerName = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Get_Computer_Name Instance
        {
            get { return instance; }
        }

#region Variables

        string _computerName;

        /// <summary>
        /// Gets or sets the value of variable computerName.
        /// </summary>
        [TestVariable("049a6ce0-01c9-4687-b402-7db1d1a592b0")]
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
            
            Report.Log(ReportLevel.Info, "User", computerName, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
