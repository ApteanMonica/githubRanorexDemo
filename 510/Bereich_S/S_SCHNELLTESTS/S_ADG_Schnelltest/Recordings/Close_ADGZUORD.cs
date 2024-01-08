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

namespace S_ADG_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Close_ADGZUORD recording.
    /// </summary>
    [TestModule("c832289f-12e7-49bd-9913-ed301d5b11e8", ModuleType.Recording, 1)]
    public partial class Close_ADGZUORD : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADG_Schnelltest.S_ADG_SchnelltestRepository repository.
        /// </summary>
        public static global::S_ADG_Schnelltest.S_ADG_SchnelltestRepository repo = global::S_ADG_Schnelltest.S_ADG_SchnelltestRepository.Instance;

        static Close_ADGZUORD instance = new Close_ADGZUORD();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Close_ADGZUORD()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Close_ADGZUORD Instance
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'TblAdgZuord.TitleBar100ZuordnungGruppenart'.", repo.TblAdgZuord.TitleBar100ZuordnungGruppenartInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.TblAdgZuord.TitleBar100ZuordnungGruppenart, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
