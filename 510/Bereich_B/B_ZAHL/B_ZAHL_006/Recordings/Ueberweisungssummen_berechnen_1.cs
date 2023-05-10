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

namespace B_ZAHL_006.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberweisungssummen_berechnen_1 recording.
    /// </summary>
    [TestModule("83fda221-f764-49f0-bd6a-e1462c388e9a", ModuleType.Recording, 1)]
    public partial class Ueberweisungssummen_berechnen_1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_006.B_ZAHL_006Repository repository.
        /// </summary>
        public static global::B_ZAHL_006.B_ZAHL_006Repository repo = global::B_ZAHL_006.B_ZAHL_006Repository.Instance;

        static Ueberweisungssummen_berechnen_1 instance = new Ueberweisungssummen_berechnen_1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberweisungssummen_berechnen_1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberweisungssummen_berechnen_1 Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER60A.
        /// </summary>
        [TestVariable("28c45491-80cf-4d16-be94-afd112140c70")]
        public string Beleg_ER60A
        {
            get { return repo.Beleg_ER60A; }
            set { repo.Beleg_ER60A = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER60B.
        /// </summary>
        [TestVariable("4750b463-db26-4c3b-bd42-d3a087a61b24")]
        public string Beleg_ER60B
        {
            get { return repo.Beleg_ER60B; }
            set { repo.Beleg_ER60B = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER65_DIV1.
        /// </summary>
        [TestVariable("20893d04-419f-4e59-b027-311c315de71a")]
        public string Beleg_ER65_DIV1
        {
            get { return repo.Beleg_ER65_DIV1; }
            set { repo.Beleg_ER65_DIV1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER65_DIV2.
        /// </summary>
        [TestVariable("47df7581-c7b1-425d-8d57-10c138fce8a9")]
        public string Beleg_ER65_DIV2
        {
            get { return repo.Beleg_ER65_DIV2; }
            set { repo.Beleg_ER65_DIV2 = value; }
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

            // Shortcut Strg+B funktioniert in Ranorex nicht zur Auswahl "Überweisungssummen berechnen"
            //Report.Log(ReportLevel.Info, "Keyboard", "Shortcut Strg+B funktioniert in Ranorex nicht zur Auswahl \"Überweisungssummen berechnen\"\r\nKey 'Ctrl+B' Press.", new RecordItemIndex(0));
            //Keyboard.Press(System.Windows.Forms.Keys.B | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.PbFunktionenFunktionen' at Center.", repo.FrmZlvsAEndern.PbFunktionenFunktionenInfo, new RecordItemIndex(1));
            repo.FrmZlvsAEndern.PbFunktionenFunktionen.Click();
            
            // disabled, Element wird nicht gefunden
            //Report.Log(ReportLevel.Info, "Mouse", "disabled, Element wird nicht gefunden\r\nMouse Left Click item 'BZAHL1.UEberweisungssummenBerechnen' at Center.", repo.BZAHL1.UEberweisungssummenBerechnenInfo, new RecordItemIndex(2));
            //repo.BZAHL1.UEberweisungssummenBerechnen.Click();
            
            // Eingabe "ü" statt Auswahl "Überweisungssummen berechnen"
            Report.Log(ReportLevel.Info, "Keyboard", "Eingabe \"ü\" statt Auswahl \"Überweisungssummen berechnen\"\r\nKey sequence 'ü'.", new RecordItemIndex(3));
            Keyboard.Press("ü");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Überweisungssummen berechnen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Überweisungssummen berechnen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(7));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'DlgMessageBox.LabelMeldungstext'", repo.DlgMessageBox.LabelMeldungstextInfo, new ActionTimeout(60000), new RecordItemIndex(8));
            repo.DlgMessageBox.LabelMeldungstextInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Überweisungssummen berechnet!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Überweisungssummen berechnet!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmZlvsAEndern.PbDataAccessLaden' at Center.", repo.FrmZlvsAEndern.PbDataAccessLadenInfo, new RecordItemIndex(11));
            repo.FrmZlvsAEndern.PbDataAccessLaden.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_ER60A.ColZlvuNrRow_ER60A'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER60A.ColZlvuNrRow_ER60AInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER60A.ColZlvuNrRow_ER60AInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_ER60B.ColZlvuNrRow_ER60B'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER60B.ColZlvuNrRow_ER60BInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER60B.ColZlvuNrRow_ER60BInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_ER65_DIV1.ColZlvuNrRow_ER65_DIV1'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER65_DIV1.ColZlvuNrRow_ER65_DIV1Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER65_DIV1.ColZlvuNrRow_ER65_DIV1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FrmZlvsAEndern.ChildTableWindow.Zeile_ER65_DIV2.ColZlvuNrRow_ER65_DIV2'.", repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER65_DIV2.ColZlvuNrRow_ER65_DIV2Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.FrmZlvsAEndern.ChildTableWindow.Zeile_ER65_DIV2.ColZlvuNrRow_ER65_DIV2Info, "Text", "1");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
