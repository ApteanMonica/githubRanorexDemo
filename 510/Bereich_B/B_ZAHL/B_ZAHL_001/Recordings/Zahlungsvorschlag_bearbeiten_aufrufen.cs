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

namespace B_ZAHL_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zahlungsvorschlag_bearbeiten_aufrufen recording.
    /// </summary>
    [TestModule("346b9f4c-4b65-4c39-932b-6007b1eebda0", ModuleType.Recording, 1)]
    public partial class Zahlungsvorschlag_bearbeiten_aufrufen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_001.B_ZAHL_001Repository repository.
        /// </summary>
        public static global::B_ZAHL_001.B_ZAHL_001Repository repo = global::B_ZAHL_001.B_ZAHL_001Repository.Instance;

        static Zahlungsvorschlag_bearbeiten_aufrufen instance = new Zahlungsvorschlag_bearbeiten_aufrufen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zahlungsvorschlag_bearbeiten_aufrufen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zahlungsvorschlag_bearbeiten_aufrufen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.PbDataAcessEdit' at Center.", repo.FrmZahlMain.PbDataAcessEditInfo, new RecordItemIndex(0));
            repo.FrmZahlMain.PbDataAcessEdit.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten - Zahlvorschlag bearbeiten:') on item 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'.", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, "Text", "Lieferanten - Zahlvorschlag bearbeiten:");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.PbDataAccessLaden' at Center.", repo.FrmZlvsAEndern.PbDataAccessLadenInfo, new RecordItemIndex(3));
            repo.FrmZlvsAEndern.PbDataAccessLaden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}