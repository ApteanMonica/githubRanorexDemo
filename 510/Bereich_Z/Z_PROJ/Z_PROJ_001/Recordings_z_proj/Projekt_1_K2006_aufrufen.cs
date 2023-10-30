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

namespace Z_PROJ_001.Recordings_z_proj
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_1_K2006_aufrufen recording.
    /// </summary>
    [TestModule("703a909d-a45d-4541-a417-aebb70ee50bd", ModuleType.Recording, 1)]
    public partial class Projekt_1_K2006_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_1_K2006_aufrufen instance = new Projekt_1_K2006_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_1_K2006_aufrufen()
        {
            PROJ_NR_1_K = "K2006";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_1_K2006_aufrufen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_1_K.
        /// </summary>
        [TestVariable("aaa74f90-7f05-488e-8be1-83ff8086d632")]
        public string PROJ_NR_1_K
        {
            get { return repo.PROJ_NR_1_K; }
            set { repo.PROJ_NR_1_K = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TitleBar100ProjektVerwalten'.", repo.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.TitleBar100ProjektVerwaltenInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PROJ_NR_1_K' with focus on 'FrmTabProjekt_alt.Text_Suchmaske'.", repo.FrmTabProjekt_alt.Text_SuchmaskeInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt_alt.Text_Suchmaske.PressKeys(PROJ_NR_1_K);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt_alt.PbEdit_Suchmaske' at Center.", repo.FrmTabProjekt_alt.PbEdit_SuchmaskeInfo, new RecordItemIndex(2));
            repo.FrmTabProjekt_alt.PbEdit_Suchmaske.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
