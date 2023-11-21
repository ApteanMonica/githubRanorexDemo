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

namespace S_ZART_Schnelltest.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Neuanlage_ZART_Werte_erfassen recording.
    /// </summary>
    [TestModule("43da60c0-98c4-4c49-b788-a172f799dab7", ModuleType.Recording, 1)]
    public partial class Neuanlage_ZART_Werte_erfassen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::S_ZART_Schnelltest.S_ZART_SchnelltestRepository repository.
        /// </summary>
        public static global::S_ZART_Schnelltest.S_ZART_SchnelltestRepository repo = global::S_ZART_Schnelltest.S_ZART_SchnelltestRepository.Instance;

        static Neuanlage_ZART_Werte_erfassen instance = new Neuanlage_ZART_Werte_erfassen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Neuanlage_ZART_Werte_erfassen()
        {
            ZART_CD_NEU = "ZLX";
            ZART_BEZ = "S_ZART_Schnelltest";
            ZAHLWEG = "SEPA-A1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Neuanlage_ZART_Werte_erfassen Instance
        {
            get { return instance; }
        }

#region Variables

        string _ZART_BEZ;

        /// <summary>
        /// Gets or sets the value of variable ZART_BEZ.
        /// </summary>
        [TestVariable("6675457a-c877-49e8-851e-f1fa7f78947c")]
        public string ZART_BEZ
        {
            get { return _ZART_BEZ; }
            set { _ZART_BEZ = value; }
        }

        string _ZAHLWEG;

        /// <summary>
        /// Gets or sets the value of variable ZAHLWEG.
        /// </summary>
        [TestVariable("9e8091a7-ac14-4233-af3d-2ee68374123c")]
        public string ZAHLWEG
        {
            get { return _ZAHLWEG; }
            set { _ZAHLWEG = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable ZART_CD_NEU.
        /// </summary>
        [TestVariable("491cf9e4-d950-4bf6-83ae-d39ce15067ab")]
        public string ZART_CD_NEU
        {
            get { return repo.ZART_CD_NEU; }
            set { repo.ZART_CD_NEU = value; }
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

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ZART_CD_NEU'.", new RecordItemIndex(0));
            Keyboard.Press(ZART_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(1));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ZART_CD_NEU) on item 'TblZahlungsarten.row1.ColCodeRow1'.", repo.TblZahlungsarten.row1.ColCodeRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblZahlungsarten.row1.ColCodeRow1Info, "Text", ZART_CD_NEU);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ZART_BEZ'.", new RecordItemIndex(3));
            Keyboard.Press(ZART_BEZ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(4));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ZART_BEZ) on item 'TblZahlungsarten.row1.ColBezeichnungRow1'.", repo.TblZahlungsarten.row1.ColBezeichnungRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblZahlungsarten.row1.ColBezeichnungRow1Info, "Text", ZART_BEZ);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '3'.", new RecordItemIndex(6));
            Keyboard.Press("3");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(7));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblZahlungsarten.row1.ColZartKzverwendungRow1'.", repo.TblZahlungsarten.row1.ColZartKzverwendungRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblZahlungsarten.row1.ColZartKzverwendungRow1Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$ZAHLWEG'.", new RecordItemIndex(9));
            Keyboard.Press(ZAHLWEG);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Tab' Press.", new RecordItemIndex(10));
            Keyboard.Press(System.Windows.Forms.Keys.Tab, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$ZAHLWEG) on item 'TblZahlungsarten.row1.ColZahlwegRow1'.", repo.TblZahlungsarten.row1.ColZahlwegRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblZahlungsarten.row1.ColZahlwegRow1Info, "Text", ZAHLWEG);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}