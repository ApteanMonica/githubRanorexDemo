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

namespace B_BUOPPR_001.Recordings_Abfrageprogramme
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_B_KLSALD recording.
    /// </summary>
    [TestModule("557366ad-6144-45b1-83c8-0a5d6800e489", ModuleType.Recording, 1)]
    public partial class Close_B_KLSALD : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUOPPR_001.B_BUOPPR_001Repository repository.
        /// </summary>
        public static global::B_BUOPPR_001.B_BUOPPR_001Repository repo = global::B_BUOPPR_001.B_BUOPPR_001Repository.Instance;

        static Close_B_KLSALD instance = new Close_B_KLSALD();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_B_KLSALD()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_B_KLSALD Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmKLSL.TitleBar100SaldenlistePerStichtag'.", repo.FrmKLSL.TitleBar100SaldenlistePerStichtagInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmKLSL.TitleBar100SaldenlistePerStichtag, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
