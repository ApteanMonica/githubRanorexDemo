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

namespace S_FUGR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CloseAUT_FUGR recording.
    /// </summary>
    [TestModule("3912fa9b-36aa-4671-8206-9074245ac912", ModuleType.Recording, 1)]
    public partial class CloseAUT_FUGR : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository repo = global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository.Instance;

        static CloseAUT_FUGR instance = new CloseAUT_FUGR();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CloseAUT_FUGR()
        {
            CloseAutProcessIDVar = "-1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CloseAUT_FUGR Instance
        {
            get { return instance; }
        }

#region Variables

        string _CloseAutProcessIDVar;

        /// <summary>
        /// Gets or sets the value of variable CloseAutProcessIDVar.
        /// </summary>
        [TestVariable("f3dd1c9d-f06e-456e-86c4-133431089d56")]
        public string CloseAutProcessIDVar
        {
            get { return _CloseAutProcessIDVar; }
            set { _CloseAutProcessIDVar = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'TblSFugr.TitleBar100Funktionsgruppen'.", repo.TblSFugr.TitleBar100FunktionsgruppenInfo, new RecordItemIndex(0));
            Host.Current.CloseApplication(repo.TblSFugr.TitleBar100Funktionsgruppen, 1000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
