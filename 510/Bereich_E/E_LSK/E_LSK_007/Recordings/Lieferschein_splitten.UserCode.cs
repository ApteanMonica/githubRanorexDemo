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

namespace E_LSK_007.Recordings
{
    public partial class Lieferschein_splitten
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
       
      
      
          public void Validate_ColLspMengeAltRow1(RepoItemInfo cellInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$MengeAlt1) on item 'cellInfo'.", cellInfo);

  
            string mengeX = MengeAlt1.Replace(",00","");

          
            string mengeY = repo.DlgLskSplitten.FlexGrid.ColLspMengeAltRow1.Text.Replace(",00","");

           	Validate.AreEqual(mengeX, mengeY);
        }
        
             
                   
        public void Validate1_ColLspMengeAltRow2(RepoItemInfo cellInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$MengeAlt2) on item 'cellInfo'.", cellInfo);

  
            string mengeX = MengeAlt2.Replace(",00","");

          
            string mengeY = repo.DlgLskSplitten.FlexGrid.ColLspMengeAltRow2.Text.Replace(",00","");

           	Validate.AreEqual(mengeX, mengeY);
        }


    	public void Validate2_ColLspMengeNeuRow2(RepoItemInfo cellInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$MengeNeu1) on item 'cellInfo'.", cellInfo);

  
            string mengeX = MengeNeu1.Replace(",00","");

          
            string mengeY = repo.DlgLskSplitten.FlexGrid.ColLspMengeNeuRow2.Text.Replace(",00","");

           	Validate.AreEqual(mengeX, mengeY);
    	}

	public void Validate_ColLslgMengeRow11(RepoItemInfo cellInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$LagerMenge) on item 'cellInfo'.", cellInfo);

  
            string mengeX = LagerMenge.Replace(",00","");

          
            string mengeY = repo.MdiLSR.FrmKopf.ColLslgMengeRow1.Text.Replace(",00","");

           	Validate.AreEqual(mengeX, mengeY);
    	}
		
		
 }
    
}