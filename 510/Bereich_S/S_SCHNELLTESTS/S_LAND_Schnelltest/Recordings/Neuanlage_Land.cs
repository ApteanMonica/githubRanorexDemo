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
    ///The Neuanlage_Land recording.
    /// </summary>
    [TestModule("3f1eb06f-04cc-40f2-8dc0-349dfb64776f", ModuleType.Recording, 1)]
    public partial class Neuanlage_Land : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repository.
        /// </summary>
        public static global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repo = global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository.Instance;

        static Neuanlage_Land instance = new Neuanlage_Land();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_Land()
        {
            LAND_CD_NEU = "A1";
            LAND_BEZ_NEU = "Wonderland";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_Land Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable LAND_CD_NEU.
        /// </summary>
        [TestVariable("eccf2229-581d-4189-bf5a-c5383e5996b7")]
        public string LAND_CD_NEU
        {
            get { return repo.LAND_CD_NEU; }
            set { repo.LAND_CD_NEU = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable LAND_BEZ_NEU.
        /// </summary>
        [TestVariable("08a0a871-b538-44e6-94fa-898e89386ae1")]
        public string LAND_BEZ_NEU
        {
            get { return repo.LAND_BEZ_NEU; }
            set { repo.LAND_BEZ_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Insert}'.", new RecordItemIndex(0));
            Keyboard.Press("{Insert}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LAND_CD_NEU'.", new RecordItemIndex(1));
            Keyboard.Press(LAND_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$LAND_BEZ_NEU'.", new RecordItemIndex(3));
            Keyboard.Press(LAND_BEZ_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.PbDataAccessSave' at Center.", repo.TblLaender.PbDataAccessSaveInfo, new RecordItemIndex(5));
            repo.TblLaender.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblLaender.PbDataAccessLoad' at Center.", repo.TblLaender.PbDataAccessLoadInfo, new RecordItemIndex(6));
            repo.TblLaender.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LAND_CD_NEU) on item 'TblLaender.Zeile_mit_LAND_CD_NEU.ColLandCd_CD_NEU'.", repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandCd_CD_NEUInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandCd_CD_NEUInfo, "Text", LAND_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LAND_BEZ_NEU) on item 'TblLaender.Zeile_mit_LAND_CD_NEU.ColLandBez_CD_NEU'.", repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandBez_CD_NEUInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblLaender.Zeile_mit_LAND_CD_NEU.ColLandBez_CD_NEUInfo, "Text", LAND_BEZ_NEU);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
