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

namespace S_ADRL_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UID_Pruefung recording.
    /// </summary>
    [TestModule("5173543a-6b35-4a38-8e88-13d1395e6071", ModuleType.Recording, 1)]
    public partial class UID_Pruefung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADRL_002.S_ADRL_002Repository repository.
        /// </summary>
        public static global::S_ADRL_002.S_ADRL_002Repository repo = global::S_ADRL_002.S_ADRL_002Repository.Instance;

        static UID_Pruefung instance = new UID_Pruefung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UID_Pruefung()
        {
            UID_falsch = "475601939";
            UID_nicht_gueltig = "UID-Prüfung: die angegebene UID ist nicht gültig.";
            UID = "U75601939";
            meldung = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UID_Pruefung Instance
        {
            get { return instance; }
        }

#region Variables

        string _UID_falsch;

        /// <summary>
        /// Gets or sets the value of variable UID_falsch.
        /// </summary>
        [TestVariable("ff1245a3-fb46-428c-93ce-bcf7c1ac0eb8")]
        public string UID_falsch
        {
            get { return _UID_falsch; }
            set { _UID_falsch = value; }
        }

        string _UID_nicht_gueltig;

        /// <summary>
        /// Gets or sets the value of variable UID_nicht_gueltig.
        /// </summary>
        [TestVariable("75453aee-25fd-4876-b483-9fa82ae6eab4")]
        public string UID_nicht_gueltig
        {
            get { return _UID_nicht_gueltig; }
            set { _UID_nicht_gueltig = value; }
        }

        string _UID;

        /// <summary>
        /// Gets or sets the value of variable UID.
        /// </summary>
        [TestVariable("7e4f089c-51ce-441e-b56c-adc82a43d35d")]
        public string UID
        {
            get { return _UID; }
            set { _UID = value; }
        }

        string _meldung;

        /// <summary>
        /// Gets or sets the value of variable meldung.
        /// </summary>
        [TestVariable("65f3ade1-91c5-4921-91f6-c397bcf0a831")]
        public string meldung
        {
            get { return _meldung; }
            set { _meldung = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.UID' at Center.", repo.FrmAdr.UIDInfo, new RecordItemIndex(0));
            repo.FrmAdr.UID.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UID_falsch' with focus on 'FrmAdr.UID'.", repo.FrmAdr.UIDInfo, new RecordItemIndex(1));
            repo.FrmAdr.UID.PressKeys(UID_falsch);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.UID'.", repo.FrmAdr.UIDInfo, new RecordItemIndex(2));
            repo.FrmAdr.UID.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Text' from item 'DlgMessageBox.UIDPruefungDieAngegebeneUIDIstNic' and assigning its value to variable 'meldung'.", repo.DlgMessageBox.UIDPruefungDieAngegebeneUIDIstNicInfo, new RecordItemIndex(3));
            meldung = repo.DlgMessageBox.UIDPruefungDieAngegebeneUIDIstNic.Element.GetAttributeValueText("Text");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.ValidateTextWithoutBreaks(meldung, UID_nicht_gueltig);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$UID_nicht_gueltig) on item 'DlgMessageBox.UIDPruefungDieAngegebeneUIDIstNic'.", repo.DlgMessageBox.UIDPruefungDieAngegebeneUIDIstNicInfo, new RecordItemIndex(5));
            //Validate.AttributeEqual(repo.DlgMessageBox.UIDPruefungDieAngegebeneUIDIstNicInfo, "Text", UID_nicht_gueltig);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Button0_UID' at Center.", repo.Button0_UIDInfo, new RecordItemIndex(6));
            repo.Button0_UID.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'FrmAdr.UID' at Center.", repo.FrmAdr.UIDInfo, new RecordItemIndex(7));
            repo.FrmAdr.UID.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}{Delete}'.", new RecordItemIndex(8));
            Keyboard.Press("{LControlKey down}{Akey}{LControlKey up}{Delete}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$UID' with focus on 'FrmAdr.UID'.", repo.FrmAdr.UIDInfo, new RecordItemIndex(9));
            repo.FrmAdr.UID.PressKeys(UID);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'FrmAdr.UID'.", repo.FrmAdr.UIDInfo, new RecordItemIndex(10));
            repo.FrmAdr.UID.PressKeys("{Tab}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Button0_UID' at Center.", repo.Button0_UIDInfo, new RecordItemIndex(11));
            repo.Button0_UID.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FrmAdr.PbDataAccessSave' at Center.", repo.FrmAdr.PbDataAccessSaveInfo, new RecordItemIndex(12));
            repo.FrmAdr.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
