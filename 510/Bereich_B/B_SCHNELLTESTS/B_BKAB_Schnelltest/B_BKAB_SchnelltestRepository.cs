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

namespace B_BKAB_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_BKAB_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("c8267511-87be-43f2-acbf-8a3d45250bd6")]
    public partial class B_BKAB_SchnelltestRepository : RepoGenBaseFolder
    {
        static B_BKAB_SchnelltestRepository instance = new B_BKAB_SchnelltestRepository();
        B_BKAB_SchnelltestRepositoryFolders.TblBkAbAppFolder _tblbkab;

        /// <summary>
        /// Gets the singleton class instance representing the B_BKAB_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("c8267511-87be-43f2-acbf-8a3d45250bd6")]
        public static B_BKAB_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_BKAB_SchnelltestRepository() 
            : base("B_BKAB_SchnelltestRepository", "/", null, 0, false, "c8267511-87be-43f2-acbf-8a3d45250bd6", ".\\RepositoryImages\\B_BKAB_SchnelltestRepositoryc8267511.rximgres")
        {
            _tblbkab = new B_BKAB_SchnelltestRepositoryFolders.TblBkAbAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c8267511-87be-43f2-acbf-8a3d45250bd6")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The TblBkAb folder.
        /// </summary>
        [RepositoryFolder("a2af9d71-4a65-4132-93a3-55fba9ca93f4")]
        public virtual B_BKAB_SchnelltestRepositoryFolders.TblBkAbAppFolder TblBkAb
        {
            get { return _tblbkab; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_BKAB_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The TblBkAbAppFolder folder.
        /// </summary>
        [RepositoryFolder("a2af9d71-4a65-4132-93a3-55fba9ca93f4")]
        public partial class TblBkAbAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100bereichskontenabfrageInfo;

            /// <summary>
            /// Creates a new TblBkAb  folder.
            /// </summary>
            public TblBkAbAppFolder(RepoGenBaseFolder parentFolder) :
                    base("TblBkAb", "/form[@controlname='tblBkAb']", parentFolder, 30000, null, true, "a2af9d71-4a65-4132-93a3-55fba9ca93f4", "")
            {
                _titlebar100bereichskontenabfrageInfo = new RepoItemInfo(this, "TitleBar100Bereichskontenabfrage", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "c9f61659-be55-45b2-b21c-de0f6a3a0fa4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a2af9d71-4a65-4132-93a3-55fba9ca93f4")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a2af9d71-4a65-4132-93a3-55fba9ca93f4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100Bereichskontenabfrage item.
            /// </summary>
            [RepositoryItem("c9f61659-be55-45b2-b21c-de0f6a3a0fa4")]
            public virtual Ranorex.TitleBar TitleBar100Bereichskontenabfrage
            {
                get
                {
                    return _titlebar100bereichskontenabfrageInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100Bereichskontenabfrage item info.
            /// </summary>
            [RepositoryItemInfo("c9f61659-be55-45b2-b21c-de0f6a3a0fa4")]
            public virtual RepoItemInfo TitleBar100BereichskontenabfrageInfo
            {
                get
                {
                    return _titlebar100bereichskontenabfrageInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}