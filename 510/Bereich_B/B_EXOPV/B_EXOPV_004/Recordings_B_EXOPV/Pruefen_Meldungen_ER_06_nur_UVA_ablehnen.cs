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

namespace B_EXOPV_004.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefen_Meldungen_ER_06_nur_UVA_ablehnen recording.
    /// </summary>
    [TestModule("b639a367-8acb-4756-8001-f1e5bb06fa39", ModuleType.Recording, 1)]
    public partial class Pruefen_Meldungen_ER_06_nur_UVA_ablehnen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Pruefen_Meldungen_ER_06_nur_UVA_ablehnen instance = new Pruefen_Meldungen_ER_06_nur_UVA_ablehnen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefen_Meldungen_ER_06_nur_UVA_ablehnen()
        {
            Jahr = "2018";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefen_Meldungen_ER_06_nur_UVA_ablehnen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("3cd1f159-ef5b-401c-9ccc-657be75cb452")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(60000), new RecordItemIndex(0));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-5 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "UVA für 2018-5 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgUva.TitleBar100UVADatum'", repo.DlgUva.TitleBar100UVADatumInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.DlgUva.TitleBar100UVADatumInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'UVA-Datum') on item 'DlgUva.TitleBar100UVADatum'.", repo.DlgUva.TitleBar100UVADatumInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgUva.TitleBar100UVADatumInfo, "Text", "UVA-Datum");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-05 schon abgeschlossen.') on item 'DlgUva.DfText'.", repo.DlgUva.DfTextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgUva.DfTextInfo, "Text", "UVA für 2018-05 schon abgeschlossen.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2019') on item 'DlgUva.Jahr_Vorschlag'.", repo.DlgUva.Jahr_VorschlagInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgUva.Jahr_VorschlagInfo, "Text", "2019");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'DlgUva.Monat_Vorschlag'.", repo.DlgUva.Monat_VorschlagInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgUva.Monat_VorschlagInfo, "Text", "5");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUva.PbNichtverwenden' at Center.", repo.DlgUva.PbNichtverwendenInfo, new RecordItemIndex(8));
            repo.DlgUva.PbNichtverwenden.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(9));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
