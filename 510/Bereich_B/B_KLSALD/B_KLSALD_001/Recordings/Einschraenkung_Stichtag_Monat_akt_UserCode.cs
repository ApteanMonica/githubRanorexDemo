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

namespace B_KLSALD_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkung_Stichtag_Monat_akt_UserCode recording.
    /// </summary>
    [TestModule("38579cfe-4ab7-468a-a771-581156636365", ModuleType.Recording, 1)]
    public partial class Einschraenkung_Stichtag_Monat_akt_UserCode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLSALD_001.B_KLSALD_001Repository repository.
        /// </summary>
        public static global::B_KLSALD_001.B_KLSALD_001Repository repo = global::B_KLSALD_001.B_KLSALD_001Repository.Instance;

        static Einschraenkung_Stichtag_Monat_akt_UserCode instance = new Einschraenkung_Stichtag_Monat_akt_UserCode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkung_Stichtag_Monat_akt_UserCode()
        {
            Jahr_aktuell_yyyy = "";
            Monat_aktuell_M = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkung_Stichtag_Monat_akt_UserCode Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr_aktuell_yyyy;

        /// <summary>
        /// Gets or sets the value of variable Jahr_aktuell_yyyy.
        /// </summary>
        [TestVariable("4c42402a-14ca-4f86-bbad-68ae0014a1f7")]
        public string Jahr_aktuell_yyyy
        {
            get { return _Jahr_aktuell_yyyy; }
            set { _Jahr_aktuell_yyyy = value; }
        }

        string _Monat_aktuell_M;

        /// <summary>
        /// Gets or sets the value of variable Monat_aktuell_M.
        /// </summary>
        [TestVariable("4e408e73-32e8-4cbe-bdb5-0d7a5dfe7ab2")]
        public string Monat_aktuell_M
        {
            get { return _Monat_aktuell_M; }
            set { _Monat_aktuell_M = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmKLSL.RbStichtagsliste' at Center.", repo.FrmKLSL.RbStichtagslisteInfo, new RecordItemIndex(0));
            repo.FrmKLSL.RbStichtagsliste.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmKLSL.RbStichtagsliste_TRUE'", repo.FrmKLSL.RbStichtagsliste_TRUEInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.FrmKLSL.RbStichtagsliste_TRUEInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmKLSL.RbStichtagsliste'.", repo.FrmKLSL.RbStichtagslisteInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmKLSL.RbStichtagslisteInfo, "Checked", "True");
            
            Jahr_aktuell_yyyy = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetSystemDateTimeAsString("yyyy");
            
            Monat_aktuell_M = Ranorex.AutomationHelpers.UserCodeCollections.Aptean.GetSystemDateTimeAsString("M");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Saldenliste per Stichtag: Kunden') on item 'FrmKLSL.TitleBar100SaldenlistePerStichtag'.", repo.FrmKLSL.TitleBar100SaldenlistePerStichtagInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmKLSL.TitleBar100SaldenlistePerStichtagInfo, "Text", "Saldenliste per Stichtag: Kunden");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmKLSL.Einschraenkungen.CbSummeSamk'.", repo.FrmKLSL.Einschraenkungen.CbSummeSamkInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmKLSL.Einschraenkungen.CbSummeSamkInfo, "Checked", "True");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
