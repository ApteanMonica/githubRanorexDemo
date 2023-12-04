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
    ///The Neuanlage_PLZ_Drittland recording.
    /// </summary>
    [TestModule("0c010f59-fbb4-44c4-b280-e6c3a2e99275", ModuleType.Recording, 1)]
    public partial class Neuanlage_PLZ_Drittland : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repository.
        /// </summary>
        public static global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repo = global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository.Instance;

        static Neuanlage_PLZ_Drittland instance = new Neuanlage_PLZ_Drittland();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_PLZ_Drittland()
        {
            PLZ_BEZ_CD = "DRITTLAND";
            PLZ_NEU = "0001";
            PLZ_NEU_ORT = "Schnelltest PLZ Anlage";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_PLZ_Drittland Instance
        {
            get { return instance; }
        }

#region Variables

        string _PLZ_BEZ_CD;

        /// <summary>
        /// Gets or sets the value of variable PLZ_BEZ_CD.
        /// </summary>
        [TestVariable("79e34ea1-472b-4118-9426-f1b1ce15d9f1")]
        public string PLZ_BEZ_CD
        {
            get { return _PLZ_BEZ_CD; }
            set { _PLZ_BEZ_CD = value; }
        }

        string _PLZ_NEU;

        /// <summary>
        /// Gets or sets the value of variable PLZ_NEU.
        /// </summary>
        [TestVariable("5ba9664a-e710-431e-95b1-7f48f6e4d1db")]
        public string PLZ_NEU
        {
            get { return _PLZ_NEU; }
            set { _PLZ_NEU = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PLZ_NEU_ORT.
        /// </summary>
        [TestVariable("49987f04-ca8b-41ed-a770-f798e885f9b3")]
        public string PLZ_NEU_ORT
        {
            get { return repo.PLZ_NEU_ORT; }
            set { repo.PLZ_NEU_ORT = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.Maximieren' at Center.", repo.TblPostleitzahl.MaximierenInfo, new RecordItemIndex(0));
            repo.TblPostleitzahl.Maximieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.PbDataAccessLoad' at Center.", repo.TblPostleitzahl.PbDataAccessLoadInfo, new RecordItemIndex(1));
            repo.TblPostleitzahl.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'DlgMessageBox.LaenderVerwalten'", repo.DlgMessageBox.LaenderVerwaltenInfo, new ActionTimeout(180000), new RecordItemIndex(2));
            repo.DlgMessageBox.LaenderVerwaltenInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'In die markierten, eingabepflichtigen Felder wurden keine Daten eingegeben!') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "In die markierten, eingabepflichtigen Felder wurden keine Daten eingegeben!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button0_OK_Meldung' at Center.", repo.DlgMessageBox.Button0_OK_MeldungInfo, new RecordItemIndex(4));
            repo.DlgMessageBox.Button0_OK_Meldung.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '*{Tab}' with focus on 'TblPostleitzahl.ToolBar_Einschraenkungen.DfLandCd_Landkuerzel'.", repo.TblPostleitzahl.ToolBar_Einschraenkungen.DfLandCd_LandkuerzelInfo, new RecordItemIndex(5));
            repo.TblPostleitzahl.ToolBar_Einschraenkungen.DfLandCd_Landkuerzel.PressKeys("*{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$PLZ_BEZ_CD) on item 'TblPostleitzahl.ToolBar_Einschraenkungen.Land_Text'.", repo.TblPostleitzahl.ToolBar_Einschraenkungen.Land_TextInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblPostleitzahl.ToolBar_Einschraenkungen.Land_TextInfo, "Text", PLZ_BEZ_CD);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.PbDataAccessLoad' at Center.", repo.TblPostleitzahl.PbDataAccessLoadInfo, new RecordItemIndex(7));
            repo.TblPostleitzahl.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'TblPostleitzahl.FlexGrid_Tabelle' at Center.", repo.TblPostleitzahl.FlexGrid_Tabelle.SelfInfo, new RecordItemIndex(8));
            repo.TblPostleitzahl.FlexGrid_Tabelle.Self.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}'.", new RecordItemIndex(9));
            Keyboard.Press("{Insert}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(10));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PLZ_NEU'.", new RecordItemIndex(11));
            Keyboard.Press(PLZ_NEU);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click at {X=0,Y=0}.", new RecordItemIndex(12));
            Mouse.MoveTo(0, 0);
            Mouse.Click(System.Windows.Forms.MouseButtons.Left);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(13));
            //Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PLZ_NEU_ORT' with focus on 'TblPostleitzahl.FlexGrid_Tabelle.ColPlzOrtRow1'.", repo.TblPostleitzahl.FlexGrid_Tabelle.ColPlzOrtRow1Info, new RecordItemIndex(14));
            repo.TblPostleitzahl.FlexGrid_Tabelle.ColPlzOrtRow1.PressKeys(PLZ_NEU_ORT);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(15));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.PbDataAccessSave' at Center.", repo.TblPostleitzahl.PbDataAccessSaveInfo, new RecordItemIndex(16));
            repo.TblPostleitzahl.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
