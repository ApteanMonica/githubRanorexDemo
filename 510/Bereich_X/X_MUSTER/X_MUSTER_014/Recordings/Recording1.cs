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
    ///The Recording1 recording.
    /// </summary>
    [TestModule("94fee24c-6359-4a3c-a6d6-7c02ca6bb4ed", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::X_MUSTER_014.X_MUSTER_014Repository repository.
        /// </summary>
        public static global::X_MUSTER_014.X_MUSTER_014Repository repo = global::X_MUSTER_014.X_MUSTER_014Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            DB_path = "C:\\Testdaten\\Allgemein\\UserCode\\datenbank.txt";
            path_1 = "c:/Temp/datei1.txt";
            path_2 = "c:/Temp/datei2.txt";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _DB_path;

        /// <summary>
        /// Gets or sets the value of variable DB_path.
        /// </summary>
        [TestVariable("be9c7de6-dcfb-4842-b6e0-48aeb7d658a6")]
        public string DB_path
        {
            get { return _DB_path; }
            set { _DB_path = value; }
        }

        string _path_1;

        /// <summary>
        /// Gets or sets the value of variable path_1.
        /// </summary>
        [TestVariable("171ec0b7-1ff2-44b4-b0b1-d6395f1812c2")]
        public string path_1
        {
            get { return _path_1; }
            set { _path_1 = value; }
        }

        string _path_2;

        /// <summary>
        /// Gets or sets the value of variable path_2.
        /// </summary>
        [TestVariable("31830bee-d6c0-448e-ada4-630764d05906")]
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

            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("select * from b_busy where firm_nr='100' and busy_cd ='ER';", "c:/Temp/pet.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("update b_busy set busy_kls = 'L'  where busy_cd='ER' and firm_nr='100';", "");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.SQLStatement("select * from b_busy where firm_nr='100' and busy_cd ='ER';", "c:/Temp/petAlle.txt");
            
            Ranorex.AutomationHelpers.UserCodeCollections.Aptean.FileCompareContains("c:/Temp/pet.txt", "c:/Temp/petAlle.txt");
            
            //Ranorex.AutomationHelpers.UserCodeCollections.Aptean.FileCompareEqual("c:/pet.txt", "c:/Temp/petAlle.txt");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
