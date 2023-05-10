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

namespace L_DISP_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BV_generieren_und_bearbeiten recording.
    /// </summary>
    [TestModule("7175b899-c843-40b3-b944-404b75c2009b", ModuleType.Recording, 1)]
    public partial class BV_generieren_und_bearbeiten : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_DISP_002.L_DISP_002Repository repository.
        /// </summary>
        public static global::L_DISP_002.L_DISP_002Repository repo = global::L_DISP_002.L_DISP_002Repository.Instance;

        static BV_generieren_und_bearbeiten instance = new BV_generieren_und_bearbeiten();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BV_generieren_und_bearbeiten()
        {
            Artikel1 = "100020";
            Verdichtet = "    ";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BV_generieren_und_bearbeiten Instance
        {
            get { return instance; }
        }

#region Variables

        string _Artikel1;

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("5a12b8db-3167-4fa2-8738-071e10917de7")]
        public string Artikel1
        {
            get { return _Artikel1; }
            set { _Artikel1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Verdichtet.
        /// </summary>
        [TestVariable("0cd89311-dd4f-4472-9aa7-6eb0952fbc66")]
        public string Verdichtet
        {
            get { return repo.Verdichtet; }
            set { repo.Verdichtet = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.CbBsvkAuftrag' at Center.", repo.FrmDispo.CbBsvkAuftragInfo, new RecordItemIndex(0));
            repo.FrmDispo.CbBsvkAuftrag.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.Auftrag' at Center.", repo.FrmDispo.AuftragInfo, new RecordItemIndex(1));
            repo.FrmDispo.Auftrag.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'A{NumPad2}{NumPad0}{Divide}{NumPad0}{NumPad0}{NumPad0}{NumPad1}{NumPad3}{Tab}' with focus on 'FrmDispo.Auftrag'.", repo.FrmDispo.AuftragInfo, new RecordItemIndex(2));
            repo.FrmDispo.Auftrag.PressKeys("A{NumPad2}{NumPad0}{Divide}{NumPad0}{NumPad0}{NumPad0}{NumPad1}{NumPad3}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.ColWert1Row4' at Center.", repo.FrmDispo.ColWert1Row4Info, new RecordItemIndex(3));
            repo.FrmDispo.ColWert1Row4.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Artikel1' with focus on 'FrmDispo.ColWert1Row4'.", repo.FrmDispo.ColWert1Row4Info, new RecordItemIndex(4));
            repo.FrmDispo.ColWert1Row4.PressKeys(Artikel1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmDispo.ColWert1Row4'.", repo.FrmDispo.ColWert1Row4Info, new RecordItemIndex(5));
            repo.FrmDispo.ColWert1Row4.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.PbExtrasStart' at Center.", repo.FrmDispo.PbExtrasStartInfo, new RecordItemIndex(6));
            repo.FrmDispo.PbExtrasStart.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'neuer Bestellvorschlag mit der Nummer') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "neuer Bestellvorschlag mit der Nummer");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.PbExtrasBearbeiten' at Center.", repo.FrmDispo.PbExtrasBearbeitenInfo, new RecordItemIndex(9));
            repo.FrmDispo.PbExtrasBearbeiten.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbDataAccessLoad' at Center.", repo.FrmBsvs.PbDataAccessLoadInfo, new RecordItemIndex(10));
            repo.FrmBsvs.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'FrmBsvs.FlexGrid.ColArtNrRow1'.", repo.FrmBsvs.FlexGrid.ColArtNrRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColArtNrRow1Info, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='0') on item 'FrmBsvs.FlexGrid.ColBsvsKzausloesRow1'.", repo.FrmBsvs.FlexGrid.ColBsvsKzausloesRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColBsvsKzausloesRow1Info, "Text", "0");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'FrmBsvs.FlexGrid.ColArtNrRow2'.", repo.FrmBsvs.FlexGrid.ColArtNrRow2Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColArtNrRow2Info, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='A') on item 'FrmBsvs.FlexGrid.ColBsvsKzausloesRow2'.", repo.FrmBsvs.FlexGrid.ColBsvsKzausloesRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColBsvsKzausloesRow2Info, "Text", "A");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1,00') on item 'FrmBsvs.FlexGrid.ColBsvsFehlmRow1'.", repo.FrmBsvs.FlexGrid.ColBsvsFehlmRow1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColBsvsFehlmRow1Info, "Text", "1,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.CbVerdichtung' at Center.", repo.FrmBsvs.CbVerdichtungInfo, new RecordItemIndex(16));
            repo.FrmBsvs.CbVerdichtung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.PbDataAccessLoad' at Center.", repo.FrmBsvs.PbDataAccessLoadInfo, new RecordItemIndex(17));
            repo.FrmBsvs.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'FrmBsvs.FlexGrid.ColArtNrRow1'.", repo.FrmBsvs.FlexGrid.ColArtNrRow1Info, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColArtNrRow1Info, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2,00') on item 'FrmBsvs.FlexGrid.ColBsvsFehlmRow1'.", repo.FrmBsvs.FlexGrid.ColBsvsFehlmRow1Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.FrmBsvs.FlexGrid.ColBsvsFehlmRow1Info, "Text", "2,00");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmBsvs.Schliessen' at Center.", repo.FrmBsvs.SchliessenInfo, new RecordItemIndex(20));
            repo.FrmBsvs.Schliessen.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
