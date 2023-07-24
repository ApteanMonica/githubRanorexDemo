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

namespace X_MUSTER_014.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The dbAbfrage recording.
    /// </summary>
    [TestModule("31847394-0a89-40fb-a8d0-b65fc7cc0529", ModuleType.Recording, 1)]
    public partial class DbAbfrage : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_014.X_MUSTER_014Repository repository.
        /// </summary>
        public static global::X_MUSTER_014.X_MUSTER_014Repository repo = global::X_MUSTER_014.X_MUSTER_014Repository.Instance;

        static DbAbfrage instance = new DbAbfrage();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DbAbfrage()
        {
            DB_path = "c:/Temp/datenbank.txt";
            path_1 = "c:/Temp/larisa.txt";
            path_2 = "c:/Temp/datei_2.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DbAbfrage Instance
        {
            get { return instance; }
        }

#region Variables

        string _DB_path;

        /// <summary>
        /// Gets or sets the value of variable DB_path.
        /// </summary>
        [TestVariable("2198486b-69d8-45d3-80c9-2f59367b5603")]
        public string DB_path
        {
            get { return _DB_path; }
            set { _DB_path = value; }
        }

        string _path_1;

        /// <summary>
        /// Gets or sets the value of variable path_1.
        /// </summary>
        [TestVariable("45d2808f-fa44-48b9-b602-56320d79e304")]
        public string path_1
        {
            get { return _path_1; }
            set { _path_1 = value; }
        }

        string _path_2;

        /// <summary>
        /// Gets or sets the value of variable path_2.
        /// </summary>
        [TestVariable("195d3ab0-f596-4d41-a4ab-0f089d02e7e6")]
        public string path_2
        {
            get { return _path_2; }
            set { _path_2 = value; }
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

            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select * from b_busy where busy_cd='ER';", DB_path, "c:/Temp/larisa.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("select * from b_busy where busy_cd='ER';", DB_path, path_2);
            
            //Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.SQLStatement("update b_busy set busy_kls = 'L'  where busy_cd='ER';", DB_path, "c:/Temp/update.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareContains(path_1, path_2);
            
            Ranorex.AutomationHelpers.UserCodeCollections.ApteanSQL.FileCompareEqual(path_1, path_2);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
