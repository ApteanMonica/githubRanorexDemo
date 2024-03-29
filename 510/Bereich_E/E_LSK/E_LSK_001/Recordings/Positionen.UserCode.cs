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

namespace E_LSK_001.Recordings
{
    public partial class Positionen
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        
        
        public void Validate_ColLspMengeRow1(RepoItemInfo cellInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$Menge) on item 'cellInfo'.", cellInfo);

  
            string mengeX = Menge.Replace(",00","");
          
            string mengeY = repo.MdiLSR.TblLsp.ColLspMengeRow1.Text.Replace(",00","");

            Validate.AreEqual(mengeX, mengeY);
        }


    }
}
