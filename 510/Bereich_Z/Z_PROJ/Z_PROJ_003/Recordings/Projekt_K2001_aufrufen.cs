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

namespace Z_PROJ_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_K2001_aufrufen recording.
    /// </summary>
    [TestModule("732c6b78-fccf-41a8-a637-ac7738b7013a", ModuleType.Recording, 1)]
    public partial class Projekt_K2001_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_003.Z_PROJ_003Repository repository.
        /// </summary>
        public static global::Z_PROJ_003.Z_PROJ_003Repository repo = global::Z_PROJ_003.Z_PROJ_003Repository.Instance;

        static Projekt_K2001_aufrufen instance = new Projekt_K2001_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_K2001_aufrufen()
        {
            PROJ_NR_K2001_K = "K2001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_K2001_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        string _PROJ_NR_K2001_K;

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_K2001_K.
        /// </summary>
        [TestVariable("9a6c4536-09b4-4fd6-b87a-2e0c702b1e19")]
        public string PROJ_NR_K2001_K
        {
            get { return _PROJ_NR_K2001_K; }
            set { _PROJ_NR_K2001_K = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmTabProjekt.TitleBar100ProjektVerwalten'.", repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PROJ_NR_K2001_K' with focus on 'FrmTabProjekt.Suche.Text'.", repo.FrmTabProjekt.Suche.TextInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt.Suche.Text.PressKeys(PROJ_NR_K2001_K);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Suche.PbEdit' at Center.", repo.FrmTabProjekt.Suche.PbEditInfo, new RecordItemIndex(2));
            repo.FrmTabProjekt.Suche.PbEdit.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
