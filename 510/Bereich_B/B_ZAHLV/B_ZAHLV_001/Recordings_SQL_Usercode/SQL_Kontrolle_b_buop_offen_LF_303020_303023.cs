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
    ///The SQL_Kontrolle_b_buop_offen_LF_303020_303023 recording.
    /// </summary>
    [TestModule("de7e28c1-932f-4774-9acd-61c34fac9c94", ModuleType.Recording, 1)]
    public partial class SQL_Kontrolle_b_buop_offen_LF_303020_303023 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Kontrolle_b_buop_offen_LF_303020_303023 instance = new SQL_Kontrolle_b_buop_offen_LF_303020_303023();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Kontrolle_b_buop_offen_LF_303020_303023()
        {
            SQL_Select_B_BUOP_offen = "select * from b_buop where firm_nr = '100' and adr_nr BETWEEN '303020' AND '303023' AND busa_keybel BETWEEN '112' AND '126';";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            file_selectergebnis_b_buop_offen_aktuell = "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt";
            file_selectergebnis_b_buop_offen_Referenz = "C:\\Testdaten\\Allgemein\\SQL_Referenz_Files\\B_ZAHLV_001\\B_ZAHLV_001_B_BUOP_offen_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Kontrolle_b_buop_offen_LF_303020_303023 Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_BUOP_offen;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_BUOP_offen.
        /// </summary>
        [TestVariable("e0bda171-4f7e-4617-82e5-678f51e22485")]
        public string SQL_Select_B_BUOP_offen
        {
            get { return _SQL_Select_B_BUOP_offen; }
            set { _SQL_Select_B_BUOP_offen = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("227fa9d9-c49b-4bc0-b838-e74667b2b79a")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _file_selectergebnis_b_buop_offen_aktuell;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_buop_offen_aktuell.
        /// </summary>
        [TestVariable("c7aa1087-4741-41a8-a359-5566d37c702d")]
        public string file_selectergebnis_b_buop_offen_aktuell
        {
            get { return _file_selectergebnis_b_buop_offen_aktuell; }
            set { _file_selectergebnis_b_buop_offen_aktuell = value; }
        }

        string _file_selectergebnis_b_buop_offen_Referenz;

        /// <summary>
        /// Gets or sets the value of variable file_selectergebnis_b_buop_offen_Referenz.
        /// </summary>
        [TestVariable("2d2a881c-6b6a-4475-bf25-9790dbb8e260")]
        public string file_selectergebnis_b_buop_offen_Referenz
        {
            get { return _file_selectergebnis_b_buop_offen_Referenz; }
            set { _file_selectergebnis_b_buop_offen_Referenz = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement(SQL_Select_B_BUOP_offen, DB_File, "C:\\temp\\B_ZAHLV_001_B_BUOP_offen_aktuell.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains(file_selectergebnis_b_buop_offen_Referenz, file_selectergebnis_b_buop_offen_aktuell);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
