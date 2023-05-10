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

namespace E_BSK_004.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BV_Import_Pruefung recording.
    /// </summary>
    [TestModule("5af1beef-7f40-420c-851c-7770c80612e1", ModuleType.Recording, 1)]
    public partial class BV_Import_Pruefung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::E_BSK_004.E_BSK_004Repository repository.
        /// </summary>
        public static global::E_BSK_004.E_BSK_004Repository repo = global::E_BSK_004.E_BSK_004Repository.Instance;

        static BV_Import_Pruefung instance = new BV_Import_Pruefung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BV_Import_Pruefung()
        {
            Lieferant1 = "300021";
            Artikel1 = "100112";
            Artikel2 = "100111";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BV_Import_Pruefung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant1;

        /// <summary>
        /// Gets or sets the value of variable Lieferant1.
        /// </summary>
        [TestVariable("04d88155-718a-40e9-becf-c3c4b0eb08d3")]
        public string Lieferant1
        {
            get { return _Lieferant1; }
            set { _Lieferant1 = value; }
        }

        string _Artikel1;

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("2d72d195-18c9-4440-bab5-9a6d87a2e418")]
        public string Artikel1
        {
            get { return _Artikel1; }
            set { _Artikel1 = value; }
        }

        string _Artikel2;

        /// <summary>
        /// Gets or sets the value of variable Artikel2.
        /// </summary>
        [TestVariable("a87bdaee-860c-4f80-93c5-b6117186e81c")]
        public string Artikel2
        {
            get { return _Artikel2; }
            set { _Artikel2 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbCommonSuchenBsvs' at Center.", repo.FrmBsvs.PbCommonSuchenBsvsInfo, new RecordItemIndex(0));
            repo.FrmBsvs.PbCommonSuchenBsvs.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox1.PbNeu' at Center.", repo.DlgMessageBox1.PbNeuInfo, new RecordItemIndex(1));
            repo.DlgMessageBox1.PbNeu.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox1.PbOk' at Center.", repo.DlgMessageBox1.PbOkInfo, new RecordItemIndex(2));
            repo.DlgMessageBox1.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmBsvs.Row2.ColBsvsStatusRow2' at Center.", repo.FrmBsvs.Row2.ColBsvsStatusRow2Info, new RecordItemIndex(3));
            repo.FrmBsvs.Row2.ColBsvsStatusRow2.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'MdiBestellung.Kopf'", repo.MdiBestellung.KopfInfo, new ActionTimeout(10000), new RecordItemIndex(4));
            repo.MdiBestellung.KopfInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'das Lieferdatum liegt VOR dem Bestelldatum') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "das Lieferdatum liegt VOR dem Bestelldatum");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lieferant1) on item 'MdiBestellung.Lieferant'.", repo.MdiBestellung.LieferantInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiBestellung.LieferantInfo, "Text", Lieferant1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBestellung.PbNavigationBack' at Center.", repo.MdiBestellung.PbNavigationBackInfo, new RecordItemIndex(8));
            repo.MdiBestellung.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBestellung.PbCommonBestellvorschlag' at Center.", repo.MdiBestellung.PbCommonBestellvorschlagInfo, new RecordItemIndex(9));
            repo.MdiBestellung.PbCommonBestellvorschlag.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'EBSK.BearbeitenImportieren' at Center.", repo.EBSK.BearbeitenImportierenInfo, new RecordItemIndex(10));
            repo.EBSK.BearbeitenImportieren.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmBsvs.TitleBar100BestellvorschlagBearbeit'.", repo.FrmBsvs.TitleBar100BestellvorschlagBearbeitInfo, new RecordItemIndex(11));
            Validate.Exists(repo.FrmBsvs.TitleBar100BestellvorschlagBearbeitInfo);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbCommonSuchenBsvs' at Center.", repo.FrmBsvs.PbCommonSuchenBsvsInfo, new RecordItemIndex(12));
            repo.FrmBsvs.PbCommonSuchenBsvs.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox1.PbNeu' at Center.", repo.DlgMessageBox1.PbNeuInfo, new RecordItemIndex(13));
            repo.DlgMessageBox1.PbNeu.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox1.ColWert1Row4' at Center.", repo.DlgMessageBox1.ColWert1Row4Info, new RecordItemIndex(14));
            repo.DlgMessageBox1.ColWert1Row4.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Artikel2' with focus on 'DlgMessageBox1.ColWert1Row4'.", repo.DlgMessageBox1.ColWert1Row4Info, new RecordItemIndex(15));
            repo.DlgMessageBox1.ColWert1Row4.EnsureVisible();
            Keyboard.Press(Artikel2);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'DlgMessageBox1.ColWert1Row4'.", repo.DlgMessageBox1.ColWert1Row4Info, new RecordItemIndex(16));
            repo.DlgMessageBox1.ColWert1Row4.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'DlgMessageBox1.ColWert2Row4'.", repo.DlgMessageBox1.ColWert2Row4Info, new RecordItemIndex(17));
            repo.DlgMessageBox1.ColWert2Row4.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox1.PbOk' at Center.", repo.DlgMessageBox1.PbOkInfo, new RecordItemIndex(18));
            repo.DlgMessageBox1.PbOk.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbDataAccessLoad' at Center.", repo.FrmBsvs.PbDataAccessLoadInfo, new RecordItemIndex(19));
            //repo.FrmBsvs.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(20));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel2) on item 'FrmBsvs.ColArtNrRow1'.", repo.FrmBsvs.ColArtNrRow1Info, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.FrmBsvs.ColArtNrRow1Info, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.Row1Column0' at Center.", repo.FrmBsvs.Row1Column0Info, new RecordItemIndex(22));
            repo.FrmBsvs.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.CbKopfAutomatisch' at Center.", repo.FrmBsvs.CbKopfAutomatischInfo, new RecordItemIndex(23));
            repo.FrmBsvs.CbKopfAutomatisch.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbCommonBestellen' at Center.", repo.FrmBsvs.PbCommonBestellenInfo, new RecordItemIndex(24));
            repo.FrmBsvs.PbCommonBestellen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PbNeuVerwalten' at Center.", repo.PbNeuVerwaltenInfo, new RecordItemIndex(25));
            repo.PbNeuVerwalten.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(26));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='200013') on item 'DlgMessageBox1.Rechnungsadr'.", repo.DlgMessageBox1.RechnungsadrInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.DlgMessageBox1.RechnungsadrInfo, "Text", "200013");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
