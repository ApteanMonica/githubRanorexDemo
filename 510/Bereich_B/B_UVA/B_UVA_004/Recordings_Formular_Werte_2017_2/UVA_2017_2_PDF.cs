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

namespace B_UVA_004.Recordings_Formular_Werte_2017_2
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The UVA_2017_2_PDF recording.
    /// </summary>
    [TestModule("fe6c5b47-ff33-4962-ade6-389164cd13ca", ModuleType.Recording, 1)]
    public partial class UVA_2017_2_PDF : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_UVA_004.B_UVA_004Repository repository.
        /// </summary>
        public static global::B_UVA_004.B_UVA_004Repository repo = global::B_UVA_004.B_UVA_004Repository.Instance;

        static UVA_2017_2_PDF instance = new UVA_2017_2_PDF();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UVA_2017_2_PDF()
        {
            PDF_Report_U30_2017_2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static UVA_2017_2_PDF Instance
        {
            get { return instance; }
        }

#region Variables

        string _PDF_Report_U30_2017_2;

        /// <summary>
        /// Gets or sets the value of variable PDF_Report_U30_2017_2.
        /// </summary>
        [TestVariable("c2ffdf2d-aca3-4e07-9a03-6d84e2ed7d45")]
        public string PDF_Report_U30_2017_2
        {
            get { return _PDF_Report_U30_2017_2; }
            set { _PDF_Report_U30_2017_2 = value; }
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '$PDF_Report_U30_2017_2' on item 'DlgDruckenDatei.Dateiname'.", repo.DlgDruckenDatei.DateinameInfo, new RecordItemIndex(5));
            repo.DlgDruckenDatei.Dateiname.Element.SetAttributeValue("Text", PDF_Report_U30_2017_2);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DlgDruckenDatei.PbOk' at Center.", repo.DlgDruckenDatei.PbOkInfo, new RecordItemIndex(6));
            repo.DlgDruckenDatei.PbOk.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
