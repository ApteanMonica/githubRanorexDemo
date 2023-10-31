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

namespace V_FADR_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Lieferschein_laden recording.
    /// </summary>
    [TestModule("584de33d-38c6-4946-a057-c1ea78b0821d", ModuleType.Recording, 1)]
    public partial class Lieferschein_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Lieferschein_laden instance = new Lieferschein_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Lieferschein_laden()
        {
            Tagesdatum = "15.12.2020";
            Rechnungsart_E = "";
            Lieferscheinnummer = "";
            getDatumRow = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Lieferschein_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("71655e56-a900-458b-95bd-e37436f5f81e")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        string _Lieferscheinnummer;

        /// <summary>
        /// Gets or sets the value of variable Lieferscheinnummer.
        /// </summary>
        [TestVariable("c90b0d38-39f9-41e3-8abe-e775fd870d3a")]
        public string Lieferscheinnummer
        {
            get { return _Lieferscheinnummer; }
            set { _Lieferscheinnummer = value; }
        }

        string _getDatumRow;

        /// <summary>
        /// Gets or sets the value of variable getDatumRow.
        /// </summary>
        [TestVariable("c6742321-376f-48ec-bb69-0c215121217b")]
        public string getDatumRow
        {
            get { return _getDatumRow; }
            set { _getDatumRow = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Rechnungsart_E.
        /// </summary>
        [TestVariable("e08984a4-0fde-4419-a22f-13edf9a4f30a")]
        public string Rechnungsart_E
        {
            get { return repo.Rechnungsart_E; }
            set { repo.Rechnungsart_E = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'RbLadenErstellen'.", repo.RbLadenErstellenInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.RbLadenErstellenInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='E') on item 'TblFadr.Rechnungsart'.", repo.TblFadr.RechnungsartInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblFadr.RechnungsartInfo, "Text", "E");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblFadr.ColLskDatumRow1' and assigning its value to variable 'Tagesdatum'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(2));
            Tagesdatum = repo.TblFadr.ColLskDatumRow1.Element.GetAttributeValueText("Text");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Tagesdatum) on item 'TblFadr.ColLskDatumRow1'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(3));
            Validate.AttributeRegex(repo.TblFadr.ColLskDatumRow1Info, "Text", new Regex(Tagesdatum));
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'TblFadr.ColLskDatumRow1' and assigning its value to variable 'getDatumRow'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(4));
            getDatumRow = repo.TblFadr.ColLskDatumRow1.Element.GetAttributeValueText("Text");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbCommonLoad' at Center.", repo.TblFadr.PbCommonLoadInfo, new RecordItemIndex(5));
            repo.TblFadr.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.ColLskDatumRow1' at Center.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(6));
            repo.TblFadr.ColLskDatumRow1.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(7));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblFadr.ColLskDatumRow1' at Center.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(8));
            repo.TblFadr.ColLskDatumRow1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(9));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'TblFadr.ColLskDatumRow1'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(10));
            repo.TblFadr.ColLskDatumRow1.PressKeys("{Delete}");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'TblFadr.ColLskDatumRow1'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(11));
            //repo.TblFadr.ColLskDatumRow1.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'TblFadr.ColLskDatumRow1'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(12));
            //Keyboard.PrepareFocus(repo.TblFadr.ColLskDatumRow1);
            //Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+X' Press with focus on 'TblFadr.ColLskDatumRow1'.", repo.TblFadr.ColLskDatumRow1Info, new RecordItemIndex(13));
            //Keyboard.PrepareFocus(repo.TblFadr.ColLskDatumRow1);
            //Keyboard.Press(System.Windows.Forms.Keys.X | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.bis_LS_DatRow2' at Center.", repo.TblFadr.bis_LS_DatRow2Info, new RecordItemIndex(14));
            //repo.TblFadr.bis_LS_DatRow2.Click();
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(15));
            //Delay.Duration(30000, false);
            
            //Report.Screenshot(ReportLevel.Info, "User", "beide Datumszeilen ohne Datum", null, false, new RecordItemIndex(16));
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+V' Press with focus on 'TblFadr.bis_LS_DatRow2'.", repo.TblFadr.bis_LS_DatRow2Info, new RecordItemIndex(17));
            //Keyboard.PrepareFocus(repo.TblFadr.bis_LS_DatRow2);
            //Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Tagesdatum' with focus on 'TblFadr.bis_LS_DatRow2'.", repo.TblFadr.bis_LS_DatRow2Info, new RecordItemIndex(18));
            repo.TblFadr.bis_LS_DatRow2.PressKeys(Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbCommonLoad' at Center.", repo.TblFadr.PbCommonLoadInfo, new RecordItemIndex(19));
            repo.TblFadr.PbCommonLoad.Click();
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(20));
            //Delay.Duration(30000, false);
            
            //Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden keine Lieferscheine gefunden die zur Belegerstellung berechtigt sind.\r\nNähere Information unter Menu/Extras/Warum wird Auftrag nicht fakturiert') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden keine Lieferscheine gefunden die zur Belegerstellung berechtigt sind.\r\nNähere Information unter Menu/Extras/Warum wird Auftrag nicht fakturiert");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(23));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
