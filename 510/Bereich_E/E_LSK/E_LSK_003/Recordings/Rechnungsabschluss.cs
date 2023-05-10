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

namespace E_LSK_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Rechnungsabschluss recording.
    /// </summary>
    [TestModule("e650c16f-158c-4360-a3be-61b0fad03420", ModuleType.Recording, 1)]
    public partial class Rechnungsabschluss : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LSK_003.E_LSK_003Repository repository.
        /// </summary>
        public static global::E_LSK_003.E_LSK_003Repository repo = global::E_LSK_003.E_LSK_003Repository.Instance;

        static Rechnungsabschluss instance = new Rechnungsabschluss();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Rechnungsabschluss()
        {
            Rechnungssumme = "33,00";
            Differenz = "0";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Rechnungsabschluss Instance
        {
            get { return instance; }
        }

#region Variables

        string _Rechnungssumme;

        /// <summary>
        /// Gets or sets the value of variable Rechnungssumme.
        /// </summary>
        [TestVariable("735aacf6-97ef-4dd4-a00f-408248273578")]
        public string Rechnungssumme
        {
            get { return _Rechnungssumme; }
            set { _Rechnungssumme = value; }
        }

        string _Differenz;

        /// <summary>
        /// Gets or sets the value of variable Differenz.
        /// </summary>
        [TestVariable("f1b902dc-974d-4909-afc0-e0ad7053d8b3")]
        public string Differenz
        {
            get { return _Differenz; }
            set { _Differenz = value; }
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

            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'MdiLSR.TpRech.DfDifferenz'", repo.MdiLSR.TpRech.DfDifferenzInfo, new ActionTimeout(30000), new RecordItemIndex(0));
            //repo.MdiLSR.TpRech.DfDifferenzInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnungssumme) on item 'MdiLSR.TpRech.Rechnung1'.", repo.MdiLSR.TpRech.Rechnung1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiLSR.TpRech.Rechnung1Info, "Text", Rechnungssumme);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnungssumme) on item 'MdiLSR.TpRech.Lieferscheine'.", repo.MdiLSR.TpRech.LieferscheineInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiLSR.TpRech.LieferscheineInfo, "Text", Rechnungssumme);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.TpRech.PbRichtig' at Center.", repo.MdiLSR.TpRech.PbRichtigInfo, new RecordItemIndex(3));
            repo.MdiLSR.TpRech.PbRichtig.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
