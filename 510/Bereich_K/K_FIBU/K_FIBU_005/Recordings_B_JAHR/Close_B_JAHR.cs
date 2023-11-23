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

namespace K_FIBU_005.Recordings_B_JAHR
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_B_JAHR recording.
    /// </summary>
    [TestModule("c01a3ef0-d12d-46c9-b26c-43c7ab0217d1", ModuleType.Recording, 1)]
    public partial class Close_B_JAHR : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_005.K_FIBU_005Repository repository.
        /// </summary>
        public static global::K_FIBU_005.K_FIBU_005Repository repo = global::K_FIBU_005.K_FIBU_005Repository.Instance;

        static Close_B_JAHR instance = new Close_B_JAHR();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_B_JAHR()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_B_JAHR Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmMain_bis_521_tblMain_ab_530.TitleBar100VerwaltenGeschaeftsjahr'.", repo.FrmMain_bis_521_tblMain_ab_530.TitleBar100VerwaltenGeschaeftsjahrInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmMain_bis_521_tblMain_ab_530.TitleBar100VerwaltenGeschaeftsjahr, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
