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

namespace B_ERBU_002.Recordings_B_EXOPV
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Protokolldatei_pruefen recording.
    /// </summary>
    [TestModule("4e940432-c4cc-4f1d-963a-8089f75e4fbd", ModuleType.Recording, 1)]
    public partial class Protokolldatei_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ERBU_002.B_ERBU_002Repository repository.
        /// </summary>
        public static global::B_ERBU_002.B_ERBU_002Repository repo = global::B_ERBU_002.B_ERBU_002Repository.Instance;

        static Protokolldatei_pruefen instance = new Protokolldatei_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Protokolldatei_pruefen()
        {
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Protokolldatei_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("51512b3d-a3c0-421b-950e-4dc87e866fb8")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmMain_Schnittstelle_verbuchen.PbCommonProtokolldatei' at Center.", repo.FrmMain_Schnittstelle_verbuchen.PbCommonProtokolldateiInfo, new RecordItemIndex(0));
            repo.FrmMain_Schnittstelle_verbuchen.PbCommonProtokolldatei.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'ExoperrTxtEditor.ExoperrTxtEditor'", repo.ExoperrTxtEditor.ExoperrTxtEditorInfo, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.ExoperrTxtEditor.ExoperrTxtEditorInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'ExoperrTxtEditor.Text15'.", repo.ExoperrTxtEditor.Text15Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.ExoperrTxtEditor.Text15Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'B_EXOPV - Starte Verbuchung') on item 'ExoperrTxtEditor.Text15'.", repo.ExoperrTxtEditor.Text15Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.ExoperrTxtEditor.Text15Info, "Text", "B_EXOPV - Starte Verbuchung");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Starte Verbuchung ER-BUCH') on item 'ExoperrTxtEditor.Text15'.", repo.ExoperrTxtEditor.Text15Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.ExoperrTxtEditor.Text15Info, "Text", "[100] Starte Verbuchung ER-BUCH");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'[100] Beende Verbuchung ER-BUCH') on item 'ExoperrTxtEditor.Text15'.", repo.ExoperrTxtEditor.Text15Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.ExoperrTxtEditor.Text15Info, "Text", "[100] Beende Verbuchung ER-BUCH");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl Buchungen gelesen  5') on item 'ExoperrTxtEditor.Text15'.", repo.ExoperrTxtEditor.Text15Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.ExoperrTxtEditor.Text15Info, "Text", "Anzahl Buchungen gelesen  5");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Anzahl Buchungen verbucht 5  Summe verbucht: 13700,00') on item 'ExoperrTxtEditor.Text15'.", repo.ExoperrTxtEditor.Text15Info, new RecordItemIndex(7));
            Validate.AttributeContains(repo.ExoperrTxtEditor.Text15Info, "Text", "Anzahl Buchungen verbucht 5  Summe verbucht: 13700,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
