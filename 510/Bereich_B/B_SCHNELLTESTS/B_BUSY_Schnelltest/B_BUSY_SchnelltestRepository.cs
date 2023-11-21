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

namespace B_BUSY_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_BUSY_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("94585fac-1128-4595-a14c-fa247f2dfc4e")]
    public partial class B_BUSY_SchnelltestRepository : RepoGenBaseFolder
    {
        static B_BUSY_SchnelltestRepository instance = new B_BUSY_SchnelltestRepository();
        B_BUSY_SchnelltestRepositoryFolders.FrmBusyAppFolder _frmbusy;

        /// <summary>
        /// Gets the singleton class instance representing the B_BUSY_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("94585fac-1128-4595-a14c-fa247f2dfc4e")]
        public static B_BUSY_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_BUSY_SchnelltestRepository() 
            : base("B_BUSY_SchnelltestRepository", "/", null, 0, false, "94585fac-1128-4595-a14c-fa247f2dfc4e", ".\\RepositoryImages\\B_BUSY_SchnelltestRepository94585fac.rximgres")
        {
            _frmbusy = new B_BUSY_SchnelltestRepositoryFolders.FrmBusyAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("94585fac-1128-4595-a14c-fa247f2dfc4e")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmBusy folder.
        /// </summary>
        [RepositoryFolder("75007abc-3aea-477a-944c-d8f77ab201d1")]
        public virtual B_BUSY_SchnelltestRepositoryFolders.FrmBusyAppFolder FrmBusy
        {
            get { return _frmbusy; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_BUSY_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The FrmBusyAppFolder folder.
        /// </summary>
        [RepositoryFolder("75007abc-3aea-477a-944c-d8f77ab201d1")]
        public partial class FrmBusyAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100buchungssymbolInfo;

            /// <summary>
            /// Creates a new FrmBusy  folder.
            /// </summary>
            public FrmBusyAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmBusy", "/form[@controlname='frmBusy']", parentFolder, 30000, null, true, "75007abc-3aea-477a-944c-d8f77ab201d1", "")
            {
                _titlebar100buchungssymbolInfo = new RepoItemInfo(this, "TitleBar100Buchungssymbol", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "d74cf5ba-8073-4304-9a59-c32ada95c364");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("75007abc-3aea-477a-944c-d8f77ab201d1")]
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
            [RepositoryItemInfo("75007abc-3aea-477a-944c-d8f77ab201d1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100Buchungssymbol item.
            /// </summary>
            [RepositoryItem("d74cf5ba-8073-4304-9a59-c32ada95c364")]
            public virtual Ranorex.TitleBar TitleBar100Buchungssymbol
            {
                get
                {
                    return _titlebar100buchungssymbolInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100Buchungssymbol item info.
            /// </summary>
            [RepositoryItemInfo("d74cf5ba-8073-4304-9a59-c32ada95c364")]
            public virtual RepoItemInfo TitleBar100BuchungssymbolInfo
            {
                get
                {
                    return _titlebar100buchungssymbolInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}