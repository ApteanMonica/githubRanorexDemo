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

namespace AEKOOE_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Datei_hochladen recording.
    /// </summary>
    [TestModule("71bdcd98-380b-49e4-b356-a029e6858ec8", ModuleType.Recording, 1)]
    public partial class Datei_hochladen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AEKOOE_001.AEKOOE_001Repository repository.
        /// </summary>
        public static global::AEKOOE_001.AEKOOE_001Repository repo = global::AEKOOE_001.AEKOOE_001Repository.Instance;

        static Datei_hochladen instance = new Datei_hochladen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Datei_hochladen()
        {
            ausgewaehlte_Testdatei = "Testdatei Antrag Krankgengeld.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Datei_hochladen Instance
        {
            get { return instance; }
        }

#region Variables

        string _ausgewaehlte_Testdatei;

        /// <summary>
        /// Gets or sets the value of variable ausgewaehlte_Testdatei.
        /// </summary>
        [TestVariable("87b9d4d6-80e0-4201-96f0-3f9130ca8ac0")]
        public string ausgewaehlte_Testdatei
        {
            get { return _ausgewaehlte_Testdatei; }
            set { _ausgewaehlte_Testdatei = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.AKAT011RequestFormRow.BtnBtnDefaultBtnExpandSmall' at Center.", repo.Login.AKAT011RequestFormRow.BtnBtnDefaultBtnExpandSmallInfo, new RecordItemIndex(0));
            repo.Login.AKAT011RequestFormRow.BtnBtnDefaultBtnExpandSmall.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'Login.AKAT011RequestFormRow.Upload'", repo.Login.AKAT011RequestFormRow.UploadInfo, new ActionTimeout(120000), new RecordItemIndex(1));
            repo.Login.AKAT011RequestFormRow.UploadInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Upload') on item 'Login.AKAT011RequestFormRow.Upload'.", repo.Login.AKAT011RequestFormRow.UploadInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Login.AKAT011RequestFormRow.UploadInfo, "InnerText", "Upload");
            
            // Mausklick mit Record eingefügt, Einstellungen zu Action spot absichtilch zu gelassen, da ich keine andere Möglichkeit gefunden habe das Fenster zu öffnen
            Report.Log(ReportLevel.Info, "Mouse", "Mausklick mit Record eingefügt, Einstellungen zu Action spot absichtilch zu gelassen, da ich keine andere Möglichkeit gefunden habe das Fenster zu öffnen\r\nMouse Left Click item 'Login.AKAT011RequestFormRow.File_Button_Datei_auswaehlen' at 3114;13.", repo.Login.AKAT011RequestFormRow.File_Button_Datei_auswaehlenInfo, new RecordItemIndex(3));
            repo.Login.AKAT011RequestFormRow.File_Button_Datei_auswaehlen.Click("3114;13");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 2m to exist. Associated repository item: 'OEffnen.OEffnen'", repo.OEffnen.OEffnenInfo, new ActionTimeout(120000), new RecordItemIndex(4));
            repo.OEffnen.OEffnenInfo.WaitForExists(120000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OEffnen.Ranorex' at Center.", repo.OEffnen.RanorexInfo, new RecordItemIndex(5));
            repo.OEffnen.Ranorex.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OEffnen.SystemItemNameDisplay_WEB_Ordner' at Center.", repo.OEffnen.SystemItemNameDisplay_WEB_OrdnerInfo, new RecordItemIndex(6));
            repo.OEffnen.SystemItemNameDisplay_WEB_Ordner.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OEffnen.SystemItemNameDisplay_Unterordner_sonstige_Daten' at Center.", repo.OEffnen.SystemItemNameDisplay_Unterordner_sonstige_DatenInfo, new RecordItemIndex(7));
            repo.OEffnen.SystemItemNameDisplay_Unterordner_sonstige_Daten.DoubleClick();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OEffnen.SystemItemNameDisplay_Testdatei_zum_upload' at Center.", repo.OEffnen.SystemItemNameDisplay_Testdatei_zum_uploadInfo, new RecordItemIndex(8));
            repo.OEffnen.SystemItemNameDisplay_Testdatei_zum_upload.DoubleClick();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
