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

namespace Servicecenter.Recordings.EDGE
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The EDDownload recording.
    /// </summary>
    [TestModule("beee5cb6-6d86-4d3f-a23f-be8d014753d7", ModuleType.Recording, 1)]
    public partial class EDDownload : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Servicecenter.ServicecenterRepository repository.
        /// </summary>
        public static global::Servicecenter.ServicecenterRepository repo = global::Servicecenter.ServicecenterRepository.Instance;

        static EDDownload instance = new EDDownload();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EDDownload()
        {
            Filecheck = "";
            Downloadfile = "rs2-4.5.0_SP14_HF013-KStandard.zip";
            Dateigroesse = "494.051 KB";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EDDownload Instance
        {
            get { return instance; }
        }

#region Variables

        string _Filecheck;

        /// <summary>
        /// Gets or sets the value of variable Filecheck.
        /// </summary>
        [TestVariable("950bedf4-be9a-4d8d-be01-3596e2da9de1")]
        public string Filecheck
        {
            get { return _Filecheck; }
            set { _Filecheck = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Downloadfile.
        /// </summary>
        [TestVariable("6a5def8d-a823-4f33-af17-b16b6e5eead5")]
        public string Downloadfile
        {
            get { return repo.Downloadfile; }
            set { repo.Downloadfile = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Dateigroesse.
        /// </summary>
        [TestVariable("184c6c79-b28e-44ac-9c72-95038d4979c9")]
        public string Dateigroesse
        {
            get { return repo.Dateigroesse; }
            set { repo.Dateigroesse = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Servicecenter.Bereiche.Bereich_Downloads' at Center.", repo.Servicecenter.Bereiche.Bereich_DownloadsInfo, new RecordItemIndex(0));
            repo.Servicecenter.Bereiche.Bereich_Downloads.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Service Center: rs2 Download\n                        ') on item 'Servicecenter.Download_TicketUebersicht.D_rs2Download'.", repo.Servicecenter.Download_TicketUebersicht.D_rs2DownloadInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Servicecenter.Download_TicketUebersicht.D_rs2DownloadInfo, "InnerText", "Service Center: rs2 Download\n                        ");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Servicecenter.Download_TicketUebersicht.Downloads.D_Umgebung' at Center.", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_UmgebungInfo, new RecordItemIndex(3));
            repo.Servicecenter.Download_TicketUebersicht.Downloads.D_Umgebung.Click();
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Servicecenter.Download_TicketUebersicht.D_Test' at Center.", repo.Servicecenter.Download_TicketUebersicht.D_TestInfo, new RecordItemIndex(5));
            repo.Servicecenter.Download_TicketUebersicht.D_Test.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Test') on item 'Servicecenter.Download_TicketUebersicht.Downloads.D_Test_Pruefung'.", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_Test_PruefungInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.Servicecenter.Download_TicketUebersicht.Downloads.D_Test_PruefungInfo, "InnerText", "Test");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'Servicecenter.Download_TicketUebersicht.Downloads.D_Version'", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_VersionInfo, new ActionTimeout(20000), new RecordItemIndex(7));
            repo.Servicecenter.Download_TicketUebersicht.Downloads.D_VersionInfo.WaitForExists(20000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Servicecenter.Download_TicketUebersicht.Downloads.D_Version' at Center.", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_VersionInfo, new RecordItemIndex(8));
            repo.Servicecenter.Download_TicketUebersicht.Downloads.D_Version.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Filecheck) on item 'Servicecenter.Download_TicketUebersicht.Downloads.D_ModulElster'.", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_ModulElsterInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.Servicecenter.Download_TicketUebersicht.Downloads.D_ModulElsterInfo, "InnerText", Filecheck);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Downloadfile) on item 'Servicecenter.Download_TicketUebersicht.Downloads.D_Downloadlink'.", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_DownloadlinkInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.Servicecenter.Download_TicketUebersicht.Downloads.D_DownloadlinkInfo, "InnerText", Downloadfile);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Servicecenter.Download_TicketUebersicht.Downloads.D_Downloadlink' at Center.", repo.Servicecenter.Download_TicketUebersicht.Downloads.D_DownloadlinkInfo, new RecordItemIndex(11));
            //repo.Servicecenter.Download_TicketUebersicht.Downloads.D_Downloadlink.Click();
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 2.5m to exist. Associated repository item: 'FFDownloadfensterZielOrdner.ZielOrdnerOeffnen'", repo.FFDownloadfensterZielOrdner.ZielOrdnerOeffnenInfo, new ActionTimeout(150000), new RecordItemIndex(12));
            //repo.FFDownloadfensterZielOrdner.ZielOrdnerOeffnenInfo.WaitForExists(150000);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FFDownloadfensterZielOrdner.ZielOrdnerOeffnen' at Center.", repo.FFDownloadfensterZielOrdner.ZielOrdnerOeffnenInfo, new RecordItemIndex(13));
            //repo.FFDownloadfensterZielOrdner.ZielOrdnerOeffnen.Click();
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (UIAutomationValueValue=$Downloadfile) on item 'Windows.FFDownloadfile'.", repo.Windows.FFDownloadfileInfo, new RecordItemIndex(14));
            //Validate.AttributeEqual(repo.Windows.FFDownloadfileInfo, "UIAutomationValueValue", Downloadfile);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (UIAutomationValueValue=$Dateigroesse) on item 'Windows.FFDownloadsize'.", repo.Windows.FFDownloadsizeInfo, new RecordItemIndex(15));
            //Validate.AttributeEqual(repo.Windows.FFDownloadsizeInfo, "UIAutomationValueValue", Dateigroesse);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Windows.FFDownloadsize' at Center.", repo.Windows.FFDownloadsizeInfo, new RecordItemIndex(16));
            //repo.Windows.FFDownloadsize.Click();
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'Windows.FFDownloadfile'.", repo.Windows.FFDownloadfileInfo, new RecordItemIndex(17));
            //repo.Windows.FFDownloadfile.PressKeys("{Delete}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
