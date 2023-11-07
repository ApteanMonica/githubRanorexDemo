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

namespace B_KTSALD_Schnelltest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the B_KTSALD_SchnelltestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f7ec50de-1c4a-4a10-95e8-bff2ccfb0542")]
    public partial class B_KTSALD_SchnelltestRepository : RepoGenBaseFolder
    {
        static B_KTSALD_SchnelltestRepository instance = new B_KTSALD_SchnelltestRepository();
        B_KTSALD_SchnelltestRepositoryFolders.FrmKtSaliAppFolder _frmktsali;

        /// <summary>
        /// Gets the singleton class instance representing the B_KTSALD_SchnelltestRepository element repository.
        /// </summary>
        [RepositoryFolder("f7ec50de-1c4a-4a10-95e8-bff2ccfb0542")]
        public static B_KTSALD_SchnelltestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public B_KTSALD_SchnelltestRepository() 
            : base("B_KTSALD_SchnelltestRepository", "/", null, 0, false, "f7ec50de-1c4a-4a10-95e8-bff2ccfb0542", ".\\RepositoryImages\\B_KTSALD_SchnelltestRepositoryf7ec50de.rximgres")
        {
            _frmktsali = new B_KTSALD_SchnelltestRepositoryFolders.FrmKtSaliAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f7ec50de-1c4a-4a10-95e8-bff2ccfb0542")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmKtSali folder.
        /// </summary>
        [RepositoryFolder("d466b40b-4aeb-47a1-bdaf-2d9aff599721")]
        public virtual B_KTSALD_SchnelltestRepositoryFolders.FrmKtSaliAppFolder FrmKtSali
        {
            get { return _frmktsali; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class B_KTSALD_SchnelltestRepositoryFolders
    {
        /// <summary>
        /// The FrmKtSaliAppFolder folder.
        /// </summary>
        [RepositoryFolder("d466b40b-4aeb-47a1-bdaf-2d9aff599721")]
        public partial class FrmKtSaliAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100sachkontenumsatzlisteInfo;

            /// <summary>
            /// Creates a new FrmKtSali  folder.
            /// </summary>
            public FrmKtSaliAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmKtSali", "/form[@controlname='frmKtSali']", parentFolder, 30000, null, true, "d466b40b-4aeb-47a1-bdaf-2d9aff599721", "")
            {
                _titlebar100sachkontenumsatzlisteInfo = new RepoItemInfo(this, "TitleBar100SachkontenUmsatzliste", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "b64ea80c-15b4-41d7-9dad-5888b562fda2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d466b40b-4aeb-47a1-bdaf-2d9aff599721")]
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
            [RepositoryItemInfo("d466b40b-4aeb-47a1-bdaf-2d9aff599721")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100SachkontenUmsatzliste item.
            /// </summary>
            [RepositoryItem("b64ea80c-15b4-41d7-9dad-5888b562fda2")]
            public virtual Ranorex.TitleBar TitleBar100SachkontenUmsatzliste
            {
                get
                {
                    return _titlebar100sachkontenumsatzlisteInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100SachkontenUmsatzliste item info.
            /// </summary>
            [RepositoryItemInfo("b64ea80c-15b4-41d7-9dad-5888b562fda2")]
            public virtual RepoItemInfo TitleBar100SachkontenUmsatzlisteInfo
            {
                get
                {
                    return _titlebar100sachkontenumsatzlisteInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
