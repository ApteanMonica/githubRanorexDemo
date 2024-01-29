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
    ///The Loeschen_Funktionsart_Neu recording.
    /// </summary>
    [TestModule("02a881cb-df7b-4237-b49d-9e0e33c7547b", ModuleType.Recording, 1)]
    public partial class Loeschen_Funktionsart_Neu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository repo = global::S_FUGR_Schnelltest.S_FUGR_SchnelltestRepository.Instance;

        static Loeschen_Funktionsart_Neu instance = new Loeschen_Funktionsart_Neu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_Funktionsart_Neu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_Funktionsart_Neu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable FUNKTIONSART_NEU.
        /// </summary>
        [TestVariable("6e5941ab-c3fa-4649-9608-cd38c203afa3")]
        public string FUNKTIONSART_NEU
        {
            get { return repo.FUNKTIONSART_NEU; }
            set { repo.FUNKTIONSART_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblSFuga.FlexGrid.Row_mit_Variable_Funktionsart_Neu' at 14;6.", repo.TblSFuga.FlexGrid.Row_mit_Variable_Funktionsart_Neu.SelfInfo, new RecordItemIndex(0));
            repo.TblSFuga.FlexGrid.Row_mit_Variable_Funktionsart_Neu.Self.Click("14;6");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(1));
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblSFuga.RibbonBar.PbDataAccessSave' at Center.", repo.TblSFuga.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(2));
            repo.TblSFuga.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'TblSFuga.FlexGrid.Row_mit_Variable_Funktionsart_Neu'.", repo.TblSFuga.FlexGrid.Row_mit_Variable_Funktionsart_Neu.SelfInfo, new RecordItemIndex(3));
            Validate.NotExists(repo.TblSFuga.FlexGrid.Row_mit_Variable_Funktionsart_Neu.SelfInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}