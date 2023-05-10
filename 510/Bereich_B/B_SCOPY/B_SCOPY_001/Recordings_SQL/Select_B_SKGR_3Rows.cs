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

namespace B_SCOPY_001.Recordings_SQL
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Select_B_SKGR_3rows recording.
    /// </summary>
    [TestModule("42d00c7a-d79d-462b-a230-c2b856c15f86", ModuleType.Recording, 1)]
    public partial class Select_B_SKGR_3rows : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_SCOPY_001.B_SCOPY_001Repository repository.
        /// </summary>
        public static global::B_SCOPY_001.B_SCOPY_001Repository repo = global::B_SCOPY_001.B_SCOPY_001Repository.Instance;

        static Select_B_SKGR_3rows instance = new Select_B_SKGR_3rows();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_B_SKGR_3rows()
        {
            Ziel_Firma = "250";
            Ziel_DB = "E510";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_B_SKGR_3rows Instance
        {
            get { return instance; }
        }

#region Variables

        string _Ziel_DB;

        /// <summary>
        /// Gets or sets the value of variable Ziel_DB.
        /// </summary>
        [TestVariable("2dc1094d-1099-4f45-9199-77dc388a75a6")]
        public string Ziel_DB
        {
            get { return _Ziel_DB; }
            set { _Ziel_DB = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ziel_Firma.
        /// </summary>
        [TestVariable("02cdd745-3baa-4ecf-9f75-0401e705d8c1")]
        public string Ziel_Firma
        {
            get { return repo.Ziel_Firma; }
            set { repo.Ziel_Firma = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence select * from b_skgr where firm_nr = '.", new RecordItemIndex(0));
            Keyboard.Press("select * from b_skgr where firm_nr = '");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Ziel_Firma'.", new RecordItemIndex(1));
            Keyboard.Press(Ziel_Firma);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence ';.", new RecordItemIndex(2));
            Keyboard.Press("';");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Return}{LControlKey up}'.", new RecordItemIndex(3));
            Keyboard.Press("{LControlKey down}{Return}{LControlKey up}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}{Return}'.", new RecordItemIndex(4));
            Keyboard.Press("{Return}{Return}");
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Ziel_DB) on item 'DBTalkUI.StatusBar_unten_rechts_Schraegstrich'.", repo.DBTalkUI.StatusBar_unten_rechts_SchraegstrichInfo, new RecordItemIndex(6));
            Validate.AttributeContains(repo.DBTalkUI.StatusBar_unten_rechts_SchraegstrichInfo, "Text", Ziel_DB);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'3 Rows') on item 'DBTalkUI.Status_Bar_unten_links_Ready'.", repo.DBTalkUI.Status_Bar_unten_links_ReadyInfo, new RecordItemIndex(7));
            Validate.AttributeContains(repo.DBTalkUI.Status_Bar_unten_links_ReadyInfo, "Text", "3 Rows");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'$RLG') on item 'DBTalkUI.Text'.", repo.DBTalkUI.TextInfo, new RecordItemIndex(8));
            //Validate.AttributeContains(repo.DBTalkUI.TextInfo, "Text", "$RLG");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'theor. Skonto') on item 'DBTalkUI.Text'.", repo.DBTalkUI.TextInfo, new RecordItemIndex(9));
            //Validate.AttributeContains(repo.DBTalkUI.TextInfo, "Text", "theor. Skonto");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kundenskonto (Klasse 4)') on item 'DBTalkUI.Text'.", repo.DBTalkUI.TextInfo, new RecordItemIndex(10));
            //Validate.AttributeContains(repo.DBTalkUI.TextInfo, "Text", "Kundenskonto (Klasse 4)");
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Lieferantenskonto (Klasse 5)') on item 'DBTalkUI.Text'.", repo.DBTalkUI.TextInfo, new RecordItemIndex(11));
            //Validate.AttributeContains(repo.DBTalkUI.TextInfo, "Text", "Lieferantenskonto (Klasse 5)");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot_Skontogruppen' with region {X=2,Y=1,Width=434,Height=83}) on item 'DBTalkUI.CustomScrollControl'.", repo.DBTalkUI.CustomScrollControlInfo, new RecordItemIndex(12));
            Validate.ContainsImage(repo.DBTalkUI.CustomScrollControlInfo, CustomScrollControl_Screenshot_Skontogruppen, CustomScrollControl_Screenshot_Skontogruppen_Options);
            
        }

#region Image Feature Data
        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        CompressedImage CustomScrollControl_Screenshot_Skontogruppen
        { get { return repo.DBTalkUI.CustomScrollControlInfo.GetScreenshot_Skontogruppen(new Rectangle(2, 1, 434, 83)); } }

        /// <summary>
        /// DO NOT REFERENCE THIS CODE  - auto generated
        /// </summary>
        Imaging.FindOptions CustomScrollControl_Screenshot_Skontogruppen_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
