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

namespace B_ZAHL_003.Recordings_B_ZAHL
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zahlungsvorschlag_pruefen recording.
    /// </summary>
    [TestModule("d709502c-0962-4f05-aa13-1d9b56e00b17", ModuleType.Recording, 1)]
    public partial class Zahlungsvorschlag_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_003.B_ZAHL_003Repository repository.
        /// </summary>
        public static global::B_ZAHL_003.B_ZAHL_003Repository repo = global::B_ZAHL_003.B_ZAHL_003Repository.Instance;

        static Zahlungsvorschlag_pruefen instance = new Zahlungsvorschlag_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zahlungsvorschlag_pruefen()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zahlungsvorschlag_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ZV_TEXT.
        /// </summary>
        [TestVariable("3ac21240-7686-4b2d-a2f1-928c714aa4c1")]
        public string ZV_TEXT
        {
            get { return repo.ZV_TEXT; }
            set { repo.ZV_TEXT = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.TitleBar100LieferantenZahlungsver'", repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, new ActionTimeout(120000), new RecordItemIndex(0));
            repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten - Zahlungsverkehr') on item 'FrmZahlMain.TitleBar100LieferantenZahlungsver'.", repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, new RecordItemIndex(1));
            Validate.AttributeContains(repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, "Text", "Lieferanten - Zahlungsverkehr");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_003'", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_003Info, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_003Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'S;;0\t100\tRS\tB_ZAHL_003\t2\t06.05.2021\t52.753,00\t20\t06.05.2021\tB_ZAHL\t\t\tTrue\tTrue') on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_003'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_003Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_003Info, "Text", "S;;0\t100\tRS\tB_ZAHL_003\t2\t06.05.2021\t52.753,00\t20\t06.05.2021\tB_ZAHL\t\t\tTrue\tTrue");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
