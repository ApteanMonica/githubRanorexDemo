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

namespace S_GAA_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Loeschen_Gaereteart_Neu recording.
    /// </summary>
    [TestModule("868f0f04-ad91-4567-9657-f4f88c9229c6", ModuleType.Recording, 1)]
    public partial class Loeschen_Gaereteart_Neu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_GAA_Schnelltest.S_GAA_SchnelltestRepository repository.
        /// </summary>
        public static global::S_GAA_Schnelltest.S_GAA_SchnelltestRepository repo = global::S_GAA_Schnelltest.S_GAA_SchnelltestRepository.Instance;

        static Loeschen_Gaereteart_Neu instance = new Loeschen_Gaereteart_Neu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_Gaereteart_Neu()
        {
            GAERETEART_NEU = "ART_NEU";
            GAERETEART_NEU_BEZEICHNUNG = "TEXT_ART_NEU";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_Gaereteart_Neu Instance
        {
            get { return instance; }
        }

#region Variables

        string _GAERETEART_NEU_BEZEICHNUNG;

        /// <summary>
        /// Gets or sets the value of variable GAERETEART_NEU_BEZEICHNUNG.
        /// </summary>
        [TestVariable("e37923d8-e2c6-4e09-9895-9928a8cc17b5")]
        public string GAERETEART_NEU_BEZEICHNUNG
        {
            get { return _GAERETEART_NEU_BEZEICHNUNG; }
            set { _GAERETEART_NEU_BEZEICHNUNG = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable GAERETEART_NEU.
        /// </summary>
        [TestVariable("1cd1ebb8-0b0b-4475-a0c8-67f2b70387fc")]
        public string GAERETEART_NEU
        {
            get { return repo.GAERETEART_NEU; }
            set { repo.GAERETEART_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSGAA.RibbonBar.PbNavigationBack' at Center.", repo.FrmSGAA.RibbonBar.PbNavigationBackInfo, new RecordItemIndex(0));
            repo.FrmSGAA.RibbonBar.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSGAA.TitleBar100GeraeteartenVerwalten'", repo.FrmSGAA.TitleBar100GeraeteartenVerwaltenInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmSGAA.TitleBar100GeraeteartenVerwaltenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmSGAA.Row_mit_Variable_Gaereteart_Neu'.", repo.FrmSGAA.Row_mit_Variable_Gaereteart_Neu.SelfInfo, new RecordItemIndex(2));
            Validate.Exists(repo.FrmSGAA.Row_mit_Variable_Gaereteart_Neu.SelfInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmSGAA.Row_mit_Variable_Gaereteart_Neu' at Center.", repo.FrmSGAA.Row_mit_Variable_Gaereteart_Neu.SelfInfo, new RecordItemIndex(3));
            repo.FrmSGAA.Row_mit_Variable_Gaereteart_Neu.Self.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSGAA.TitleBar100GeraeteartenVerwalten'", repo.FrmSGAA.TitleBar100GeraeteartenVerwaltenInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.FrmSGAA.TitleBar100GeraeteartenVerwaltenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSGAA.RibbonBar.PbCommon2Loeschen' at Center.", repo.FrmSGAA.RibbonBar.PbCommon2LoeschenInfo, new RecordItemIndex(5));
            repo.FrmSGAA.RibbonBar.PbCommon2Loeschen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSGAA.RibbonBar.PbNavigationBack' at Center.", repo.FrmSGAA.RibbonBar.PbNavigationBackInfo, new RecordItemIndex(6));
            repo.FrmSGAA.RibbonBar.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSGAA.TitleBar100GeraeteartenVerwalten'", repo.FrmSGAA.TitleBar100GeraeteartenVerwaltenInfo, new ActionTimeout(120000), new RecordItemIndex(7));
            repo.FrmSGAA.TitleBar100GeraeteartenVerwaltenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'FrmSGAA.Row_mit_Variable_Gaereteart_Neu'.", repo.FrmSGAA.Row_mit_Variable_Gaereteart_Neu.SelfInfo, new RecordItemIndex(8));
            Validate.NotExists(repo.FrmSGAA.Row_mit_Variable_Gaereteart_Neu.SelfInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
