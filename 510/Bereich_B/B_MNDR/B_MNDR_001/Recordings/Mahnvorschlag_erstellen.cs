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

namespace B_MNDR_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Mahnvorschlag_erstellen recording.
    /// </summary>
    [TestModule("406322ae-10f3-4510-8ad6-37cc6be3d4bd", ModuleType.Recording, 1)]
    public partial class Mahnvorschlag_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_MNDR_001.B_MNDR_001Repository repository.
        /// </summary>
        public static global::B_MNDR_001.B_MNDR_001Repository repo = global::B_MNDR_001.B_MNDR_001Repository.Instance;

        static Mahnvorschlag_erstellen instance = new Mahnvorschlag_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Mahnvorschlag_erstellen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Mahnvorschlag_erstellen Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblMndt.Button_Vorschlag_erstellenPbCommonErstellen' at Center.", repo.TblMndt.Button_Vorschlag_erstellenPbCommonErstellenInfo, new RecordItemIndex(0));
            repo.TblMndt.Button_Vorschlag_erstellenPbCommonErstellen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmVorschlagErstellen.TitleBar100MahnvorschlagErstellenK'", repo.FrmVorschlagErstellen.TitleBar100MahnvorschlagErstellenKInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.FrmVorschlagErstellen.TitleBar100MahnvorschlagErstellenKInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Mahnvorschlag erstellen Kunden') on item 'FrmVorschlagErstellen.TitleBar100MahnvorschlagErstellenK'.", repo.FrmVorschlagErstellen.TitleBar100MahnvorschlagErstellenKInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.FrmVorschlagErstellen.TitleBar100MahnvorschlagErstellenKInfo, "Text", "Mahnvorschlag erstellen Kunden");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
