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

namespace V_FIBU_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kontrolle recording.
    /// </summary>
    [TestModule("d53dd0fd-8380-4ef9-a15d-1025e1ac5d5e", ModuleType.Recording, 1)]
    public partial class Kontrolle : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::V_FIBU_001.V_FIBU_001Repository repository.
        /// </summary>
        public static global::V_FIBU_001.V_FIBU_001Repository repo = global::V_FIBU_001.V_FIBU_001Repository.Instance;

        static Kontrolle instance = new Kontrolle();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kontrolle()
        {
            stornierte_Rechnung = "";
            Rechnung1 = "192000001";
            Status = "9";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kontrolle Instance
        {
            get { return instance; }
        }

#region Variables

        string _stornierte_Rechnung;

        /// <summary>
        /// Gets or sets the value of variable stornierte_Rechnung.
        /// </summary>
        [TestVariable("44e43f20-dba0-48dc-8f3e-f8857e2ccb28")]
        public string stornierte_Rechnung
        {
            get { return _stornierte_Rechnung; }
            set { _stornierte_Rechnung = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Rechnung1.
        /// </summary>
        [TestVariable("59662065-b2b3-4357-aab0-bcd6b39e8ab9")]
        public string Rechnung1
        {
            get { return repo.Rechnung1; }
            set { repo.Rechnung1 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Status.
        /// </summary>
        [TestVariable("90cddd1c-7862-487f-97bf-56c396f99a03")]
        public string Status
        {
            get { return repo.Status; }
            set { repo.Status = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.RbRechUebergeleitet' at Center.", repo.TblFIBU.RbRechUebergeleitetInfo, new RecordItemIndex(0));
            repo.TblFIBU.RbRechUebergeleitet.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.PbCommonLoad' at Center.", repo.TblFIBU.PbCommonLoadInfo, new RecordItemIndex(1));
            repo.TblFIBU.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Rechnung1) on item 'TblFIBU.Rechnungsnummer1'.", repo.TblFIBU.Rechnungsnummer1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblFIBU.Rechnungsnummer1Info, "Text", Rechnung1);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.RbRechNichtUeberleiten' at Center.", repo.TblFIBU.RbRechNichtUeberleitenInfo, new RecordItemIndex(3));
            repo.TblFIBU.RbRechNichtUeberleiten.Click();
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblFIBU.PbCommonLoad' at Center.", repo.TblFIBU.PbCommonLoadInfo, new RecordItemIndex(4));
            repo.TblFIBU.PbCommonLoad.Click();
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegex (Text~$stornierte_Rechnung) on item 'TblFIBU.ChildTableWindow.ColRechNrRow3'.", repo.TblFIBU.ChildTableWindow.ColRechNrRow3Info, new RecordItemIndex(5));
            Validate.AttributeRegex(repo.TblFIBU.ChildTableWindow.ColRechNrRow3Info, "Text", new Regex(stornierte_Rechnung));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
