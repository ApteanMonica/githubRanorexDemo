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

namespace B_ZAHL_001.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Zahlungsvorschlag_Drucktabelle_pruefen recording.
    /// </summary>
    [TestModule("f78b29f7-ccfe-4b9d-8f3f-72750abdd3b6", ModuleType.Recording, 1)]
    public partial class Zahlungsvorschlag_Drucktabelle_pruefen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::B_ZAHL_001.B_ZAHL_001Repository repository.
        /// </summary>
        public static global::B_ZAHL_001.B_ZAHL_001Repository repo = global::B_ZAHL_001.B_ZAHL_001Repository.Instance;

        static Zahlungsvorschlag_Drucktabelle_pruefen instance = new Zahlungsvorschlag_Drucktabelle_pruefen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Zahlungsvorschlag_Drucktabelle_pruefen()
        {
            Tagesdatum = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Zahlungsvorschlag_Drucktabelle_pruefen Instance
        {
            get { return instance; }
        }

#region Variables

        string _Tagesdatum;

        /// <summary>
        /// Gets or sets the value of variable Tagesdatum.
        /// </summary>
        [TestVariable("fb4efef9-2c41-49b7-9d4c-d68d82998f9c")]
        public string Tagesdatum
        {
            get { return _Tagesdatum; }
            set { _Tagesdatum = value; }
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

            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tER\tER042 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t1200\t1176\t24\t\t\t\t2\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tR\tER042 B_ZAHL_001 \t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row1'.", repo.TblDrucken.ChildTableWindow.Row1Info, new RecordItemIndex(0));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row1Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tER\tER042 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t1200\t1176\t24\t\t\t\t2\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tR\tER042 B_ZAHL_001 \t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tER\tER044 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t1800\t1800\t0\t\t\t\t2\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tR\tER044 B_ZAHL_001 Skontobasis 0,00\t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row2'.", repo.TblDrucken.ChildTableWindow.Row2Info, new RecordItemIndex(1));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row2Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tER\tER044 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t1800\t1800\t0\t\t\t\t2\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tR\tER044 B_ZAHL_001 Skontobasis 0,00\t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tER\tER043 B_ZAHL_001\t05.07.2021\t04.08.2021\tEUR\t600\t588\t12\t\t\t\t2\t\t19.07.2021\t05.07.2021\t14T 2% 30N\tR\tER043 B_ZAHL_001 \t\t\t05.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row3'.", repo.TblDrucken.ChildTableWindow.Row3Info, new RecordItemIndex(2));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row3Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tER\tER043 B_ZAHL_001\t05.07.2021\t04.08.2021\tEUR\t600\t588\t12\t\t\t\t2\t\t19.07.2021\t05.07.2021\t14T 2% 30N\tR\tER043 B_ZAHL_001 \t\t\t05.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tERG\tGS008 B_ZAHL_001\t05.07.2021\t04.08.2021\tEUR\t-120\t-120\t0\t\t\t\t0\t\t19.07.2021\t05.07.2021\t14T 2% 30N\tG\tGS008 B_ZAHL_001\t\t\t05.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row4'.", repo.TblDrucken.ChildTableWindow.Row4Info, new RecordItemIndex(3));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row4Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303040\tLF-40 INLAND B_ZAHL_001\tLF-40 B_ZAHL_001\tLF-40 B_ZAHL_001 Salzburger Straße 31\tAT 5020 Salzburg\t4080\t0\t\tAT 5020 Salzburg\t1\tAT\t19043\t00234573201\tLF-40 B_ZAHL_001 \t1\tERG\tGS008 B_ZAHL_001\t05.07.2021\t04.08.2021\tEUR\t-120\t-120\t0\t\t\t\t0\t\t19.07.2021\t05.07.2021\t14T 2% 30N\tG\tGS008 B_ZAHL_001\t\t\t05.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303041\tLF-41 DIV INLAND B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tAT 1010 Wien\t3000\t1\tLF-41 DIV INLAND B_ZAHL_001\tAT 1010 Wien\t2\tAT\t19043\t00234573201\t \t1\tER\tER045 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t2400\t2376\t24\t\t\t\t2\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tR\tER045 B_ZAHL_001 Skontobasis 1.200,00\t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row5'.", repo.TblDrucken.ChildTableWindow.Row5Info, new RecordItemIndex(4));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row5Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303041\tLF-41 DIV INLAND B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tAT 1010 Wien\t3000\t1\tLF-41 DIV INLAND B_ZAHL_001\tAT 1010 Wien\t2\tAT\t19043\t00234573201\t \t1\tER\tER045 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t2400\t2376\t24\t\t\t\t2\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tR\tER045 B_ZAHL_001 Skontobasis 1.200,00\t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303041\tLF-41 DIV INLAND B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tAT 1010 Wien\t3000\t2\tLF-41 DIV INLAND B_ZAHL_001\tAT 1010 Wien\t3\tDE\t50010517\t0137075030\tING-DiBa \t1\tERG\tGS009 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t-1800\t-1800\t0\t\t\t\t0\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tG\tGS009 B_ZAHL_001\t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row6'.", repo.TblDrucken.ChildTableWindow.Row6Info, new RecordItemIndex(5));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row6Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303041\tLF-41 DIV INLAND B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tAT 1010 Wien\t3000\t2\tLF-41 DIV INLAND B_ZAHL_001\tAT 1010 Wien\t3\tDE\t50010517\t0137075030\tING-DiBa \t1\tERG\tGS009 B_ZAHL_001\t01.07.2021\t31.07.2021\tEUR\t-1800\t-1800\t0\t\t\t\t0\t\t15.07.2021\t01.07.2021\t14T 2% 30N\tG\tGS009 B_ZAHL_001\t\t\t01.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
            // Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)
            Report.Log(ReportLevel.Info, "Validation", "Beginn und Ende entfernt mit ZV-Nummer und Erstellungsdatum (ist variabel)\r\nValidating AttributeContains (Text>'S\tSepaüberweisung\t15.07.2021\t303041\tLF-41 DIV INLAND B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tAT 1010 Wien\t3000\t2\tLF-41 DIV INLAND B_ZAHL_001\tAT 1010 Wien\t3\tDE\t50010517\t0137075030\tING-DiBa \t1\tER\tER046 B_ZAHL_001\t05.07.2021\t04.08.2021\tEUR\t1800\t1764\t36\t\t\t\t2\t\t19.07.2021\t05.07.2021\t14T 2% 30N\tR\tER046 B_ZAHL_001\t\t\t05.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:') on item 'TblDrucken.ChildTableWindow.Row7'.", repo.TblDrucken.ChildTableWindow.Row7Info, new RecordItemIndex(6));
            Validate.AttributeContains(repo.TblDrucken.ChildTableWindow.Row7Info, "Text", "S\tSepaüberweisung\t15.07.2021\t303041\tLF-41 DIV INLAND B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tLF-41 DIV B_ZAHL_001\tAT 1010 Wien\t3000\t2\tLF-41 DIV INLAND B_ZAHL_001\tAT 1010 Wien\t3\tDE\t50010517\t0137075030\tING-DiBa \t1\tER\tER046 B_ZAHL_001\t05.07.2021\t04.08.2021\tEUR\t1800\t1764\t36\t\t\t\t2\t\t19.07.2021\t05.07.2021\t14T 2% 30N\tR\tER046 B_ZAHL_001\t\t\t05.07.2021\t\tEUR\t0\t0\t\t\tErstellt am:");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
