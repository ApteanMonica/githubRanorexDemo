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

namespace B_ZAHL_005.Recordings_Bankbeleg
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zahldatum_Tagesdatum_setzen recording.
    /// </summary>
    [TestModule("0fdb33ad-eb94-439f-896c-8ffe9def8a8d", ModuleType.Recording, 1)]
    public partial class Zahldatum_Tagesdatum_setzen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_005.B_ZAHL_005Repository repository.
        /// </summary>
        public static global::B_ZAHL_005.B_ZAHL_005Repository repo = global::B_ZAHL_005.B_ZAHL_005Repository.Instance;

        static Zahldatum_Tagesdatum_setzen instance = new Zahldatum_Tagesdatum_setzen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zahldatum_Tagesdatum_setzen()
        {
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zahldatum_Tagesdatum_setzen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("bda8774b-f54f-4b4d-ba2e-f45be35da247")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ZV_TEXT.
        /// </summary>
        [TestVariable("613bc3d4-01d8-49fe-bbf9-af57ab471f10")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferanten - Zahlungsverkehr') on item 'FrmZahlMain.TitleBar100LieferantenZahlungsver'.", repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.FrmZahlMain.TitleBar100LieferantenZahlungsverInfo, "Text", "Lieferanten - Zahlungsverkehr");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_005'", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_005Info, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Row_mit_ZV_TEXT_B_ZAHL_005Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_005' at Center.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_005Info, new RecordItemIndex(2));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.Column0_Zeile_mit_ZV_TEXT_B_ZAHL_005.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.PbOptionenDatumAEndern' at Center.", repo.FrmZahlMain.PbOptionenDatumAEndernInfo, new RecordItemIndex(3));
            repo.FrmZahlMain.PbOptionenDatumAEndern.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgDatumAEndern.TitleBar100DatumAEndern'", repo.DlgDatumAEndern.TitleBar100DatumAEndernInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.DlgDatumAEndern.TitleBar100DatumAEndernInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5') on item 'DlgDatumAEndern.DfZlvsVorschlag'.", repo.DlgDatumAEndern.DfZlvsVorschlagInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgDatumAEndern.DfZlvsVorschlagInfo, "Text", "5");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'DlgDatumAEndern.Datum' at Center.", repo.DlgDatumAEndern.DatumInfo, new RecordItemIndex(6));
            repo.DlgDatumAEndern.Datum.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'DlgDatumAEndern.Datum'.", repo.DlgDatumAEndern.DatumInfo, new RecordItemIndex(7));
            repo.DlgDatumAEndern.Datum.EnsureVisible();
            Keyboard.Press("{Back}");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Tagesdatum' on item 'DlgDatumAEndern.Datum'.", repo.DlgDatumAEndern.DatumInfo, new RecordItemIndex(8));
            repo.DlgDatumAEndern.Datum.Element.SetAttributeValue("AccessibleValue", Tagesdatum);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDatumAEndern.PbSpeichern' at Center.", repo.DlgDatumAEndern.PbSpeichernInfo, new RecordItemIndex(9));
            repo.DlgDatumAEndern.PbSpeichern.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_B_ZAHL_005'", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_B_ZAHL_005Info, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_B_ZAHL_005Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Tagesdatum) on item 'FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_B_ZAHL_005'.", repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_B_ZAHL_005Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.FrmZahlMain.Zeilen_Zahlungsvorschlaege.ColZlvsZahldatum_Zeile_mit_B_ZAHL_005Info, "Text", Tagesdatum);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
