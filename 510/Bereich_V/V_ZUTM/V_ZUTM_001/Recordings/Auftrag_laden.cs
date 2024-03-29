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

namespace V_ZUTM_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Auftrag_laden recording.
    /// </summary>
    [TestModule("d76fd643-476a-4ddf-9ad1-648d28add09e", ModuleType.Recording, 1)]
    public partial class Auftrag_laden : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_ZUTM_001.V_ZUTM_001Repository repository.
        /// </summary>
        public static global::V_ZUTM_001.V_ZUTM_001Repository repo = global::V_ZUTM_001.V_ZUTM_001Repository.Instance;

        static Auftrag_laden instance = new Auftrag_laden();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Auftrag_laden()
        {
            Auftrag = "";
            Kunde = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Auftrag_laden Instance
        {
            get { return instance; }
        }

#region Variables

        string _Auftrag;

        /// <summary>
        /// Gets or sets the value of variable Auftrag.
        /// </summary>
        [TestVariable("63b3c33b-ac18-4517-bd3c-61ef815202cb")]
        public string Auftrag
        {
            get { return _Auftrag; }
            set { _Auftrag = value; }
        }

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("65e48cae-c945-452a-9d36-62c259f13f65")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZutm.AuftragArt' at Center.", repo.TblZutm.AuftragArtInfo, new RecordItemIndex(0));
            repo.TblZutm.AuftragArt.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Auftrag' with focus on 'TblZutm.AuftragArt'.", repo.TblZutm.AuftragArtInfo, new RecordItemIndex(1));
            repo.TblZutm.AuftragArt.PressKeys(Auftrag);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Auftrag) on item 'TblZutm.AuftragArt'.", repo.TblZutm.AuftragArtInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblZutm.AuftragArtInfo, "Text", Auftrag);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Kunde) on item 'TblZutm.Kundennummer'.", repo.TblZutm.KundennummerInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblZutm.KundennummerInfo, "Text", Kunde);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblZutm.PbCommonLoad' at Center.", repo.TblZutm.PbCommonLoadInfo, new RecordItemIndex(5));
            repo.TblZutm.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100001') on item 'TblZutm.FlexGrid1.ColArtNrRow1'.", repo.TblZutm.FlexGrid1.ColArtNrRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblZutm.FlexGrid1.ColArtNrRow1Info, "Text", "100001");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100002') on item 'TblZutm.FlexGrid1.ColArtNrRow2'.", repo.TblZutm.FlexGrid1.ColArtNrRow2Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblZutm.FlexGrid1.ColArtNrRow2Info, "Text", "100002");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100003') on item 'TblZutm.FlexGrid1.ColArtNrRow3'.", repo.TblZutm.FlexGrid1.ColArtNrRow3Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblZutm.FlexGrid1.ColArtNrRow3Info, "Text", "100003");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100005') on item 'TblZutm.FlexGrid1.ColArtNrRow4'.", repo.TblZutm.FlexGrid1.ColArtNrRow4Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblZutm.FlexGrid1.ColArtNrRow4Info, "Text", "100005");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100006') on item 'TblZutm.FlexGrid1.ColArtNrRow5'.", repo.TblZutm.FlexGrid1.ColArtNrRow5Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblZutm.FlexGrid1.ColArtNrRow5Info, "Text", "100006");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='100007') on item 'TblZutm.FlexGrid1.ColArtNrRow6'.", repo.TblZutm.FlexGrid1.ColArtNrRow6Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblZutm.FlexGrid1.ColArtNrRow6Info, "Text", "100007");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
