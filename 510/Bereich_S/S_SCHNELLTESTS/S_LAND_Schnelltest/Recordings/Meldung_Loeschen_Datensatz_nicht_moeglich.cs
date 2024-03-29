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

namespace S_LAND_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_Loeschen_Datensatz_nicht_moeglich recording.
    /// </summary>
    [TestModule("f420f435-9215-4455-8178-be71cc08cf4a", ModuleType.Recording, 1)]
    public partial class Meldung_Loeschen_Datensatz_nicht_moeglich : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repository.
        /// </summary>
        public static global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repo = global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository.Instance;

        static Meldung_Loeschen_Datensatz_nicht_moeglich instance = new Meldung_Loeschen_Datensatz_nicht_moeglich();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_Loeschen_Datensatz_nicht_moeglich()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_Loeschen_Datensatz_nicht_moeglich Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable LAND_CD_ALT.
        /// </summary>
        [TestVariable("4ccb901a-5751-47f5-a896-8569ca58de2e")]
        public string LAND_CD_ALT
        {
            get { return repo.LAND_CD_ALT; }
            set { repo.LAND_CD_ALT = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.LaenderVerwalten'", repo.DlgMessageBox.LaenderVerwaltenInfo, new ActionTimeout(180000), new RecordItemIndex(0));
            repo.DlgMessageBox.LaenderVerwaltenInfo.WaitForExists(180000);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'Land AT wird in abhängigen Datensätzen verwendet.\nLöschen nicht möglich|Es wurde versucht einen Datensatz zu löschen, für den noch abhängige Daten existieren!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            //Validate.AttributeRegex(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", new Regex("Land AT wird in abhängigen Datensätzen verwendet.\nLöschen nicht möglich|Es wurde versucht einen Datensatz zu löschen, für den noch abhängige Daten existieren!"));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~'Land AT wird in abhängigen Datensätzen verwendet.\nLöschen nicht möglich|Es wurde versucht einen Datensatz zu löschen, für den noch abhängige Daten existieren!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(2));
            Validate.AttributeRegex(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", new Regex("Land AT wird in abhängigen Datensätzen verwendet.\nLöschen nicht möglich|Es wurde versucht einen Datensatz zu löschen, für den noch abhängige Daten existieren!"));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0_OK_Meldung' at Center.", repo.DlgMessageBox.Button0_OK_MeldungInfo, new RecordItemIndex(3));
            repo.DlgMessageBox.Button0_OK_Meldung.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.PbDataAccessLoad' at Center.", repo.TblLaender.PbDataAccessLoadInfo, new RecordItemIndex(4));
            repo.TblLaender.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.LaenderVerwalten'", repo.DlgMessageBox.LaenderVerwaltenInfo, new ActionTimeout(180000), new RecordItemIndex(5));
            repo.DlgMessageBox.LaenderVerwaltenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden Daten geändert!\r\nSollen die Änderungen gespeichert werden?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden Daten geändert!\r\nSollen die Änderungen gespeichert werden?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1_Nein' at Center.", repo.DlgMessageBox.Button1_NeinInfo, new RecordItemIndex(7));
            repo.DlgMessageBox.Button1_Nein.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TblLaender.Zeile_mit_LAND_CD_ALT.Row_mit_LAND_CD_ALT'.", repo.TblLaender.Zeile_mit_LAND_CD_ALT.Row_mit_LAND_CD_ALTInfo, new RecordItemIndex(8));
            Validate.Exists(repo.TblLaender.Zeile_mit_LAND_CD_ALT.Row_mit_LAND_CD_ALTInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
