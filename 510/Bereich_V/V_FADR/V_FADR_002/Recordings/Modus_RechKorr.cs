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

namespace V_FADR_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Modus_RechKorr recording.
    /// </summary>
    [TestModule("399ae452-2fc9-4faa-a16f-e01b82acd36f", ModuleType.Recording, 1)]
    public partial class Modus_RechKorr : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FADR_002.V_FADR_002Repository repository.
        /// </summary>
        public static global::V_FADR_002.V_FADR_002Repository repo = global::V_FADR_002.V_FADR_002Repository.Instance;

        static Modus_RechKorr instance = new Modus_RechKorr();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Modus_RechKorr()
        {
            Microsoft_print_to_PDF = "Microsoft Print to PDF";
            Modus_Rechnungskorr = "R21/00005";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Modus_RechKorr Instance
        {
            get { return instance; }
        }

#region Variables

        string _Microsoft_print_to_PDF;

        /// <summary>
        /// Gets or sets the value of variable Microsoft_print_to_PDF.
        /// </summary>
        [TestVariable("238bf6a6-6392-49b8-b8a4-b59cef636eba")]
        public string Microsoft_print_to_PDF
        {
            get { return _Microsoft_print_to_PDF; }
            set { _Microsoft_print_to_PDF = value; }
        }

        string _Modus_Rechnungskorr;

        /// <summary>
        /// Gets or sets the value of variable Modus_Rechnungskorr.
        /// </summary>
        [TestVariable("f8d1dc95-0976-4cd6-ae39-01711a3fd643")]
        public string Modus_Rechnungskorr
        {
            get { return _Modus_Rechnungskorr; }
            set { _Modus_Rechnungskorr = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Buttons.Modus' at Center.", repo.Buttons.ModusInfo, new RecordItemIndex(0));
            repo.Buttons.Modus.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Moduswechsel.Rechnungskorrektur' at Center.", repo.Moduswechsel.RechnungskorrekturInfo, new RecordItemIndex(1));
            repo.Moduswechsel.Rechnungskorrektur.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Titelbar.TblFadr.RechNr' at Center.", repo.Titelbar.TblFadr.RechNrInfo, new RecordItemIndex(2));
            repo.Titelbar.TblFadr.RechNr.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'R21{RShiftKey down}/{RShiftKey up}00005' with focus on 'Titelbar.TblFadr.RechNr'.", repo.Titelbar.TblFadr.RechNrInfo, new RecordItemIndex(3));
            repo.Titelbar.TblFadr.RechNr.PressKeys("R21{RShiftKey down}/{RShiftKey up}00005");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Buttons.Laden' at Center.", repo.Buttons.LadenInfo, new RecordItemIndex(4));
            repo.Buttons.Laden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'R([0-9]{2})[\\/]([0-9]{5})$') on item 'Titelbar.TblFadr.R21_00005'.", repo.Titelbar.TblFadr.R21_00005Info, new RecordItemIndex(5));
            Validate.AttributeRegex(repo.Titelbar.TblFadr.R21_00005Info, "Text", new Regex("R([0-9]{2})[\\/]([0-9]{5})$"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Buttons.Drucken' at Center.", repo.Buttons.DruckenInfo, new RecordItemIndex(6));
            repo.Buttons.Drucken.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Moduswechsel.DruckerWechseln' at Center.", repo.Moduswechsel.DruckerWechselnInfo, new RecordItemIndex(7));
            repo.Moduswechsel.DruckerWechseln.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDruckerWechseln.OEffnen' at Center.", repo.DlgDruckerWechseln.OEffnenInfo, new RecordItemIndex(8));
            //repo.DlgDruckerWechseln.OEffnen.Click();
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.DateiausgabeStandardformat' at Center.", repo.List1000.DateiausgabeStandardformatInfo, new RecordItemIndex(9));
            //repo.List1000.DateiausgabeStandardformat.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Microsoft_print_to_PDF) on item 'DlgDruckerWechseln.CmbDrucker'.", repo.DlgDruckerWechseln.CmbDruckerInfo, new RecordItemIndex(10));
            Validate.AttributeContains(repo.DlgDruckerWechseln.CmbDruckerInfo, "Text", Microsoft_print_to_PDF);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDruckerWechseln.PbOk' at Center.", repo.DlgDruckerWechseln.PbOkInfo, new RecordItemIndex(11));
            repo.DlgDruckerWechseln.PbOk.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Titelbar.TblFadr.Row1Column0' at Center.", repo.Titelbar.TblFadr.Row1Column0Info, new RecordItemIndex(12));
            repo.Titelbar.TblFadr.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Buttons.Button_Fakturenerstellung' at Center.", repo.Buttons.Button_FakturenerstellungInfo, new RecordItemIndex(13));
            repo.Buttons.Button_Fakturenerstellung.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2') on item 'Titelbar.TblFadr.ColRechKzkorrRow1'.", repo.Titelbar.TblFadr.ColRechKzkorrRow1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.Titelbar.TblFadr.ColRechKzkorrRow1Info, "Text", "2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Buttons.Laden' at Center.", repo.Buttons.LadenInfo, new RecordItemIndex(15));
            repo.Buttons.Laden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Keine zu korrigierenden Rechnungen gefunden!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Keine zu korrigierenden Rechnungen gefunden!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(17));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
