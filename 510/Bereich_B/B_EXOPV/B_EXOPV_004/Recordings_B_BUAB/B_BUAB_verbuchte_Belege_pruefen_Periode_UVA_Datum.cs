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

namespace B_EXOPV_004.Recordings_B_BUAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_BUAB_verbuchte_Belege_pruefen_Periode_UVA_Datum recording.
    /// </summary>
    [TestModule("9ab18750-e993-4b50-80f8-cb32bf713788", ModuleType.Recording, 1)]
    public partial class B_BUAB_verbuchte_Belege_pruefen_Periode_UVA_Datum : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_EXOPV_004.B_EXOPV_004Repository repository.
        /// </summary>
        public static global::B_EXOPV_004.B_EXOPV_004Repository repo = global::B_EXOPV_004.B_EXOPV_004Repository.Instance;

        static B_BUAB_verbuchte_Belege_pruefen_Periode_UVA_Datum instance = new B_BUAB_verbuchte_Belege_pruefen_Periode_UVA_Datum();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_BUAB_verbuchte_Belege_pruefen_Periode_UVA_Datum()
        {
            Periode_6_offen = "6";
            Jahr = "2018";
            Beleg1 = "ER_01_B_EXOPV_004";
            Beleg2 = "ER_02_B_EXOPV_004";
            Beleg5 = "ER_05_B_EXOPV_004";
            Beleg6 = "ER_06_B_EXOPV_004";
            UVA_Monat_13_offen = "13";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_BUAB_verbuchte_Belege_pruefen_Periode_UVA_Datum Instance
        {
            get { return instance; }
        }

#region Variables

        string _Periode_6_offen;

        /// <summary>
        /// Gets or sets the value of variable Periode_6_offen.
        /// </summary>
        [TestVariable("295281af-2079-4565-947a-44cd24c16dc9")]
        public string Periode_6_offen
        {
            get { return _Periode_6_offen; }
            set { _Periode_6_offen = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("268580fc-72a3-45a9-bc68-d883b528ac20")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _Beleg1;

        /// <summary>
        /// Gets or sets the value of variable Beleg1.
        /// </summary>
        [TestVariable("3c522181-d236-4b42-8751-62f26934d2b6")]
        public string Beleg1
        {
            get { return _Beleg1; }
            set { _Beleg1 = value; }
        }

        string _Beleg2;

        /// <summary>
        /// Gets or sets the value of variable Beleg2.
        /// </summary>
        [TestVariable("c45ed5e4-a2ad-4f1f-aa32-66bce6031994")]
        public string Beleg2
        {
            get { return _Beleg2; }
            set { _Beleg2 = value; }
        }

        string _Beleg5;

        /// <summary>
        /// Gets or sets the value of variable Beleg5.
        /// </summary>
        [TestVariable("1806b985-f4a9-46c9-a948-6a72fddd08bd")]
        public string Beleg5
        {
            get { return _Beleg5; }
            set { _Beleg5 = value; }
        }

        string _Beleg6;

        /// <summary>
        /// Gets or sets the value of variable Beleg6.
        /// </summary>
        [TestVariable("8cf38043-01bc-4716-9f2f-fea42cb41313")]
        public string Beleg6
        {
            get { return _Beleg6; }
            set { _Beleg6 = value; }
        }

        string _UVA_Monat_13_offen;

        /// <summary>
        /// Gets or sets the value of variable UVA_Monat_13_offen.
        /// </summary>
        [TestVariable("91f7a0a0-8cbf-4851-8ef9-99e5ed305988")]
        public string UVA_Monat_13_offen
        {
            get { return _UVA_Monat_13_offen; }
            set { _UVA_Monat_13_offen = value; }
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

            // Beleg ER 1 Sachbuchung
            Report.Log(ReportLevel.Info, "Section", "Beleg ER 1 Sachbuchung", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg1) on item 'TblB.Buchungszeilen_Tabelle.Zeile2.ColBelegnrRow2'.", repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColBelegnrRow2Info, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColBelegnrRow2Info, "Text", Beleg1);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile2.ColJahrPeriRow2'.", repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColJahrPeriRow2Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColJahrPeriRow2Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Periode_6_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile2.ColJahrPeriRow2'.", repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColJahrPeriRow2Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColJahrPeriRow2Info, "Text", Periode_6_offen);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile2.ColUvaRow2'.", repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColUvaRow2Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColUvaRow2Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UVA_Monat_13_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile2.ColUvaRow2'.", repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColUvaRow2Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile2.ColUvaRow2Info, "Text", UVA_Monat_13_offen);
            
            // Beleg ER 2 Pos2 Sachbuchung
            Report.Log(ReportLevel.Info, "Section", "Beleg ER 2 Pos2 Sachbuchung", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg2) on item 'TblB.Buchungszeilen_Tabelle.Zeile4.ColBelegnrRow4'.", repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColBelegnrRow4Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColBelegnrRow4Info, "Text", Beleg2);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile4.ColJahrPeriRow4'.", repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColJahrPeriRow4Info, new RecordItemIndex(8));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColJahrPeriRow4Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Periode_6_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile4.ColJahrPeriRow4'.", repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColJahrPeriRow4Info, new RecordItemIndex(9));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColJahrPeriRow4Info, "Text", Periode_6_offen);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile4.ColUvaRow4'.", repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColUvaRow4Info, new RecordItemIndex(10));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColUvaRow4Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UVA_Monat_13_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile4.ColUvaRow4'.", repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColUvaRow4Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile4.ColUvaRow4Info, "Text", UVA_Monat_13_offen);
            
            // Beleg ER 5 Sachbuchung
            Report.Log(ReportLevel.Info, "Section", "Beleg ER 5 Sachbuchung", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg5) on item 'TblB.Buchungszeilen_Tabelle.Zeile6.ColBelegnrRow6'.", repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColBelegnrRow6Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColBelegnrRow6Info, "Text", Beleg5);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile6.ColJahrPeriRow6'.", repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColJahrPeriRow6Info, new RecordItemIndex(14));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColJahrPeriRow6Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Periode_6_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile6.ColJahrPeriRow6'.", repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColJahrPeriRow6Info, new RecordItemIndex(15));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColJahrPeriRow6Info, "Text", Periode_6_offen);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile6.ColUvaRow6'.", repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColUvaRow6Info, new RecordItemIndex(16));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColUvaRow6Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UVA_Monat_13_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile6.ColUvaRow6'.", repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColUvaRow6Info, new RecordItemIndex(17));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile6.ColUvaRow6Info, "Text", UVA_Monat_13_offen);
            
            // Beleg ER 6 Sachbuchung
            Report.Log(ReportLevel.Info, "Section", "Beleg ER 6 Sachbuchung", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg6) on item 'TblB.Buchungszeilen_Tabelle.Zeile8.ColBelegnrRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColBelegnrRow8Info, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColBelegnrRow8Info, "Text", Beleg6);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile8.ColJahrPeriRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColJahrPeriRow8Info, new RecordItemIndex(20));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColJahrPeriRow8Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Periode_6_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile8.ColJahrPeriRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColJahrPeriRow8Info, new RecordItemIndex(21));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColJahrPeriRow8Info, "Text", Periode_6_offen);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Jahr) on item 'TblB.Buchungszeilen_Tabelle.Zeile8.ColUvaRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColUvaRow8Info, new RecordItemIndex(22));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColUvaRow8Info, "Text", Jahr);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$UVA_Monat_13_offen) on item 'TblB.Buchungszeilen_Tabelle.Zeile8.ColUvaRow8'.", repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColUvaRow8Info, new RecordItemIndex(23));
            Validate.AttributeContains(repo.TblB.Buchungszeilen_Tabelle.Zeile8.ColUvaRow8Info, "Text", UVA_Monat_13_offen);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
