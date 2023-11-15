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

namespace B_ELSTER_2024_UVA_JUVA_ZM.Recordings_ZM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Elster_Aufruf_DSGVO_Meldung_RS_bestaetigen recording.
    /// </summary>
    [TestModule("4b8b6245-d99f-4213-8a57-489c1a03142f", ModuleType.Recording, 1)]
    public partial class Elster_Aufruf_DSGVO_Meldung_RS_bestaetigen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repository.
        /// </summary>
        public static global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository repo = global::B_ELSTER_2024_UVA_JUVA_ZM.B_ELSTER_2024_UVA_JUVA_ZMRepository.Instance;

        static Elster_Aufruf_DSGVO_Meldung_RS_bestaetigen instance = new Elster_Aufruf_DSGVO_Meldung_RS_bestaetigen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Elster_Aufruf_DSGVO_Meldung_RS_bestaetigen()
        {
            Firma = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Elster_Aufruf_DSGVO_Meldung_RS_bestaetigen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("66a72278-2b34-4046-b100-40f43150c584")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'FrmMain_B_ZM.ZM_PbElster_visible_enabled'", repo.FrmMain_B_ZM.ZM_PbElster_visible_enabledInfo, new ActionTimeout(300000), new RecordItemIndex(0));
            repo.FrmMain_B_ZM.ZM_PbElster_visible_enabledInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain_B_ZM.PbElster' at Center.", repo.FrmMain_B_ZM.PbElsterInfo, new RecordItemIndex(1));
            repo.FrmMain_B_ZM.PbElster.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to exist. Associated repository item: 'DlgElsterDSGVO.TitleBar300ElsterInformation'", repo.DlgElsterDSGVO.TitleBar300ElsterInformationInfo, new ActionTimeout(300000), new RecordItemIndex(2));
            repo.DlgElsterDSGVO.TitleBar300ElsterInformationInfo.WaitForExists(300000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Elster Information') on item 'DlgElsterDSGVO.TitleBar300ElsterInformation'.", repo.DlgElsterDSGVO.TitleBar300ElsterInformationInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgElsterDSGVO.TitleBar300ElsterInformationInfo, "Text", "Elster Information");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'DlgElsterDSGVO.TitleBar300ElsterInformation'.", repo.DlgElsterDSGVO.TitleBar300ElsterInformationInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgElsterDSGVO.TitleBar300ElsterInformationInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgElsterDSGVO.LblMessage_Preview_Generation_Failed'", repo.DlgElsterDSGVO.LblMessage_Preview_Generation_FailedInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.DlgElsterDSGVO.LblMessage_Preview_Generation_FailedInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgElsterDSGVO.CbDSGVO_unchecked'", repo.DlgElsterDSGVO.CbDSGVO_uncheckedInfo, new ActionTimeout(60000), new RecordItemIndex(6));
            repo.DlgElsterDSGVO.CbDSGVO_uncheckedInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElsterDSGVO.CbDSGVO' at Center.", repo.DlgElsterDSGVO.CbDSGVOInfo, new RecordItemIndex(7));
            repo.DlgElsterDSGVO.CbDSGVO.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(8));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'DlgElsterDSGVO.CbDSGVO'.", repo.DlgElsterDSGVO.CbDSGVOInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.DlgElsterDSGVO.CbDSGVOInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElsterDSGVO.PbWeiter' at Center.", repo.DlgElsterDSGVO.PbWeiterInfo, new RecordItemIndex(10));
            repo.DlgElsterDSGVO.PbWeiter.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 7m to exist. Associated repository item: 'Hinweis.Hinweis'", repo.Hinweis.HinweisInfo, new ActionTimeout(420000), new RecordItemIndex(11));
            repo.Hinweis.HinweisInfo.WaitForExists(420000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Arbeitsgruppe: GURUS\r\nBenutzer: RS\r\n\r\nNur Testübermittlung möglich!') on item 'Hinweis.Text65535'.", repo.Hinweis.Text65535Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.Hinweis.Text65535Info, "Text", "Arbeitsgruppe: GURUS\r\nBenutzer: RS\r\n\r\nNur Testübermittlung möglich!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hinweis.Button' at Center.", repo.Hinweis.ButtonInfo, new RecordItemIndex(13));
            repo.Hinweis.Button.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to not exist. Associated repository item: 'Hinweis.Text65535_Meldung_Testuebermittlung'", repo.Hinweis.Text65535_Meldung_TestuebermittlungInfo, new ActionTimeout(300000), new RecordItemIndex(14));
            repo.Hinweis.Text65535_Meldung_TestuebermittlungInfo.WaitForNotExists(300000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
