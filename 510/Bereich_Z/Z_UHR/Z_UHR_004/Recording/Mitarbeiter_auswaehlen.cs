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

namespace Z_UHR_004.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Mitarbeiter_auswaehlen recording.
    /// </summary>
    [TestModule("0b5e6ba0-2a2b-4487-8998-07474810133d", ModuleType.Recording, 1)]
    public partial class Mitarbeiter_auswaehlen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_UHR_004.Z_UHR_004Repository repository.
        /// </summary>
        public static global::Z_UHR_004.Z_UHR_004Repository repo = global::Z_UHR_004.Z_UHR_004Repository.Instance;

        static Mitarbeiter_auswaehlen instance = new Mitarbeiter_auswaehlen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Mitarbeiter_auswaehlen()
        {
            pers_nr = "Z_UHR_004";
            Mitarbeiter = "Z_UHR_004 - Bürger Simon";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Mitarbeiter_auswaehlen Instance
        {
            get { return instance; }
        }

#region Variables

        string _pers_nr;

        /// <summary>
        /// Gets or sets the value of variable pers_nr.
        /// </summary>
        [TestVariable("7526ef53-8247-499e-b816-4933a11e313d")]
        public string pers_nr
        {
            get { return _pers_nr; }
            set { _pers_nr = value; }
        }

        string _Mitarbeiter;

        /// <summary>
        /// Gets or sets the value of variable Mitarbeiter.
        /// </summary>
        [TestVariable("c7d197b7-ed36-4e7e-b077-368ea0fa11e0")]
        public string Mitarbeiter
        {
            get { return _Mitarbeiter; }
            set { _Mitarbeiter = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$pers_nr' with focus on 'FrmUhr.Mitarbeiter_510_521'.", repo.FrmUhr.Mitarbeiter_510_521Info, new RecordItemIndex(0));
            repo.FrmUhr.Mitarbeiter_510_521.PressKeys(pers_nr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Down' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Down, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            // Probleme bei Prüfung sowohl mit Repository als auch mit Variable die ausgelesen werden soll in 521
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nProbleme bei Prüfung sowohl mit Repository als auch mit Variable die ausgelesen werden soll in 521\r\nValidating AttributeEqual (Text=$Mitarbeiter) on item 'FrmUhr.Mitarbeiter_510_521'.", repo.FrmUhr.Mitarbeiter_510_521Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.FrmUhr.Mitarbeiter_510_521Info, "Text", Mitarbeiter, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmUhr.PbExtrasExtras' at Center.", repo.FrmUhr.PbExtrasExtrasInfo, new RecordItemIndex(4));
            repo.FrmUhr.PbExtrasExtras.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Down}{Return}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgKorrekturZeiten.TitleBar100KorrekturMitarbeiterzeit'", repo.DlgKorrekturZeiten.TitleBar100KorrekturMitarbeiterzeitInfo, new ActionTimeout(120000), new RecordItemIndex(6));
            repo.DlgKorrekturZeiten.TitleBar100KorrekturMitarbeiterzeitInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Korrektur Mitarbeiterzeiten') on item 'DlgKorrekturZeiten.TitleBar100KorrekturMitarbeiterzeit'.", repo.DlgKorrekturZeiten.TitleBar100KorrekturMitarbeiterzeitInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.DlgKorrekturZeiten.TitleBar100KorrekturMitarbeiterzeitInfo, "Text", "Korrektur Mitarbeiterzeiten");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
