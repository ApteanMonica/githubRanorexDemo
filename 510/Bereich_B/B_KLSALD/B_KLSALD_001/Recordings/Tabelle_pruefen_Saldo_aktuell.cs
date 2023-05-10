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

namespace B_KLSALD_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Tabelle_pruefen_Saldo_aktuell recording.
    /// </summary>
    [TestModule("3ade58e1-01e3-41d5-b6dd-5385b646bb0c", ModuleType.Recording, 1)]
    public partial class Tabelle_pruefen_Saldo_aktuell : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_KLSALD_001.B_KLSALD_001Repository repository.
        /// </summary>
        public static global::B_KLSALD_001.B_KLSALD_001Repository repo = global::B_KLSALD_001.B_KLSALD_001Repository.Instance;

        static Tabelle_pruefen_Saldo_aktuell instance = new Tabelle_pruefen_Saldo_aktuell();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Tabelle_pruefen_Saldo_aktuell()
        {
            KU_2030001 = "2030001";
            KU_2030002_DIV = "2030002";
            KU_2030003 = "2030003";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Tabelle_pruefen_Saldo_aktuell Instance
        {
            get { return instance; }
        }

#region Variables

        string _KU_2030001;

        /// <summary>
        /// Gets or sets the value of variable KU_2030001.
        /// </summary>
        [TestVariable("738ea11f-24e1-402a-90ed-602c2f9d044d")]
        public string KU_2030001
        {
            get { return _KU_2030001; }
            set { _KU_2030001 = value; }
        }

        string _KU_2030002_DIV;

        /// <summary>
        /// Gets or sets the value of variable KU_2030002_DIV.
        /// </summary>
        [TestVariable("fb5db6a0-a1cd-4131-a8c0-e4b2eaba2c89")]
        public string KU_2030002_DIV
        {
            get { return _KU_2030002_DIV; }
            set { _KU_2030002_DIV = value; }
        }

        string _KU_2030003;

        /// <summary>
        /// Gets or sets the value of variable KU_2030003.
        /// </summary>
        [TestVariable("e5857567-8b10-4726-bd66-2aa9758050a2")]
        public string KU_2030003
        {
            get { return _KU_2030003; }
            set { _KU_2030003 = value; }
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

            // Sammelkonto KE 2100
            Report.Log(ReportLevel.Info, "Section", "Sammelkonto KE 2100", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KE') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_1.ColAdrNrRow1'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_1.ColAdrNrRow1Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_1.ColAdrNrRow1Info, "Text", "KE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2100 SK Kunden EU') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_1.ColAdrNameRow1'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_1.ColAdrNameRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_1.ColAdrNameRow1Info, "Text", "2100 SK Kunden EU");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030003) on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_2.ColAdrNrRow2'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_2.ColAdrNrRow2Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_2.ColAdrNrRow2Info, "Text", KU_2030003);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-620,41') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_2.ColBusaBetragRow2'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_2.ColBusaBetragRow2Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_2.ColBusaBetragRow2Info, "Text", "-620,41");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KE') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColAdrNrRow3'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColAdrNrRow3Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColAdrNrRow3Info, "Text", "KE");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColAdrNameRow3'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColAdrNameRow3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColAdrNameRow3Info, "Text", "Summe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='-620,41') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColBusaBetragRow3'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColBusaBetragRow3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_3.ColBusaBetragRow3Info, "Text", "-620,41");
            
            // Sammelkonto KI 2000
            Report.Log(ReportLevel.Info, "Section", "Sammelkonto KI 2000", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KI') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_5.ColAdrNrRow5'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_5.ColAdrNrRow5Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_5.ColAdrNrRow5Info, "Text", "KI");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2000 SK Kunden Inland') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_5.ColAdrNameRow5'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_5.ColAdrNameRow5Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_5.ColAdrNameRow5Info, "Text", "2000 SK Kunden Inland");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030001) on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_6.ColAdrNrRow6'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_6.ColAdrNrRow6Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_6.ColAdrNrRow6Info, "Text", KU_2030001);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='957,96') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_6.ColBusaBetragRow6'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_6.ColBusaBetragRow6Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_6.ColBusaBetragRow6Info, "Text", "957,96");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$KU_2030002_DIV) on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_7.ColAdrNrRow7'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_7.ColAdrNrRow7Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_7.ColAdrNrRow7Info, "Text", KU_2030002_DIV);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.494,00') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_7.ColBusaBetragRow7'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_7.ColBusaBetragRow7Info, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_7.ColBusaBetragRow7Info, "Text", "1.494,00");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='KI') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColAdrNrRow8'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColAdrNrRow8Info, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColAdrNrRow8Info, "Text", "KI");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColAdrNameRow8'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColAdrNameRow8Info, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColAdrNameRow8Info, "Text", "Summe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='2.451,96') on item 'TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColBusaBetragRow8'.", repo.TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColBusaBetragRow8Info, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.TblAnzeige.FlexGrid_Tabelle.Zeile_8.ColBusaBetragRow8Info, "Text", "2.451,96");
            
            // Fußzeile_Summe
            Report.Log(ReportLevel.Info, "Section", "Fußzeile_Summe", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Summe') on item 'TblAnzeige.Fusszeile.ColAdrNameRow0'.", repo.TblAnzeige.Fusszeile.ColAdrNameRow0Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TblAnzeige.Fusszeile.ColAdrNameRow0Info, "Text", "Summe");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='1.831,55') on item 'TblAnzeige.Fusszeile.ColBusaBetragRow0'.", repo.TblAnzeige.Fusszeile.ColBusaBetragRow0Info, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.TblAnzeige.Fusszeile.ColBusaBetragRow0Info, "Text", "1.831,55");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
