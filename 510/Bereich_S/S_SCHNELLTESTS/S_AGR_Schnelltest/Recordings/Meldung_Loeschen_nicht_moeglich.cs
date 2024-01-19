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

namespace S_AGR_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Meldung_Loeschen_nicht_moeglich recording.
    /// </summary>
    [TestModule("6852b099-8dea-4a13-9573-da76c6f7828e", ModuleType.Recording, 1)]
    public partial class Meldung_Loeschen_nicht_moeglich : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repo = global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository.Instance;

        static Meldung_Loeschen_nicht_moeglich instance = new Meldung_Loeschen_nicht_moeglich();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Meldung_Loeschen_nicht_moeglich()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Meldung_Loeschen_nicht_moeglich Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ARTIKELGRUPPE_ALT.
        /// </summary>
        [TestVariable("04d596e0-f25a-4df1-9d2f-5ae4d510d7df")]
        public string ARTIKELGRUPPE_ALT
        {
            get { return repo.ARTIKELGRUPPE_ALT; }
            set { repo.ARTIKELGRUPPE_ALT = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.ArtikelgruppenVerwalten'", repo.DlgMessageBox.ArtikelgruppenVerwaltenInfo, new ActionTimeout(5000), new RecordItemIndex(0));
            repo.DlgMessageBox.ArtikelgruppenVerwaltenInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Vor dem löschen der Artikelgruppen müssen die Artikelzuordnungen gelöscht werden') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Vor dem löschen der Artikelgruppen müssen die Artikelzuordnungen gelöscht werden");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(2));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppen.RibbonBar.PbDataAccessLoad' at Center.", repo.TblArtikelgruppen.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(3));
            repo.TblArtikelgruppen.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.ArtikelgruppenVerwalten'", repo.DlgMessageBox.ArtikelgruppenVerwaltenInfo, new ActionTimeout(5000), new RecordItemIndex(4));
            repo.DlgMessageBox.ArtikelgruppenVerwaltenInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden Daten geändert!\r\nSollen die Änderungen gespeichert werden?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden Daten geändert!\r\nSollen die Änderungen gespeichert werden?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1' at Center.", repo.DlgMessageBox.Button1Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button1.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'TblArtikelgruppen.FlexGrid.Row_mit_Artikelgruppe_Alt'.", repo.TblArtikelgruppen.FlexGrid.Row_mit_Artikelgruppe_Alt.SelfInfo, new RecordItemIndex(7));
            Validate.Exists(repo.TblArtikelgruppen.FlexGrid.Row_mit_Artikelgruppe_Alt.SelfInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
