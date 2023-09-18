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

namespace B_ZAHLV_001.Recordings_SQL_Usercode
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The SQL_Kontrolle_b_bube_Beleg_1001 recording.
    /// </summary>
    [TestModule("dd9a7fbd-0e01-4711-b4ac-557302826617", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_bube_Beleg_1001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Kontrolle_b_bube_Beleg_1001 instance = new SQL_Kontrolle_b_bube_Beleg_1001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_bube_Beleg_1001()
        {
            SQL_Select_B_BUBE = "SELECT wird abgeschnitten bei copy/paste in Default value";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_bube_aktuell = "C:\\temp\\B_ZAHLV_001_B_BUBE_aktuell.txt";
            file_selectergebnis_b_bube_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUBE_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_bube_Beleg_1001 Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_BUBE;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_BUBE.
        /// </summary>
        [TestVariable("c4db1547-c73b-4552-8fd3-b0f72d01a01c")]
        public string SQL_Select_B_BUBE
        {
            get { return _SQL_Select_B_BUBE; }
            set { _SQL_Select_B_BUBE = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("092f3f01-0f6d-4794-a21e-f22a26027b09")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _file_selectergebnis_b_bube_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_bube_aktuell.
        /// </summary>
        [TestVariable("4d200bea-eba2-4785-acb2-a27e784482f4")]
        public string file_selectergebnis_b_bube_aktuell
        {
            get { return _file_selectergebnis_b_bube_aktuell; }
            set { _file_selectergebnis_b_bube_aktuell = value; }
        }

        string _file_selectergebnis_b_bube_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_bube_Referenz.
        /// </summary>
        [TestVariable("60728b99-a153-4b95-8157-18096a6233e2")]
        public string file_selectergebnis_b_bube_Referenz
        {
            get { return _file_selectergebnis_b_bube_Referenz; }
            set { _file_selectergebnis_b_bube_Referenz = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.ReadVersion("C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "c:\\temp\\version_b_zahlv_001_b_bube_verbucht.txt");
            
            //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement(SQL_Select_B_BUBE, DB_File, "C:\\temp\\B_ZAHLV_001_B_BUBE_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("SELECT\r\nb_bube.BUSA_USERAENDG,\r\nb_bube.FIRM_NR,\r\nb_bube.BUSA_KEYPOS,\r\nBUBE_POS,\r\nBUBE_BETRAG,\r\nBUBE_MENGE,\r\nBER_CD1,\r\nBEKT_NR1,\r\nBER_CD2,\r\nBEKT_NR2,\r\nBER_CD3,\r\nBEKT_NR3,\r\nBER_CD4,\r\nBEKT_NR4,\r\nBER_CD5,\r\nBEKT_NR5,\r\nBER_CD6,\r\nBEKT_NR6,\r\nBUBE_TEXT,\r\nb_bube.KTBE_NR,\r\nKTBE_PROZ,\r\nKTBE_MENGE,\r\nBUBE_USERANLAG,\r\nBUBE_USERAENDG,\r\nBUBE_SKBETRAG,\r\nBUBE_FELD1,\r\nBUBE_FELD2,\r\nBUBE_FELD3,\r\nBUBE_FELD4,\r\nBUBE_MENGE2,\r\nBUBE_PENSBETRAG,\r\nBUBE_DTPENS,\r\nBUBE_DTEINZLG,\r\nBUBE_PENSBETRSTO\r\nFROM\tb_bube, b_busa\r\n\tWHERE\tb_busa.busa_belegnr = '1001'\r\n\tAND \tb_busa.firm_nr = b_bube.firm_nr \r\n\tAND \tb_busa.busa_useraendg = b_bube.busa_useraendg\r\n\tAND \tb_busa.busa_keybel = b_bube.busa_keybel \r\n\tAND \tb_busa.busa_keypos = b_bube.busa_keypos\r\n\tAND \tb_busa.busa_status BETWEEN '1' AND '8'\r\n\tAND\t\tb_busa.firm_nr = '100';", DB_File, "C:\\temp\\B_ZAHLV_001_B_BUBE_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains("C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUBE_Referenz.txt", "C:\\temp\\B_ZAHLV_001_B_BUBE_aktuell.txt");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
