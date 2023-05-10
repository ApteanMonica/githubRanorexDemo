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

namespace B_ELSTER_005.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The StartAUT recording.
    /// </summary>
    [TestModule("61505fe9-6640-4db9-b6f3-adf46c137247", ModuleType.Recording, 1)]
    public partial class StartAUT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_005.B_ELSTER_005Repository repository.
        /// </summary>
        public static global::B_ELSTER_005.B_ELSTER_005Repository repo = global::B_ELSTER_005.B_ELSTER_005Repository.Instance;

        static StartAUT instance = new StartAUT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public StartAUT()
        {
            Programm = "B_UVA AUFRUFART UVAF x 300";
            Startfile = "C:\\Testdaten\\Allgemein\\Start.bat";
            Firma = "300";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static StartAUT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Programm;

        /// <summary>
        /// Gets or sets the value of variable Programm.
        /// </summary>
        [TestVariable("2ff6440e-482e-4773-b4d5-338fc1f2eece")]
        public string Programm
        {
            get { return _Programm; }
            set { _Programm = value; }
        }

        string _Startfile;

        /// <summary>
        /// Gets or sets the value of variable Startfile.
        /// </summary>
        [TestVariable("7a5189fd-31f3-4d73-935e-04cf5b4bf05d")]
        public string Startfile
        {
            get { return _Startfile; }
            set { _Startfile = value; }
        }

        string _Firma;

        /// <summary>
        /// Gets or sets the value of variable Firma.
        /// </summary>
        [TestVariable("fbe5d79f-b3b1-4cbf-8e45-4cbca3d9e17f")]
        public string Firma
        {
            get { return _Firma; }
            set { _Firma = value; }
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

            Report.Log(ReportLevel.Info, "Application", "Run application with file name from variable $Startfile with arguments from variable $Programm in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication(Startfile, Programm, "", false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 3m to exist. Associated repository item: 'TblUVAF.TitleBar100VerwaltenUVAFormulare'", repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, new ActionTimeout(180000), new RecordItemIndex(1));
            repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo.WaitForExists(180000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Verwalten UVA-Formulare') on item 'TblUVAF.TitleBar100VerwaltenUVAFormulare'.", repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, "Text", "Verwalten UVA-Formulare");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Firma) on item 'TblUVAF.TitleBar100VerwaltenUVAFormulare'.", repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblUVAF.TitleBar100VerwaltenUVAFormulareInfo, "Text", Firma);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
