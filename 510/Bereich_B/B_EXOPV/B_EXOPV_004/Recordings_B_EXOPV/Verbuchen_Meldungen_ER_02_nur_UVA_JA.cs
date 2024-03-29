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
    ///The Verbuchen_Meldungen_ER_02_nur_UVA_JA recording.
    /// </summary>
    [TestModule("68df4bac-4497-4fe0-8120-38de04e18f0a", ModuleType.Recording, 1)]
    public partial class Verbuchen_Meldungen_ER_02_nur_UVA_JA : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static Verbuchen_Meldungen_ER_02_nur_UVA_JA instance = new Verbuchen_Meldungen_ER_02_nur_UVA_JA();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verbuchen_Meldungen_ER_02_nur_UVA_JA()
        {
            Jahr = "2018";
            UVA_Monat_13_offen = "13";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verbuchen_Meldungen_ER_02_nur_UVA_JA Instance
        {
            get { return instance; }
        }

#region Variables

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("248d5717-0f63-4535-b1ab-6143d5f352a8")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _UVA_Monat_13_offen;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_13_offen.
        /// </summary>
        [TestVariable("e2e4fef8-ae45-4aba-bdab-5456cff2efab")]
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

            // ER 02 nur Meldung UVA-Datum
            Report.Log(ReportLevel.Info, "Section", "ER 02 nur Meldung UVA-Datum", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.FakturenPruefung'", repo.DlgMessageBox.FakturenPruefungInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.DlgMessageBox.FakturenPruefungInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-6 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "UVA für 2018-6 ist schon abgeschlossen.\r\n\r\nBitte UVA-Termin korrigieren! \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(3));
            repo.DlgMessageBox.Button0.Click();
            
            // ER 02 Maske UVA-Datum - neuen UVA-Termin verwenden
            Report.Log(ReportLevel.Info, "Section", "ER 02 Maske UVA-Datum - neuen UVA-Termin verwenden", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgUva.TitleBar100UVADatum'", repo.DlgUva.TitleBar100UVADatumInfo, new ActionTimeout(60000), new RecordItemIndex(5));
            repo.DlgUva.TitleBar100UVADatumInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'UVA-Datum') on item 'DlgUva.TitleBar100UVADatum'.", repo.DlgUva.TitleBar100UVADatumInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgUva.TitleBar100UVADatumInfo, "Text", "UVA-Datum");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='UVA für 2018-06 schon abgeschlossen.') on item 'DlgUva.DfText'.", repo.DlgUva.DfTextInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgUva.DfTextInfo, "Text", "UVA für 2018-06 schon abgeschlossen.");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'DlgUva.Jahr_Vorschlag'.", repo.DlgUva.Jahr_VorschlagInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.DlgUva.Jahr_VorschlagInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UVA_Monat_13_offen) on item 'DlgUva.Monat_Vorschlag'.", repo.DlgUva.Monat_VorschlagInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.DlgUva.Monat_VorschlagInfo, "Text", UVA_Monat_13_offen);
            
            // ok bis hierher
            Report.Log(ReportLevel.Info, "Mouse", "ok bis hierher\r\nMouse Left Click item 'DlgUva.PbVerwenden' at Center.", repo.DlgUva.PbVerwendenInfo, new RecordItemIndex(10));
            repo.DlgUva.PbVerwenden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
