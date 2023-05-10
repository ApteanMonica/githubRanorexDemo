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

namespace Z_PROJ_001.Recordings_loeschen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_2_I_FEIER_Art_IP_loeschen recording.
    /// </summary>
    [TestModule("a7010685-41ed-45a7-97bb-65b2c0ea44b3", ModuleType.Recording, 1)]
    public partial class Projekt_2_I_FEIER_Art_IP_loeschen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_001.Z_PROJ_001Repository repository.
        /// </summary>
        public static global::Z_PROJ_001.Z_PROJ_001Repository repo = global::Z_PROJ_001.Z_PROJ_001Repository.Instance;

        static Projekt_2_I_FEIER_Art_IP_loeschen instance = new Projekt_2_I_FEIER_Art_IP_loeschen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_2_I_FEIER_Art_IP_loeschen()
        {
            PROJ_BEZ_2_IP = "";
            PROJ_NR_2_IP = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_2_I_FEIER_Art_IP_loeschen Instance
        {
            get { return instance; }
        }

#region Variables

        string _PROJ_BEZ_2_IP;

        /// <summary>
        /// Gets or sets the value of variable PROJ_BEZ_2_IP.
        /// </summary>
        [TestVariable("186bb0c6-bc97-43db-9cf5-907215ff7fa1")]
        public string PROJ_BEZ_2_IP
        {
            get { return _PROJ_BEZ_2_IP; }
            set { _PROJ_BEZ_2_IP = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_2_IP.
        /// </summary>
        [TestVariable("b7141760-7e86-4c17-897c-aa7c96a88297")]
        public string PROJ_NR_2_IP
        {
            get { return repo.PROJ_NR_2_IP; }
            set { repo.PROJ_NR_2_IP = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'FrmTabProjekt.TitleBar100ProjektVerwalten'.", repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo, new RecordItemIndex(0));
            Validate.Exists(repo.FrmTabProjekt.TitleBar100ProjektVerwaltenInfo);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press with focus on 'FrmTabProjekt.Suche.Text'.", repo.FrmTabProjekt.Suche.TextInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.Suche.Text);
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PROJ_NR_2_IP' with focus on 'FrmTabProjekt.Suche.Text'.", repo.FrmTabProjekt.Suche.TextInfo, new RecordItemIndex(2));
            repo.FrmTabProjekt.Suche.Text.PressKeys(PROJ_NR_2_IP);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$PROJ_BEZ_2_IP) on item 'FrmTabProjekt.Suche.Suchergebnis.Row1'.", repo.FrmTabProjekt.Suche.Suchergebnis.Row1Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.FrmTabProjekt.Suche.Suchergebnis.Row1Info, "Text", PROJ_BEZ_2_IP);
            
            // Mit Klick auf Suche wird bei nur 1 Suchergebnis autom. Bearbeiten ausgelöst
            Report.Log(ReportLevel.Info, "Mouse", "Mit Klick auf Suche wird bei nur 1 Suchergebnis autom. Bearbeiten ausgelöst\r\nMouse Left Click item 'FrmTabProjekt.Suche.PbPerformSimpleSearch' at Center.", repo.FrmTabProjekt.Suche.PbPerformSimpleSearchInfo, new RecordItemIndex(4));
            repo.FrmTabProjekt.Suche.PbPerformSimpleSearch.Click();
            
            // auf autom. bearbeiten eingestellt?
            //Report.Log(ReportLevel.Info, "Mouse", "auf autom. bearbeiten eingestellt?\r\nMouse Left Click item 'FrmTabProjekt.Suche.PbEdit' at Center.", repo.FrmTabProjekt.Suche.PbEditInfo, new RecordItemIndex(5));
            //repo.FrmTabProjekt.Suche.PbEdit.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbCommonDel' at Center.", repo.FrmTabProjekt.PbCommonDelInfo, new RecordItemIndex(6));
            repo.FrmTabProjekt.PbCommonDel.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Projekt löschen ?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Projekt löschen ?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0' at Center.", repo.DlgMessageBox.Button0Info, new RecordItemIndex(8));
            repo.DlgMessageBox.Button0.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.PbNavigationBack' at Center.", repo.FrmTabProjekt.PbNavigationBackInfo, new RecordItemIndex(9));
            repo.FrmTabProjekt.PbNavigationBack.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PROJ_NR_2_IP' with focus on 'FrmTabProjekt.Suche.Text'.", repo.FrmTabProjekt.Suche.TextInfo, new RecordItemIndex(10));
            repo.FrmTabProjekt.Suche.Text.PressKeys(PROJ_NR_2_IP);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmTabProjekt.Suche.PbPerformSimpleSearch' at Center.", repo.FrmTabProjekt.Suche.PbPerformSimpleSearchInfo, new RecordItemIndex(11));
            repo.FrmTabProjekt.Suche.PbPerformSimpleSearch.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Es wurden keine passenden Daten gefunden!') on item 'FrmTabProjekt.Suche.Suchergebnis.Row1'.", repo.FrmTabProjekt.Suche.Suchergebnis.Row1Info, new RecordItemIndex(12));
            Validate.AttributeContains(repo.FrmTabProjekt.Suche.Suchergebnis.Row1Info, "Text", "Es wurden keine passenden Daten gefunden!");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
