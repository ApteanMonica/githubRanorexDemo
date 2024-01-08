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

namespace S_ADG_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Loeschen_Adresse_Neu recording.
    /// </summary>
    [TestModule("c102cd30-7772-445a-8975-7ed2f40d5c01", ModuleType.Recording, 1)]
    public partial class Loeschen_Adresse_Neu : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ADG_Schnelltest.S_ADG_SchnelltestRepository repository.
        /// </summary>
        public static global::S_ADG_Schnelltest.S_ADG_SchnelltestRepository repo = global::S_ADG_Schnelltest.S_ADG_SchnelltestRepository.Instance;

        static Loeschen_Adresse_Neu instance = new Loeschen_Adresse_Neu();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Loeschen_Adresse_Neu()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Loeschen_Adresse_Neu Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable GRUPPENART_NEU.
        /// </summary>
        [TestVariable("79087cc8-7954-4dce-b3e2-9af4a2d16ce5")]
        public string GRUPPENART_NEU
        {
            get { return repo.GRUPPENART_NEU; }
            set { repo.GRUPPENART_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblAdga.FlexGrid.Row_mit_Variable_Gruppenart_NEU' at 11;8.", repo.TblAdga.FlexGrid.Row_mit_Variable_Gruppenart_NEU.SelfInfo, new RecordItemIndex(0));
            repo.TblAdga.FlexGrid.Row_mit_Variable_Gruppenart_NEU.Self.Click("11;8");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'TblAdga'.", repo.TblAdga.SelfInfo, new RecordItemIndex(1));
            repo.TblAdga.Self.EnsureVisible();
            Keyboard.Press("{Delete}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblAdga.RibbonBar.PbDataAccessSave' at Center.", repo.TblAdga.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(2));
            repo.TblAdga.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblAdga.RibbonBar.PbDataAccessLoad' at Center.", repo.TblAdga.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(3));
            repo.TblAdga.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblAdga.FlexGrid.Row0Column0'", repo.TblAdga.FlexGrid.Row0Column0Info, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.TblAdga.FlexGrid.Row0Column0Info.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'TblAdga.FlexGrid.Row_mit_Variable_Gruppenart_NEU'.", repo.TblAdga.FlexGrid.Row_mit_Variable_Gruppenart_NEU.SelfInfo, new RecordItemIndex(5));
            Validate.NotExists(repo.TblAdga.FlexGrid.Row_mit_Variable_Gruppenart_NEU.SelfInfo);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}