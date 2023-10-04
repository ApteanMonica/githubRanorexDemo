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

namespace V_AUF_008.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Auftrag_kopieren_Artikelverdichtung recording.
    /// </summary>
    [TestModule("b6aee0c3-8458-43bd-a92d-8b6c88f67bb6", ModuleType.Recording, 1)]
    public partial class Auftrag_kopieren_Artikelverdichtung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_AUF_008.V_AUF_008Repository repository.
        /// </summary>
        public static global::V_AUF_008.V_AUF_008Repository repo = global::V_AUF_008.V_AUF_008Repository.Instance;

        static Auftrag_kopieren_Artikelverdichtung instance = new Auftrag_kopieren_Artikelverdichtung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Auftrag_kopieren_Artikelverdichtung()
        {
            Auftrag1 = "A21/00013";
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Auftrag_kopieren_Artikelverdichtung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Auftrag1;

        /// <summary>
        /// Gets or sets the value of variable Auftrag1.
        /// </summary>
        [TestVariable("df734842-712e-44e5-a4c5-83869f881988")]
        public string Auftrag1
        {
            get { return _Auftrag1; }
            set { _Auftrag1 = value; }
        }

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("a2d3f802-bf29-4ce4-bf24-14088a6ac72c")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Suchleiste' at Center.", repo.FrmAufk.SuchleisteInfo, new RecordItemIndex(0));
            repo.FrmAufk.Suchleiste.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Auftrag1' with focus on 'FrmAufk.Suchleiste'.", repo.FrmAufk.SuchleisteInfo, new RecordItemIndex(1));
            repo.FrmAufk.Suchleiste.PressKeys(Auftrag1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.Row1Column0' at Center.", repo.FrmAufk.Row1Column0Info, new RecordItemIndex(2));
            repo.FrmAufk.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Auftrag1) on item 'FrmAufk.DfAufkNr'.", repo.FrmAufk.DfAufkNrInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmAufk.DfAufkNrInfo, "Text", Auftrag1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TabPagePositionen' at Center.", repo.FrmAufk.TabPagePositionenInfo, new RecordItemIndex(4));
            repo.FrmAufk.TabPagePositionen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'FrmAufk.ZlNr'", repo.FrmAufk.ZlNrInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.FrmAufk.ZlNrInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='7') on item 'FrmAufk.ZlNr'.", repo.FrmAufk.ZlNrInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmAufk.ZlNrInfo, "Text", "7");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Kopf' at Center.", repo.FrmAufk.KopfInfo, new RecordItemIndex(7));
            repo.FrmAufk.Kopf.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommon2Kopieren' at Center.", repo.FrmAufk.PbCommon2KopierenInfo, new RecordItemIndex(8));
            repo.FrmAufk.PbCommon2Kopieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommon2Kopieren' at Center.", repo.FrmAufk.PbCommon2KopierenInfo, new RecordItemIndex(9));
            repo.FrmAufk.PbCommon2Kopieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1' at Center.", repo.DlgMessageBox.Button1Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button1.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'FrmAufk.DfAufkDtauftrag'.", repo.FrmAufk.DfAufkDtauftragInfo, new RecordItemIndex(11));
            //Validate.AttributeContains(repo.FrmAufk.DfAufkDtauftragInfo, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TabPagePositionen' at Center.", repo.FrmAufk.TabPagePositionenInfo, new RecordItemIndex(12));
            repo.FrmAufk.TabPagePositionen.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Auftrag kopieren:\r\nVariante 1: Preisliste, Währung, Rechnungsart, Versand-, Liefer-, Zahlungsbedingung und Beschaffungskz.\r\nvom ursprünglichen Auftrag übernehmen\r\nVariante 2: Die Werte kommen von der Auftragsart\r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(13));
            //Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Auftrag kopieren:\r\nVariante 1: Preisliste, Währung, Rechnungsart, Versand-, Liefer-, Zahlungsbedingung und Beschaffungskz.\r\nvom ursprünglichen Auftrag übernehmen\r\nVariante 2: Die Werte kommen von der Auftragsart\r\n");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='False') on item 'DlgAufpCopy.CbArtVerdichtung'.", repo.DlgAufpCopy.CbArtVerdichtungInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgAufpCopy.CbArtVerdichtungInfo, "Checked", "False");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAufpCopy.CbArtVerdichtung' at Center.", repo.DlgAufpCopy.CbArtVerdichtungInfo, new RecordItemIndex(15));
            repo.DlgAufpCopy.CbArtVerdichtung.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgAufpCopy.CbArtVerdichtung'.", repo.DlgAufpCopy.CbArtVerdichtungInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.DlgAufpCopy.CbArtVerdichtungInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgAufpCopy.PbOk' at Center.", repo.DlgAufpCopy.PbOkInfo, new RecordItemIndex(17));
            repo.DlgAufpCopy.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Keine weiteren Positionen zum Kopieren') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Keine weiteren Positionen zum Kopieren");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(19));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4') on item 'FrmAufk.DfAufpZeile'.", repo.FrmAufk.DfAufpZeileInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmAufk.DfAufpZeileInfo, "Text", "4");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Kopf' at Center.", repo.FrmAufk.KopfInfo, new RecordItemIndex(21));
            repo.FrmAufk.Kopf.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'A([0-9]{2})[\\/]([0-9]{5})$') on item 'FrmAufk.DfAufkNr'.", repo.FrmAufk.DfAufkNrInfo, new RecordItemIndex(22));
            Validate.AttributeRegex(repo.FrmAufk.DfAufkNrInfo, "Text", new Regex("A([0-9]{2})[\\/]([0-9]{5})$"));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
