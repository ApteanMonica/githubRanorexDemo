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

namespace L_DISP_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BV_bestandsbezogen_erstellen recording.
    /// </summary>
    [TestModule("1d7e6c9c-a3a4-4066-89c3-e2d534a6ad8c", ModuleType.Recording, 1)]
    public partial class BV_bestandsbezogen_erstellen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::L_DISP_001.L_DISP_001Repository repository.
        /// </summary>
        public static global::L_DISP_001.L_DISP_001Repository repo = global::L_DISP_001.L_DISP_001Repository.Instance;

        static BV_bestandsbezogen_erstellen instance = new BV_bestandsbezogen_erstellen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BV_bestandsbezogen_erstellen()
        {
            Dispo_art = "BVS";
            Lager = "100";
            Artikel1 = "100020";
            Artikel2 = "100021";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BV_bestandsbezogen_erstellen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dispo_art;

        /// <summary>
        /// Gets or sets the value of variable Dispo_art.
        /// </summary>
        [TestVariable("f3cfff89-379d-4a0f-9c03-6263b770381f")]
        public string Dispo_art
        {
            get { return _Dispo_art; }
            set { _Dispo_art = value; }
        }

        string _Lager;

        /// <summary>
        /// Gets or sets the value of variable Lager.
        /// </summary>
        [TestVariable("2d8a3fe9-1490-43e9-8846-fceb8714125d")]
        public string Lager
        {
            get { return _Lager; }
            set { _Lager = value; }
        }

        string _Artikel1;

        /// <summary>
        /// Gets or sets the value of variable Artikel1.
        /// </summary>
        [TestVariable("67489f18-4c62-40fd-b6dc-d1474eedd28e")]
        public string Artikel1
        {
            get { return _Artikel1; }
            set { _Artikel1 = value; }
        }

        string _Artikel2;

        /// <summary>
        /// Gets or sets the value of variable Artikel2.
        /// </summary>
        [TestVariable("eac01a97-e688-4df5-9393-332721ca706e")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.Text' at Center.", repo.FrmDispo.TextInfo, new RecordItemIndex(0));
            repo.FrmDispo.Text.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$Dispo_art) on item 'FrmDispo.Text'.", repo.FrmDispo.TextInfo, new RecordItemIndex(1));
            Validate.AttributeRegex(repo.FrmDispo.TextInfo, "Text", new Regex(Dispo_art));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmDispo.CbBsvkBestand'.", repo.FrmDispo.CbBsvkBestandInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmDispo.CbBsvkBestandInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'FrmDispo.RbBsvkMindest'.", repo.FrmDispo.RbBsvkMindestInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmDispo.RbBsvkMindestInfo, "Checked", "True");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.RbDezentral' at Center.", repo.FrmDispo.RbDezentralInfo, new RecordItemIndex(4));
            repo.FrmDispo.RbDezentral.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Lager) on item 'FrmDispo.Lager'.", repo.FrmDispo.LagerInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FrmDispo.LagerInfo, "Text", Lager);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.ColWert1Row4' at Center.", repo.FrmDispo.ColWert1Row4Info, new RecordItemIndex(6));
            repo.FrmDispo.ColWert1Row4.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad0}{NumPad0}{NumPad0}{NumPad2}{NumPad0}' with focus on 'FrmDispo.ColWert1Row4'.", repo.FrmDispo.ColWert1Row4Info, new RecordItemIndex(7));
            repo.FrmDispo.ColWert1Row4.EnsureVisible();
            Keyboard.Press("{NumPad1}{NumPad0}{NumPad0}{NumPad0}{NumPad2}{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmDispo.ColWert1Row4'.", repo.FrmDispo.ColWert1Row4Info, new RecordItemIndex(8));
            repo.FrmDispo.ColWert1Row4.EnsureVisible();
            Keyboard.Press("{Tab}");
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.ColWert2Row4' at Center.", repo.FrmDispo.ColWert2Row4Info, new RecordItemIndex(9));
            //repo.FrmDispo.ColWert2Row4.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(10));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad0}{NumPad0}{NumPad0}{NumPad2}{NumPad4}{Tab}' with focus on 'FrmDispo.ColWert2Row4'.", repo.FrmDispo.ColWert2Row4Info, new RecordItemIndex(11));
            repo.FrmDispo.ColWert2Row4.PressKeys("{NumPad1}{NumPad0}{NumPad0}{NumPad0}{NumPad2}{NumPad4}{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.PbExtrasListe' at Center.", repo.FrmDispo.PbExtrasListeInfo, new RecordItemIndex(12));
            repo.FrmDispo.PbExtrasListe.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel1) on item 'TblDispVSL.ColArtNrRow1'.", repo.TblDispVSL.ColArtNrRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblDispVSL.ColArtNrRow1Info, "Text", Artikel1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Artikel2) on item 'TblDispVSL.ColArtNrRow2'.", repo.TblDispVSL.ColArtNrRow2Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblDispVSL.ColArtNrRow2Info, "Text", Artikel2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblDispVSL.Schliessen' at Center.", repo.TblDispVSL.SchliessenInfo, new RecordItemIndex(15));
            repo.TblDispVSL.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmDispo.PbExtrasStart' at Center.", repo.FrmDispo.PbExtrasStartInfo, new RecordItemIndex(16));
            repo.FrmDispo.PbExtrasStart.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'neuer Bestellvorschlag mit der Nummer') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(17));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "neuer Bestellvorschlag mit der Nummer");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(18));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
