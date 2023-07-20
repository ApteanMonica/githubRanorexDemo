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
    ///The Stapel_verbuchen_Meldungen_ER_01_Vorschlag_akzeptieren recording.
    /// </summary>
    [TestModule("7d12990c-9158-4471-9449-7893d0c8a7e6", ModuleType.Recording, 1)]
    public partial class Stapel_verbuchen_Meldungen_ER_01_Vorschlag_akzeptieren : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Stapel_verbuchen_Meldungen_ER_01_Vorschlag_akzeptieren instance = new Stapel_verbuchen_Meldungen_ER_01_Vorschlag_akzeptieren();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Stapel_verbuchen_Meldungen_ER_01_Vorschlag_akzeptieren()
        {
            Jahr = "2018";
            UVA_Monat_13_offen = "13";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Stapel_verbuchen_Meldungen_ER_01_Vorschlag_akzeptieren Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("3fc7fe0b-8d97-47f7-ae76-86a1092938ae")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _UVA_Monat_13_offen;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_13_offen.
        /// </summary>
        [TestVariable("566eb65e-8edc-4e2f-be10-c2a8bfb30e05")]
        public string UVA_Monat_13_offen
        {
            get { return _UVA_Monat_13_offen; }
            set { _UVA_Monat_13_offen = value; }
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

            // ER_01 Meldung Buchungsperiode
            Report.Log(ReportLevel.Info, "Section", "ER_01 Meldung Buchungsperiode", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 4m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(240000), new RecordItemIndex(1));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(240000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Prüfen Buchungsperiode') on item 'DlgMessageBox.FakturenPruefung'.", repo.DlgMessageBox.FakturenPruefungInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgMessageBox.FakturenPruefungInfo, "Text", "Prüfen Buchungsperiode");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(60000), new RecordItemIndex(3));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Buchungen für Periode 2018 / 5 vorhanden,\r\nBuchen nur in Periode 2018 / 6 erlaubt !\r\nBuchung mit der Beleg-Nr: ER_01_B_EXOPV_004 \r\n\r\nBelege in Periode 2018 / 6 buchen ?\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Buchungen für Periode 2018 / 5 vorhanden,\r\nBuchen nur in Periode 2018 / 6 erlaubt !\r\nBuchung mit der Beleg-Nr: ER_01_B_EXOPV_004 \r\n\r\nBelege in Periode 2018 / 6 buchen ?\r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(5));
            repo.DlgMessageBox.Button0.Click();
            
            // ER_01 Meldung UVA-Periode
            Report.Log(ReportLevel.Info, "Section", "ER_01 Meldung UVA-Periode", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(60000), new RecordItemIndex(7));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-4 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "UVA für 2018-4 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(9));
            repo.DlgMessageBox.Button0.Click();
            
            // ER_01 Maske UVA-Periode - neuen UVA-Termin 2018/13 verwenden
            Report.Log(ReportLevel.Info, "Section", "ER_01 Maske UVA-Periode - neuen UVA-Termin 2018/13 verwenden", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgUva.TitleBar100UVADatum'", repo.DlgUva.TitleBar100UVADatumInfo, new ActionTimeout(60000), new RecordItemIndex(11));
            repo.DlgUva.TitleBar100UVADatumInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'UVA-Datum') on item 'DlgUva.TitleBar100UVADatum'.", repo.DlgUva.TitleBar100UVADatumInfo, new RecordItemIndex(12));
            Validate.AttributeContains(repo.DlgUva.TitleBar100UVADatumInfo, "Text", "UVA-Datum");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-04 schon abgeschlossen.') on item 'DlgUva.DfText'.", repo.DlgUva.DfTextInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgUva.DfTextInfo, "Text", "UVA für 2018-04 schon abgeschlossen.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'DlgUva.Jahr_Vorschlag'.", repo.DlgUva.Jahr_VorschlagInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgUva.Jahr_VorschlagInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_13_offen) on item 'DlgUva.Monat_Vorschlag'.", repo.DlgUva.Monat_VorschlagInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.DlgUva.Monat_VorschlagInfo, "Text", UVA_Monat_13_offen);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgUva.PbVerwenden' at Center.", repo.DlgUva.PbVerwendenInfo, new RecordItemIndex(16));
            repo.DlgUva.PbVerwenden.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(17));
            Delay.Duration(2000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
