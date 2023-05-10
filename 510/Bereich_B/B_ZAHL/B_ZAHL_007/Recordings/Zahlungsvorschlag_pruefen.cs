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

namespace B_ZAHL_007.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zahlungsvorschlag_pruefen recording.
    /// </summary>
    [TestModule("0cdd274b-262b-49fb-a440-77bb78cbbc69", ModuleType.Recording, 1)]
    public partial class Zahlungsvorschlag_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_007.B_ZAHL_007Repository repository.
        /// </summary>
        public static global::B_ZAHL_007.B_ZAHL_007Repository repo = global::B_ZAHL_007.B_ZAHL_007Repository.Instance;

        static Zahlungsvorschlag_pruefen instance = new Zahlungsvorschlag_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zahlungsvorschlag_pruefen()
        {
            Tagesdatum = "";
            ZV_TEXT = "B_ZAHL_007";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zahlungsvorschlag_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("da0911d9-328d-4e3c-9504-8391013115ed")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ZV_TEXT.
        /// </summary>
        [TestVariable("a514b40b-2319-4a79-b9ca-6369e3674d15")]
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_007'", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_007Info, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_007Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$ZV_TEXT) on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_007'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_007Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_007Info, "Text", ZV_TEXT);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='20.482,00') on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsSumme_Zeile_mit_ZV_TEXT_B_ZAHL_007'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsSumme_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsSumme_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, "Text", "20.482,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsAnzah_Zeile_mit_ZV_TEXT_B_ZAHL_007'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsAnzah_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsAnzah_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, "Text", "5");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_ZV_TEXT_B_ZAHL_007'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Tagesdatum) on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZldtDtanlag_Zeile_mit_ZV_TEXT_B_ZAHL_007'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZldtDtanlag_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZldtDtanlag_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, "Text", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_007' at Center.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_007Info, new RecordItemIndex(8));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_007.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.PbDataAcessEdit' at Center.", repo.FrmZahlMain.PbDataAcessEditInfo, new RecordItemIndex(9));
            repo.FrmZahlMain.PbDataAcessEdit.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.TitleBar100LieferantenZahlungsver'", repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten - Zahlvorschlag bearbeiten:') on item 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'.", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new RecordItemIndex(11));
            Validate.AttributeContains(repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, "Text", "Lieferanten - Zahlvorschlag bearbeiten:");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.PbDataAccessLaden' at Center.", repo.FrmZlvsAEndern.PbDataAccessLadenInfo, new RecordItemIndex(12));
            repo.FrmZlvsAEndern.PbDataAccessLaden.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
