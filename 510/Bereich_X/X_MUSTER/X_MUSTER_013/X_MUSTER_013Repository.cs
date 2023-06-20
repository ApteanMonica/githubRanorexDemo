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

namespace X_MUSTER_013
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the X_MUSTER_013Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("d17931bd-ec14-4c13-92a8-4698b1841f78")]
    public partial class X_MUSTER_013Repository : RepoGenBaseFolder
    {
        static X_MUSTER_013Repository instance = new X_MUSTER_013Repository();
        X_MUSTER_013RepositoryFolders.FrmZahlMainAppFolder _frmzahlmain;

        /// <summary>
        /// Gets the singleton class instance representing the X_MUSTER_013Repository element repository.
        /// </summary>
        [RepositoryFolder("d17931bd-ec14-4c13-92a8-4698b1841f78")]
        public static X_MUSTER_013Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public X_MUSTER_013Repository() 
            : base("X_MUSTER_013Repository", "/", null, 0, false, "d17931bd-ec14-4c13-92a8-4698b1841f78", ".\\RepositoryImages\\X_MUSTER_013Repositoryd17931bd.rximgres")
        {
            _frmzahlmain = new X_MUSTER_013RepositoryFolders.FrmZahlMainAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d17931bd-ec14-4c13-92a8-4698b1841f78")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The FrmZahlMain folder.
        /// </summary>
        [RepositoryFolder("3e6d4218-4012-4d97-8272-c7917daa4f3e")]
        public virtual X_MUSTER_013RepositoryFolders.FrmZahlMainAppFolder FrmZahlMain
        {
            get { return _frmzahlmain; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class X_MUSTER_013RepositoryFolders
    {
        /// <summary>
        /// The FrmZahlMainAppFolder folder.
        /// </summary>
        [RepositoryFolder("3e6d4218-4012-4d97-8272-c7917daa4f3e")]
        public partial class FrmZahlMainAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _titlebar100lieferantenzahlungsverInfo;

            /// <summary>
            /// Creates a new FrmZahlMain  folder.
            /// </summary>
            public FrmZahlMainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrmZahlMain", "/form[@controlname='frmZahlMain']", parentFolder, 30000, null, true, "3e6d4218-4012-4d97-8272-c7917daa4f3e", "")
            {
                _titlebar100lieferantenzahlungsverInfo = new RepoItemInfo(this, "TitleBar100LieferantenZahlungsver", "titlebar[@accessiblerole='TitleBar']", "", 30000, null, "acc574e5-b92c-475e-82ac-f39a5aabb9f8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3e6d4218-4012-4d97-8272-c7917daa4f3e")]
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
            [RepositoryItemInfo("3e6d4218-4012-4d97-8272-c7917daa4f3e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TitleBar100LieferantenZahlungsver item.
            /// </summary>
            [RepositoryItem("acc574e5-b92c-475e-82ac-f39a5aabb9f8")]
            public virtual Ranorex.TitleBar TitleBar100LieferantenZahlungsver
            {
                get
                {
                    return _titlebar100lieferantenzahlungsverInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The TitleBar100LieferantenZahlungsver item info.
            /// </summary>
            [RepositoryItemInfo("acc574e5-b92c-475e-82ac-f39a5aabb9f8")]
            public virtual RepoItemInfo TitleBar100LieferantenZahlungsverInfo
            {
                get
                {
                    return _titlebar100lieferantenzahlungsverInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}