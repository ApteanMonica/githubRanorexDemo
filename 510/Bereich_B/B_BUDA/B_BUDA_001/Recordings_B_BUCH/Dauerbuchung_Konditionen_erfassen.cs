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

namespace B_BUDA_001.Recordings_B_BUCH
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Dauerbuchung_Konditionen_erfassen recording.
    /// </summary>
    [TestModule("65bd9494-0058-4949-98b4-2c53db04f3dc", ModuleType.Recording, 1)]
    public partial class Dauerbuchung_Konditionen_erfassen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_001.B_BUDA_001Repository repository.
        /// </summary>
        public static global::B_BUDA_001.B_BUDA_001Repository repo = global::B_BUDA_001.B_BUDA_001Repository.Instance;

        static Dauerbuchung_Konditionen_erfassen instance = new Dauerbuchung_Konditionen_erfassen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchung_Konditionen_erfassen()
        {
            Beleg_Nr = "B_BUDA_001";
            BUDA_Beleg_NR_1 = "B_BUDA_001-1";
            DABU_Beginn = "01.12.2021";
            DABU_Ende = "01.09.2022";
            DABU_Next1 = "01.12.2021";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchung_Konditionen_erfassen Instance
        {
            get { return instance; }
        }

#region Variables

        string _BUDA_Beleg_NR_1;

        /// <summary>
        /// Gets or sets the value of variable BUDA_Beleg_NR_1.
        /// </summary>
        [TestVariable("0dec9b1b-a1e3-42dd-8770-14bc18b4c691")]
        public string BUDA_Beleg_NR_1
        {
            get { return _BUDA_Beleg_NR_1; }
            set { _BUDA_Beleg_NR_1 = value; }
        }

        string _DABU_Beginn;

        /// <summary>
        /// Gets or sets the value of variable DABU_Beginn.
        /// </summary>
        [TestVariable("082f82a0-c300-433c-98c0-afa588e8988f")]
        public string DABU_Beginn
        {
            get { return _DABU_Beginn; }
            set { _DABU_Beginn = value; }
        }

        string _DABU_Ende;

        /// <summary>
        /// Gets or sets the value of variable DABU_Ende.
        /// </summary>
        [TestVariable("5cb64088-d45a-4736-bc64-c080673b8580")]
        public string DABU_Ende
        {
            get { return _DABU_Ende; }
            set { _DABU_Ende = value; }
        }

        string _DABU_Next1;

        /// <summary>
        /// Gets or sets the value of variable DABU_Next1.
        /// </summary>
        [TestVariable("04fcb0b6-8fd2-4a13-ad97-ae73c7df194d")]
        public string DABU_Next1
        {
            get { return _DABU_Next1; }
            set { _DABU_Next1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("ea284ee0-2262-4101-b175-525a6c1636bb")]
        public string Beleg_Nr
        {
            get { return repo.Beleg_NR; }
            set { repo.Beleg_NR = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDaBuParam.TitleBar100DauerbuchungKonditione'", repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Dauerbuchung - Konditionen') on item 'DlgDaBuParam.TitleBar100DauerbuchungKonditione'.", repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo, "Text", "Dauerbuchung - Konditionen");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgDaBuParam.dfBelNr' at Center.", repo.DlgDaBuParam.dfBelNrInfo, new RecordItemIndex(2));
            repo.DlgDaBuParam.dfBelNr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BUDA_Beleg_NR_1' with focus on 'DlgDaBuParam.dfBelNr'.", repo.DlgDaBuParam.dfBelNrInfo, new RecordItemIndex(3));
            repo.DlgDaBuParam.dfBelNr.PressKeys(BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.CmbBelegNummerArt' at Center.", repo.DlgDaBuParam.CmbBelegNummerArtInfo, new RecordItemIndex(5));
            repo.DlgDaBuParam.CmbBelegNummerArt.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Strukturiert' at Center.", repo.List1000.StrukturiertInfo, new RecordItemIndex(6));
            repo.List1000.Strukturiert.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beleg_Nr' with focus on 'DlgDaBuParam.DfBudaText'.", repo.DlgDaBuParam.DfBudaTextInfo, new RecordItemIndex(8));
            repo.DlgDaBuParam.DfBudaText.PressKeys(Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(9));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgDaBuParam.UpDownEdit' at Center.", repo.DlgDaBuParam.UpDownEditInfo, new RecordItemIndex(10));
            //repo.DlgDaBuParam.UpDownEdit.DoubleClick();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'DlgDaBuParam.UpDownEdit'.", repo.DlgDaBuParam.UpDownEditInfo, new RecordItemIndex(11));
            //repo.DlgDaBuParam.UpDownEdit.PressKeys("1");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(12));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.CmbIntervallArt' at Center.", repo.DlgDaBuParam.CmbIntervallArtInfo, new RecordItemIndex(13));
            repo.DlgDaBuParam.CmbIntervallArt.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Monate' at Center.", repo.List1000.MonateInfo, new RecordItemIndex(14));
            repo.List1000.Monate.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(15));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'True' on item 'DlgDaBuParam.RbDatum'.", repo.DlgDaBuParam.RbDatumInfo, new RecordItemIndex(16));
            //repo.DlgDaBuParam.RbDatum.Element.SetAttributeValue("Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.CmbTag' at Center.", repo.DlgDaBuParam.CmbTagInfo, new RecordItemIndex(17));
            repo.DlgDaBuParam.CmbTag.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'DlgDaBuParam.CmbTag'.", repo.DlgDaBuParam.CmbTagInfo, new RecordItemIndex(18));
            repo.DlgDaBuParam.CmbTag.PressKeys("1");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.Beginn' at Center.", repo.DlgDaBuParam.BeginnInfo, new RecordItemIndex(19));
            repo.DlgDaBuParam.Beginn.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DABU_Beginn' with focus on 'DlgDaBuParam.Beginn'.", repo.DlgDaBuParam.BeginnInfo, new RecordItemIndex(20));
            repo.DlgDaBuParam.Beginn.PressKeys(DABU_Beginn);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(21));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.AnzahlGesamt' at Center.", repo.DlgDaBuParam.AnzahlGesamtInfo, new RecordItemIndex(22));
            repo.DlgDaBuParam.AnzahlGesamt.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10' with focus on 'DlgDaBuParam.AnzahlGesamt'.", repo.DlgDaBuParam.AnzahlGesamtInfo, new RecordItemIndex(23));
            repo.DlgDaBuParam.AnzahlGesamt.PressKeys("10");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(24));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'DlgDaBuParam.dfBelNr'.", repo.DlgDaBuParam.dfBelNrInfo, new RecordItemIndex(25));
            Validate.AttributeEqual(repo.DlgDaBuParam.dfBelNrInfo, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Strukturiert') on item 'DlgDaBuParam.CmbBelegNummerArt'.", repo.DlgDaBuParam.CmbBelegNummerArtInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.DlgDaBuParam.CmbBelegNummerArtInfo, "Text", "Strukturiert");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Nr) on item 'DlgDaBuParam.DfBudaText'.", repo.DlgDaBuParam.DfBudaTextInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.DlgDaBuParam.DfBudaTextInfo, "Text", Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Monate') on item 'DlgDaBuParam.CmbIntervallArt'.", repo.DlgDaBuParam.CmbIntervallArtInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.DlgDaBuParam.CmbIntervallArtInfo, "Text", "Monate");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'DlgDaBuParam.UpDownEdit'.", repo.DlgDaBuParam.UpDownEditInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.DlgDaBuParam.UpDownEditInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgDaBuParam.RbDatum'.", repo.DlgDaBuParam.RbDatumInfo, new RecordItemIndex(30));
            Validate.AttributeEqual(repo.DlgDaBuParam.RbDatumInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'DlgDaBuParam.CmbTag'.", repo.DlgDaBuParam.CmbTagInfo, new RecordItemIndex(31));
            Validate.AttributeEqual(repo.DlgDaBuParam.CmbTagInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Beginn) on item 'DlgDaBuParam.DfInfo_erste_Buchung'.", repo.DlgDaBuParam.DfInfo_erste_BuchungInfo, new RecordItemIndex(32));
            Validate.AttributeEqual(repo.DlgDaBuParam.DfInfo_erste_BuchungInfo, "Text", DABU_Beginn);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Ende) on item 'DlgDaBuParam.Ende'.", repo.DlgDaBuParam.EndeInfo, new RecordItemIndex(33));
            Validate.AttributeEqual(repo.DlgDaBuParam.EndeInfo, "Text", DABU_Ende);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Next1) on item 'DlgDaBuParam.NaechsteBuchung'.", repo.DlgDaBuParam.NaechsteBuchungInfo, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.DlgDaBuParam.NaechsteBuchungInfo, "Text", DABU_Next1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='10') on item 'DlgDaBuParam.AnzahlGesamt'.", repo.DlgDaBuParam.AnzahlGesamtInfo, new RecordItemIndex(35));
            Validate.AttributeEqual(repo.DlgDaBuParam.AnzahlGesamtInfo, "Text", "10");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.PbOK' at Center.", repo.DlgDaBuParam.PbOKInfo, new RecordItemIndex(36));
            repo.DlgDaBuParam.PbOK.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
