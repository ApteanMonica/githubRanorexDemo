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

namespace V_AUF_006.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kreditlimit100 recording.
    /// </summary>
    [TestModule("42f71f14-ee94-48a2-a85d-bea11856c146", ModuleType.Recording, 1)]
    public partial class Kreditlimit100 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_AUF_006.V_AUF_006Repository repository.
        /// </summary>
        public static global::V_AUF_006.V_AUF_006Repository repo = global::V_AUF_006.V_AUF_006Repository.Instance;

        static Kreditlimit100 instance = new Kreditlimit100();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kreditlimit100()
        {
            Kunde_Kreditlimit100 = "200004";
            Art_Nr_Kreditlimit = "100015";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kreditlimit100 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kunde_Kreditlimit100;

        /// <summary>
        /// Gets or sets the value of variable Kunde_Kreditlimit100.
        /// </summary>
        [TestVariable("dfb72b9b-b306-480f-a26b-ed306ef1d561")]
        public string Kunde_Kreditlimit100
        {
            get { return _Kunde_Kreditlimit100; }
            set { _Kunde_Kreditlimit100 = value; }
        }

        string _Art_Nr_Kreditlimit;

        /// <summary>
        /// Gets or sets the value of variable Art_Nr_Kreditlimit.
        /// </summary>
        [TestVariable("16eaacfd-c8fc-43fe-aaec-4f32270e7720")]
        public string Art_Nr_Kreditlimit
        {
            get { return _Art_Nr_Kreditlimit; }
            set { _Art_Nr_Kreditlimit = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbNew' at Center.", repo.FrmAufk.PbNewInfo, new RecordItemIndex(0));
            repo.FrmAufk.PbNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Kunde' at Center.", repo.FrmAufk.KundeInfo, new RecordItemIndex(1));
            repo.FrmAufk.Kunde.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kunde_Kreditlimit100' with focus on 'FrmAufk.Kunde'.", repo.FrmAufk.KundeInfo, new RecordItemIndex(2));
            repo.FrmAufk.Kunde.PressKeys(Kunde_Kreditlimit100);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAufk.Kunde'.", repo.FrmAufk.KundeInfo, new RecordItemIndex(3));
            //repo.FrmAufk.Kunde.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(4));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.DfAufkAdrWare' at Center.", repo.FrmAufk.DfAufkAdrWareInfo, new RecordItemIndex(5));
            repo.FrmAufk.DfAufkAdrWare.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1.5m for the attribute 'Text' to equal the specified value $Kunde_Kreditlimit100. Associated repository item: 'FrmAufk.DfAufkAdrWare'", repo.FrmAufk.DfAufkAdrWareInfo, new RecordItemIndex(7));
            repo.FrmAufk.DfAufkAdrWareInfo.WaitForAttributeEqual(90000, "Text", Kunde_Kreditlimit100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kunde_Kreditlimit100) on item 'FrmAufk.Kunde'.", repo.FrmAufk.KundeInfo, new RecordItemIndex(8));
            //Validate.AttributeEqual(repo.FrmAufk.KundeInfo, "Text", Kunde_Kreditlimit100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'FrmAufk.DfAufkZahlart'.", repo.FrmAufk.DfAufkZahlartInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmAufk.DfAufkZahlartInfo, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.TabPagePositionen' at Center.", repo.FrmAufk.TabPagePositionenInfo, new RecordItemIndex(10));
            repo.FrmAufk.TabPagePositionen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.ArtNr' at Center.", repo.FrmAufk.ArtNrInfo, new RecordItemIndex(11));
            repo.FrmAufk.ArtNr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Art_Nr_Kreditlimit' with focus on 'FrmAufk.ArtNr'.", repo.FrmAufk.ArtNrInfo, new RecordItemIndex(12));
            repo.FrmAufk.ArtNr.PressKeys(Art_Nr_Kreditlimit);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.Menge' at Center.", repo.FrmAufk.MengeInfo, new RecordItemIndex(13));
            repo.FrmAufk.Menge.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2{Tab}' with focus on 'FrmAufk.Menge'.", repo.FrmAufk.MengeInfo, new RecordItemIndex(14));
            repo.FrmAufk.Menge.PressKeys("2{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.DfAufpPreis' at Center.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(15));
            repo.FrmAufk.DfAufpPreis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '50{Tab}' with focus on 'FrmAufk.DfAufpPreis'.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(16));
            repo.FrmAufk.DfAufpPreis.PressKeys("50{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='50,000') on item 'FrmAufk.DfAufpPreis'.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.FrmAufk.DfAufpPreisInfo, "Text", "50,000");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Die maximal zulässige Preisabweichung von 10,00 %  wurde überschritten\r\n\r\nZulässiger Preisbereich: 9,900 - 12,100  EUR') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Die maximal zulässige Preisabweichung von 10,00 %  wurde überschritten\r\n\r\nZulässiger Preisbereich: 9,900 - 12,100  EUR");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(19));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(20));
            repo.FrmAufk.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ACHTUNG: Kreditlimit um 20,00 EUR überschritten\r\n\r\nWollen Sie die Position trotzdem speichern?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "ACHTUNG: Kreditlimit um 20,00 EUR überschritten\r\n\r\nWollen Sie die Position trotzdem speichern?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(22));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.Row1Column0' at Center.", repo.FrmAufk.Row1Column0Info, new RecordItemIndex(23));
            repo.FrmAufk.Row1Column0.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.DfAufpPreis' at Center.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(24));
            repo.FrmAufk.DfAufpPreis.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAufk.DfAufpPreis' at Center.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(25));
            repo.FrmAufk.DfAufpPreis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '40{Tab}' with focus on 'FrmAufk.DfAufpPreis'.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(26));
            repo.FrmAufk.DfAufpPreis.PressKeys("40{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Die maximal zulässige Preisabweichung von 10,00 %  wurde überschritten\r\n\r\nZulässiger Preisbereich: 9,900 - 12,100  EUR') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(27));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Die maximal zulässige Preisabweichung von 10,00 %  wurde überschritten\r\n\r\nZulässiger Preisbereich: 9,900 - 12,100  EUR");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='40,000') on item 'FrmAufk.DfAufpPreis'.", repo.FrmAufk.DfAufpPreisInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.FrmAufk.DfAufpPreisInfo, "Text", "40,000");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(29));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAufk.PbCommonSave' at Center.", repo.FrmAufk.PbCommonSaveInfo, new RecordItemIndex(30));
            repo.FrmAufk.PbCommonSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
