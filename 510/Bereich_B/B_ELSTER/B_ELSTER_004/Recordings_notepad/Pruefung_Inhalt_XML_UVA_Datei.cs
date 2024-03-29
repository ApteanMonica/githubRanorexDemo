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

namespace B_ELSTER_004.Recordings_notepad
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Pruefung_Inhalt_XML_UVA_Datei recording.
    /// </summary>
    [TestModule("043dc707-4948-4c9a-9f30-78ff5f4e4f2b", ModuleType.Recording, 1)]
    public partial class Pruefung_Inhalt_XML_UVA_Datei : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ELSTER_004.B_ELSTER_004Repository repository.
        /// </summary>
        public static global::B_ELSTER_004.B_ELSTER_004Repository repo = global::B_ELSTER_004.B_ELSTER_004Repository.Instance;

        static Pruefung_Inhalt_XML_UVA_Datei instance = new Pruefung_Inhalt_XML_UVA_Datei();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Pruefung_Inhalt_XML_UVA_Datei()
        {
            Tagesdatum_yyyyMMdd = "";
            XML_UVA_VERSION = "";
            XML_UVA_2023_01_Teil_1 = "";
            XML_UVA_2023_01_Teil_2 = "";
            XML_UVA_2023_01_Teil_3 = "";
            XML_UVA_2023_01_Teil_4 = "";
            Jahr = "";
            XML_UVA_2023_01_Teil_5 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Pruefung_Inhalt_XML_UVA_Datei Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum_yyyyMMdd;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum_yyyyMMdd.
        /// </summary>
        [TestVariable("67638583-64d0-46c7-a1d4-a87c45ec6b9c")]
        public string Tagesdatum_yyyyMMdd
        {
            get { return _Tagesdatum_yyyyMMdd; }
            set { _Tagesdatum_yyyyMMdd = value; }
        }

        string _XML_UVA_VERSION;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_VERSION.
        /// </summary>
        [TestVariable("bfb20789-6bd8-499e-beb8-88f331c4f972")]
        public string XML_UVA_VERSION
        {
            get { return _XML_UVA_VERSION; }
            set { _XML_UVA_VERSION = value; }
        }

        string _XML_UVA_2023_01_Teil_1;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_2023_01_Teil_1.
        /// </summary>
        [TestVariable("6c1b8652-797d-437c-b716-5a8c543e6f63")]
        public string XML_UVA_2023_01_Teil_1
        {
            get { return _XML_UVA_2023_01_Teil_1; }
            set { _XML_UVA_2023_01_Teil_1 = value; }
        }

        string _XML_UVA_2023_01_Teil_2;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_2023_01_Teil_2.
        /// </summary>
        [TestVariable("94e45f87-fd71-4b99-9faa-14ad7e1afb7a")]
        public string XML_UVA_2023_01_Teil_2
        {
            get { return _XML_UVA_2023_01_Teil_2; }
            set { _XML_UVA_2023_01_Teil_2 = value; }
        }

        string _XML_UVA_2023_01_Teil_3;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_2023_01_Teil_3.
        /// </summary>
        [TestVariable("8b000fde-ad88-4ecb-982a-4d74f5762ab0")]
        public string XML_UVA_2023_01_Teil_3
        {
            get { return _XML_UVA_2023_01_Teil_3; }
            set { _XML_UVA_2023_01_Teil_3 = value; }
        }

        string _XML_UVA_2023_01_Teil_4;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_2023_01_Teil_4.
        /// </summary>
        [TestVariable("eb3fe635-3a94-49ae-ae6d-ba101d7119fb")]
        public string XML_UVA_2023_01_Teil_4
        {
            get { return _XML_UVA_2023_01_Teil_4; }
            set { _XML_UVA_2023_01_Teil_4 = value; }
        }

        string _Jahr;

        /// <summary>
        /// Gets or sets the value of variable Jahr.
        /// </summary>
        [TestVariable("4debbd9e-3ca8-4546-b40d-d01d3d950440")]
        public string Jahr
        {
            get { return _Jahr; }
            set { _Jahr = value; }
        }

        string _XML_UVA_2023_01_Teil_5;

        /// <summary>
        /// Gets or sets the value of variable XML_UVA_2023_01_Teil_5.
        /// </summary>
        [TestVariable("173eb200-4b7f-47ea-b956-f232b32011d2")]
        public string XML_UVA_2023_01_Teil_5
        {
            get { return _XML_UVA_2023_01_Teil_5; }
            set { _XML_UVA_2023_01_Teil_5 = value; }
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

            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_2023_01_Teil_1) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(0));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_UVA_2023_01_Teil_1, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(0)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_2023_01_Teil_2) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(1));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_UVA_2023_01_Teil_2, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_2023_01_Teil_3) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(2));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_UVA_2023_01_Teil_3, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_VERSION) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(3));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_UVA_VERSION, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$Tagesdatum_yyyyMMdd) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(4));
                //Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", Tagesdatum_yyyyMMdd, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_2023_01_Teil_4) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(5));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_UVA_2023_01_Teil_4, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$Jahr) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(6));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", Jahr, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeContains (Text>$XML_UVA_2023_01_Teil_5) on item 'XMLEditor_UVA_ZM.Text15'.", repo.XMLEditor_UVA_ZM.Text15Info, new RecordItemIndex(7));
                Validate.AttributeContains(repo.XMLEditor_UVA_ZM.Text15Info, "Text", XML_UVA_2023_01_Teil_5, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
