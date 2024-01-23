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
    ///The Neuanlage_Gruppenart recording.
    /// </summary>
    [TestModule("da9962df-ee55-472b-bb34-f172db4b1aa7", ModuleType.Recording, 1)]
    public partial class Neuanlage_Gruppenart : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repository.
        /// </summary>
        public static global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository repo = global::S_AGR_Schnelltest.S_AGR_SchnelltestRepository.Instance;

        static Neuanlage_Gruppenart instance = new Neuanlage_Gruppenart();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_Gruppenart()
        {
            GRUPPENART_NEU = "X";
            GRUPPENART_NEU_BEZEICHNUNG = "Testgruppenart BAR";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_Gruppenart Instance
        {
            get { return instance; }
        }

#region Variables

        string _GRUPPENART_NEU_BEZEICHNUNG;

        /// <summary>
        /// Gets or sets the value of variable GRUPPENART_NEU_BEZEICHNUNG.
        /// </summary>
        [TestVariable("893bf7c1-3237-40e6-9e20-ab5e42cbfff1")]
        public string GRUPPENART_NEU_BEZEICHNUNG
        {
            get { return _GRUPPENART_NEU_BEZEICHNUNG; }
            set { _GRUPPENART_NEU_BEZEICHNUNG = value; }
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

        /// <summary>
        /// Gets or sets the value of variable GRUPPENART_NEU.
        /// </summary>
        [TestVariable("22ec1b4d-b55c-4f82-b521-5393a3acd11c")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppenarten.RibbonBar.PbDataAccessNew' at Center.", repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessNewInfo, new RecordItemIndex(0));
            repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessNew.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row0Column0' at Center.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row0Column0Info, new RecordItemIndex(1));
            repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row0Column0.Click(System.Windows.Forms.MouseButtons.Right);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Down}{Return}'.", new RecordItemIndex(2));
            Keyboard.Press("{Down}{Down}{Return}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GRUPPENART_NEU'.", new RecordItemIndex(3));
            Keyboard.Press(GRUPPENART_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$GRUPPENART_NEU_BEZEICHNUNG'.", new RecordItemIndex(5));
            Keyboard.Press(GRUPPENART_NEU_BEZEICHNUNG);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(6));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0'.", new RecordItemIndex(7));
            Keyboard.Press("0");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppenarten.RibbonBar.PbDataAccessSave' at Center.", repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessSaveInfo, new RecordItemIndex(8));
            repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessSave.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblArtikelgruppenarten.RibbonBar.PbDataAccessLoad' at Center.", repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessLoadInfo, new RecordItemIndex(9));
            repo.TblArtikelgruppenarten.RibbonBar.PbDataAccessLoad.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Alt'", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Alt.SelfInfo, new ActionTimeout(120000), new RecordItemIndex(10));
            repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Alt.SelfInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GRUPPENART_NEU) on item 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraCd'.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraCdInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraCdInfo, "Text", GRUPPENART_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$GRUPPENART_NEU_BEZEICHNUNG) on item 'TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraBez'.", repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraBezInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblArtikelgruppenarten.FlexGrid_Tabelle.Row_mit_Variable_Gruppenart_Neu.ColAgraBezInfo, "Text", GRUPPENART_NEU_BEZEICHNUNG);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
