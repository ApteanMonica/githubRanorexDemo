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

namespace B_BUDA_002.Recordings_B_BUDA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Dauerbuchung_Konditionen_aendern recording.
    /// </summary>
    [TestModule("c6e55c0b-e54e-49ff-b118-57a75afc2175", ModuleType.Recording, 1)]
    public partial class Dauerbuchung_Konditionen_aendern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_002.B_BUDA_002Repository repository.
        /// </summary>
        public static global::B_BUDA_002.B_BUDA_002Repository repo = global::B_BUDA_002.B_BUDA_002Repository.Instance;

        static Dauerbuchung_Konditionen_aendern instance = new Dauerbuchung_Konditionen_aendern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchung_Konditionen_aendern()
        {
            BUDA_Beleg_NR_1 = "B_BUDA_002-0";
            Beleg_Nr = "B_BUDA_002";
            DABU_Beginn = "01.01.2022";
            DABU_Next1 = "01.01.2022";
            DABU_Ende2 = "01.09.2022";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchung_Konditionen_aendern Instance
        {
            get { return instance; }
        }

#region Variables

        string _BUDA_Beleg_NR_1;

        /// <summary>
        /// Gets or sets the value of variable BUDA_Beleg_NR_1.
        /// </summary>
        [TestVariable("69b2d5e8-7865-4e85-b72d-641f0133791d")]
        public string BUDA_Beleg_NR_1
        {
            get { return _BUDA_Beleg_NR_1; }
            set { _BUDA_Beleg_NR_1 = value; }
        }

        string _DABU_Beginn;

        /// <summary>
        /// Gets or sets the value of variable DABU_Beginn.
        /// </summary>
        [TestVariable("62950f93-67e7-4d91-9826-614e0e65e090")]
        public string DABU_Beginn
        {
            get { return _DABU_Beginn; }
            set { _DABU_Beginn = value; }
        }

        string _DABU_Next1;

        /// <summary>
        /// Gets or sets the value of variable DABU_Next1.
        /// </summary>
        [TestVariable("a84461fb-2a7f-4ec3-8a09-0575d7ecfb7c")]
        public string DABU_Next1
        {
            get { return _DABU_Next1; }
            set { _DABU_Next1 = value; }
        }

        string _DABU_Ende2;

        /// <summary>
        /// Gets or sets the value of variable DABU_Ende2.
        /// </summary>
        [TestVariable("13012c8c-15f2-417a-9c2d-e181341e4804")]
        public string DABU_Ende2
        {
            get { return _DABU_Ende2; }
            set { _DABU_Ende2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("111bc9c5-6d4b-4c05-9bc1-5658d6a03b4f")]
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblDaBu.TitleBar100Dauerbuchungen'", repo.TblDaBu.TitleBar100DauerbuchungenInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.TblDaBu.TitleBar100DauerbuchungenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Dauerbuchungen') on item 'TblDaBu.TitleBar100Dauerbuchungen'.", repo.TblDaBu.TitleBar100DauerbuchungenInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblDaBu.TitleBar100DauerbuchungenInfo, "Text", "Dauerbuchungen");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblDaBu.ChildTableWindow.Row_Zeile_mit_ColText_B_BUDA_002'", repo.TblDaBu.ChildTableWindow.Row_Zeile_mit_ColText_B_BUDA_002Info, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.TblDaBu.ChildTableWindow.Row_Zeile_mit_ColText_B_BUDA_002Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblDaBu.ChildTableWindow.Column0_in_Zeile_mit_ColText_B_BUDA_002' at Center.", repo.TblDaBu.ChildTableWindow.Column0_in_Zeile_mit_ColText_B_BUDA_002Info, new RecordItemIndex(3));
            repo.TblDaBu.ChildTableWindow.Column0_in_Zeile_mit_ColText_B_BUDA_002.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblDaBu.PbToolBarItemsConditions' at Center.", repo.TblDaBu.PbToolBarItemsConditionsInfo, new RecordItemIndex(4));
            repo.TblDaBu.PbToolBarItemsConditions.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDaBuParam.TitleBar100DauerbuchungKonditione'", repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Dauerbuchung - Konditionen') on item 'DlgDaBuParam.TitleBar100DauerbuchungKonditione'.", repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DlgDaBuParam.TitleBar100DauerbuchungKonditioneInfo, "Text", "Dauerbuchung - Konditionen");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$BUDA_Beleg_NR_1) on item 'DlgDaBuParam.Belegnummer'.", repo.DlgDaBuParam.BelegnummerInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgDaBuParam.BelegnummerInfo, "Text", BUDA_Beleg_NR_1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.CmbBelegNummerArt' at Center.", repo.DlgDaBuParam.CmbBelegNummerArtInfo, new RecordItemIndex(8));
            repo.DlgDaBuParam.CmbBelegNummerArt.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.Gleichbleibend' at Center.", repo.List1000.GleichbleibendInfo, new RecordItemIndex(9));
            repo.List1000.Gleichbleibend.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$DABU_Ende2' with focus on 'DlgDaBuParam.GroupBox2.Ende'.", repo.DlgDaBuParam.GroupBox2.EndeInfo, new RecordItemIndex(10));
            repo.DlgDaBuParam.GroupBox2.Ende.PressKeys(DABU_Ende2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Nr) on item 'DlgDaBuParam.DfBudaText'.", repo.DlgDaBuParam.DfBudaTextInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.DlgDaBuParam.DfBudaTextInfo, "Text", Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Gleichbleibend') on item 'DlgDaBuParam.CmbBelegNummerArt'.", repo.DlgDaBuParam.CmbBelegNummerArtInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.DlgDaBuParam.CmbBelegNummerArtInfo, "Text", "Gleichbleibend");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'DlgDaBuParam.UpDownEdit'.", repo.DlgDaBuParam.UpDownEditInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.DlgDaBuParam.UpDownEditInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Monate') on item 'DlgDaBuParam.CmbIntervallArt'.", repo.DlgDaBuParam.CmbIntervallArtInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.DlgDaBuParam.CmbIntervallArtInfo, "Text", "Monate");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'DlgDaBuParam.CmbTag'.", repo.DlgDaBuParam.CmbTagInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.DlgDaBuParam.CmbTagInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Beginn) on item 'DlgDaBuParam.GroupBox2.Beginn'.", repo.DlgDaBuParam.GroupBox2.BeginnInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.DlgDaBuParam.GroupBox2.BeginnInfo, "Text", DABU_Beginn);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Ende2) on item 'DlgDaBuParam.GroupBox2.Ende'.", repo.DlgDaBuParam.GroupBox2.EndeInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.DlgDaBuParam.GroupBox2.EndeInfo, "Text", DABU_Ende2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Beginn) on item 'DlgDaBuParam.GroupBox2.DfInfo'.", repo.DlgDaBuParam.GroupBox2.DfInfoInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.DlgDaBuParam.GroupBox2.DfInfoInfo, "Text", DABU_Beginn);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$DABU_Next1) on item 'DlgDaBuParam.GroupBox2.NaechsteBuchung'.", repo.DlgDaBuParam.GroupBox2.NaechsteBuchungInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.DlgDaBuParam.GroupBox2.NaechsteBuchungInfo, "Text", DABU_Next1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9') on item 'DlgDaBuParam.GroupBox2.AnzahlGesamt'.", repo.DlgDaBuParam.GroupBox2.AnzahlGesamtInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.DlgDaBuParam.GroupBox2.AnzahlGesamtInfo, "Text", "9");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='9') on item 'DlgDaBuParam.GroupBox2.DfAnzbuchRest'.", repo.DlgDaBuParam.GroupBox2.DfAnzbuchRestInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.DlgDaBuParam.GroupBox2.DfAnzbuchRestInfo, "Text", "9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDaBuParam.PbOK' at Center.", repo.DlgDaBuParam.PbOKInfo, new RecordItemIndex(23));
            repo.DlgDaBuParam.PbOK.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
