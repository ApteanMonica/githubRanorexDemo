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

namespace B_BUCH_003.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Eingabe_Zahlung recording.
    /// </summary>
    [TestModule("7a5ec590-fb2c-41f8-a930-97713c856322", ModuleType.Recording, 1)]
    public partial class Eingabe_Zahlung : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_003.B_BUCH_003Repository repository.
        /// </summary>
        public static global::B_BUCH_003.B_BUCH_003Repository repo = global::B_BUCH_003.B_BUCH_003Repository.Instance;

        static Eingabe_Zahlung instance = new Eingabe_Zahlung();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Eingabe_Zahlung()
        {
            Beleg1 = "B_BUCH_003_1";
            Kunde = "200006";
            OP_Beleg = "OP_Beleg_B_BUCH_003_1";
            Jahr = "2020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Eingabe_Zahlung Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("0dab1348-0cfb-4f88-9519-7bc711d14e3a")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
        }

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("afd4a641-60f8-4481-8c3f-99e366e74f31")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("acca2bd0-4f6b-494f-9893-7b5954cc82b2")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable OP_Beleg.
        /// </summary>
        [TestVariable("5c03d3b9-dc94-4bc3-86ec-c6883596deb1")]
        public string OP_Beleg
        {
            get { return repo.OP_Beleg; }
            set { repo.OP_Beleg = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beleg1' with focus on 'MdiBuch.FrmZ.DfBelegnr'.", repo.MdiBuch.FrmZ.DfBelegnrInfo, new RecordItemIndex(0));
            repo.MdiBuch.FrmZ.DfBelegnr.PressKeys(Beleg1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(1));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '05.01.2020' with focus on 'MdiBuch.FrmZ.DfDtbeleg'.", repo.MdiBuch.FrmZ.DfDtbelegInfo, new RecordItemIndex(2));
            repo.MdiBuch.FrmZ.DfDtbeleg.PressKeys("05.01.2020");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(3));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'MdiBuch.FrmZ.DfUvajahr'.", repo.MdiBuch.FrmZ.DfUvajahrInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.MdiBuch.FrmZ.DfUvajahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiBuch.FrmZ.DfUvamonat'.", repo.MdiBuch.FrmZ.DfUvamonatInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.MdiBuch.FrmZ.DfUvamonatInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'K' with focus on 'MdiBuch.FrmZ.DfKLSH'.", repo.MdiBuch.FrmZ.DfKLSHInfo, new RecordItemIndex(6));
            repo.MdiBuch.FrmZ.DfKLSH.PressKeys("K");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(7));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'MdiBuch.FrmZ.DfAdrNr'", repo.MdiBuch.FrmZ.DfAdrNrInfo, new ActionTimeout(60000), new RecordItemIndex(8));
            repo.MdiBuch.FrmZ.DfAdrNrInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kunde' with focus on 'MdiBuch.FrmZ.DfAdrNr'.", repo.MdiBuch.FrmZ.DfAdrNrInfo, new RecordItemIndex(9));
            repo.MdiBuch.FrmZ.DfAdrNr.PressKeys(Kunde);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(10));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '98' with focus on 'MdiBuch.FrmZ.DfBetrag'.", repo.MdiBuch.FrmZ.DfBetragInfo, new RecordItemIndex(11));
            repo.MdiBuch.FrmZ.DfBetrag.PressKeys("98");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(12));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'MdiBuch.FrmZP.DfBelegnr_frmZP'", repo.MdiBuch.FrmZP.DfBelegnr_frmZPInfo, new ActionTimeout(60000), new RecordItemIndex(13));
            repo.MdiBuch.FrmZP.DfBelegnr_frmZPInfo.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$OP_Beleg' with focus on 'MdiBuch.FrmZP.DfBelegnr_frmZP'.", repo.MdiBuch.FrmZP.DfBelegnr_frmZPInfo, new RecordItemIndex(14));
            repo.MdiBuch.FrmZP.DfBelegnr_frmZP.PressKeys(OP_Beleg);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(15));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(16));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(17));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(18));
            Keyboard.Press("{Tab}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
