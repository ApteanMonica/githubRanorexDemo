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
    ///The Aendern_Gruppenart_Neu recording.
    /// </summary>
    [TestModule("0c720be5-00c3-4a13-92d0-7adce1fa70ab", ModuleType.Recording, 1)]
    public partial class Aendern_Gruppenart_Neu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repo = global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository.Instance;

        static Aendern_Gruppenart_Neu instance = new Aendern_Gruppenart_Neu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aendern_Gruppenart_Neu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aendern_Gruppenart_Neu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable GRUPPENART_NEU.
        /// </summary>
        [TestVariable("fb8c8f36-075a-4b4a-bad4-7133110574ed")]
        public string GRUPPENART_NEU
        {
            get { return repo.GRUPPENART_NEU; }
            set { repo.GRUPPENART_NEU = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable GRUPPENART_ALT.
        /// </summary>
        [TestVariable("04d596e0-f25a-4df1-9d2f-5ae4d510d7df")]
        public string GRUPPENART_ALT
        {
            get { return repo.GRUPPENART_ALT; }
            set { repo.GRUPPENART_ALT = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnung' at Center.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungInfo, new RecordItemIndex(0));
            repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnung.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Delete' Press with focus on 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnung'.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnung);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{Tab}'.", new RecordItemIndex(2));
            Keyboard.Press("1{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppenarten.RibbonBar.PbDataAccessSave' at Center.", repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(3));
            repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppenarten.RibbonBar.PbDataAccessLoad' at Center.", repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(4));
            repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Alt'", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Alt.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(5));
            repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Alt.SelfInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnung'.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Mehrfachzuordnung nicht erlaubt') on item 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungBez'.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungBezInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraKzzuordnungBezInfo, "Text", "Mehrfachzuordnung nicht erlaubt");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
