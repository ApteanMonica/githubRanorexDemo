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
    ///The Loeschen_PLZ_NEU recording.
    /// </summary>
    [TestModule("24d534f7-38bd-43c2-b0fd-7adec927af87", ModuleType.Recording, 1)]
    public partial class Loeschen_PLZ_NEU : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repository.
        /// </summary>
        public static global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository repo = global::S_LAND_Schnelltest.S_LAND_SchnelltestRepository.Instance;

        static Loeschen_PLZ_NEU instance = new Loeschen_PLZ_NEU();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_PLZ_NEU()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_PLZ_NEU Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable PLZ_NEU_ORT.
        /// </summary>
        [TestVariable("23330725-514d-4b36-8f54-b06afff7a917")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.FlexGrid_Tabelle.Row1Column0' at Center.", repo.TblPostleitzahl.FlexGrid_Tabelle.Row1Column0Info, new RecordItemIndex(0));
            repo.TblPostleitzahl.FlexGrid_Tabelle.Row1Column0.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(1));
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.PbDataAccessSave' at Center.", repo.TblPostleitzahl.PbDataAccessSaveInfo, new RecordItemIndex(2));
            repo.TblPostleitzahl.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblPostleitzahl.PbDataAccessLoad' at Center.", repo.TblPostleitzahl.PbDataAccessLoadInfo, new RecordItemIndex(3));
            repo.TblPostleitzahl.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'TblPostleitzahl.Zeile_mit_PLZ_NEU.Row_mit_Variable_PLZ_NEU_ORT'.", repo.TblPostleitzahl.Zeile_mit_PLZ_NEU.Row_mit_Variable_PLZ_NEU_ORTInfo, new RecordItemIndex(4));
            Validate.NotExists(repo.TblPostleitzahl.Zeile_mit_PLZ_NEU.Row_mit_Variable_PLZ_NEU_ORTInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}