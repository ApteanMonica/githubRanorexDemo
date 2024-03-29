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

namespace Z_PROJ_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Projekt_I_FORUM_aendern_A_bis_Datum_Status_extern recording.
    /// </summary>
    [TestModule("33389f47-4e64-467f-98ec-6e0529b01afb", ModuleType.Recording, 1)]
    public partial class Projekt_I_FORUM_aendern_A_bis_Datum_Status_extern : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_PROJ_003.Z_PROJ_003Repository repository.
        /// </summary>
        public static global::Z_PROJ_003.Z_PROJ_003Repository repo = global::Z_PROJ_003.Z_PROJ_003Repository.Instance;

        static Projekt_I_FORUM_aendern_A_bis_Datum_Status_extern instance = new Projekt_I_FORUM_aendern_A_bis_Datum_Status_extern();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Projekt_I_FORUM_aendern_A_bis_Datum_Status_extern()
        {
            PROJ_NR_I_FORUM_IP = "I-FORUM";
            bis_Datum3 = "31.12.2999";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Projekt_I_FORUM_aendern_A_bis_Datum_Status_extern Instance
        {
            get { return instance; }
        }

#region Variables

        string _PROJ_NR_I_FORUM_IP;

        /// <summary>
        /// Gets or sets the value of variable PROJ_NR_I_FORUM_IP.
        /// </summary>
        [TestVariable("99c5b27e-18c1-4e1c-a61c-6d6a1a6b72c4")]
        public string PROJ_NR_I_FORUM_IP
        {
            get { return _PROJ_NR_I_FORUM_IP; }
            set { _PROJ_NR_I_FORUM_IP = value; }
        }

        string _bis_Datum3;

        /// <summary>
        /// Gets or sets the value of variable bis_Datum3.
        /// </summary>
        [TestVariable("64bef029-447a-4596-aff5-b8d11b67113e")]
        public string bis_Datum3
        {
            get { return _bis_Datum3; }
            set { _bis_Datum3 = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PROJ_NR_I_FORUM_IP) on item 'FrmTabProjekt.Projektnr'.", repo.FrmTabProjekt.ProjektnrInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmTabProjekt.ProjektnrInfo, "Text", PROJ_NR_I_FORUM_IP);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmTabProjekt.Register_Projekt.TextBis' at Center.", repo.FrmTabProjekt.Register_Projekt.TextBisInfo, new RecordItemIndex(1));
            repo.FrmTabProjekt.Register_Projekt.TextBis.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Back' Press with focus on 'FrmTabProjekt.Register_Projekt.TextBis'.", repo.FrmTabProjekt.Register_Projekt.TextBisInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.Register_Projekt.TextBis);
            Keyboard.Press(System.Windows.Forms.Keys.Back, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$bis_Datum3' with focus on 'FrmTabProjekt.Register_Projekt.TextBis'.", repo.FrmTabProjekt.Register_Projekt.TextBisInfo, new RecordItemIndex(3));
            repo.FrmTabProjekt.Register_Projekt.TextBis.EnsureVisible();
            Keyboard.Press(bis_Datum3);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmTabProjekt.Register_Projekt.TextBis'.", repo.FrmTabProjekt.Register_Projekt.TextBisInfo, new RecordItemIndex(4));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.Register_Projekt.TextBis);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Endedatum auf den 31.12.2999 setzen bei allen Phasen mit dem Endedatum 31.12.2099? \r\n') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Endedatum auf den 31.12.2999 setzen bei allen Phasen mit dem Endedatum 31.12.2099? \r\n");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1' at Center.", repo.DlgMessageBox.Button1Info, new RecordItemIndex(6));
            repo.DlgMessageBox.Button1.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on 'FrmTabProjekt.Register_Projekt.Status_extern'.", repo.FrmTabProjekt.Register_Projekt.Status_externInfo, new RecordItemIndex(7));
            repo.FrmTabProjekt.Register_Projekt.Status_extern.PressKeys("0");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press with focus on 'FrmTabProjekt.Register_Projekt.Status_extern'.", repo.FrmTabProjekt.Register_Projekt.Status_externInfo, new RecordItemIndex(8));
            Keyboard.PrepareFocus(repo.FrmTabProjekt.Register_Projekt.Status_extern);
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Soll diese Änderung bei den Phasen auch durchgeführt werden?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Soll diese Änderung bei den Phasen auch durchgeführt werden?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button1' at Center.", repo.DlgMessageBox.Button1Info, new RecordItemIndex(10));
            repo.DlgMessageBox.Button1.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
