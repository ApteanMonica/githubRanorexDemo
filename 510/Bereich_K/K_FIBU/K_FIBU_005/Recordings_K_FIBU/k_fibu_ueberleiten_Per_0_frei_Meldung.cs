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

namespace K_FIBU_005.Recordings_K_FIBU
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The k_fibu_ueberleiten_Per_0_frei_Meldung recording.
    /// </summary>
    [TestModule("db663c10-6e1d-4d22-a197-66523fa8e75e", ModuleType.Recording, 1)]
    public partial class K_fibu_ueberleiten_Per_0_frei_Meldung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::K_FIBU_005.K_FIBU_005Repository repository.
        /// </summary>
        public static global::K_FIBU_005.K_FIBU_005Repository repo = global::K_FIBU_005.K_FIBU_005Repository.Instance;

        static K_fibu_ueberleiten_Per_0_frei_Meldung instance = new K_fibu_ueberleiten_Per_0_frei_Meldung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public K_fibu_ueberleiten_Per_0_frei_Meldung()
        {
            Periode_von = "01";
            Periode_bis = "02";
            Jahr = "2017";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static K_fibu_ueberleiten_Per_0_frei_Meldung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Periode_von;

        /// <summary>
        /// Gets or sets the value of variable Periode_von.
        /// </summary>
        [TestVariable("b7f2b96d-8b37-4c13-ae25-d6fc9fe1d9c1")]
        public string Periode_von
        {
            get { return _Periode_von; }
            set { _Periode_von = value; }
        }

        string _Periode_bis;

        /// <summary>
        /// Gets or sets the value of variable Periode_bis.
        /// </summary>
        [TestVariable("0d27aafd-db3d-4be4-8654-2a8cec027da1")]
        public string Periode_bis
        {
            get { return _Periode_bis; }
            set { _Periode_bis = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("bf77fa50-f9b8-44f3-a56f-0880d413271e")]
        public string Jahr
        {
            get { return repo.Jahr; }
            set { repo.Jahr = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmVerbuch.TitleBar100BereichsSummierung'.", repo.FrmVerbuch.TitleBar100BereichsSummierungInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmVerbuch.TitleBar100BereichsSummierungInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'FrmVerbuch.JahrPeriode'.", repo.FrmVerbuch.JahrPeriodeInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmVerbuch.JahrPeriodeInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode_von) on item 'FrmVerbuch.Text'.", repo.FrmVerbuch.TextInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmVerbuch.TextInfo, "Text", Periode_von);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'FrmVerbuch.Bis'.", repo.FrmVerbuch.BisInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmVerbuch.BisInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Periode_bis) on item 'FrmVerbuch.Text1'.", repo.FrmVerbuch.Text1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmVerbuch.Text1Info, "Text", Periode_bis);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmVerbuch.PbOK' at Center.", repo.FrmVerbuch.PbOKInfo, new RecordItemIndex(5));
            repo.FrmVerbuch.PbOK.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(6));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Die Periode <2> ist für die Kostenrechnung gesperrt!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Die Periode <2> ist für die Kostenrechnung gesperrt!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(9));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summierung beendet!\r\nHINWEIS: Aufgrund von Fehlern konnte die Bereichs-Summierung nicht vollständig durchgeführt werden!\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Summierung beendet!\r\nHINWEIS: Aufgrund von Fehlern konnte die Bereichs-Summierung nicht vollständig durchgeführt werden!\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(11));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
