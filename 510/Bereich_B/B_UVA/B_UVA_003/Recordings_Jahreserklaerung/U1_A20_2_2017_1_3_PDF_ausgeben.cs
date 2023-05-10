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

namespace B_UVA_003.Recordings_Jahreserklaerung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The U1_A20_2_2017_1_3_PDF_ausgeben recording.
    /// </summary>
    [TestModule("d56fbc66-8bed-474e-8c71-340b7e0e619c", ModuleType.Recording, 1)]
    public partial class U1_A20_2_2017_1_3_PDF_ausgeben : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_003.B_UVA_003Repository repository.
        /// </summary>
        public static global::B_UVA_003.B_UVA_003Repository repo = global::B_UVA_003.B_UVA_003Repository.Instance;

        static U1_A20_2_2017_1_3_PDF_ausgeben instance = new U1_A20_2_2017_1_3_PDF_ausgeben();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public U1_A20_2_2017_1_3_PDF_ausgeben()
        {
            U1_PDF_Report_A20_2_2017_1_3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static U1_A20_2_2017_1_3_PDF_ausgeben Instance
        {
            get { return instance; }
        }

#region Variables

        string _U1_PDF_Report_A20_2_2017_1_3;

        /// <summary>
        /// Gets or sets the value of variable U1_PDF_Report_A20_2_2017_1_3.
        /// </summary>
        [TestVariable("e6f93e96-11b6-43fa-baf6-7c7720707650")]
        public string U1_PDF_Report_A20_2_2017_1_3
        {
            get { return _U1_PDF_Report_A20_2_2017_1_3; }
            set { _U1_PDF_Report_A20_2_2017_1_3 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDrucken.PbExport' at Center.", repo.DlgDrucken.PbExportInfo, new RecordItemIndex(0));
            repo.DlgDrucken.PbExport.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'pdf' with focus on 'DlgDrucken.PbExport'.", repo.DlgDrucken.PbExportInfo, new RecordItemIndex(1));
            //repo.DlgDrucken.PbExport.PressKeys("pdf");
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Enter' Press with focus on 'PbExportItems.PDFDatei'.", repo.PbExportItems.PDFDateiInfo, new RecordItemIndex(2));
            //Keyboard.PrepareFocus(repo.PbExportItems.PDFDatei);
            //Keyboard.Press(System.Windows.Forms.Keys.Return, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'PbExportItems.PDFDatei' at Center.", repo.PbExportItems.PDFDateiInfo, new RecordItemIndex(3));
            repo.PbExportItems.PDFDatei.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Ausgabe in PDF Datei') on item 'DlgDruckenDatei.TitleBar200AusgabeInPDFDatei'.", repo.DlgDruckenDatei.TitleBar200AusgabeInPDFDateiInfo, new RecordItemIndex(4));
            Validate.AttributeContains(repo.DlgDruckenDatei.TitleBar200AusgabeInPDFDateiInfo, "Text", "Ausgabe in PDF Datei");
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$U1_PDF_Report_A20_2_2017_1_3' on item 'DlgDruckenDatei.Dateiname'.", repo.DlgDruckenDatei.DateinameInfo, new RecordItemIndex(5));
            repo.DlgDruckenDatei.Dateiname.Element.SetAttributeValue("Text", U1_PDF_Report_A20_2_2017_1_3);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDruckenDatei.PbOk' at Center.", repo.DlgDruckenDatei.PbOkInfo, new RecordItemIndex(6));
            repo.DlgDruckenDatei.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
