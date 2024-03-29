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

namespace X_MUSTER_021
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Update recording.
    /// </summary>
    [TestModule("ec5cdcf6-a8af-4c59-a08c-aaae2e666959", ModuleType.Recording, 1)]
    public partial class Update : ITestModule
    {
        /// <summary>
        /// Holds an instance of the X_MUSTER_021Repository repository.
        /// </summary>
        public static X_MUSTER_021Repository repo = X_MUSTER_021Repository.Instance;

        static Update instance = new Update();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Update()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Update Instance
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

            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ReadDBVersion();
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ReadProgrammVersion("");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("update y_par set par_textk = '0' where par_cd = 'FIBU_SPERRE_100' and par_lfdnr= '0';", "c.\\temp\\X_MUSTER_021_update.txt");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
