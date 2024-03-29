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

namespace S_ZLBD_Schnelltest.Recordings_ZAHLUNG
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Aenderung_ZLBD_Speichern_Pruefen recording.
    /// </summary>
    [TestModule("74fdb586-c52d-48ac-9dfa-80b5b45a7fab", ModuleType.Recording, 1)]
    public partial class Aenderung_ZLBD_Speichern_Pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ZLBD_Schnelltest.S_ZLBD_SchnelltestRepository repository.
        /// </summary>
        public static global::S_ZLBD_Schnelltest.S_ZLBD_SchnelltestRepository repo = global::S_ZLBD_Schnelltest.S_ZLBD_SchnelltestRepository.Instance;

        static Aenderung_ZLBD_Speichern_Pruefen instance = new Aenderung_ZLBD_Speichern_Pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Aenderung_ZLBD_Speichern_Pruefen()
        {
            ZLBD_CD_NEU = "TST";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Aenderung_ZLBD_Speichern_Pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable ZLBD_CD_NEU.
        /// </summary>
        [TestVariable("5f30b91f-0c84-49bb-9f94-e86a9de1c784")]
        public string ZLBD_CD_NEU
        {
            get { return repo.ZLBD_CD_NEU; }
            set { repo.ZLBD_CD_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEU' at Center.", repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEUInfo, new RecordItemIndex(0));
            repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEU.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '8'.", new RecordItemIndex(2));
            Keyboard.Press("8");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(3));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='8') on item 'TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdTage1_ZLBD_CD_NEU'.", repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdTage1_ZLBD_CD_NEUInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdTage1_ZLBD_CD_NEUInfo, "Text", "8");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZlbd.PbCommonSave' at Center.", repo.TblZlbd.PbCommonSaveInfo, new RecordItemIndex(5));
            repo.TblZlbd.PbCommonSave.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ZLBD_CD_NEU) on item 'TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEU'.", repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEUInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdCdRow_ZLBD_CD_NEUInfo, "Text", ZLBD_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='8') on item 'TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdTage1_ZLBD_CD_NEU'.", repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdTage1_ZLBD_CD_NEUInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdTage1_ZLBD_CD_NEUInfo, "Text", "8");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3,00') on item 'TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdSkonto1_ZLBD_CD_NEU'.", repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdSkonto1_ZLBD_CD_NEUInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblZlbd.Row_mit_ZLBD_CD_NEU.ColZlbdSkonto1_ZLBD_CD_NEUInfo, "Text", "3,00");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
