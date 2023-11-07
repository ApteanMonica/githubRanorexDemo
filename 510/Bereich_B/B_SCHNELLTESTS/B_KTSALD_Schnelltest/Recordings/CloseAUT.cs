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

namespace B_KTSALD_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseAUT recording.
    /// </summary>
    [TestModule("f16ee7ff-d5f0-443a-b482-af020fb9a3f7", ModuleType.Recording, 1)]
    public partial class CloseAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KTSALD_Schnelltest.B_KTSALD_SchnelltestRepository repository.
        /// </summary>
        public static global::B_KTSALD_Schnelltest.B_KTSALD_SchnelltestRepository repo = global::B_KTSALD_Schnelltest.B_KTSALD_SchnelltestRepository.Instance;

        static CloseAUT instance = new CloseAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseAUT()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseAUT Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmKtSali.TitleBar100SachkontenUmsatzliste'.", repo.FrmKtSali.TitleBar100SachkontenUmsatzlisteInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmKtSali.TitleBar100SachkontenUmsatzliste, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
