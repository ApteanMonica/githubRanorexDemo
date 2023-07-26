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

namespace N_LISTEN_BULI_001.Recordings_b_exops
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Einschraenkungen_ueberpruefen recording.
    /// </summary>
    [TestModule("e284a7db-38e4-4019-9f0b-19a404c58484", ModuleType.Recording, 1)]
    public partial class Einschraenkungen_ueberpruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repository.
        /// </summary>
        public static global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository repo = global::N_LISTEN_BULI_001.N_LISTEN_BULI_001Repository.Instance;

        static Einschraenkungen_ueberpruefen instance = new Einschraenkungen_ueberpruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Einschraenkungen_ueberpruefen()
        {
            Tagesdatum_ermitteln = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Einschraenkungen_ueberpruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum_ermitteln;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_ermitteln.
        /// </summary>
        [TestVariable("ddc7f825-89a7-4aa4-a591-d3b0af11c21a")]
        public string Tagesdatum_ermitteln
        {
            get { return _Tagesdatum_ermitteln; }
            set { _Tagesdatum_ermitteln = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='S') on item 'FrmBEXOP.Einschraenkungen_BEXOP.ColKlsRow1'.", repo.FrmBEXOP.Einschraenkungen_BEXOP.ColKlsRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FrmBEXOP.Einschraenkungen_BEXOP.ColKlsRow1Info, "Text", "S");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N') on item 'FrmBEXOP.Einschraenkungen_BEXOP.ColStatusRow1'.", repo.FrmBEXOP.Einschraenkungen_BEXOP.ColStatusRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FrmBEXOP.Einschraenkungen_BEXOP.ColStatusRow1Info, "Text", "N");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='N_LISTEN') on item 'FrmBEXOP.Einschraenkungen_BEXOP.ColHerkunftRow1'.", repo.FrmBEXOP.Einschraenkungen_BEXOP.ColHerkunftRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FrmBEXOP.Einschraenkungen_BEXOP.ColHerkunftRow1Info, "Text", "N_LISTEN");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='31.12.2022') on item 'FrmBEXOP.Einschraenkungen_BEXOP.ColDatumRow1'.", repo.FrmBEXOP.Einschraenkungen_BEXOP.ColDatumRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FrmBEXOP.Einschraenkungen_BEXOP.ColDatumRow1Info, "Text", "31.12.2022");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
