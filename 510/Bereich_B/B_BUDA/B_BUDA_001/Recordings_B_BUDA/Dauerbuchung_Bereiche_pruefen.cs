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

namespace B_BUDA_001.Recordings_B_BUDA
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Dauerbuchung_Bereiche_pruefen recording.
    /// </summary>
    [TestModule("a66f70e8-da7a-4485-ade2-bff6e41e5269", ModuleType.Recording, 1)]
    public partial class Dauerbuchung_Bereiche_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUDA_001.B_BUDA_001Repository repository.
        /// </summary>
        public static global::B_BUDA_001.B_BUDA_001Repository repo = global::B_BUDA_001.B_BUDA_001Repository.Instance;

        static Dauerbuchung_Bereiche_pruefen instance = new Dauerbuchung_Bereiche_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Dauerbuchung_Bereiche_pruefen()
        {
            Beleg_Nr = "B_BUDA_001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Dauerbuchung_Bereiche_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("4ea548b5-050d-487b-b2df-489d200c8c01")]
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TblDetail.Row1'", repo.DlgDetail.TblDetail.Row1Info, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.DlgDetail.TblDetail.Row1Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.TblDetail.Row1Column0' at Center.", repo.DlgDetail.TblDetail.Row1Column0Info, new RecordItemIndex(1));
            repo.DlgDetail.TblDetail.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.PbBereich' at Center.", repo.DlgDetail.PbBereichInfo, new RecordItemIndex(2));
            repo.DlgDetail.PbBereich.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new ActionTimeout(120000), new RecordItemIndex(3));
            repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bereichs-Aufteilung - Konto: 3300') on item 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'.", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, "Text", "Bereichs-Aufteilung - Konto: 3300");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'9,04\t\t\t\t20\tBaustoffe') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, "Text", "9,04\t\t\t\t20\tBaustoffe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'599,99\t\t\t\t30\tKST 30') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row2Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row2Info, "Text", "599,99\t\t\t\t30\tKST 30");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'990,96\t\t\t\t40\tKST 40') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row3'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row3Info, new RecordItemIndex(7));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row3Info, "Text", "990,96\t\t\t\t40\tKST 40");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'600,01\t\t\t\t50\tKST 50') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row4'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row4Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row4Info, "Text", "600,01\t\t\t\t50\tKST 50");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSB_Bereichsaufteilung.Schliessen' at Center.", repo.FrmSB_Bereichsaufteilung.SchliessenInfo, new RecordItemIndex(9));
            repo.FrmSB_Bereichsaufteilung.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TblDetail.Row2'", repo.DlgDetail.TblDetail.Row2Info, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.DlgDetail.TblDetail.Row2Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.TblDetail.Row2Column0' at Center.", repo.DlgDetail.TblDetail.Row2Column0Info, new RecordItemIndex(11));
            repo.DlgDetail.TblDetail.Row2Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.PbBereich' at Center.", repo.DlgDetail.PbBereichInfo, new RecordItemIndex(12));
            repo.DlgDetail.PbBereich.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new ActionTimeout(120000), new RecordItemIndex(13));
            repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Bereichs-Aufteilung - Konto: 7778') on item 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'.", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new RecordItemIndex(14));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, "Text", "Bereichs-Aufteilung - Konto: 7778");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'499,99\t\t0\t0\t30\tKST 30') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, new RecordItemIndex(15));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, "Text", "499,99\t\t0\t0\t30\tKST 30");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'500,01\t\t0\t0\t50\tKST 50') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row2'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row2Info, new RecordItemIndex(16));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row2Info, "Text", "500,01\t\t0\t0\t50\tKST 50");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSB_Bereichsaufteilung.Schliessen' at Center.", repo.FrmSB_Bereichsaufteilung.SchliessenInfo, new RecordItemIndex(17));
            repo.FrmSB_Bereichsaufteilung.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TblDetail.Row3'", repo.DlgDetail.TblDetail.Row3Info, new ActionTimeout(120000), new RecordItemIndex(18));
            repo.DlgDetail.TblDetail.Row3Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.TblDetail.Row3Column0' at Center.", repo.DlgDetail.TblDetail.Row3Column0Info, new RecordItemIndex(19));
            repo.DlgDetail.TblDetail.Row3Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.PbBereich' at Center.", repo.DlgDetail.PbBereichInfo, new RecordItemIndex(20));
            repo.DlgDetail.PbBereich.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new ActionTimeout(120000), new RecordItemIndex(21));
            repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bereichs-Aufteilung - Konto: 7777') on item 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'.", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, "Text", "Bereichs-Aufteilung - Konto: 7777");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'990,96\t\t0\t0\t40\tKST 40') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, new RecordItemIndex(23));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, "Text", "990,96\t\t0\t0\t40\tKST 40");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSB_Bereichsaufteilung.Schliessen' at Center.", repo.FrmSB_Bereichsaufteilung.SchliessenInfo, new RecordItemIndex(24));
            repo.FrmSB_Bereichsaufteilung.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TblDetail.Row4'", repo.DlgDetail.TblDetail.Row4Info, new ActionTimeout(120000), new RecordItemIndex(25));
            repo.DlgDetail.TblDetail.Row4Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.TblDetail.Row4Column0' at Center.", repo.DlgDetail.TblDetail.Row4Column0Info, new RecordItemIndex(26));
            repo.DlgDetail.TblDetail.Row4Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDetail.PbBereich' at Center.", repo.DlgDetail.PbBereichInfo, new RecordItemIndex(27));
            repo.DlgDetail.PbBereich.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new ActionTimeout(120000), new RecordItemIndex(28));
            repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bereichs-Aufteilung - Konto: 7778') on item 'FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778'.", repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.FrmSB_Bereichsaufteilung.BereichsAufteilungKonto7778Info, "Text", "Bereichs-Aufteilung - Konto: 7778");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'7,53\t\t0\t0\t20\tBaustoffe') on item 'FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1'.", repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, new RecordItemIndex(30));
            Validate.AttributeContains(repo.FrmSB_Bereichsaufteilung.FlexGrid_Bereichsaufteilung.Row1Info, "Text", "7,53\t\t0\t0\t20\tBaustoffe");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmSB_Bereichsaufteilung.Schliessen' at Center.", repo.FrmSB_Bereichsaufteilung.SchliessenInfo, new RecordItemIndex(31));
            repo.FrmSB_Bereichsaufteilung.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDetail.TitleBar100BuchungenFuerDauerbuchu'", repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo, new ActionTimeout(120000), new RecordItemIndex(32));
            repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'DlgDetail.TitleBar100BuchungenFuerDauerbuchu'.", repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchuInfo, new RecordItemIndex(33));
            Keyboard.PrepareFocus(repo.DlgDetail.TitleBar100BuchungenFuerDauerbuchu);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
