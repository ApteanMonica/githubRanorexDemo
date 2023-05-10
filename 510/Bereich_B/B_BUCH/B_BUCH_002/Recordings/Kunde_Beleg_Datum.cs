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

namespace B_BUCH_002.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Kunde_Beleg_Datum recording.
    /// </summary>
    [TestModule("0ac2aa9e-7283-45c6-87fe-542b93eb29e4", ModuleType.Recording, 1)]
    public partial class Kunde_Beleg_Datum : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_BUCH_002.B_BUCH_002Repository repository.
        /// </summary>
        public static global::B_BUCH_002.B_BUCH_002Repository repo = global::B_BUCH_002.B_BUCH_002Repository.Instance;

        static Kunde_Beleg_Datum instance = new Kunde_Beleg_Datum();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Kunde_Beleg_Datum()
        {
            Kunde = "200066";
            Beleg1 = "B_BUCH_002_A";
            Datum_Beleg = "01.01.2020";
            Jahr = "2020";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Kunde_Beleg_Datum Instance
        {
            get { return instance; }
        }

#region Variables

        string _Kunde;

        /// <summary>
        /// Gets or sets the value of variable Kunde.
        /// </summary>
        [TestVariable("a6e70432-a756-499e-8a68-4e1b195adc5c")]
        public string Kunde
        {
            get { return _Kunde; }
            set { _Kunde = value; }
        }

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("7679d3ed-549c-4050-a2bf-c86e075d8526")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
        }

        string _Datum_Beleg;

        /// <summary>
        /// Gets or sets the value of variable Datum_Beleg.
        /// </summary>
        [TestVariable("c67e1de3-e1c2-481e-bffa-9b7422fb4ddb")]
        public string Datum_Beleg
        {
            get { return _Datum_Beleg; }
            set { _Datum_Beleg = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("dc508b0b-7993-4dea-8ea0-86ac3aef367b")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MdiBuch.FrmRG.Hauptframe_2.Konto' at Center.", repo.MdiBuch.FrmRG.Hauptframe_2.KontoInfo, new RecordItemIndex(0));
            repo.MdiBuch.FrmRG.Hauptframe_2.Konto.Click();
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Kunde' with focus on 'MdiBuch.FrmRG.Hauptframe_2.Konto'.", repo.MdiBuch.FrmRG.Hauptframe_2.KontoInfo, new RecordItemIndex(1));
            repo.MdiBuch.FrmRG.Hauptframe_2.Konto.PressKeys(Kunde);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(2));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Beleg1' with focus on 'MdiBuch.FrmRG.Hauptframe_2.DfBelegnr'.", repo.MdiBuch.FrmRG.Hauptframe_2.DfBelegnrInfo, new RecordItemIndex(3));
            repo.MdiBuch.FrmRG.Hauptframe_2.DfBelegnr.EnsureVisible();
            Keyboard.Press(Beleg1);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(4));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Datum_Beleg' with focus on 'MdiBuch.FrmRG.Hauptframe_2.DfDtbeleg'.", repo.MdiBuch.FrmRG.Hauptframe_2.DfDtbelegInfo, new RecordItemIndex(5));
            repo.MdiBuch.FrmRG.Hauptframe_2.DfDtbeleg.EnsureVisible();
            Keyboard.Press(Datum_Beleg);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}'.", new RecordItemIndex(6));
            Keyboard.Press("{Tab}");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KUNDE FÜR B_BUCH MIT BV') on item 'MdiBuch.FrmRG.Hauptframe_2.DfAdrName'.", repo.MdiBuch.FrmRG.Hauptframe_2.DfAdrNameInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.MdiBuch.FrmRG.Hauptframe_2.DfAdrNameInfo, "Text", "KUNDE FÜR B_BUCH MIT BV");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>'Kunde für B_BUCH mit BV') on item 'MdiBuch.FrmRG.rechter_Frame_1.MlAdresse'.", repo.MdiBuch.FrmRG.rechter_Frame_1.MlAdresseInfo, new RecordItemIndex(8));
            Validate.AttributeContains(repo.MdiBuch.FrmRG.rechter_Frame_1.MlAdresseInfo, "Text", "Kunde für B_BUCH mit BV");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Jahr) on item 'MdiBuch.FrmRG.Hauptframe_2.DfUvajahr'.", repo.MdiBuch.FrmRG.Hauptframe_2.DfUvajahrInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.MdiBuch.FrmRG.Hauptframe_2.DfUvajahrInfo, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'MdiBuch.FrmRG.Hauptframe_2.DfUvamonat'.", repo.MdiBuch.FrmRG.Hauptframe_2.DfUvamonatInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.MdiBuch.FrmRG.Hauptframe_2.DfUvamonatInfo, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2000') on item 'MdiBuch.FrmRG.Hauptframe_2.DfKtoNrSamk'.", repo.MdiBuch.FrmRG.Hauptframe_2.DfKtoNrSamkInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.MdiBuch.FrmRG.Hauptframe_2.DfKtoNrSamkInfo, "Text", "2000");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
