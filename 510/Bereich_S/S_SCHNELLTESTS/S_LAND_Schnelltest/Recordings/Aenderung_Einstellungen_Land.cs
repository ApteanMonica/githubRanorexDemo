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
    ///The Aenderung_Einstellungen_Land recording.
    /// </summary>
    [TestModule("af098cdc-9ee0-4a64-af6e-c473babfcbbb", ModuleType.Recording, 1)]
    public partial class Aenderung_Einstellungen_Land : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repository.
        /// </summary>
        public static global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repo = global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository.Instance;

        static Aenderung_Einstellungen_Land instance = new Aenderung_Einstellungen_Land();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aenderung_Einstellungen_Land()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aenderung_Einstellungen_Land Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable LAND_CD_NEU.
        /// </summary>
        [TestVariable("908b91a7-c3fd-4c9e-8ca4-a53208564f63")]
        public string LAND_CD_NEU
        {
            get { return repo.LAND_CD_NEU; }
            set { repo.LAND_CD_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.Maximieren' at Center.", repo.TblLaender.MaximierenInfo, new RecordItemIndex(0));
            repo.TblLaender.Maximieren.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.Zeile_mit_LAND_CD_NEU.ColSepaTeiln_CD_NEU' at Center.", repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColSepaTeiln_CD_NEUInfo, new RecordItemIndex(1));
            repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColSepaTeiln_CD_NEU.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WON' with focus on 'TblLaender.Zeile_mit_LAND_CD_NEU.ColLandKfzCode_CD_NEU'.", repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandKfzCode_CD_NEUInfo, new RecordItemIndex(3));
            repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandKfzCode_CD_NEU.PressKeys("WON");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.PbDataAccessSave' at Center.", repo.TblLaender.PbDataAccessSaveInfo, new RecordItemIndex(4));
            repo.TblLaender.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.PbDataAccessLoad' at Center.", repo.TblLaender.PbDataAccessLoadInfo, new RecordItemIndex(5));
            repo.TblLaender.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleValue='True') on item 'TblLaender.Zeile_mit_LAND_CD_NEU.ColSepaTeiln_CD_NEU'.", repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColSepaTeiln_CD_NEUInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColSepaTeiln_CD_NEUInfo, "AccessibleValue", "True");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='WON') on item 'TblLaender.Zeile_mit_LAND_CD_NEU.ColLandKfzCode_CD_NEU'.", repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandKfzCode_CD_NEUInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandKfzCode_CD_NEUInfo, "Text", "WON");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}