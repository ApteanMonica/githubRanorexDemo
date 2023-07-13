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

namespace N_LISTEN_BULI_001.Recordings_b_exops
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Versuch_nochmalige_Ueberleitung recording.
    /// </summary>
    [TestModule("a7e783a5-2033-4695-991d-5c9edba779f4", ModuleType.Recording, 1)]
    public partial class Versuch_nochmalige_Ueberleitung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static Versuch_nochmalige_Ueberleitung instance = new Versuch_nochmalige_Ueberleitung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Versuch_nochmalige_Ueberleitung()
        {
            Belegnummer_Ueberleitung = "BULI_001_A";
            Belegdatum_Ueberleitung = "31.12.2022";
            Ust_Code_Ueberleitung = "V00";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Versuch_nochmalige_Ueberleitung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Belegdatum_Ueberleitung;

        /// <summary>
        /// Gets or sets the value of variable Belegdatum_Ueberleitung.
        /// </summary>
        [TestVariable("8f3b81aa-4d7e-41cb-8cdd-a11530d6de4f")]
        public string Belegdatum_Ueberleitung
        {
            get { return _Belegdatum_Ueberleitung; }
            set { _Belegdatum_Ueberleitung = value; }
        }

        string _Ust_Code_Ueberleitung;

        /// <summary>
        /// Gets or sets the value of variable Ust_Code_Ueberleitung.
        /// </summary>
        [TestVariable("5d4a1061-7c83-47d4-97e3-1977a55afcfd")]
        public string Ust_Code_Ueberleitung
        {
            get { return _Ust_Code_Ueberleitung; }
            set { _Ust_Code_Ueberleitung = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Belegnummer_Ueberleitung.
        /// </summary>
        [TestVariable("d58d6872-e365-4653-b3b2-20e189291331")]
        public string Belegnummer_Ueberleitung
        {
            get { return repo.Belegnummer_Ueberleitung; }
            set { repo.Belegnummer_Ueberleitung = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Soll trotz AVZ-Stammdateneinstellung :\r\n\r\n> Buchungsliste monatlich speichern <\r\n\r\neine Überleitung über mehrere Monate\r\nin die Fibu erfolgen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Soll trotz AVZ-Stammdateneinstellung :\r\n\r\n> Buchungsliste monatlich speichern <\r\n\r\neine Überleitung über mehrere Monate\r\nin die Fibu erfolgen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(1));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'DlgMessageBox.AVZAuswertungen'", repo.DlgMessageBox.AVZAuswertungenInfo, new ActionTimeout(120000), new RecordItemIndex(2));
            repo.DlgMessageBox.AVZAuswertungenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es sind bereits berechnete Monate vorhanden! \r\n \r\nSollen diese gelöscht und neu erfaßt werden? \r\n \r\nJa\t\t= Löschen und Neu erfassen \r\nNein\t= Bereits vorhandene Buchungszeilen laden \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es sind bereits berechnete Monate vorhanden! \r\n \r\nSollen diese gelöscht und neu erfaßt werden? \r\n \r\nJa\t\t= Löschen und Neu erfassen \r\nNein\t= Bereits vorhandene Buchungszeilen laden \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
