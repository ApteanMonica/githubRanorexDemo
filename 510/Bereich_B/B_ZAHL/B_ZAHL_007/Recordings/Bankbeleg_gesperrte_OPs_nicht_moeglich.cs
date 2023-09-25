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
    ///The Bankbeleg_gesperrte_OPs_nicht_moeglich recording.
    /// </summary>
    [TestModule("022911a7-fe14-4670-8bf7-dfc31e35c1a6", ModuleType.Recording, 1)]
    public partial class Bankbeleg_gesperrte_OPs_nicht_moeglich : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_007.B_ZAHL_007Repository repository.
        /// </summary>
        public static global::B_ZAHL_007.B_ZAHL_007Repository repo = global::B_ZAHL_007.B_ZAHL_007Repository.Instance;

        static Bankbeleg_gesperrte_OPs_nicht_moeglich instance = new Bankbeleg_gesperrte_OPs_nicht_moeglich();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Bankbeleg_gesperrte_OPs_nicht_moeglich()
        {
            Bank = "OBK";
            Zahlart = "S";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Bankbeleg_gesperrte_OPs_nicht_moeglich Instance
        {
            get { return instance; }
        }

#region Variables

        string _Bank;

        /// <summary>
        /// Gets or sets the value of variable Bank.
        /// </summary>
        [TestVariable("6a523dd5-602c-4bbb-a613-30f460098c23")]
        public string Bank
        {
            get { return _Bank; }
            set { _Bank = value; }
        }

        string _Zahlart;

        /// <summary>
        /// Gets or sets the value of variable Zahlart.
        /// </summary>
        [TestVariable("9f921438-7ef3-4620-ad1a-b72d01759f2a")]
        public string Zahlart
        {
            get { return _Zahlart; }
            set { _Zahlart = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.ChildTableWindow.Row1Column0' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Row1Column0Info, new RecordItemIndex(0));
            repo.FrmZlvsAEndern.ChildTableWindow.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}' with focus on 'FrmZlvsAEndern'.", repo.FrmZlvsAEndern.SelfInfo, new RecordItemIndex(1));
            repo.FrmZlvsAEndern.Self.EnsureVisible();
            Keyboard.Press("{LControlKey down}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.ChildTableWindow.Row3Column0' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Row3Column0Info, new RecordItemIndex(2));
            repo.FrmZlvsAEndern.ChildTableWindow.Row3Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.ChildTableWindow.Row4Column0' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Row4Column0Info, new RecordItemIndex(3));
            repo.FrmZlvsAEndern.ChildTableWindow.Row4Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.ChildTableWindow.Row5Column0' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Row5Column0Info, new RecordItemIndex(4));
            repo.FrmZlvsAEndern.ChildTableWindow.Row5Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.ChildTableWindow.Row7Column0' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Row7Column0Info, new RecordItemIndex(5));
            repo.FrmZlvsAEndern.ChildTableWindow.Row7Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}' with focus on 'FrmZlvsAEndern'.", repo.FrmZlvsAEndern.SelfInfo, new RecordItemIndex(6));
            repo.FrmZlvsAEndern.Self.EnsureVisible();
            Keyboard.Press("{LControlKey up}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'FrmZlvsAEndern.ChildTableWindow.Row7Column0' at Center.", repo.FrmZlvsAEndern.ChildTableWindow.Row7Column0Info, new RecordItemIndex(7));
            repo.FrmZlvsAEndern.ChildTableWindow.Row7Column0.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'BZAHL.BankbelegErstellen'", repo.BZAHL.BankbelegErstellenInfo, new ActionTimeout(180000), new RecordItemIndex(8));
            repo.BZAHL.BankbelegErstellenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'BZAHL.BankbelegErstellen' at Center.", repo.BZAHL.BankbelegErstellenInfo, new RecordItemIndex(9));
            repo.BZAHL.BankbelegErstellen.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'FrmBankbeleg.Bankbeleg'", repo.FrmBankbeleg.BankbelegInfo, new ActionTimeout(180000), new RecordItemIndex(10));
            repo.FrmBankbeleg.BankbelegInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Bankbeleg aus 5 markierten OPs') on item 'FrmBankbeleg.Bankbeleg'.", repo.FrmBankbeleg.BankbelegInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBankbeleg.BankbelegInfo, "Text", "Bankbeleg aus 5 markierten OPs");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Zahlart) on item 'FrmBankbeleg.Zahlart'.", repo.FrmBankbeleg.ZahlartInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmBankbeleg.ZahlartInfo, "Text", Zahlart);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmBankbeleg.Zahlart'.", repo.FrmBankbeleg.ZahlartInfo, new RecordItemIndex(13));
            Keyboard.PrepareFocus(repo.FrmBankbeleg.Zahlart);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bank' with focus on 'FrmBankbeleg.Bank'.", repo.FrmBankbeleg.BankInfo, new RecordItemIndex(14));
            repo.FrmBankbeleg.Bank.EnsureVisible();
            Keyboard.Press(Bank);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmBankbeleg.Bank'.", repo.FrmBankbeleg.BankInfo, new RecordItemIndex(15));
            Keyboard.PrepareFocus(repo.FrmBankbeleg.Bank);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmBankbeleg.Bank'.", repo.FrmBankbeleg.BankInfo, new RecordItemIndex(16));
            repo.FrmBankbeleg.Bank.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBankbeleg.CbDruckKeiner' at Center.", repo.FrmBankbeleg.CbDruckKeinerInfo, new RecordItemIndex(17));
            repo.FrmBankbeleg.CbDruckKeiner.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bank) on item 'FrmBankbeleg.Bank'.", repo.FrmBankbeleg.BankInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmBankbeleg.BankInfo, "Text", Bank);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmBankbeleg.CbDruckKeiner'.", repo.FrmBankbeleg.CbDruckKeinerInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmBankbeleg.CbDruckKeinerInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBankbeleg.PbCommonStart' at Center.", repo.FrmBankbeleg.PbCommonStartInfo, new RecordItemIndex(20));
            repo.FrmBankbeleg.PbCommonStart.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'UEberweisungsDatentraeger.UEberweisungsDatentraeger'", repo.UEberweisungsDatentraeger.UEberweisungsDatentraegerInfo, new ActionTimeout(180000), new RecordItemIndex(21));
            repo.UEberweisungsDatentraeger.UEberweisungsDatentraegerInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'c:\\temp\\nur_gesperrte_OPs.xml' with focus on 'UEberweisungsDatentraeger.Text1001'.", repo.UEberweisungsDatentraeger.Text1001Info, new RecordItemIndex(22));
            repo.UEberweisungsDatentraeger.Text1001.PressKeys("c:\\temp\\nur_gesperrte_OPs.xml");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'UEberweisungsDatentraeger.ButtonSpeichern' at Center.", repo.UEberweisungsDatentraeger.ButtonSpeichernInfo, new RecordItemIndex(23));
            repo.UEberweisungsDatentraeger.ButtonSpeichern.Click();
            
            // Falls b_zahl_007.xml schon vorhanden ist, die Meldung mit J bestätigen (nicht Button JA, weil sonst Fehler, wenn Meldung nicht kommt). Nächster Button ist "OK" (O)
            Report.Log(ReportLevel.Info, "Keyboard", "Falls b_zahl_007.xml schon vorhanden ist, die Meldung mit J bestätigen (nicht Button JA, weil sonst Fehler, wenn Meldung nicht kommt). Nächster Button ist \"OK\" (O)\r\nKey 'J' Press.", new RecordItemIndex(24));
            Keyboard.Press(System.Windows.Forms.Keys.J, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.Zahlungsverkehr'", repo.DlgMessageBox.ZahlungsverkehrInfo, new ActionTimeout(180000), new RecordItemIndex(25));
            repo.DlgMessageBox.ZahlungsverkehrInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es gibt keine Zahlung. Datenträger nicht erstellt !') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(26));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es gibt keine Zahlung. Datenträger nicht erstellt !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(27));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(28));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=' Bitte kontrollieren Sie die nicht übernommenen OP's.') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", " Bitte kontrollieren Sie die nicht übernommenen OP's.");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(30));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'FrmBankbeleg.PbToolBarItemsNichtUebernommen'", repo.FrmBankbeleg.PbToolBarItemsNichtUebernommenInfo, new ActionTimeout(180000), new RecordItemIndex(31));
            repo.FrmBankbeleg.PbToolBarItemsNichtUebernommenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmBankbeleg.Bankbeleg'.", repo.FrmBankbeleg.BankbelegInfo, new RecordItemIndex(32));
            Keyboard.PrepareFocus(repo.FrmBankbeleg.Bankbeleg);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.PbDataAccessLaden' at Center.", repo.FrmZlvsAEndern.PbDataAccessLadenInfo, new RecordItemIndex(33));
            repo.FrmZlvsAEndern.PbDataAccessLaden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ER_077B_B_ZAHL_007') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColBelegRow7'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColBelegRow7Info, new RecordItemIndex(34));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_7.ColBelegRow7Info, "Text", "ER_077B_B_ZAHL_007");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Alt+F4' Press with focus on 'FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl'.", repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschlInfo, new RecordItemIndex(35));
            Keyboard.PrepareFocus(repo.FrmZlvsAEndern.TitleBar100LieferantenZahlvorschl);
            Keyboard.Press(System.Windows.Forms.Keys.F4 | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
