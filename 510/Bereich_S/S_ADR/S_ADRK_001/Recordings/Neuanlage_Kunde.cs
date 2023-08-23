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

namespace S_ADRK_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neuanlage_Kunde recording.
    /// </summary>
    [TestModule("14beffcc-422a-4506-881b-e9df3fc277b3", ModuleType.Recording, 1)]
    public partial class Neuanlage_Kunde : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADRK_001.S_ADRK_001Repository repository.
        /// </summary>
        public static global::S_ADRK_001.S_ADRK_001Repository repo = global::S_ADRK_001.S_ADRK_001Repository.Instance;

        static Neuanlage_Kunde instance = new Neuanlage_Kunde();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_Kunde()
        {
            Kurzname = "KUNDE_QS_RANOREX";
            Firma1 = "Ranorex GmbH & Co. KG";
            Strasse = "Dorfstraße 67";
            PLZ = "5020";
            Ort = "Salzburg";
            meldung1 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_Kunde Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kurzname;

        /// <summary>
        /// Gets or sets the value of variable Kurzname.
        /// </summary>
        [TestVariable("0c3b6da0-6e7c-46a9-b9c3-788e958af313")]
        public string Kurzname
        {
            get { return _Kurzname; }
            set { _Kurzname = value; }
        }

        string _Firma1;

        /// <summary>
        /// Gets or sets the value of variable Firma1.
        /// </summary>
        [TestVariable("2161cd13-ec70-49a6-b3ef-b749e1af9af3")]
        public string Firma1
        {
            get { return _Firma1; }
            set { _Firma1 = value; }
        }

        string _Strasse;

        /// <summary>
        /// Gets or sets the value of variable Strasse.
        /// </summary>
        [TestVariable("64faa46f-de39-4472-b4f5-810d52c43e0d")]
        public string Strasse
        {
            get { return _Strasse; }
            set { _Strasse = value; }
        }

        string _PLZ;

        /// <summary>
        /// Gets or sets the value of variable PLZ.
        /// </summary>
        [TestVariable("031e72b9-959b-46da-870d-88cdb44e0f94")]
        public string PLZ
        {
            get { return _PLZ; }
            set { _PLZ = value; }
        }

        string _Ort;

        /// <summary>
        /// Gets or sets the value of variable Ort.
        /// </summary>
        [TestVariable("20c1e33e-39c1-4375-ac6e-db65b8a0ece3")]
        public string Ort
        {
            get { return _Ort; }
            set { _Ort = value; }
        }

        string _meldung1;

        /// <summary>
        /// Gets or sets the value of variable meldung1.
        /// </summary>
        [TestVariable("6093b6b1-fb01-497b-a1ac-11bcbb819d33")]
        public string meldung1
        {
            get { return _meldung1; }
            set { _meldung1 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Button_Neu' at Center.", repo.FrmAdr.Button_NeuInfo, new RecordItemIndex(0));
            repo.FrmAdr.Button_Neu.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.ClientArea.Kurzname' at Center.", repo.FrmAdr.ClientArea.KurznameInfo, new RecordItemIndex(1));
            repo.FrmAdr.ClientArea.Kurzname.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kurzname' with focus on 'FrmAdr.ClientArea.Kurzname'.", repo.FrmAdr.ClientArea.KurznameInfo, new RecordItemIndex(2));
            repo.FrmAdr.ClientArea.Kurzname.PressKeys(Kurzname);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.ClientArea.Kurzname'.", repo.FrmAdr.ClientArea.KurznameInfo, new RecordItemIndex(3));
            repo.FrmAdr.ClientArea.Kurzname.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kurzname) on item 'FrmAdr.ClientArea.Kurzname'.", repo.FrmAdr.ClientArea.KurznameInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmAdr.ClientArea.KurznameInfo, "Text", Kurzname);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Firma1' with focus on 'FrmAdr.ClientArea.Firma1'.", repo.FrmAdr.ClientArea.Firma1Info, new RecordItemIndex(5));
            repo.FrmAdr.ClientArea.Firma1.PressKeys(Firma1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Firma1) on item 'FrmAdr.ClientArea.Firma1'.", repo.FrmAdr.ClientArea.Firma1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmAdr.ClientArea.Firma1Info, "Text", Firma1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Strasse' at Center.", repo.FrmAdr.StrasseInfo, new RecordItemIndex(7));
            repo.FrmAdr.Strasse.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Strasse' with focus on 'FrmAdr.Strasse'.", repo.FrmAdr.StrasseInfo, new RecordItemIndex(8));
            repo.FrmAdr.Strasse.PressKeys(Strasse);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Strasse) on item 'FrmAdr.Strasse'.", repo.FrmAdr.StrasseInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FrmAdr.StrasseInfo, "Text", Strasse);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.PLZ' at Center.", repo.FrmAdr.PLZInfo, new RecordItemIndex(10));
            repo.FrmAdr.PLZ.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PLZ' with focus on 'FrmAdr.PLZ'.", repo.FrmAdr.PLZInfo, new RecordItemIndex(11));
            repo.FrmAdr.PLZ.PressKeys(PLZ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.PLZ'.", repo.FrmAdr.PLZInfo, new RecordItemIndex(12));
            repo.FrmAdr.PLZ.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PLZ) on item 'FrmAdr.PLZ'.", repo.FrmAdr.PLZInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmAdr.PLZInfo, "Text", PLZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ort) on item 'FrmAdr.Ort'.", repo.FrmAdr.OrtInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmAdr.OrtInfo, "Text", Ort);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Speicher_Button' at Center.", repo.FrmAdr.Speicher_ButtonInfo, new RecordItemIndex(15));
            repo.FrmAdr.Speicher_Button.Click();
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'DlgMessageBox.LabelMeldungstext1' and assigning its value to variable 'meldung1'.", repo.DlgMessageBox.LabelMeldungstext1Info, new RecordItemIndex(16));
            meldung1 = repo.DlgMessageBox.LabelMeldungstext1.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateTextWithoutWhiteSpaces(meldung1, "Bitte Kundennummer eingeben !");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Bestaetigung_Fehlermeldung' at Center.", repo.DlgMessageBox.Bestaetigung_FehlermeldungInfo, new RecordItemIndex(18));
            repo.DlgMessageBox.Bestaetigung_Fehlermeldung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Nummer_Button' at Center.", repo.FrmAdr.Nummer_ButtonInfo, new RecordItemIndex(19));
            repo.FrmAdr.Nummer_Button.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'\\d{6}') on item 'FrmAdr.ClientArea.DfAdrNr'.", repo.FrmAdr.ClientArea.DfAdrNrInfo, new RecordItemIndex(20));
            Validate.AttributeRegex(repo.FrmAdr.ClientArea.DfAdrNrInfo, "Text", new Regex("\\d{6}"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.Speicher_Button' at Center.", repo.FrmAdr.Speicher_ButtonInfo, new RecordItemIndex(21));
            repo.FrmAdr.Speicher_Button.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
