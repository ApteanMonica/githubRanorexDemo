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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace V_AUFC_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the V_AUFC_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("5e5c9d07-d7ce-4a75-ada2-bab4fc3c4f73")]
    public partial class V_AUFC_SchnelltestRepository : RepoGenBaseFolder
    {
        static V_AUFC_SchnelltestRepository instance = new V_AUFC_SchnelltestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the V_AUFC_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("5e5c9d07-d7ce-4a75-ada2-bab4fc3c4f73")]
        public static V_AUFC_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public V_AUFC_SchnelltestRepository() 
            : base("V_AUFC_SchnelltestRepository", "/", null, 0, false, "5e5c9d07-d7ce-4a75-ada2-bab4fc3c4f73", ".\\RepositoryImages\\V_AUFC_SchnelltestRepository5e5c9d07.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("5e5c9d07-d7ce-4a75-ada2-bab4fc3c4f73")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class V_AUFC_SchnelltestRepositoryFolders
    {
    }
#pragma warning restore 0436
}
