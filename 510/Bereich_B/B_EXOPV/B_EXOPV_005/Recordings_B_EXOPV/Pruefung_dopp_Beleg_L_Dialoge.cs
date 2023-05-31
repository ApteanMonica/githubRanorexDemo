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

namespace B_EXOPV_005.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_dopp_Beleg_L_Dialoge recording.
    /// </summary>
    [TestModule("358790d0-4e14-46fe-828e-be724e2022a1", ModuleType.Recording, 1)]
    public partial class Pruefung_dopp_Beleg_L_Dialoge : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_005.B_EXOPV_005Repository repository.
        /// </summary>
        public static global::B_EXOPV_005.B_EXOPV_005Repository repo = global::B_EXOPV_005.B_EXOPV_005Repository.Instance;

        static Pruefung_dopp_Beleg_L_Dialoge instance = new Pruefung_dopp_Beleg_L_Dialoge();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_dopp_Beleg_L_Dialoge()
        {
            Fehlerprotokoll_Pruefung = "c:\\temp\\Fehlerprotokoll_b_exopv_005_pruef.txt";
            Beleg_ER01_FB01_LF01_OP = "ER_01_B_EXOPV_005";
            Beleg_ER03_FB03_LF02_OP = "ER_03_B_EXOPV_005";
            LF_01 = "303201";
            LF_02 = "303202";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_dopp_Beleg_L_Dialoge Instance
        {
            get { return instance; }
        }

#region Variables

        string _Fehlerprotokoll_Pruefung;

        /// <summary>
        /// Gets or sets the value of variable Fehlerprotokoll_Pruefung.
        /// </summary>
        [TestVariable("a44d4820-852d-4c33-9a5e-26d0c8753b77")]
        public string Fehlerprotokoll_Pruefung
        {
            get { return _Fehlerprotokoll_Pruefung; }
            set { _Fehlerprotokoll_Pruefung = value; }
        }

        string _Beleg_ER01_FB01_LF01_OP;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER01_FB01_LF01_OP.
        /// </summary>
        [TestVariable("1f018603-2457-4650-b32a-375f8b7ec07c")]
        public string Beleg_ER01_FB01_LF01_OP
        {
            get { return _Beleg_ER01_FB01_LF01_OP; }
            set { _Beleg_ER01_FB01_LF01_OP = value; }
        }

        string _Beleg_ER03_FB03_LF02_OP;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER03_FB03_LF02_OP.
        /// </summary>
        [TestVariable("2a91abe8-ec26-4696-8bea-57e8bd533c4d")]
        public string Beleg_ER03_FB03_LF02_OP
        {
            get { return _Beleg_ER03_FB03_LF02_OP; }
            set { _Beleg_ER03_FB03_LF02_OP = value; }
        }

        string _LF_01;

        /// <summary>
        /// Gets or sets the value of variable LF_01.
        /// </summary>
        [TestVariable("bc21bb92-472a-4554-aa1b-3c095fcb6ff1")]
        public string LF_01
        {
            get { return _LF_01; }
            set { _LF_01 = value; }
        }

        string _LF_02;

        /// <summary>
        /// Gets or sets the value of variable LF_02.
        /// </summary>
        [TestVariable("38d8351a-ae3e-4f48-a34f-bf2101fe0e21")]
        public string LF_02
        {
            get { return _LF_02; }
            set { _LF_02 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Stapel_Herkunft.
        /// </summary>
        [TestVariable("80147ceb-e943-46c5-a7c1-f05b59ef1cce")]
        public string Stapel_Herkunft
        {
            get { return repo.Stapel_Herkunft; }
            set { repo.Stapel_Herkunft = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_005.Column0_Stapel1' at Center.", repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_005.Column0_Stapel1Info, new RecordItemIndex(0));
            repo.Form100ExterneBuchungenVerbuchen.Tabelle_Zeilen.Zeile_mit_Stapel_Herkunft_B_EXOPV_005.Column0_Stapel1.Click();
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$Fehlerprotokoll_Pruefung' on item 'Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll'.", repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_PruefprotokollInfo, new RecordItemIndex(1));
            repo.Form100ExterneBuchungenVerbuchen.Text_Pfad_Pruefprotokoll.Element.SetAttributeValue("Text", Fehlerprotokoll_Pruefung);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100ExterneBuchungenVerbuchen.PbCommonPruefen' at Center.", repo.Form100ExterneBuchungenVerbuchen.PbCommonPruefenInfo, new RecordItemIndex(2));
            repo.Form100ExterneBuchungenVerbuchen.PbCommonPruefen.Click();
            
            // Meldung1_Beleg
            Report.Log(ReportLevel.Info, "Section", "Meldung1_Beleg", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgBelegnrFehler.TitleBar100BelegNrFehler'", repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'DlgBelegnrFehler.Frame2.DfAdrNr'.", repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Beleg im selben Jahr schon als OP vorhanden !') on item 'DlgBelegnrFehler.Frame2.Label3'.", repo.DlgBelegnrFehler.Frame2.Label3Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgBelegnrFehler.Frame2.Label3Info, "Text", "Beleg im selben Jahr schon als OP vorhanden !");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER01_FB01_LF01_OP) on item 'DlgBelegnrFehler.Frame2.DfBelegNr'.", repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, "Text", Beleg_ER01_FB01_LF01_OP, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER01_FB01_LF01_OP) on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", Beleg_ER01_FB01_LF01_OP, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBelegnrFehler.PbUEber' at Center.", repo.DlgBelegnrFehler.PbUEberInfo, new RecordItemIndex(9));
            repo.DlgBelegnrFehler.PbUEber.Click();
            
            // Meldung2_Fremdbeleg Lieferant 01
            Report.Log(ReportLevel.Info, "Section", "Meldung2_Fremdbeleg Lieferant 01", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new ActionTimeout(60000), new RecordItemIndex(11));
            repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(13));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='FB01_B_EXOPV_005') on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(14));
                Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", "FB01_B_EXOPV_005", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='FB01_B_EXOPV_005') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB01_B_EXOPV_005", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbUEber' at Center.", repo.DlgFremdbelegnrFehler.PbUEberInfo, new RecordItemIndex(16));
            repo.DlgFremdbelegnrFehler.PbUEber.Click();
            
            // Meldung3_Fremdbeleg LF 01
            Report.Log(ReportLevel.Info, "Section", "Meldung3_Fremdbeleg LF 01", new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new ActionTimeout(60000), new RecordItemIndex(18));
            repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_01) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_01);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(20));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='FB02_B_EXOPV_005') on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(21));
                Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", "FB02_B_EXOPV_005", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='FB02_B_EXOPV_005') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB02_B_EXOPV_005", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbUEber' at Center.", repo.DlgFremdbelegnrFehler.PbUEberInfo, new RecordItemIndex(23));
            repo.DlgFremdbelegnrFehler.PbUEber.Click();
            
            // Meldung 4 Lieferant 02
            Report.Log(ReportLevel.Info, "Section", "Meldung 4 Lieferant 02", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgBelegnrFehler.TitleBar100BelegNrFehler'", repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo, new ActionTimeout(60000), new RecordItemIndex(25));
            repo.DlgBelegnrFehler.TitleBar100BelegNrFehlerInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'DlgBelegnrFehler.Frame2.DfAdrNr'.", repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_02);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER03_FB03_LF02_OP) on item 'DlgBelegnrFehler.Frame2.DfBelegNr'.", repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(27));
                Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.DfBelegNrInfo, "Text", Beleg_ER03_FB03_LF02_OP, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER03_FB03_LF02_OP) on item 'DlgBelegnrFehler.Frame2.NeueBelegNr'.", repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, new RecordItemIndex(28));
                Validate.AttributeEqual(repo.DlgBelegnrFehler.Frame2.NeueBelegNrInfo, "Text", Beleg_ER03_FB03_LF02_OP, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgBelegnrFehler.PbUEber' at Center.", repo.DlgBelegnrFehler.PbUEberInfo, new RecordItemIndex(29));
            repo.DlgBelegnrFehler.PbUEber.Click();
            
            // Meldung5_Fremdbeleg Lieferant 02
            Report.Log(ReportLevel.Info, "Section", "Meldung5_Fremdbeleg Lieferant 02", new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehler'", repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo, new ActionTimeout(60000), new RecordItemIndex(31));
            repo.DlgFremdbelegnrFehler.TitleBar100FremdbelegNrFehlerInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LF_02) on item 'DlgFremdbelegnrFehler.Frame2.DfAdrNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfAdrNrInfo, "Text", LF_02);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Fremdbeleg im selben Jahr schon als OP vorhanden !') on item 'DlgFremdbelegnrFehler.Frame2.Label3'.", repo.DlgFremdbelegnrFehler.Frame2.Label3Info, new RecordItemIndex(33));
            Validate.AttributeContains(repo.DlgFremdbelegnrFehler.Frame2.Label3Info, "Text", "Fremdbeleg im selben Jahr schon als OP vorhanden !");
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='FB03_B_EXOPV_005') on item 'DlgFremdbelegnrFehler.Frame2.DfBelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, new RecordItemIndex(34));
                Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.DfBelegNrInfo, "Text", "FB03_B_EXOPV_005", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(34)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='FB03_B_EXOPV_005') on item 'DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNr'.", repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, new RecordItemIndex(35));
                Validate.AttributeEqual(repo.DlgFremdbelegnrFehler.Frame2.NeueFremdbelegNrInfo, "Text", "FB03_B_EXOPV_005", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgFremdbelegnrFehler.PbUEber' at Center.", repo.DlgFremdbelegnrFehler.PbUEberInfo, new RecordItemIndex(36));
            repo.DlgFremdbelegnrFehler.PbUEber.Click();
            
            // Meldung Fehler
            Report.Log(ReportLevel.Info, "Section", "Meldung Fehler", new RecordItemIndex(37));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(60000), new RecordItemIndex(38));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden Fehler/Hinweise protokolliert!\r\n\r\nWollen Sie die Protokoll-Datei öffnen ? ') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(39));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden Fehler/Hinweise protokolliert!\r\n\r\nWollen Sie die Protokoll-Datei öffnen ? ");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(40));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
