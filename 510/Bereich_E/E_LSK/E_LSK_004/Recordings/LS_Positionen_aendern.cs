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

namespace E_LSK_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LS_Positionen_aendern recording.
    /// </summary>
    [TestModule("b94f7d50-f8e2-4a1f-bd04-ac4502ad1d37", ModuleType.Recording, 1)]
    public partial class LS_Positionen_aendern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_LSK_004.E_LSK_004Repository repository.
        /// </summary>
        public static global::E_LSK_004.E_LSK_004Repository repo = global::E_LSK_004.E_LSK_004Repository.Instance;

        static LS_Positionen_aendern instance = new LS_Positionen_aendern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LS_Positionen_aendern()
        {
            LSK_NR = "";
            Artikel2 = "100035";
            Artikel1 = "100034";
            Artikel3 = "100038";
            Lieferscheinsumme = "70,00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LS_Positionen_aendern Instance
        {
            get { return instance; }
        }

#region Variables

        string _LSK_NR;

        /// <summary>
        /// Gets or sets the value of variable LSK_NR.
        /// </summary>
        [TestVariable("6843c548-84e7-4310-8cb9-082e93046935")]
        public string LSK_NR
        {
            get { return _LSK_NR; }
            set { _LSK_NR = value; }
        }

        string _Artikel2;

        /// <summary>
        /// Gets or sets the value of variable Artikel2.
        /// </summary>
        [TestVariable("496c4db4-db00-4849-b321-61cdbc249891")]
        public string Artikel2
        {
            get { return _Artikel2; }
            set { _Artikel2 = value; }
        }

        string _Artikel1;

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("1e5f2064-8a86-4dc7-8b87-79b091ddaa03")]
        public string Artikel1
        {
            get { return _Artikel1; }
            set { _Artikel1 = value; }
        }

        string _Artikel3;

        /// <summary>
        /// Gets or sets the value of variable Artikel3.
        /// </summary>
        [TestVariable("28e3bfea-2026-42f3-94cd-d5aa11172cef")]
        public string Artikel3
        {
            get { return _Artikel3; }
            set { _Artikel3 = value; }
        }

        string _Lieferscheinsumme;

        /// <summary>
        /// Gets or sets the value of variable Lieferscheinsumme.
        /// </summary>
        [TestVariable("51ef6bc0-8c59-46a2-a455-89833622d465")]
        public string Lieferscheinsumme
        {
            get { return _Lieferscheinsumme; }
            set { _Lieferscheinsumme = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$LSK_NR) on item 'MdiLSR.TitleBar100LieferscheineLagerzuga'.", repo.MdiLSR.TitleBar100LieferscheineLagerzugaInfo, new RecordItemIndex(0));
            Validate.AttributeContains(repo.MdiLSR.TitleBar100LieferscheineLagerzugaInfo, "Text", LSK_NR);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'MdiLSR.FrmKopf.Artikel'.", repo.MdiLSR.FrmKopf.ArtikelInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ArtikelInfo, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel2) on item 'MdiLSR.FrmKopf.ColArtNrRow2'.", repo.MdiLSR.FrmKopf.ColArtNrRow2Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ColArtNrRow2Info, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.PbVorwaerts' at Center.", repo.MdiLSR.FrmKopf.PbVorwaertsInfo, new RecordItemIndex(3));
            repo.MdiLSR.FrmKopf.PbVorwaerts.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'Text' to equal the specified value $Artikel2. Associated repository item: 'MdiLSR.FrmKopf.Artikel'", repo.MdiLSR.FrmKopf.ArtikelInfo, new RecordItemIndex(4));
            repo.MdiLSR.FrmKopf.ArtikelInfo.WaitForAttributeEqual(10000, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.Preis' at Center.", repo.MdiLSR.FrmKopf.PreisInfo, new RecordItemIndex(5));
            repo.MdiLSR.FrmKopf.Preis.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel2) on item 'MdiLSR.FrmKopf.Artikel'.", repo.MdiLSR.FrmKopf.ArtikelInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ArtikelInfo, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='49,00') on item 'MdiLSR.FrmKopf.DfWertBetrag'.", repo.MdiLSR.FrmKopf.DfWertBetragInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.DfWertBetragInfo, "Text", "49,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiLSR.FrmKopf.Preis' at Center.", repo.MdiLSR.FrmKopf.PreisInfo, new RecordItemIndex(8));
            repo.MdiLSR.FrmKopf.Preis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad5}{Tab}' with focus on 'MdiLSR.FrmKopf.Preis'.", repo.MdiLSR.FrmKopf.PreisInfo, new RecordItemIndex(9));
            repo.MdiLSR.FrmKopf.Preis.EnsureVisible();
            Keyboard.Press("{NumPad5}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.Rabatt1' at Center.", repo.MdiLSR.FrmKopf.Rabatt1Info, new RecordItemIndex(10));
            repo.MdiLSR.FrmKopf.Rabatt1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad0}{Tab}' with focus on 'MdiLSR.FrmKopf.Rabatt1'.", repo.MdiLSR.FrmKopf.Rabatt1Info, new RecordItemIndex(11));
            repo.MdiLSR.FrmKopf.Rabatt1.PressKeys("{NumPad1}{NumPad0}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.PbDataAccessSave' at Center.", repo.MdiLSR.PbDataAccessSaveInfo, new RecordItemIndex(12));
            repo.MdiLSR.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='56,50') on item 'MdiLSR.FrmKopf.DfWertBetrag'.", repo.MdiLSR.FrmKopf.DfWertBetragInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.DfWertBetragInfo, "Text", "56,50");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'MdiLSR.FrmKopf.Row3Column0' at Center.", repo.MdiLSR.FrmKopf.Row3Column0Info, new RecordItemIndex(14));
            repo.MdiLSR.FrmKopf.Row3Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.FrmKopf.Menge' at CenterRight.", repo.MdiLSR.FrmKopf.MengeInfo, new RecordItemIndex(15));
            repo.MdiLSR.FrmKopf.Menge.Click(Location.CenterRight);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel3) on item 'MdiLSR.FrmKopf.Artikel'.", repo.MdiLSR.FrmKopf.ArtikelInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.ArtikelInfo, "Text", Artikel3);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad0}' with focus on 'MdiLSR.FrmKopf.Menge'.", repo.MdiLSR.FrmKopf.MengeInfo, new RecordItemIndex(17));
            repo.MdiLSR.FrmKopf.Menge.EnsureVisible();
            Keyboard.Press("{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'MdiLSR.FrmKopf.Menge'.", repo.MdiLSR.FrmKopf.MengeInfo, new RecordItemIndex(18));
            repo.MdiLSR.FrmKopf.Menge.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='15,00') on item 'MdiLSR.FrmKopf.DfWertBetrag'.", repo.MdiLSR.FrmKopf.DfWertBetragInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.DfWertBetragInfo, "Text", "15,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiLSR.PbDataAccessSave' at Center.", repo.MdiLSR.PbDataAccessSaveInfo, new RecordItemIndex(20));
            repo.MdiLSR.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferscheinsumme) on item 'MdiLSR.FrmKopf.DfWertBetrag'.", repo.MdiLSR.FrmKopf.DfWertBetragInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.MdiLSR.FrmKopf.DfWertBetragInfo, "Text", Lieferscheinsumme);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
