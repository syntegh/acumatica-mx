﻿using System;
using PX.Data;

namespace AcumaticaMX
{
    public class MXFESatZipCodeList : IBqlTable
    {
        public abstract class zipCodeID: IBqlField
        {
        }
        [PXDBIdentity]
        public virtual int? ZipCodeID { get; set; }

        public abstract class zipCodeCD : IBqlField
        {
        }
        [PXDBString(5, IsKey = true, IsUnicode = true, InputMask = ">CCCCC")]
        [PXDefault]
        [PXUIField(DisplayName = Messages.ZipCodeCD)]
        public virtual int? ZipCodeCD { get; set; }

        public abstract class state : IBqlField
        {
        }
        [PXDBString(3, IsUnicode = true, InputMask = ">CCCCC")]
        [PXDefault]
        [PXUIField(DisplayName = Messages.State)]
        public virtual string State { get; set; }

        public abstract class municipality : IBqlField
        {
        }
        [PXDBString(3, IsUnicode = true, InputMask = ">CCC")]
        [PXUIField(DisplayName = Messages.Municipality)]
        public virtual string Municipality { get; set; }

        public abstract class town : IBqlField
        {
        }
        [PXDBString(3, IsUnicode = true, InputMask = ">CCC")]
        [PXUIField(DisplayName = Messages.Town)]
        public virtual string Town { get; set; }

        #region audit

        #region tstamp

        public abstract class Tstamp : PX.Data.IBqlField
        {
        }

        protected byte[] _tstamp;

        [PXDBTimestamp()]
        public virtual byte[] tstamp
        {
            get
            {
                return this._tstamp;
            }
            set
            {
                this._tstamp = value;
            }
        }

        #endregion tstamp

        #region CreatedByID

        public abstract class createdByID : PX.Data.IBqlField
        {
        }

        protected Guid? _CreatedByID;

        [PXDBCreatedByID()]
        public virtual Guid? CreatedByID
        {
            get
            {
                return this._CreatedByID;
            }
            set
            {
                this._CreatedByID = value;
            }
        }

        #endregion CreatedByID

        #region CreatedByScreenID

        public abstract class createdByScreenID : PX.Data.IBqlField
        {
        }

        protected string _CreatedByScreenID;

        [PXDBCreatedByScreenID()]
        public virtual string CreatedByScreenID
        {
            get
            {
                return this._CreatedByScreenID;
            }
            set
            {
                this._CreatedByScreenID = value;
            }
        }

        #endregion CreatedByScreenID

        #region CreatedDateTime

        public abstract class createdDateTime : PX.Data.IBqlField
        {
        }

        protected DateTime? _CreatedDateTime;

        [PXDBCreatedDateTime()]
        public virtual DateTime? CreatedDateTime
        {
            get
            {
                return this._CreatedDateTime;
            }
            set
            {
                this._CreatedDateTime = value;
            }
        }

        #endregion CreatedDateTime

        #region LastModifiedByID

        public abstract class lastModifiedByID : PX.Data.IBqlField
        {
        }

        protected Guid? _LastModifiedByID;

        [PXDBLastModifiedByID()]
        public virtual Guid? LastModifiedByID
        {
            get
            {
                return this._LastModifiedByID;
            }
            set
            {
                this._LastModifiedByID = value;
            }
        }

        #endregion LastModifiedByID

        #region LastModifiedByScreenID

        public abstract class lastModifiedByScreenID : PX.Data.IBqlField
        {
        }

        protected string _LastModifiedByScreenID;

        [PXDBLastModifiedByScreenID()]
        public virtual string LastModifiedByScreenID
        {
            get
            {
                return this._LastModifiedByScreenID;
            }
            set
            {
                this._LastModifiedByScreenID = value;
            }
        }

        #endregion LastModifiedByScreenID

        #region LastModifiedDateTime

        public abstract class lastModifiedDateTime : PX.Data.IBqlField
        {
        }

        protected DateTime? _LastModifiedDateTime;

        [PXDBLastModifiedDateTime()]
        public virtual DateTime? LastModifiedDateTime
        {
            get
            {
                return this._LastModifiedDateTime;
            }
            set
            {
                this._LastModifiedDateTime = value;
            }
        }

        #endregion LastModifiedDateTime

        #endregion audit

    }
}
