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

namespace S_ADRK_002.Recording
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UID_Pruefung recording.
    /// </summary>
    [TestModule("a82fe075-d41f-49c0-9843-d4bc90bc4a82", ModuleType.Recording, 1)]
    public partial class UID_Pruefung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADRK_002.S_ADRK_002Repository repository.
        /// </summary>
        public static global::S_ADRK_002.S_ADRK_002Repository repo = global::S_ADRK_002.S_ADRK_002Repository.Instance;

        static UID_Pruefung instance = new UID_Pruefung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UID_Pruefung()
        {
            UID_korrekt = "U75601939";
            UID_falsch = "475601939";
            UID_nicht_gueltig = "UID-Prüfung: die angegebene UID ist nicht gültig.";
            Neue_Kundennummer = "";
            Aptean_Austria = "Aptean Austria GmbH";
            newText = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UID_Pruefung Instance
        {
            get { return instance; }
        }

#region Variables

        string _UID_korrekt;

        /// <summary>
        /// Gets or sets the value of variable UID_korrekt.
        /// </summary>
        [TestVariable("fc37aa28-17ab-48ac-9569-1c29f3544245")]
        public string UID_korrekt
        {
            get { return _UID_korrekt; }
            set { _UID_korrekt = value; }
        }

        string _UID_falsch;

        /// <summary>
        /// Gets or sets the value of variable UID_falsch.
        /// </summary>
        [TestVariable("c6c9c4c4-ecd7-4410-8fc2-82828da57a76")]
        public string UID_falsch
        {
            get { return _UID_falsch; }
            set { _UID_falsch = value; }
        }

        string _UID_nicht_gueltig;

        /// <summary>
        /// Gets or sets the value of variable UID_nicht_gueltig.
        /// </summary>
        [TestVariable("bcf9dfe0-2a23-4243-bb4f-07015e44e55b")]
        public string UID_nicht_gueltig
        {
            get { return _UID_nicht_gueltig; }
            set { _UID_nicht_gueltig = value; }
        }

        string _Neue_Kundennummer;

        /// <summary>
        /// Gets or sets the value of variable Neue_Kundennummer.
        /// </summary>
        [TestVariable("9e7d6e54-13b1-4633-941b-2b65e5af0a14")]
        public string Neue_Kundennummer
        {
            get { return _Neue_Kundennummer; }
            set { _Neue_Kundennummer = value; }
        }

        string _Aptean_Austria;

        /// <summary>
        /// Gets or sets the value of variable Aptean_Austria.
        /// </summary>
        [TestVariable("75448926-2327-48d9-ba86-c5884950958e")]
        public string Aptean_Austria
        {
            get { return _Aptean_Austria; }
            set { _Aptean_Austria = value; }
        }

        string _newText;

        /// <summary>
        /// Gets or sets the value of variable newText.
        /// </summary>
        [TestVariable("7d021c0e-18d0-4e66-81e4-9f081e53a7b4")]
        public string newText
        {
            get { return _newText; }
            set { _newText = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAdr.TpAllgemein.UID_Nr' at Center.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(0));
            repo.FrmAdr.TpAllgemein.UID_Nr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UID_falsch' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(1));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys(UID_falsch);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(2));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UID_nicht_gueltig) on item 'DlgMessageBox.Fehlermeldung_UID_Nicht_gueltig'.", repo.DlgMessageBox.Fehlermeldung_UID_Nicht_gueltigInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgMessageBox.Fehlermeldung_UID_Nicht_gueltigInfo, "Text", UID_nicht_gueltig);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.OK' at Center.", repo.DlgMessageBox.OKInfo, new RecordItemIndex(4));
            repo.DlgMessageBox.OK.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UID_korrekt' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(5));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys(UID_korrekt);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(6));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys("{Tab}");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Aptean_Austria) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            //Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", Aptean_Austria);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'DlgMessageBox.LabelMeldungstext' and assigning its value to variable 'newText'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(8));
            newText = repo.DlgMessageBox.LabelMeldungstext.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateTextWithoutBreaks(newText, Aptean_Austria);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.OK' at Center.", repo.DlgMessageBox.OKInfo, new RecordItemIndex(10));
            repo.DlgMessageBox.OK.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Speicher_Button' at Center.", repo.FrmAdr.Speicher_ButtonInfo, new RecordItemIndex(11));
            repo.FrmAdr.Speicher_Button.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UID_falsch' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(12));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys(UID_falsch);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(13));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UID_nicht_gueltig) on item 'DlgMessageBox.Fehlermeldung_UID_Nicht_gueltig'.", repo.DlgMessageBox.Fehlermeldung_UID_Nicht_gueltigInfo, new RecordItemIndex(14));
            Validate.AttributeContains(repo.DlgMessageBox.Fehlermeldung_UID_Nicht_gueltigInfo, "Text", UID_nicht_gueltig);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.OK' at Center.", repo.DlgMessageBox.OKInfo, new RecordItemIndex(15));
            repo.DlgMessageBox.OK.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Speicher_Button' at Center.", repo.FrmAdr.Speicher_ButtonInfo, new RecordItemIndex(16));
            repo.FrmAdr.Speicher_Button.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Extras' at Center.", repo.FrmAdr.ExtrasInfo, new RecordItemIndex(17));
            repo.FrmAdr.Extras.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SADR.UIDPruefung' at Center.", repo.SADR.UIDPruefungInfo, new RecordItemIndex(18));
            repo.SADR.UIDPruefung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Bearbeiten' at Center.", repo.BearbeitenInfo, new RecordItemIndex(19));
            repo.Bearbeiten.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUidCheck.DfAdrNrVon' at Center.", repo.TblUidCheck.DfAdrNrVonInfo, new RecordItemIndex(20));
            repo.TblUidCheck.DfAdrNrVon.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Neue_Kundennummer' with focus on 'TblUidCheck.DfAdrNrVon'.", repo.TblUidCheck.DfAdrNrVonInfo, new RecordItemIndex(21));
            repo.TblUidCheck.DfAdrNrVon.PressKeys(Neue_Kundennummer);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUidCheck.Laden' at Center.", repo.TblUidCheck.LadenInfo, new RecordItemIndex(22));
            repo.TblUidCheck.Laden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='ATU75818635') on item 'TblUidCheck.ColAdrUidnrRow1'.", repo.TblUidCheck.ColAdrUidnrRow1Info, new RecordItemIndex(23));
            Validate.AttributeEqual(repo.TblUidCheck.ColAdrUidnrRow1Info, "Text", "ATU75818635");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblUidCheck.Schliessen' at Center.", repo.TblUidCheck.SchliessenInfo, new RecordItemIndex(24));
            repo.TblUidCheck.Schliessen.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAdr.TpAllgemein.UID_Nr' at Center.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(25));
            repo.FrmAdr.TpAllgemein.UID_Nr.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UID_korrekt' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(26));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys(UID_korrekt);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.TpAllgemein.UID_Nr'.", repo.FrmAdr.TpAllgemein.UID_NrInfo, new RecordItemIndex(27));
            repo.FrmAdr.TpAllgemein.UID_Nr.PressKeys("{Tab}");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Aptean_Austria) on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(28));
            //Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", Aptean_Austria);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'DlgMessageBox.LabelMeldungstext' and assigning its value to variable 'newText'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(29));
            newText = repo.DlgMessageBox.LabelMeldungstext.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateTextWithoutBreaks(newText, Aptean_Austria);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.OK' at Center.", repo.DlgMessageBox.OKInfo, new RecordItemIndex(31));
            repo.DlgMessageBox.OK.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Speicher_Button' at Center.", repo.FrmAdr.Speicher_ButtonInfo, new RecordItemIndex(32));
            repo.FrmAdr.Speicher_Button.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
