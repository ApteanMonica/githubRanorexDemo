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

namespace B_ZAHL_004.Recordings_B_KLAB
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The B_KLAB_DIV_OPs_pruefen recording.
    /// </summary>
    [TestModule("3a366680-3ead-4ab1-984f-2e0a517443c6", ModuleType.Recording, 1)]
    public partial class B_KLAB_DIV_OPs_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_004.B_ZAHL_004Repository repository.
        /// </summary>
        public static global::B_ZAHL_004.B_ZAHL_004Repository repo = global::B_ZAHL_004.B_ZAHL_004Repository.Instance;

        static B_KLAB_DIV_OPs_pruefen instance = new B_KLAB_DIV_OPs_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public B_KLAB_DIV_OPs_pruefen()
        {
            Beleg_ER035 = "ER035 B_ZAHL_004";
            Beleg_ER036 = "ER036 B_ZAHL_004";
            Beleg_ER037 = "ER037 B_ZAHL_004";
            Beleg_ER038 = "ER038 B_ZAHL_004";
            Beleg_ER039 = "ER039 B_ZAHL_004";
            Beleg_ER040 = "ER040 B_ZAHL_004";
            Beleg_ER041 = "ER041 B_ZAHL_004";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static B_KLAB_DIV_OPs_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Beleg_ER035;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER035.
        /// </summary>
        [TestVariable("b4229547-b79a-4c3f-b9f9-bc9dd85065e1")]
        public string Beleg_ER035
        {
            get { return _Beleg_ER035; }
            set { _Beleg_ER035 = value; }
        }

        string _Beleg_ER036;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER036.
        /// </summary>
        [TestVariable("b5fb00f4-ac96-4e6f-b966-3a44d0e02e24")]
        public string Beleg_ER036
        {
            get { return _Beleg_ER036; }
            set { _Beleg_ER036 = value; }
        }

        string _Beleg_ER037;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER037.
        /// </summary>
        [TestVariable("cc6e352c-5117-489c-ab22-4cdda0b9ad3d")]
        public string Beleg_ER037
        {
            get { return _Beleg_ER037; }
            set { _Beleg_ER037 = value; }
        }

        string _Beleg_ER038;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER038.
        /// </summary>
        [TestVariable("b360289c-2118-4eb2-bce5-2b347945ade6")]
        public string Beleg_ER038
        {
            get { return _Beleg_ER038; }
            set { _Beleg_ER038 = value; }
        }

        string _Beleg_ER039;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER039.
        /// </summary>
        [TestVariable("d7cf3513-049b-4e00-9f0d-23e167bcc023")]
        public string Beleg_ER039
        {
            get { return _Beleg_ER039; }
            set { _Beleg_ER039 = value; }
        }

        string _Beleg_ER040;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER040.
        /// </summary>
        [TestVariable("7831a31b-e146-4d83-914d-8f3fee78d25a")]
        public string Beleg_ER040
        {
            get { return _Beleg_ER040; }
            set { _Beleg_ER040 = value; }
        }

        string _Beleg_ER041;

        /// <summary>
        /// Gets or sets the value of variable Beleg_ER041.
        /// </summary>
        [TestVariable("312337be-8dc0-4eef-9401-faeaf1e772a6")]
        public string Beleg_ER041
        {
            get { return _Beleg_ER041; }
            set { _Beleg_ER041 = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'TblBuop.FlexGrid_Tabelle_oben.Row1'", repo.TblBuop.FlexGrid_Tabelle_oben.Row1Info, new ActionTimeout(60000), new RecordItemIndex(0));
            repo.TblBuop.FlexGrid_Tabelle_oben.Row1Info.WaitForExists(60000);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER035) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColBelegnrRow1'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColBelegnrRow1Info, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColBelegnrRow1Info, "Text", Beleg_ER035, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1.200,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColOffenRow1'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColOffenRow1Info, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColOffenRow1Info, "Text", "1.200,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1.200,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColBuopSkontobasisRow1'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColBuopSkontobasisRow1Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColBuopSkontobasisRow1Info, "Text", "1.200,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColKldvNrRow1'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColKldvNrRow1Info, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColKldvNrRow1Info, "Text", "1", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColZlvsRow1'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColZlvsRow1Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColZlvsRow1Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColKlbkNrOpRow1'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColKlbkNrOpRow1Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile1.ColKlbkNrOpRow1Info, "Text", "1", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER036) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColBelegnrRow2'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColBelegnrRow2Info, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColBelegnrRow2Info, "Text", Beleg_ER036, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='600,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColOffenRow2'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColOffenRow2Info, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColOffenRow2Info, "Text", "600,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='600,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColBuopSkontobasisRow2'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColBuopSkontobasisRow2Info, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColBuopSkontobasisRow2Info, "Text", "600,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColKldvNrRow2'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColKldvNrRow2Info, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColKldvNrRow2Info, "Text", "1", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColZlvsRow2'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColZlvsRow2Info, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColZlvsRow2Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColKlbkNrOpRow2'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColKlbkNrOpRow2Info, new RecordItemIndex(12));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile2.ColKlbkNrOpRow2Info, "Text", "1", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(12)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER037) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColBelegnrRow3'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColBelegnrRow3Info, new RecordItemIndex(13));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColBelegnrRow3Info, "Text", Beleg_ER037, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(13)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='2.400,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColOffenRow3'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColOffenRow3Info, new RecordItemIndex(14));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColOffenRow3Info, "Text", "2.400,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='0,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColBuopSkontobasisRow3'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColBuopSkontobasisRow3Info, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColBuopSkontobasisRow3Info, "Text", "0,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColKldvNrRow3'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColKldvNrRow3Info, new RecordItemIndex(16));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColKldvNrRow3Info, "Text", "1", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColZlvsRow3'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColZlvsRow3Info, new RecordItemIndex(17));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColZlvsRow3Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColKlbkNrOpRow3'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColKlbkNrOpRow3Info, new RecordItemIndex(18));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile3.ColKlbkNrOpRow3Info, "Text", "1", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER038) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColBelegnrRow4'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColBelegnrRow4Info, new RecordItemIndex(19));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColBelegnrRow4Info, "Text", Beleg_ER038, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(19)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1.800,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColOffenRow4'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColOffenRow4Info, new RecordItemIndex(20));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColOffenRow4Info, "Text", "1.800,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(20)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1.800,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColBuopSkontobasisRow4'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColBuopSkontobasisRow4Info, new RecordItemIndex(21));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColBuopSkontobasisRow4Info, "Text", "1.800,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='2') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColKldvNrRow4'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColKldvNrRow4Info, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColKldvNrRow4Info, "Text", "2", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColZlvsRow4'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColZlvsRow4Info, new RecordItemIndex(23));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColZlvsRow4Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='3') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColKlbkNrOpRow4'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColKlbkNrOpRow4Info, new RecordItemIndex(24));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile4.ColKlbkNrOpRow4Info, "Text", "3", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(24)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER039) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColBelegnrRow5'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColBelegnrRow5Info, new RecordItemIndex(25));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColBelegnrRow5Info, "Text", Beleg_ER039, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='12.000,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColOffenRow5'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColOffenRow5Info, new RecordItemIndex(26));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColOffenRow5Info, "Text", "12.000,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(26)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='12.000,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColBuopSkontobasisRow5'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColBuopSkontobasisRow5Info, new RecordItemIndex(27));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColBuopSkontobasisRow5Info, "Text", "12.000,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='2') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColKldvNrRow5'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColKldvNrRow5Info, new RecordItemIndex(28));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColKldvNrRow5Info, "Text", "2", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColZlvsRow5'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColZlvsRow5Info, new RecordItemIndex(29));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColZlvsRow5Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='2') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColKlbkNrOpRow5'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColKlbkNrOpRow5Info, new RecordItemIndex(30));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile5.ColKlbkNrOpRow5Info, "Text", "2", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(30)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER040) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColBelegnrRow6'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColBelegnrRow6Info, new RecordItemIndex(31));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColBelegnrRow6Info, "Text", Beleg_ER040, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(31)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='6.000,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColOffenRow6'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColOffenRow6Info, new RecordItemIndex(32));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColOffenRow6Info, "Text", "6.000,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(32)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='0,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColBuopSkontobasisRow6'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColBuopSkontobasisRow6Info, new RecordItemIndex(33));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColBuopSkontobasisRow6Info, "Text", "0,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(33)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='2') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColKldvNrRow6'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColKldvNrRow6Info, new RecordItemIndex(34));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColKldvNrRow6Info, "Text", "2", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(34)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColZlvsRow6'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColZlvsRow6Info, new RecordItemIndex(35));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColZlvsRow6Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='3') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColKlbkNrOpRow6'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColKlbkNrOpRow6Info, new RecordItemIndex(36));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile6.ColKlbkNrOpRow6Info, "Text", "3", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(36)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text=$Beleg_ER041) on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColBelegnrRow7'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColBelegnrRow7Info, new RecordItemIndex(37));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColBelegnrRow7Info, "Text", Beleg_ER041, null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(37)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='1.000,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColOffenRow7'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColOffenRow7Info, new RecordItemIndex(38));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColOffenRow7Info, "Text", "1.000,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(38)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='300,00') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColBuopSkontobasisRow7'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColBuopSkontobasisRow7Info, new RecordItemIndex(39));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColBuopSkontobasisRow7Info, "Text", "300,00", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(39)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='2') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColKldvNrRow7'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColKldvNrRow7Info, new RecordItemIndex(40));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColKldvNrRow7Info, "Text", "2", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(40)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='4') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColZlvsRow7'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColZlvsRow7Info, new RecordItemIndex(41));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColZlvsRow7Info, "Text", "4", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(41)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='3') on item 'TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColKlbkNrOpRow7'.", repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColKlbkNrOpRow7Info, new RecordItemIndex(42));
                Validate.AttributeEqual(repo.TblBuop.FlexGrid_Tabelle_oben.Zeile7.ColKlbkNrOpRow7Info, "Text", "3", null, false);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(42)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
