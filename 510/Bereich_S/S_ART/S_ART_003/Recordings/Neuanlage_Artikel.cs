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

namespace S_ART_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neuanlage_Artikel recording.
    /// </summary>
    [TestModule("c0d66c11-bdef-474b-9f14-18e1a4887338", ModuleType.Recording, 1)]
    public partial class Neuanlage_Artikel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ART_003.S_ART_003Repository repository.
        /// </summary>
        public static global::S_ART_003.S_ART_003Repository repo = global::S_ART_003.S_ART_003Repository.Instance;

        static Neuanlage_Artikel instance = new Neuanlage_Artikel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_Artikel()
        {
            Arikelnummer = "100016";
            Bezeichnung_1 = "Chargen-mit Folgeartikel";
            Kurzbezeichnung = "QS_TEST_S_ART_003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_Artikel Instance
        {
            get { return instance; }
        }

#region Variables

        string _Arikelnummer;

        /// <summary>
        /// Gets or sets the value of variable Arikelnummer.
        /// </summary>
        [TestVariable("56c24473-b375-4d2f-a971-ea67c1b74529")]
        public string Arikelnummer
        {
            get { return _Arikelnummer; }
            set { _Arikelnummer = value; }
        }

        string _Bezeichnung_1;

        /// <summary>
        /// Gets or sets the value of variable Bezeichnung_1.
        /// </summary>
        [TestVariable("233af929-eeda-4448-8da6-b83658deb5bf")]
        public string Bezeichnung_1
        {
            get { return _Bezeichnung_1; }
            set { _Bezeichnung_1 = value; }
        }

        string _Kurzbezeichnung;

        /// <summary>
        /// Gets or sets the value of variable Kurzbezeichnung.
        /// </summary>
        [TestVariable("504ffb41-8022-46f6-970d-f5ba12488be8")]
        public string Kurzbezeichnung
        {
            get { return _Kurzbezeichnung; }
            set { _Kurzbezeichnung = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Suchleiste' at Center.", repo.FrmArt.SuchleisteInfo, new RecordItemIndex(0));
            repo.FrmArt.Suchleiste.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Arikelnummer' with focus on 'FrmArt.Suchleiste'.", repo.FrmArt.SuchleisteInfo, new RecordItemIndex(1));
            repo.FrmArt.Suchleiste.PressKeys(Arikelnummer);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmArt.Zeile_Suchleiste' at Center.", repo.FrmArt.Zeile_SuchleisteInfo, new RecordItemIndex(2));
            repo.FrmArt.Zeile_Suchleiste.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Arikelnummer) on item 'FrmArt.Art_Nr'.", repo.FrmArt.Art_NrInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmArt.Art_NrInfo, "Text", Arikelnummer);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Button_Zurueck' at Center.", repo.FrmArt.Button_ZurueckInfo, new RecordItemIndex(4));
            repo.FrmArt.Button_Zurueck.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Button_NEW' at Center.", repo.FrmArt.Button_NEWInfo, new RecordItemIndex(5));
            repo.FrmArt.Button_NEW.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Button_Nummer' at Center.", repo.FrmArt.Button_NummerInfo, new RecordItemIndex(6));
            repo.FrmArt.Button_Nummer.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'\\d{6}') on item 'FrmArt.Art_Nr'.", repo.FrmArt.Art_NrInfo, new RecordItemIndex(7));
            Validate.AttributeRegex(repo.FrmArt.Art_NrInfo, "Text", new Regex("\\d{6}"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmArt.Bezeichnung1' at Center.", repo.FrmArt.Bezeichnung1Info, new RecordItemIndex(8));
            repo.FrmArt.Bezeichnung1.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Bezeichnung_1' with focus on 'FrmArt.Bezeichnung1'.", repo.FrmArt.Bezeichnung1Info, new RecordItemIndex(9));
            repo.FrmArt.Bezeichnung1.PressKeys(Bezeichnung_1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Bezeichnung_1) on item 'FrmArt.Bezeichnung1'.", repo.FrmArt.Bezeichnung1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FrmArt.Bezeichnung1Info, "Text", Bezeichnung_1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Kurzbez' at Center.", repo.FrmArt.KurzbezInfo, new RecordItemIndex(11));
            repo.FrmArt.Kurzbez.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kurzbezeichnung' with focus on 'FrmArt.Kurzbez'.", repo.FrmArt.KurzbezInfo, new RecordItemIndex(12));
            repo.FrmArt.Kurzbez.PressKeys(Kurzbezeichnung);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kurzbezeichnung) on item 'FrmArt.Kurzbez'.", repo.FrmArt.KurzbezInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmArt.KurzbezInfo, "Text", Kurzbezeichnung);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.Button_Speichern' at Center.", repo.FrmArt.Button_SpeichernInfo, new RecordItemIndex(14));
            repo.FrmArt.Button_Speichern.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmArt.TextKz' at CenterLeft.", repo.FrmArt.TextKzInfo, new RecordItemIndex(15));
            repo.FrmArt.TextKz.Click(Location.CenterLeft);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '01{Tab}' with focus on 'FrmArt.TextKz'.", repo.FrmArt.TextKzInfo, new RecordItemIndex(16));
            repo.FrmArt.TextKz.PressKeys("01{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10{Tab}' with focus on 'FrmArt.Folgeartikel'.", repo.FrmArt.FolgeartikelInfo, new RecordItemIndex(17));
            repo.FrmArt.Folgeartikel.EnsureVisible();
            Keyboard.Press("10{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '100015{Tab}' with focus on 'FrmArt.Folgeartikel'.", repo.FrmArt.FolgeartikelInfo, new RecordItemIndex(18));
            repo.FrmArt.Folgeartikel.EnsureVisible();
            Keyboard.Press("100015{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{F12}' with focus on 'FrmArt.Folgeartikel'.", repo.FrmArt.FolgeartikelInfo, new RecordItemIndex(19));
            repo.FrmArt.Folgeartikel.EnsureVisible();
            Keyboard.Press("{F12}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100015') on item 'FrmArt.Text'.", repo.FrmArt.TextInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.FrmArt.TextInfo, "Text", "100015");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
