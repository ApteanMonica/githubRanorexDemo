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
    ///The Bankbeleg_erstellen_ohne_Ausdruck recording.
    /// </summary>
    [TestModule("dbf2ceec-2540-4d11-abbc-cff373e380b7", ModuleType.Recording, 1)]
    public partial class Bankbeleg_erstellen_ohne_Ausdruck : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_005.B_ZAHL_005Repository repository.
        /// </summary>
        public static global::B_ZAHL_005.B_ZAHL_005Repository repo = global::B_ZAHL_005.B_ZAHL_005Repository.Instance;

        static Bankbeleg_erstellen_ohne_Ausdruck instance = new Bankbeleg_erstellen_ohne_Ausdruck();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bankbeleg_erstellen_ohne_Ausdruck()
        {
            Zahlart = "S";
            Bank = "OBK";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bankbeleg_erstellen_ohne_Ausdruck Instance
        {
            get { return instance; }
        }

#region Variables

        string _Zahlart;

        /// <summary>
        /// Gets or sets the value of variable Zahlart.
        /// </summary>
        [TestVariable("15b82ffc-84be-4196-a72f-eb11065fb25a")]
        public string Zahlart
        {
            get { return _Zahlart; }
            set { _Zahlart = value; }
        }

        string _Bank;

        /// <summary>
        /// Gets or sets the value of variable Bank.
        /// </summary>
        [TestVariable("7c076d95-95e8-454d-b8b1-26a2f4221b0f")]
        public string Bank
        {
            get { return _Bank; }
            set { _Bank = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZahlMain.PbOptionenBankbelegV' at Center.", repo.FrmZahlMain.PbOptionenBankbelegVInfo, new RecordItemIndex(3));
            repo.FrmZahlMain.PbOptionenBankbelegV.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'FrmBankbeleg.Bankbeleg'", repo.FrmBankbeleg.BankbelegInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.FrmBankbeleg.BankbelegInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bankbeleg') on item 'FrmBankbeleg.Bankbeleg'.", repo.FrmBankbeleg.BankbelegInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmBankbeleg.BankbelegInfo, "Text", "Bankbeleg");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Zahlart' with focus on 'FrmBankbeleg.Zahlart'.", repo.FrmBankbeleg.ZahlartInfo, new RecordItemIndex(6));
            repo.FrmBankbeleg.Zahlart.PressKeys(Zahlart);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bank' with focus on 'FrmBankbeleg.Bank'.", repo.FrmBankbeleg.BankInfo, new RecordItemIndex(7));
            repo.FrmBankbeleg.Bank.PressKeys(Bank);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBankbeleg.CbDruckKeiner' at Center.", repo.FrmBankbeleg.CbDruckKeinerInfo, new RecordItemIndex(8));
            repo.FrmBankbeleg.CbDruckKeiner.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBankbeleg.PbCommonStart' at Center.", repo.FrmBankbeleg.PbCommonStartInfo, new RecordItemIndex(9));
            repo.FrmBankbeleg.PbCommonStart.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'UEberweisungsDatentraeger.UEberweisungsDatentraeger'", repo.UEberweisungsDatentraeger.UEberweisungsDatentraegerInfo, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.UEberweisungsDatentraeger.UEberweisungsDatentraegerInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'UEberweisungsDatentraeger.UEberweisungsDatentraeger'.", repo.UEberweisungsDatentraeger.UEberweisungsDatentraegerInfo, new RecordItemIndex(11));
            Validate.Exists(repo.UEberweisungsDatentraeger.UEberweisungsDatentraegerInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
