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

namespace B_SCOPY_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Quell_Firma_aendern_Aufruf_250 recording.
    /// </summary>
    [TestModule("cc2db665-f631-4a74-adf8-766121a90cd5", ModuleType.Recording, 1)]
    public partial class Quell_Firma_aendern_Aufruf_250 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_SCOPY_001.B_SCOPY_001Repository repository.
        /// </summary>
        public static global::B_SCOPY_001.B_SCOPY_001Repository repo = global::B_SCOPY_001.B_SCOPY_001Repository.Instance;

        static Quell_Firma_aendern_Aufruf_250 instance = new Quell_Firma_aendern_Aufruf_250();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Quell_Firma_aendern_Aufruf_250()
        {
            Quell_Firma = "200";
            Ziel_Firma = "250";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Quell_Firma_aendern_Aufruf_250 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Quell_Firma;

        /// <summary>
        /// Gets or sets the value of variable Quell_Firma.
        /// </summary>
        [TestVariable("dc9ec25d-b335-4c7b-be48-eb9aedda6c4e")]
        public string Quell_Firma
        {
            get { return _Quell_Firma; }
            set { _Quell_Firma = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ziel_Firma.
        /// </summary>
        [TestVariable("89ea7105-94ca-48a5-86c0-b61721114ee9")]
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ziel_Firma) on item 'FrmBSCOPY.Firma_Quelle'.", repo.FrmBSCOPY.Firma_QuelleInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBSCOPY.Firma_QuelleInfo, "Text", Ziel_Firma);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Quell_Firma' with focus on 'FrmBSCOPY.Firma_Quelle'.", repo.FrmBSCOPY.Firma_QuelleInfo, new RecordItemIndex(1));
            repo.FrmBSCOPY.Firma_Quelle.PressKeys(Quell_Firma);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(2));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Quell_Firma) on item 'FrmBSCOPY.Firma_Quelle'.", repo.FrmBSCOPY.Firma_QuelleInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBSCOPY.Firma_QuelleInfo, "Text", Quell_Firma);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
