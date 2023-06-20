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

namespace S_PRLKL_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neue_Preisliste_anlegen recording.
    /// </summary>
    [TestModule("6b915584-c11f-40ec-8921-6e6b16bad447", ModuleType.Recording, 1)]
    public partial class Neue_Preisliste_anlegen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_PRLKL_001.S_PRLKL_001Repository repository.
        /// </summary>
        public static global::S_PRLKL_001.S_PRLKL_001Repository repo = global::S_PRLKL_001.S_PRLKL_001Repository.Instance;

        static Neue_Preisliste_anlegen instance = new Neue_Preisliste_anlegen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neue_Preisliste_anlegen()
        {
            Lieferant = "";
            Anzahl_Nachkomma = "";
            KzRabatt = "";
            Datumskennzeichen = "";
            Von_Datum = "";
            Waehrung = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neue_Preisliste_anlegen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Lieferant;

        /// <summary>
        /// Gets or sets the value of variable Lieferant.
        /// </summary>
        [TestVariable("10640d38-ed99-44e7-be45-e51c8937410a")]
        public string Lieferant
        {
            get { return _Lieferant; }
            set { _Lieferant = value; }
        }

        string _Anzahl_Nachkomma;

        /// <summary>
        /// Gets or sets the value of variable Anzahl_Nachkomma.
        /// </summary>
        [TestVariable("5e1c9639-2fb5-4963-b571-344f3398f06e")]
        public string Anzahl_Nachkomma
        {
            get { return _Anzahl_Nachkomma; }
            set { _Anzahl_Nachkomma = value; }
        }

        string _KzRabatt;

        /// <summary>
        /// Gets or sets the value of variable KzRabatt.
        /// </summary>
        [TestVariable("7439a3d5-4537-4cd3-85cb-b536d10fb84c")]
        public string KzRabatt
        {
            get { return _KzRabatt; }
            set { _KzRabatt = value; }
        }

        string _Datumskennzeichen;

        /// <summary>
        /// Gets or sets the value of variable Datumskennzeichen.
        /// </summary>
        [TestVariable("08225923-ad14-4958-a5c1-720ea7c0b9c1")]
        public string Datumskennzeichen
        {
            get { return _Datumskennzeichen; }
            set { _Datumskennzeichen = value; }
        }

        string _Von_Datum;

        /// <summary>
        /// Gets or sets the value of variable Von_Datum.
        /// </summary>
        [TestVariable("d3a01c7a-b489-4a63-831e-f0f50b1fb18f")]
        public string Von_Datum
        {
            get { return _Von_Datum; }
            set { _Von_Datum = value; }
        }

        string _Waehrung;

        /// <summary>
        /// Gets or sets the value of variable Waehrung.
        /// </summary>
        [TestVariable("839c020d-cbb1-4cc7-81d9-57e4bcac33bc")]
        public string Waehrung
        {
            get { return _Waehrung; }
            set { _Waehrung = value; }
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
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmPrlk.FrmSearchPage.PbNew' at Center.", repo.FrmPrlk.FrmSearchPage.PbNewInfo, new RecordItemIndex(0));
            repo.FrmPrlk.FrmSearchPage.PbNew.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmPrlk.Nummer' at Center.", repo.FrmPrlk.NummerInfo, new RecordItemIndex(1));
            repo.FrmPrlk.Nummer.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Lieferant' with focus on 'FrmPrlk.Nummer'.", repo.FrmPrlk.NummerInfo, new RecordItemIndex(2));
            repo.FrmPrlk.Nummer.PressKeys(Lieferant);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Waehrung) on item 'FrmPrlk.Waehrung'.", repo.FrmPrlk.WaehrungInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FrmPrlk.WaehrungInfo, "Text", Waehrung);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$Anzahl_Nachkomma' on item 'FrmPrlk.Nachkommastellen'.", repo.FrmPrlk.NachkommastellenInfo, new RecordItemIndex(5));
            repo.FrmPrlk.Nachkommastellen.Element.SetAttributeValue("AccessibleValue", Anzahl_Nachkomma);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Anzahl_Nachkomma) on item 'FrmPrlk.Nachkommastellen'.", repo.FrmPrlk.NachkommastellenInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FrmPrlk.NachkommastellenInfo, "Text", Anzahl_Nachkomma);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute AccessibleValue to '$KzRabatt' on item 'FrmPrlk.Kz_Rabatt'.", repo.FrmPrlk.Kz_RabattInfo, new RecordItemIndex(7));
            repo.FrmPrlk.Kz_Rabatt.Element.SetAttributeValue("AccessibleValue", KzRabatt);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KzRabatt) on item 'FrmPrlk.Kz_Rabatt'.", repo.FrmPrlk.Kz_RabattInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FrmPrlk.Kz_RabattInfo, "Text", KzRabatt);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datumskennzeichen' with focus on 'FrmPrlk.Datumskennz'.", repo.FrmPrlk.DatumskennzInfo, new RecordItemIndex(9));
            repo.FrmPrlk.Datumskennz.PressKeys(Datumskennzeichen);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmPrlk.FlexGrid' at Center.", repo.FrmPrlk.FlexGridInfo, new RecordItemIndex(10));
            repo.FrmPrlk.FlexGrid.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Insert' Press.", new RecordItemIndex(11));
            Keyboard.Press(System.Windows.Forms.Keys.Insert, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmPrlk.ColPrldDtvonRow1' at Center.", repo.FrmPrlk.ColPrldDtvonRow1Info, new RecordItemIndex(12));
            repo.FrmPrlk.ColPrldDtvonRow1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Von_Datum' with focus on 'FrmPrlk.FlexGrid'.", repo.FrmPrlk.FlexGridInfo, new RecordItemIndex(13));
            repo.FrmPrlk.FlexGrid.PressKeys(Von_Datum);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmPrlk.Speichern' at Center.", repo.FrmPrlk.SpeichernInfo, new RecordItemIndex(14));
            repo.FrmPrlk.Speichern.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue=$Von_Datum) on item 'FrmPrlk.ColPrldDtvonRow1'.", repo.FrmPrlk.ColPrldDtvonRow1Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmPrlk.ColPrldDtvonRow1Info, "AccessibleValue", Von_Datum);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
