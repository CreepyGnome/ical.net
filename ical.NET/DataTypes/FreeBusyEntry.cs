﻿using Ical.Net.Interfaces.DataTypes;
using Ical.Net.Interfaces.General;

namespace Ical.Net.DataTypes
{
    public class FreeBusyEntry :
        Period,
        IFreeBusyEntry
    {
        #region Private Fields

        FreeBusyStatus _status;

        #endregion

        #region Constructors

        public FreeBusyEntry() : base() { Initialize(); }
        public FreeBusyEntry(IPeriod period, FreeBusyStatus status) : base()
        {
            Initialize();
            CopyFrom(period);
            Status = status;
        }

        void Initialize()
        {
            Status = FreeBusyStatus.Busy;
        }

        #endregion

        #region Overrides

        public override void CopyFrom(ICopyable obj)
        {
            base.CopyFrom(obj);

            var fb = obj as IFreeBusyEntry;
            if (fb != null)
            {
                Status = fb.Status;
            }
        }

        #endregion

        #region IFreeBusyEntry Members

        virtual public FreeBusyStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        #endregion
    }
}
