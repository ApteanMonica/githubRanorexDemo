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
    ///The Ueberpruefung_Anlage_BLZ recording.
    /// </summary>
    [TestModule("0338f1e1-08a0-4e77-a49a-741291347968", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_Anlage_BLZ : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repository.
        /// </summary>
        public static global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repo = global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository.Instance;

        static Ueberpruefung_Anlage_BLZ instance = new Ueberpruefung_Anlage_BLZ();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_Anlage_BLZ()
        {
            BLZ_NEU = "XBARX";
            BLZ_NEU_Bezeichnung = "BAR_BANK";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_Anlage_BLZ Instance
        {
            get { return instance; }
        }

#region Variables

        string _BLZ_NEU_Bezeichnung;

        /// <summary>
        /// Gets or sets the value of variable BLZ_NEU_Bezeichnung.
        /// </summary>
        [TestVariable("0f065ab5-5a41-4059-80af-f98e47c5cb23")]
        public string BLZ_NEU_Bezeichnung
        {
            get { return _BLZ_NEU_Bezeichnung; }
            set { _BLZ_NEU_Bezeichnung = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable BLZ_NEU.
        /// </summary>
        [TestVariable("440f716f-8d1f-4c11-bbf6-43aa2b121a79")]
        public string BLZ_NEU
        {
            get { return repo.BLZ_NEU; }
            set { repo.BLZ_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBankleitzahl.PbDataAccessLoad' at Center.", repo.TblBankleitzahl.PbDataAccessLoadInfo, new RecordItemIndex(0));
            repo.TblBankleitzahl.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'DlgMessageBox.LaenderVerwalten'", repo.DlgMessageBox.LaenderVerwaltenInfo, new ActionTimeout(5000), new RecordItemIndex(1));
            repo.DlgMessageBox.LaenderVerwaltenInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Es wurden bereits 500 Daten gelesen.\r\nWollen Sie weitere Daten einlesen?') on item 'DlgMessageBox.LabelMeldungstext'.", repo.DlgMessageBox.LabelMeldungstextInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.DlgMessageBox.LabelMeldungstextInfo, "Text", "Es wurden bereits 500 Daten gelesen.\r\nWollen Sie weitere Daten einlesen?");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgMessageBox.Button2_Alle' at Center.", repo.DlgMessageBox.Button2_AlleInfo, new RecordItemIndex(3));
            repo.DlgMessageBox.Button2_Alle.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblBankleitzahl.Row1Column0'", repo.TblBankleitzahl.Row1Column0Info, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.TblBankleitzahl.Row1Column0Info.WaitForExists(120000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
