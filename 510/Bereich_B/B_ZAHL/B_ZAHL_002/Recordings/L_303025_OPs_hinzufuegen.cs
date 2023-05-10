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

namespace B_ZAHL_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The L_303025_OPs_hinzufuegen recording.
    /// </summary>
    [TestModule("54419ea4-2d56-4fcf-ab2b-6038b55fb42f", ModuleType.Recording, 1)]
    public partial class L_303025_OPs_hinzufuegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_002.B_ZAHL_002Repository repository.
        /// </summary>
        public static global::B_ZAHL_002.B_ZAHL_002Repository repo = global::B_ZAHL_002.B_ZAHL_002Repository.Instance;

        static L_303025_OPs_hinzufuegen instance = new L_303025_OPs_hinzufuegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public L_303025_OPs_hinzufuegen()
        {
            LF_303025 = "303025";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static L_303025_OPs_hinzufuegen Instance
        {
            get { return instance; }
        }

#region Variables

        string _LF_303025;

        /// <summary>
        /// Gets or sets the value of variable LF_303025.
        /// </summary>
        [TestVariable("093b81d9-c471-46e4-9cc1-44a09c47d4e8")]
        public string LF_303025
        {
            get { return _LF_303025; }
            set { _LF_303025 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.PbToolBarItemsOPAuswahl' at Center.", repo.FrmZlvsAEndern.PbToolBarItemsOPAuswahlInfo, new RecordItemIndex(0));
            repo.FrmZlvsAEndern.PbToolBarItemsOPAuswahl.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgBuopSuch.TitleBar100AuswahlFuerOPSuche'", repo.DlgBuopSuch.TitleBar100AuswahlFuerOPSucheInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.DlgBuopSuch.TitleBar100AuswahlFuerOPSucheInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Auswahl für OP-Suche') on item 'DlgBuopSuch.TitleBar100AuswahlFuerOPSuche'.", repo.DlgBuopSuch.TitleBar100AuswahlFuerOPSucheInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgBuopSuch.TitleBar100AuswahlFuerOPSucheInfo, "Text", "Auswahl für OP-Suche");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LF_303025' with focus on 'DlgBuopSuch.AdrNr'.", repo.DlgBuopSuch.AdrNrInfo, new RecordItemIndex(3));
            repo.DlgBuopSuch.AdrNr.PressKeys(LF_303025);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBuopSuch.PbOk' at Center.", repo.DlgBuopSuch.PbOkInfo, new RecordItemIndex(4));
            repo.DlgBuopSuch.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
