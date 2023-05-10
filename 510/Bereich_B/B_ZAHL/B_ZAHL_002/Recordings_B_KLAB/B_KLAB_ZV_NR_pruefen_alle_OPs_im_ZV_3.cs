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

namespace B_ZAHL_002.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_KLAB_ZV_NR_pruefen_alle_OPs_im_ZV_3 recording.
    /// </summary>
    [TestModule("3fe135f1-fdaf-407b-99b0-dd46e66f8291", ModuleType.Recording, 1)]
    public partial class B_KLAB_ZV_NR_pruefen_alle_OPs_im_ZV_3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_002.B_ZAHL_002Repository repository.
        /// </summary>
        public static global::B_ZAHL_002.B_ZAHL_002Repository repo = global::B_ZAHL_002.B_ZAHL_002Repository.Instance;

        static B_KLAB_ZV_NR_pruefen_alle_OPs_im_ZV_3 instance = new B_KLAB_ZV_NR_pruefen_alle_OPs_im_ZV_3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_KLAB_ZV_NR_pruefen_alle_OPs_im_ZV_3()
        {
            Beleg_ER032 = "ER032 B_ZAHL_002";
            Beleg_ER033 = "ER033 B_ZAHL_002";
            Beleg_ER034 = "ER034 B_ZAHL_002";
            Beleg_GS007 = "GS007 B_ZAHL_002";
            Beleg_ER031 = "ER031 B_ZAHL_002";
            Beleg_ER030 = "ER030 B_ZAHL_002";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_KLAB_ZV_NR_pruefen_alle_OPs_im_ZV_3 Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg_ER032;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER032.
        /// </summary>
        [TestVariable("18a703e1-cd00-47fa-9657-f285a6e6f948")]
        public string Beleg_ER032
        {
            get { return _Beleg_ER032; }
            set { _Beleg_ER032 = value; }
        }

        string _Beleg_ER033;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER033.
        /// </summary>
        [TestVariable("512f7992-fe18-40b0-83b9-872e667f413e")]
        public string Beleg_ER033
        {
            get { return _Beleg_ER033; }
            set { _Beleg_ER033 = value; }
        }

        string _Beleg_ER034;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER034.
        /// </summary>
        [TestVariable("02fbf2dc-f9df-4dd7-8cf2-8b59a7ed03b9")]
        public string Beleg_ER034
        {
            get { return _Beleg_ER034; }
            set { _Beleg_ER034 = value; }
        }

        string _Beleg_GS007;

        /// <summary>
        /// Gets or sets the value of variable Beleg_GS007.
        /// </summary>
        [TestVariable("6dc03b20-5eec-42f9-85d4-d8f73a47d61d")]
        public string Beleg_GS007
        {
            get { return _Beleg_GS007; }
            set { _Beleg_GS007 = value; }
        }

        string _Beleg_ER031;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER031.
        /// </summary>
        [TestVariable("57bf1965-b5b7-4343-9caf-7d3da401df60")]
        public string Beleg_ER031
        {
            get { return _Beleg_ER031; }
            set { _Beleg_ER031 = value; }
        }

        string _Beleg_ER030;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER030.
        /// </summary>
        [TestVariable("32a0835e-5436-4677-9633-5fffb2dfceb1")]
        public string Beleg_ER030
        {
            get { return _Beleg_ER030; }
            set { _Beleg_ER030 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TblBuop.PbCommonLaden' at Center.", repo.TblBuop.PbCommonLadenInfo, new RecordItemIndex(0));
            repo.TblBuop.PbCommonLaden.Click();
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblBuop.OP_Tabelle.Row1'", repo.TblBuop.OP_Tabelle.Row1Info, new ActionTimeout(60000), new RecordItemIndex(1));
            repo.TblBuop.OP_Tabelle.Row1Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_ER032) on item 'TblBuop.OP_Tabelle.ColBelegnrRow1'.", repo.TblBuop.OP_Tabelle.ColBelegnrRow1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColBelegnrRow1Info, "Text", Beleg_ER032);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblBuop.OP_Tabelle.ColZlvsRow1'.", repo.TblBuop.OP_Tabelle.ColZlvsRow1Info, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColZlvsRow1Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Beleg_ER033) on item 'TblBuop.OP_Tabelle.ColBelegnrRow2'.", repo.TblBuop.OP_Tabelle.ColBelegnrRow2Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblBuop.OP_Tabelle.ColBelegnrRow2Info, "Text", Beleg_ER033);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblBuop.OP_Tabelle.ColZlvsRow2'.", repo.TblBuop.OP_Tabelle.ColZlvsRow2Info, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColZlvsRow2Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_ER034) on item 'TblBuop.OP_Tabelle.ColBelegnrRow3'.", repo.TblBuop.OP_Tabelle.ColBelegnrRow3Info, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColBelegnrRow3Info, "Text", Beleg_ER034);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblBuop.OP_Tabelle.ColZlvsRow3'.", repo.TblBuop.OP_Tabelle.ColZlvsRow3Info, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColZlvsRow3Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_GS007) on item 'TblBuop.OP_Tabelle.ColBelegnrRow4'.", repo.TblBuop.OP_Tabelle.ColBelegnrRow4Info, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColBelegnrRow4Info, "Text", Beleg_GS007);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblBuop.OP_Tabelle.ColZlvsRow4'.", repo.TblBuop.OP_Tabelle.ColZlvsRow4Info, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColZlvsRow4Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_ER031) on item 'TblBuop.OP_Tabelle.ColBelegnrRow5'.", repo.TblBuop.OP_Tabelle.ColBelegnrRow5Info, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColBelegnrRow5Info, "Text", Beleg_ER031);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblBuop.OP_Tabelle.ColZlvsRow5'.", repo.TblBuop.OP_Tabelle.ColZlvsRow5Info, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColZlvsRow5Info, "Text", "3");
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Beleg_ER030) on item 'TblBuop.OP_Tabelle.ColBelegnrRow6'.", repo.TblBuop.OP_Tabelle.ColBelegnrRow6Info, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColBelegnrRow6Info, "Text", Beleg_ER030);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='3') on item 'TblBuop.OP_Tabelle.ColZlvsRow6'.", repo.TblBuop.OP_Tabelle.ColZlvsRow6Info, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.TblBuop.OP_Tabelle.ColZlvsRow6Info, "Text", "3");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
