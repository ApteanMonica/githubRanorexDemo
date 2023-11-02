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
    ///The Rechnung_aendern recording.
    /// </summary>
    [TestModule("7ee890f8-90dd-4f2f-b049-5188a62ba171", ModuleType.Recording, 1)]
    public partial class Rechnung_aendern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_001.V_FADR_001Repository repository.
        /// </summary>
        public static global::V_FADR_001.V_FADR_001Repository repo = global::V_FADR_001.V_FADR_001Repository.Instance;

        static Rechnung_aendern instance = new Rechnung_aendern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Rechnung_aendern()
        {
            Zahlungsbedingung = "030";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Rechnung_aendern Instance
        {
            get { return instance; }
        }

#region Variables

        string _Zahlungsbedingung;

        /// <summary>
        /// Gets or sets the value of variable Zahlungsbedingung.
        /// </summary>
        [TestVariable("794c186c-05d0-4da2-b8a2-33b65d28405f")]
        public string Zahlungsbedingung
        {
            get { return _Zahlungsbedingung; }
            set { _Zahlungsbedingung = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFadr.PbSpec3Extras' at Center.", repo.TblFadr.PbSpec3ExtrasInfo, new RecordItemIndex(0));
            repo.TblFadr.PbSpec3Extras.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VFADR.RechnungAendern' at Center.", repo.VFADR.RechnungAendernInfo, new RecordItemIndex(1));
            repo.VFADR.RechnungAendern.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgRechAenderung'", repo.DlgRechAenderung.SelfInfo, new ActionTimeout(60000), new RecordItemIndex(2));
            repo.DlgRechAenderung.SelfInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgRechAenderung.Zahlungsbedingung' at CenterRight.", repo.DlgRechAenderung.ZahlungsbedingungInfo, new RecordItemIndex(3));
            repo.DlgRechAenderung.Zahlungsbedingung.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'VFADR1.DropDown' at Center.", repo.VFADR1.DropDownInfo, new RecordItemIndex(4));
            repo.VFADR1.DropDown.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Zahlungsbedingung'.", new RecordItemIndex(5));
            Keyboard.Press(Zahlungsbedingung);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Zahlungsbedingung) on item 'DlgRechAenderung.Zahlungsbedingung'.", repo.DlgRechAenderung.ZahlungsbedingungInfo, new RecordItemIndex(7));
            Validate.AttributeRegex(repo.DlgRechAenderung.ZahlungsbedingungInfo, "Text", new Regex(Zahlungsbedingung));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgRechAenderung.PbSpeichern' at Center.", repo.DlgRechAenderung.PbSpeichernInfo, new RecordItemIndex(8));
            repo.DlgRechAenderung.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgRechAenderung.Schliessen' at Center.", repo.DlgRechAenderung.SchliessenInfo, new RecordItemIndex(10));
            repo.DlgRechAenderung.Schliessen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
