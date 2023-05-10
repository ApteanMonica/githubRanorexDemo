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

namespace B_ZAHL_006.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_KLAB recording.
    /// </summary>
    [TestModule("48e65375-c6a7-4732-af89-464f1a368263", ModuleType.Recording, 1)]
    public partial class Close_KLAB : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_006.B_ZAHL_006Repository repository.
        /// </summary>
        public static global::B_ZAHL_006.B_ZAHL_006Repository repo = global::B_ZAHL_006.B_ZAHL_006Repository.Instance;

        static Close_KLAB instance = new Close_KLAB();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_KLAB()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_KLAB Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'FrmKlAb.TitleBar100LieferantenKonto'.", repo.FrmKlAb.TitleBar100LieferantenKontoInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.FrmKlAb.TitleBar100LieferantenKonto, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
