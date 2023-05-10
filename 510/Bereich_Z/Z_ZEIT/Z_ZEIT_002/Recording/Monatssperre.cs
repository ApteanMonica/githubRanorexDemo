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

namespace Z_ZEIT_002.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Monatssperre recording.
    /// </summary>
    [TestModule("0f68f881-24f0-4c04-a6f3-2a84378f812d", ModuleType.Recording, 1)]
    public partial class Monatssperre : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_ZEIT_002.Z_ZEIT_002Repository repository.
        /// </summary>
        public static global::Z_ZEIT_002.Z_ZEIT_002Repository repo = global::Z_ZEIT_002.Z_ZEIT_002Repository.Instance;

        static Monatssperre instance = new Monatssperre();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Monatssperre()
        {
            Sperrzeitraum_Monat = "01";
            Sperrzeitraum_Jahr = "2000";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Monatssperre Instance
        {
            get { return instance; }
        }

#region Variables

        string _Sperrzeitraum_Monat;

        /// <summary>
        /// Gets or sets the value of variable Sperrzeitraum_Monat.
        /// </summary>
        [TestVariable("8a7f0cba-99ac-4f59-bd64-fc67cef2fe49")]
        public string Sperrzeitraum_Monat
        {
            get { return _Sperrzeitraum_Monat; }
            set { _Sperrzeitraum_Monat = value; }
        }

        string _Sperrzeitraum_Jahr;

        /// <summary>
        /// Gets or sets the value of variable Sperrzeitraum_Jahr.
        /// </summary>
        [TestVariable("98e34796-e158-4790-9a93-8d8ee1069d17")]
        public string Sperrzeitraum_Jahr
        {
            get { return _Sperrzeitraum_Jahr; }
            set { _Sperrzeitraum_Jahr = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiZeit.PbExtrasExtras' at Center.", repo.MdiZeit.PbExtrasExtrasInfo, new RecordItemIndex(0));
            repo.MdiZeit.PbExtrasExtras.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Down' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMonateSperren.TitleBar100MonateSperren'", repo.DlgMonateSperren.TitleBar100MonateSperrenInfo, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.DlgMonateSperren.TitleBar100MonateSperrenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Monate sperren') on item 'DlgMonateSperren.TitleBar100MonateSperren'.", repo.DlgMonateSperren.TitleBar100MonateSperrenInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgMonateSperren.TitleBar100MonateSperrenInfo, "Text", "Monate sperren");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgMonateSperren.DfMonatSperre' at Center.", repo.DlgMonateSperren.DfMonatSperreInfo, new RecordItemIndex(5));
            repo.DlgMonateSperren.DfMonatSperre.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}01' with focus on 'DlgMonateSperren.DfMonatSperre'.", repo.DlgMonateSperren.DfMonatSperreInfo, new RecordItemIndex(6));
            repo.DlgMonateSperren.DfMonatSperre.PressKeys("{Delete}01");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgMonateSperren.DfJahrSperre' at Center.", repo.DlgMonateSperren.DfJahrSperreInfo, new RecordItemIndex(7));
            repo.DlgMonateSperren.DfJahrSperre.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}2000' with focus on 'DlgMonateSperren.DfJahrSperre'.", repo.DlgMonateSperren.DfJahrSperreInfo, new RecordItemIndex(8));
            repo.DlgMonateSperren.DfJahrSperre.PressKeys("{Delete}2000");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
