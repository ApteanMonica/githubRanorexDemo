﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace B_BUCH_005.Recordings
{
    public partial class Validierung_Jahr_Periode
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_DfSoll(RepoItemInfo textInfo)
        {
            // TODO: Replace the following line with your code implementation.
            throw new NotImplementedException();
        }

        public void Validate_DfPeriodeJ1(RepoItemInfo textInfo)
        {
        	// Inhalt von Feld wird als Integer konvertiert
        	int Periode_int1 = Convert.ToInt32(repo.MdiBuch.ToolBar.DfPeriodeJ.TextValue);
        	// Periode_int (konvertierte Inhalt von Feld als integer) wird als String konvertiert
        	string Periode_string1 = Periode_int1.ToString();
        	
        	int Periode_int2 = Convert.ToInt32(periode);
        	// Periode_int (konvertierte Inhalt von Feld als integer) wird als String konvertiert
        	string Periode_string2 = Periode_int2.ToString();
        	
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (ControlText=$Periode) on item 'textInfo'.", textInfo);

            // Vergleichen die Periode_string (konvertierte Inhalt von Feld als integer) und Variable Periode
            Validate.AreEqual(Periode_string1, Periode_string2);
        }

        public void Validate_DfPeriodeJ(RepoItemInfo textInfo)
        {
        /*	// Inhalt von Feld wird als Integer konvertiert
        	int Periode_int = Convert.ToInt32 (Periode);
        	// Prüfen ob Periode hat zwei Stelle
        	if(Periode_int<9)
        		// Wenn Periode großer als 9 ist, ein 0 vorne eingeben
				Validate.AttributeEqual(textInfo, "Text", '0'+Periode);
        	else
        		Validate.AttributeEqual(textInfo, "Text", Periode);
        */
        }

    }
}
