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

namespace B_ZAHLV_001.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Bereichs_Buchungen_pruefen_A_GS003_Z_38 recording.
    /// </summary>
    [TestModule("abe38439-b891-41bd-87cb-666d1763934b", ModuleType.Recording, 1)]
    public partial class Bereichs_Buchungen_pruefen_A_GS003_Z_38 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static Bereichs_Buchungen_pruefen_A_GS003_Z_38 instance = new Bereichs_Buchungen_pruefen_A_GS003_Z_38();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bereichs_Buchungen_pruefen_A_GS003_Z_38()
        {
            Beleg_Nr = "1001";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bereichs_Buchungen_pruefen_A_GS003_Z_38 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beleg_Nr.
        /// </summary>
        [TestVariable("f2a893b4-7a11-476a-8cbb-dfad936bf590")]
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Form100BuchungenAnzeigen.TitleBar100BuchungenAnzeigen'.", repo.Form100BuchungenAnzeigen.TitleBar100BuchungenAnzeigenInfo, new RecordItemIndex(0));
            //Validate.Exists(repo.Form100BuchungenAnzeigen.TitleBar100BuchungenAnzeigenInfo);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_Nr) on item 'Form100BuchungenAnzeigen.Beleg'.", repo.Form100BuchungenAnzeigen.BelegInfo, new RecordItemIndex(1));
            //Validate.AttributeEqual(repo.Form100BuchungenAnzeigen.BelegInfo, "Text", Beleg_Nr);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row1Column0_erste_Zeile_markieren' at Center.", repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row1Column0_erste_Zeile_markierenInfo, new RecordItemIndex(2));
            repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row1Column0_erste_Zeile_markieren.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'End' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.End, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.PageDown' at Center.", repo.Form100BuchungenAnzeigen.PageDownInfo, new RecordItemIndex(4));
            //repo.Form100BuchungenAnzeigen.PageDown.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row38Column0_mit_Bereichsaufteilung'", repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row38Column0_mit_BereichsaufteilungInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row38Column0_mit_BereichsaufteilungInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row38Column0_mit_Bereichsaufteilung' at Center.", repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row38Column0_mit_BereichsaufteilungInfo, new RecordItemIndex(6));
            repo.Form100BuchungenAnzeigen.FlexGrid_Zeilen_mit_Bereichsaufteilung.Row38Column0_mit_Bereichsaufteilung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Form100BuchungenAnzeigen.PbCommonBereichsAufteilung' at Center.", repo.Form100BuchungenAnzeigen.PbCommonBereichsAufteilungInfo, new RecordItemIndex(7));
            repo.Form100BuchungenAnzeigen.PbCommonBereichsAufteilung.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmSB.BereichsAufteilungKonto2833Refe'", repo.FrmSB.BereichsAufteilungKonto2833RefeInfo, new ActionTimeout(120000), new RecordItemIndex(8));
            repo.FrmSB.BereichsAufteilungKonto2833RefeInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'2833') on item 'FrmSB.BereichsAufteilungKonto2833Refe'.", repo.FrmSB.BereichsAufteilungKonto2833RefeInfo, new RecordItemIndex(9));
            Validate.AttributeContains(repo.FrmSB.BereichsAufteilungKonto2833RefeInfo, "Text", "2833");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='\t1\t-500,01\t-500,01\t\t\t\t40\tKST 40\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t40\t\t\t\t\t') on item 'FrmSB.Row1'.", repo.FrmSB.Row1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmSB.Row1Info, "Text", "\t1\t-500,01\t-500,01\t\t\t\t40\tKST 40\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t40\t\t\t\t\t");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='\t2\t-499,99\t-499,99\t\t\t\t50\tKST 50\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t50\t\t\t\t\t') on item 'FrmSB.Row2'.", repo.FrmSB.Row2Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmSB.Row2Info, "Text", "\t2\t-499,99\t-499,99\t\t\t\t50\tKST 50\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t50\t\t\t\t\t");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmSB.BereichsAufteilungKonto2833Refe'.", repo.FrmSB.BereichsAufteilungKonto2833RefeInfo, new RecordItemIndex(12));
            Keyboard.PrepareFocus(repo.FrmSB.BereichsAufteilungKonto2833Refe);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
