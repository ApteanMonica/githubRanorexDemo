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
    ///The Verbuchen_Meldungen_ER_04_Peri_UVA_NEIN recording.
    /// </summary>
    [TestModule("432d1afa-b3ad-403d-ae28-db5974a3a582", ModuleType.Recording, 1)]
    public partial class Verbuchen_Meldungen_ER_04_Peri_UVA_NEIN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Verbuchen_Meldungen_ER_04_Peri_UVA_NEIN instance = new Verbuchen_Meldungen_ER_04_Peri_UVA_NEIN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchen_Meldungen_ER_04_Peri_UVA_NEIN()
        {
            Jahr = "2018";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchen_Meldungen_ER_04_Peri_UVA_NEIN Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("db595bfc-bd30-47a8-910a-b3b040c8f2c6")]
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

            // ER_04 Meldung Buchungsperiode
            Report.Log(ReportLevel.Info, "Section", "ER_04 Meldung Buchungsperiode", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Prüfen Buchungsperiode') on item 'DlgMessageBox.FakturenPruefung'.", repo.DlgMessageBox.FakturenPruefungInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgMessageBox.FakturenPruefungInfo, "Text", "Prüfen Buchungsperiode");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Buchungen für Periode 2018 / 7 vorhanden,\r\nBuchen nur in Periode 2018 / 6 erlaubt !\r\nBuchung mit der Beleg-Nr: ER_04_B_EXOPV_004 \r\n\r\nBelege in Periode 2018 / 6 buchen ?\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Buchungen für Periode 2018 / 7 vorhanden,\r\nBuchen nur in Periode 2018 / 6 erlaubt !\r\nBuchung mit der Beleg-Nr: ER_04_B_EXOPV_004 \r\n\r\nBelege in Periode 2018 / 6 buchen ?\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button2' at Center.", repo.DlgMessageBox.Button2Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button2.Click();
            
            // ER_04 Meldung UVA-Periode
            Report.Log(ReportLevel.Info, "Section", "ER_04 Meldung UVA-Periode", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(6));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-5 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "UVA für 2018-5 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            // ER_04 Maske UVA-Periode -ablehnen und weiterprüfen
            Report.Log(ReportLevel.Info, "Section", "ER_04 Maske UVA-Periode -ablehnen und weiterprüfen", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgUva.TitleBar100UVADatum'", repo.DlgUva.TitleBar100UVADatumInfo, new ActionTimeout(60000), new RecordItemIndex(10));
            repo.DlgUva.TitleBar100UVADatumInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'UVA-Datum') on item 'DlgUva.TitleBar100UVADatum'.", repo.DlgUva.TitleBar100UVADatumInfo, new RecordItemIndex(11));
            Validate.AttributeContains(repo.DlgUva.TitleBar100UVADatumInfo, "Text", "UVA-Datum");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-05 schon abgeschlossen.') on item 'DlgUva.DfText'.", repo.DlgUva.DfTextInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgUva.DfTextInfo, "Text", "UVA für 2018-05 schon abgeschlossen.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2019') on item 'DlgUva.Jahr_Vorschlag'.", repo.DlgUva.Jahr_VorschlagInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgUva.Jahr_VorschlagInfo, "Text", "2019");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'DlgUva.Monat_Vorschlag'.", repo.DlgUva.Monat_VorschlagInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgUva.Monat_VorschlagInfo, "Text", "5");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUva.PbNichtverwenden' at Center.", repo.DlgUva.PbNichtverwendenInfo, new RecordItemIndex(15));
            repo.DlgUva.PbNichtverwenden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}