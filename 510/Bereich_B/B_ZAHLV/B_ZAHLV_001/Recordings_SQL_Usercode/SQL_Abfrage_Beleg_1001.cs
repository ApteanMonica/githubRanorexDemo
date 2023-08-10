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
    ///The SQL_Abfrage_Beleg_1001 recording.
    /// </summary>
    [TestModule("9d4f59a9-9ef3-4f29-809b-8ca0da01da29", ModuleType.Recording, 1)]
    public partial class SQL_Abfrage_Beleg_1001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHLV_001.B_ZAHLV_001Repository repository.
        /// </summary>
        public static global::B_ZAHLV_001.B_ZAHLV_001Repository repo = global::B_ZAHLV_001.B_ZAHLV_001Repository.Instance;

        static SQL_Abfrage_Beleg_1001 instance = new SQL_Abfrage_Beleg_1001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SQL_Abfrage_Beleg_1001()
        {
            SQL_Select_B_BUSA = "select * from b_busa where firm_nr = '100' and busa_belegnr = '1001';";
            DB_File = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            output_file_select_b_busa_akt = "C:\\Testdaten\\Allgemein\\UserCode\\Files_B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_aktuell.txt";
            output_file_select_b_busa_ref_1 = "C:\\Testdaten\\Allgemein\\UserCode\\Files_B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz_1.txt";
            output_file_select_b_busa_ref_2 = "C:\\Testdaten\\Allgemein\\UserCode\\Files_B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz_2.txt";
            output_file_select_b_busa_ref = "C:\\Testdaten\\Allgemein\\UserCode\\Files_B_ZAHLV_001\\B_ZAHLV_001_B_BUSA_Referenz.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SQL_Abfrage_Beleg_1001 Instance
        {
            get { return instance; }
        }

#region Variables

        string _SQL_Select_B_BUSA;

        /// <summary>
        /// Gets or sets the value of variable SQL_Select_B_BUSA.
        /// </summary>
        [TestVariable("70edba51-7fb8-4239-95ab-25dc436e0ffb")]
        public string SQL_Select_B_BUSA
        {
            get { return _SQL_Select_B_BUSA; }
            set { _SQL_Select_B_BUSA = value; }
        }

        string _DB_File;

        /// <summary>
        /// Gets or sets the value of variable DB_File.
        /// </summary>
        [TestVariable("b2ddc891-35e9-42a4-bb53-685bf4b418bb")]
        public string DB_File
        {
            get { return _DB_File; }
            set { _DB_File = value; }
        }

        string _output_file_select_b_busa_akt;

        /// <summary>
        /// Gets or sets the value of variable output_file_select_b_busa_akt.
        /// </summary>
        [TestVariable("32df8d2d-a9cb-4e59-ae9f-8d2f302926a7")]
        public string output_file_select_b_busa_akt
        {
            get { return _output_file_select_b_busa_akt; }
            set { _output_file_select_b_busa_akt = value; }
        }

        string _output_file_select_b_busa_ref_1;

        /// <summary>
        /// Gets or sets the value of variable output_file_select_b_busa_ref_1.
        /// </summary>
        [TestVariable("64f5aaec-2205-498c-83d3-79694ec03669")]
        public string output_file_select_b_busa_ref_1
        {
            get { return _output_file_select_b_busa_ref_1; }
            set { _output_file_select_b_busa_ref_1 = value; }
        }

        string _output_file_select_b_busa_ref_2;

        /// <summary>
        /// Gets or sets the value of variable output_file_select_b_busa_ref_2.
        /// </summary>
        [TestVariable("9bd40583-7f95-4af8-90b4-1b7c75ecfea7")]
        public string output_file_select_b_busa_ref_2
        {
            get { return _output_file_select_b_busa_ref_2; }
            set { _output_file_select_b_busa_ref_2 = value; }
        }

        string _output_file_select_b_busa_ref;

        /// <summary>
        /// Gets or sets the value of variable output_file_select_b_busa_ref.
        /// </summary>
        [TestVariable("f6b28cd6-6599-45fa-827f-fcba99142176")]
        public string output_file_select_b_busa_ref
        {
            get { return _output_file_select_b_busa_ref; }
            set { _output_file_select_b_busa_ref = value; }
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

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
