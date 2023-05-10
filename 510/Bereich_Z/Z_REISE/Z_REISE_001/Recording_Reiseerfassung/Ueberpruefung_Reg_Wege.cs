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

namespace Z_REISE_001.Recording_Reiseerfassung
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Ueberpruefung_Reg_Wege recording.
    /// </summary>
    [TestModule("f908aff8-cd2d-4f12-838a-231eb4060efa", ModuleType.Recording, 1)]
    public partial class Ueberpruefung_Reg_Wege : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Z_REISE_001.Z_REISE_001Repository repository.
        /// </summary>
        public static global::Z_REISE_001.Z_REISE_001Repository repo = global::Z_REISE_001.Z_REISE_001Repository.Instance;

        static Ueberpruefung_Reg_Wege instance = new Ueberpruefung_Reg_Wege();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ueberpruefung_Reg_Wege()
        {
            Datum_Beginn = "20.05.2022";
            Beginn_Uhrzeit = "06:00";
            Ende_Uhrzeit = "17:00";
            Start_Ort = "Wien";
            Start_Strasse = "Wienerstrasse 1";
            Start_PLZ = "1020";
            Ziel_Ort = "Graz";
            Ziel_Strasse = "Grazerstr. 12";
            Ziel_PLZ = "8010";
            KFZ_Kennzeichen = "SU321TT";
            Strecke_in_KM = "250";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ueberpruefung_Reg_Wege Instance
        {
            get { return instance; }
        }

#region Variables

        string _Datum_Beginn;

        /// <summary>
        /// Gets or sets the value of variable Datum_Beginn.
        /// </summary>
        [TestVariable("5b03e093-3806-4523-9b47-55b7e7c2d287")]
        public string Datum_Beginn
        {
            get { return _Datum_Beginn; }
            set { _Datum_Beginn = value; }
        }

        string _Beginn_Uhrzeit;

        /// <summary>
        /// Gets or sets the value of variable Beginn_Uhrzeit.
        /// </summary>
        [TestVariable("c0b90e29-8149-4690-bb1d-1cfb1bee0315")]
        public string Beginn_Uhrzeit
        {
            get { return _Beginn_Uhrzeit; }
            set { _Beginn_Uhrzeit = value; }
        }

        string _Start_Ort;

        /// <summary>
        /// Gets or sets the value of variable Start_Ort.
        /// </summary>
        [TestVariable("f8f33039-a124-4e20-8817-e407fd199c4a")]
        public string Start_Ort
        {
            get { return _Start_Ort; }
            set { _Start_Ort = value; }
        }

        string _Start_Strasse;

        /// <summary>
        /// Gets or sets the value of variable Start_Strasse.
        /// </summary>
        [TestVariable("23128a3e-5fc4-4782-8472-5475f5ff351f")]
        public string Start_Strasse
        {
            get { return _Start_Strasse; }
            set { _Start_Strasse = value; }
        }

        string _Start_PLZ;

        /// <summary>
        /// Gets or sets the value of variable Start_PLZ.
        /// </summary>
        [TestVariable("62eaf0ed-5a37-48ef-bb83-5bd7e4ee6ba0")]
        public string Start_PLZ
        {
            get { return _Start_PLZ; }
            set { _Start_PLZ = value; }
        }

        string _Ziel_Ort;

        /// <summary>
        /// Gets or sets the value of variable Ziel_Ort.
        /// </summary>
        [TestVariable("9ee72a3a-bea9-4d0c-b431-a689f17e7ec2")]
        public string Ziel_Ort
        {
            get { return _Ziel_Ort; }
            set { _Ziel_Ort = value; }
        }

        string _Ziel_Strasse;

        /// <summary>
        /// Gets or sets the value of variable Ziel_Strasse.
        /// </summary>
        [TestVariable("ba20b72a-840c-4a84-976f-857e685d4155")]
        public string Ziel_Strasse
        {
            get { return _Ziel_Strasse; }
            set { _Ziel_Strasse = value; }
        }

        string _Ziel_PLZ;

        /// <summary>
        /// Gets or sets the value of variable Ziel_PLZ.
        /// </summary>
        [TestVariable("14ba83ce-d6bc-4e86-a2ff-acdc032b4849")]
        public string Ziel_PLZ
        {
            get { return _Ziel_PLZ; }
            set { _Ziel_PLZ = value; }
        }

        string _KFZ_Kennzeichen;

        /// <summary>
        /// Gets or sets the value of variable KFZ_Kennzeichen.
        /// </summary>
        [TestVariable("1a72cc4a-8e28-4f5e-bcdd-0bf3e50aa9e5")]
        public string KFZ_Kennzeichen
        {
            get { return _KFZ_Kennzeichen; }
            set { _KFZ_Kennzeichen = value; }
        }

        string _Strecke_in_KM;

        /// <summary>
        /// Gets or sets the value of variable Strecke_in_KM.
        /// </summary>
        [TestVariable("9a40605f-d2ec-4146-8e56-08c1b8a6ec44")]
        public string Strecke_in_KM
        {
            get { return _Strecke_in_KM; }
            set { _Strecke_in_KM = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Ende_Uhrzeit.
        /// </summary>
        [TestVariable("601d576c-58cf-484e-8718-d549f5071c2d")]
        public string Ende_Uhrzeit
        {
            get { return repo.Ende_Uhrzeit; }
            set { repo.Ende_Uhrzeit = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Datum_Beginn) on item 'FormRk.FlexGrid1.ColRtagDatumRow1'.", repo.FormRk.FlexGrid1.ColRtagDatumRow1Info, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRtagDatumRow1Info, "Text", Datum_Beginn);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beginn_Uhrzeit) on item 'FormRk.FlexGrid1.ColRwegDtbeginnRow1'.", repo.FormRk.FlexGrid1.ColRwegDtbeginnRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegDtbeginnRow1Info, "Text", Beginn_Uhrzeit);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ende_Uhrzeit) on item 'FormRk.FlexGrid1.ColRwegDtendeRow1'.", repo.FormRk.FlexGrid1.ColRwegDtendeRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegDtendeRow1Info, "Text", Ende_Uhrzeit);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Start_Ort) on item 'FormRk.FlexGrid1.ColPlzOrtVonRow1'.", repo.FormRk.FlexGrid1.ColPlzOrtVonRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColPlzOrtVonRow1Info, "Text", Start_Ort);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Start_Strasse) on item 'FormRk.FlexGrid1.ColRwegStrasseVonRow1'.", repo.FormRk.FlexGrid1.ColRwegStrasseVonRow1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegStrasseVonRow1Info, "Text", Start_Strasse);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Start_PLZ) on item 'FormRk.FlexGrid1.ColPlzCdVonRow1'.", repo.FormRk.FlexGrid1.ColPlzCdVonRow1Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColPlzCdVonRow1Info, "Text", Start_PLZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ziel_Ort) on item 'FormRk.FlexGrid1.ColPlzOrtBisRow1'.", repo.FormRk.FlexGrid1.ColPlzOrtBisRow1Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColPlzOrtBisRow1Info, "Text", Ziel_Ort);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ziel_Strasse) on item 'FormRk.FlexGrid1.ColRwegStrasseBisRow1'.", repo.FormRk.FlexGrid1.ColRwegStrasseBisRow1Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegStrasseBisRow1Info, "Text", Ziel_Strasse);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Ziel_PLZ) on item 'FormRk.FlexGrid1.ColPlzCdBisRow1'.", repo.FormRk.FlexGrid1.ColPlzCdBisRow1Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColPlzCdBisRow1Info, "Text", Ziel_PLZ);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1') on item 'FormRk.FlexGrid1.ColRkfzCdRow1'.", repo.FormRk.FlexGrid1.ColRkfzCdRow1Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRkfzCdRow1Info, "Text", "1");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KFZ_Kennzeichen) on item 'FormRk.FlexGrid1.ColRkfzKzRow1'.", repo.FormRk.FlexGrid1.ColRkfzKzRow1Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRkfzKzRow1Info, "Text", KFZ_Kennzeichen);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5100') on item 'FormRk.FlexGrid1.ColRwegKmstartRow1'.", repo.FormRk.FlexGrid1.ColRwegKmstartRow1Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegKmstartRow1Info, "Text", "5100");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='5350') on item 'FormRk.FlexGrid1.ColRwegKmendeRow1'.", repo.FormRk.FlexGrid1.ColRwegKmendeRow1Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegKmendeRow1Info, "Text", "5350");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='250') on item 'FormRk.FlexGrid1.ColRwegKmRow1'.", repo.FormRk.FlexGrid1.ColRwegKmRow1Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.FormRk.FlexGrid1.ColRwegKmRow1Info, "Text", "250");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'FormRk.PbDataAccessSave' at Center.", repo.FormRk.PbDataAccessSaveInfo, new RecordItemIndex(14));
            repo.FormRk.PbDataAccessSave.Click();
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
