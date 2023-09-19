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
    ///The SQL_Kontrolle_b_zlvs_Bankbeleg_Details recording.
    /// </summary>
    [TestModule("b73dbd7c-0631-44ce-86c9-28ebcb4a9100", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_zlvs_Bankbeleg_Details : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Kontrolle_b_zlvs_Bankbeleg_Details instance = new SQL_Kontrolle_b_zlvs_Bankbeleg_Details();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_zlvs_Bankbeleg_Details()
        {
            SQL_Select_B_ZLVS = "select * from b_zlvs where firm_nr ='100' and zlvs_vorschlag = '1' and busa_keybel BETWEEN 112 AND 126;";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_zlvs_aktuell = "C:\\temp\\B_ZAHLV_001_B_ZLVS_aktuell.txt";
            file_selectergebnis_b_zlvs_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_ZLVS_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_zlvs_Bankbeleg_Details Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_ZLVS;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_ZLVS.
        /// </summary>
        [TestVariable("0a122bcd-58da-4679-99ef-9f53b25facc8")]
        public string SQL_Select_B_ZLVS
        {
            get { return _SQL_Select_B_ZLVS; }
            set { _SQL_Select_B_ZLVS = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("915a9a1c-3f12-457e-af39-c4e72e51ca13")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _file_selectergebnis_b_zlvs_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_zlvs_aktuell.
        /// </summary>
        [TestVariable("a0990d32-9ba3-486a-aaf6-f2a1f930c201")]
        public string file_selectergebnis_b_zlvs_aktuell
        {
            get { return _file_selectergebnis_b_zlvs_aktuell; }
            set { _file_selectergebnis_b_zlvs_aktuell = value; }
        }

        string _file_selectergebnis_b_zlvs_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_zlvs_Referenz.
        /// </summary>
        [TestVariable("c7af9926-6ec7-4ab2-b637-470a8494ebeb")]
        public string file_selectergebnis_b_zlvs_Referenz
        {
            get { return _file_selectergebnis_b_zlvs_Referenz; }
            set { _file_selectergebnis_b_zlvs_Referenz = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.ReadVersion("C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "c:\\temp\\version_b_zahlv_001_b_zlvs_vor_Verbuchung.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select * from b_zlvs where firm_nr ='100' and zlvs_vorschlag = '1' and busa_keybel BETWEEN '112' AND '126';", "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt", "C:\\temp\\B_ZAHLV_001_B_ZLVS_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareEqual(file_selectergebnis_b_zlvs_Referenz, file_selectergebnis_b_zlvs_aktuell);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
