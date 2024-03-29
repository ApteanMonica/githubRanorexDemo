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

namespace Z_ZEIT_001.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MA_laden recording.
    /// </summary>
    [TestModule("d8c2559d-8d64-4cd3-8931-df64a0275fc8", ModuleType.Recording, 1)]
    public partial class MA_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_ZEIT_001.Z_ZEIT_001Repository repository.
        /// </summary>
        public static global::Z_ZEIT_001.Z_ZEIT_001Repository repo = global::Z_ZEIT_001.Z_ZEIT_001Repository.Instance;

        static MA_laden instance = new MA_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MA_laden()
        {
            Personalnr = "ZEIT_001_G";
            Einschraenkungsmonat = "10";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MA_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Personalnr;

        /// <summary>
        /// Gets or sets the value of variable Personalnr.
        /// </summary>
        [TestVariable("c410b02c-34a9-4c47-aff7-9599fa8207c0")]
        public string Personalnr
        {
            get { return _Personalnr; }
            set { _Personalnr = value; }
        }

        string _Einschraenkungsmonat;

        /// <summary>
        /// Gets or sets the value of variable Einschraenkungsmonat.
        /// </summary>
        [TestVariable("f59ed164-b9a0-4c3b-b3a3-1fc878dd7679")]
        public string Einschraenkungsmonat
        {
            get { return _Einschraenkungsmonat; }
            set { _Einschraenkungsmonat = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiZeit.Mitarbeiter' at Center.", repo.MdiZeit.MitarbeiterInfo, new RecordItemIndex(0));
            repo.MdiZeit.Mitarbeiter.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'MdiZeit.Mitarbeiter'.", repo.MdiZeit.MitarbeiterInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.MdiZeit.Mitarbeiter);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Personalnr' with focus on 'MdiZeit.Mitarbeiter'.", repo.MdiZeit.MitarbeiterInfo, new RecordItemIndex(2));
            repo.MdiZeit.Mitarbeiter.PressKeys(Personalnr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiZeit.DfJahr' at Center.", repo.MdiZeit.DfJahrInfo, new RecordItemIndex(4));
            repo.MdiZeit.DfJahr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}2022'.", new RecordItemIndex(5));
            Keyboard.Press("{Delete}2022");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiZeit.DfMonat' at Center.", repo.MdiZeit.DfMonatInfo, new RecordItemIndex(6));
            repo.MdiZeit.DfMonat.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'MdiZeit.DfMonat'.", repo.MdiZeit.DfMonatInfo, new RecordItemIndex(7));
            Keyboard.PrepareFocus(repo.MdiZeit.DfMonat);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Einschraenkungsmonat' with focus on 'MdiZeit.DfMonat'.", repo.MdiZeit.DfMonatInfo, new RecordItemIndex(8));
            repo.MdiZeit.DfMonat.PressKeys(Einschraenkungsmonat);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
