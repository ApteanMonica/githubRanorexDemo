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

namespace B_ELSTER_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Elster_XML_Ausgabe_starten_Meldung_RS_bestaetigen recording.
    /// </summary>
    [TestModule("cd677785-d1aa-442c-86cd-09d66e12934a", ModuleType.Recording, 1)]
    public partial class Elster_XML_Ausgabe_starten_Meldung_RS_bestaetigen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_001.B_ELSTER_001Repository repository.
        /// </summary>
        public static global::B_ELSTER_001.B_ELSTER_001Repository repo = global::B_ELSTER_001.B_ELSTER_001Repository.Instance;

        static Elster_XML_Ausgabe_starten_Meldung_RS_bestaetigen instance = new Elster_XML_Ausgabe_starten_Meldung_RS_bestaetigen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Elster_XML_Ausgabe_starten_Meldung_RS_bestaetigen()
        {
            Firma = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Elster_XML_Ausgabe_starten_Meldung_RS_bestaetigen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("71940a3d-4d3d-48e1-a7f5-1059b7215d13")]
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 4m to exist. Associated repository item: 'DlgElster.TitleBar300ElsterXML'", repo.DlgElster.TitleBar300ElsterXMLInfo, new ActionTimeout(240000), new RecordItemIndex(0));
            repo.DlgElster.TitleBar300ElsterXMLInfo.WaitForExists(240000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Elster-XML') on item 'DlgElster.TitleBar300ElsterXML'.", repo.DlgElster.TitleBar300ElsterXMLInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.DlgElster.TitleBar300ElsterXMLInfo, "Text", "Elster-XML");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'DlgElster.TitleBar300ElsterXML'.", repo.DlgElster.TitleBar300ElsterXMLInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.DlgElster.TitleBar300ElsterXMLInfo, "Text", Firma);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgElster.PbJa' at Center.", repo.DlgElster.PbJaInfo, new RecordItemIndex(3));
            repo.DlgElster.PbJa.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 7m to exist. Associated repository item: 'Hinweis.Hinweis'", repo.Hinweis.HinweisInfo, new ActionTimeout(420000), new RecordItemIndex(4));
            repo.Hinweis.HinweisInfo.WaitForExists(420000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Arbeitsgruppe: GURUS\r\nBenutzer: RS\r\n\r\nNur Testübermittlung möglich!') on item 'Hinweis.Text65535'.", repo.Hinweis.Text65535Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.Hinweis.Text65535Info, "Text", "Arbeitsgruppe: GURUS\r\nBenutzer: RS\r\n\r\nNur Testübermittlung möglich!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Hinweis.Button' at Center.", repo.Hinweis.ButtonInfo, new RecordItemIndex(6));
            repo.Hinweis.Button.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5m to not exist. Associated repository item: 'Hinweis.Text65535_Meldung_Testuebermittlung'", repo.Hinweis.Text65535_Meldung_TestuebermittlungInfo, new ActionTimeout(300000), new RecordItemIndex(7));
            repo.Hinweis.Text65535_Meldung_TestuebermittlungInfo.WaitForNotExists(300000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
