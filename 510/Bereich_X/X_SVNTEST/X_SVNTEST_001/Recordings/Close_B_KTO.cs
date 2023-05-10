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

namespace X_SVNTEST_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_B_KTO recording.
    /// </summary>
    [TestModule("3319cc3a-9642-424d-a88d-b37b46a00027", ModuleType.Recording, 1)]
    public partial class Close_B_KTO : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_SVNTEST_001.X_SVNTEST_001Repository repository.
        /// </summary>
        public static global::X_SVNTEST_001.X_SVNTEST_001Repository repo = global::X_SVNTEST_001.X_SVNTEST_001Repository.Instance;

        static Close_B_KTO instance = new Close_B_KTO();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_B_KTO()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_B_KTO Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmKto.TitleBar300SachkontenVerwalten'.", repo.FrmKto.TitleBar300SachkontenVerwaltenInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmKto.TitleBar300SachkontenVerwalten, 500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
