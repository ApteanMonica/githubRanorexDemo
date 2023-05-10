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

namespace V_AUF_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Preisermittlung recording.
    /// </summary>
    [TestModule("51d8c815-c795-4669-a57f-9bd823e51ea7", ModuleType.Recording, 1)]
    public partial class Preisermittlung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_AUF_007.V_AUF_007Repository repository.
        /// </summary>
        public static global::V_AUF_007.V_AUF_007Repository repo = global::V_AUF_007.V_AUF_007Repository.Instance;

        static Preisermittlung instance = new Preisermittlung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Preisermittlung()
        {
            Auftragswert_netto = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Preisermittlung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Auftragswert_netto;

        /// <summary>
        /// Gets or sets the value of variable Auftragswert_netto.
        /// </summary>
        [TestVariable("9554a141-e54b-4a60-8b85-a1d44c60f02f")]
        public string Auftragswert_netto
        {
            get { return _Auftragswert_netto; }
            set { _Auftragswert_netto = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Maximieren' at Center.", repo.FrmAufk.MaximierenInfo, new RecordItemIndex(0));
            repo.FrmAufk.Maximieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.FlexGrid.Row1Column0' at Center.", repo.FrmAufk.FlexGrid.Row1Column0Info, new RecordItemIndex(1));
            repo.FrmAufk.FlexGrid.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Label8' at Center.", repo.FrmAufk.Label8Info, new RecordItemIndex(2));
            repo.FrmAufk.Label8.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgPreise.TitleBar100DetailanzeigePreisermitt'.", repo.DlgPreise.TitleBar100DetailanzeigePreisermittInfo, new RecordItemIndex(3));
            Validate.Exists(repo.DlgPreise.TitleBar100DetailanzeigePreisermittInfo);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'DlgPreise.RsSplitContainer1.ColStaffelRow3'.", repo.DlgPreise.RsSplitContainer1.ColStaffelRow3Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.DlgPreise.RsSplitContainer1.ColStaffelRow3Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='11,000') on item 'DlgPreise.RsSplitContainer1.ColPreisRow2'.", repo.DlgPreise.RsSplitContainer1.ColPreisRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgPreise.RsSplitContainer1.ColPreisRow2Info, "Text", "11,000");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgPreise.RsSplitContainer1.PbOk' at Center.", repo.DlgPreise.RsSplitContainer1.PbOkInfo, new RecordItemIndex(6));
            repo.DlgPreise.RsSplitContainer1.PbOk.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbSpec3Weitere' at Center.", repo.FrmAufk.PbSpec3WeitereInfo, new RecordItemIndex(7));
            //repo.FrmAufk.PbSpec3Weitere.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbSpec1Summen' at Center.", repo.FrmAufk.PbSpec1SummenInfo, new RecordItemIndex(8));
            repo.FrmAufk.PbSpec1Summen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'DlgSummen.TitleBar100Auftragssummen'.", repo.DlgSummen.TitleBar100AuftragssummenInfo, new RecordItemIndex(9));
            Validate.Exists(repo.DlgSummen.TitleBar100AuftragssummenInfo);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'DlgSummen.DfAufkWert1' and assigning its value to variable 'Auftragswert_netto'.", repo.DlgSummen.DfAufkWert1Info, new RecordItemIndex(10));
            Auftragswert_netto = repo.DlgSummen.DfAufkWert1.Element.GetAttributeValueText("Text");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgSummen.Schliessen' at Center.", repo.DlgSummen.SchliessenInfo, new RecordItemIndex(11));
            repo.DlgSummen.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Auftragswert_netto) on item 'FrmAufk.DfAufkWert1D'.", repo.FrmAufk.DfAufkWert1DInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmAufk.DfAufkWert1DInfo, "Text", Auftragswert_netto);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.FlexGrid.Row3Column0' at Center.", repo.FrmAufk.FlexGrid.Row3Column0Info, new RecordItemIndex(13));
            repo.FrmAufk.FlexGrid.Row3Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100017') on item 'FrmAufk.TpPos.ArtNr'.", repo.FrmAufk.TpPos.ArtNrInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmAufk.TpPos.ArtNrInfo, "Text", "100017");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TpPos.TextVEH' at Center.", repo.FrmAufk.TpPos.TextVEHInfo, new RecordItemIndex(15));
            repo.FrmAufk.TpPos.TextVEH.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Z' with focus on 'FrmAufk.TpPos.TextVEH'.", repo.FrmAufk.TpPos.TextVEHInfo, new RecordItemIndex(16));
            repo.FrmAufk.TpPos.TextVEH.PressKeys("Z");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAufk.TpPos.TextVEH'.", repo.FrmAufk.TpPos.TextVEHInfo, new RecordItemIndex(17));
            repo.FrmAufk.TpPos.TextVEH.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TpPos.Zuschlagsart' at Center.", repo.FrmAufk.TpPos.ZuschlagsartInfo, new RecordItemIndex(18));
            repo.FrmAufk.TpPos.Zuschlagsart.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Zuschlag') on item 'FrmAufk.TpPos.DfAufpKzherkunftBez'.", repo.FrmAufk.TpPos.DfAufpKzherkunftBezInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmAufk.TpPos.DfAufpKzherkunftBezInfo, "Text", "Zuschlag");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(20));
            repo.FrmAufk.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Herkunfts-Kz. und Zuschlagsart müssen beide befüllt oder beide leer sein !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Herkunfts-Kz. und Zuschlagsart müssen beide befüllt oder beide leer sein !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(22));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TpPos.Zuschlagsart' at Center.", repo.FrmAufk.TpPos.ZuschlagsartInfo, new RecordItemIndex(23));
            repo.FrmAufk.TpPos.Zuschlagsart.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'F' with focus on 'FrmAufk.TpPos.Zuschlagsart'.", repo.FrmAufk.TpPos.ZuschlagsartInfo, new RecordItemIndex(24));
            repo.FrmAufk.TpPos.Zuschlagsart.PressKeys("F");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TpPos.TextVEH' at Center.", repo.FrmAufk.TpPos.TextVEHInfo, new RecordItemIndex(25));
            repo.FrmAufk.TpPos.TextVEH.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAufk.TpPos.Zuschlagsart'.", repo.FrmAufk.TpPos.ZuschlagsartInfo, new RecordItemIndex(26));
            //repo.FrmAufk.TpPos.Zuschlagsart.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TpPos.TextVEH' at CenterLeft.", repo.FrmAufk.TpPos.TextVEHInfo, new RecordItemIndex(27));
            repo.FrmAufk.TpPos.TextVEH.Click(Location.CenterLeft);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Frachtkosten') on item 'FrmAufk.TpPos.DfZusaBez'.", repo.FrmAufk.TpPos.DfZusaBezInfo, new RecordItemIndex(28));
            //Validate.AttributeEqual(repo.FrmAufk.TpPos.DfZusaBezInfo, "Text", "Frachtkosten");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(29));
            repo.FrmAufk.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='4') on item 'FrmAufk.TpPos.DfAufpZeile'.", repo.FrmAufk.TpPos.DfAufpZeileInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.FrmAufk.TpPos.DfAufpZeileInfo, "Text", "4");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
