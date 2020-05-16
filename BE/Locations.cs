using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Locations : INotifyPropertyChanged
    {
        #region Enum
        public enum FallStatus { REAL, PREDICTION, REPORT };
        #endregion

        #region Private Fields
        List<iLocationClass> _theObject;
        FallStatus _status;
        #endregion

        #region Constructor
        public Locations(FallStatus mystatus, List<iLocationClass> code)
        {
            _status = mystatus;

            _theObject = code;
        }
        #endregion

        #region Public Properties
        public List<iLocationClass> TheObject
        {
            get
            {
                return _theObject;
            }
            set
            {
                if (_theObject != value)
                {
                    _theObject = value;
                    OnPropertyChanged("TheObject");
                }
            }
        }
        public FallStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged("Status");
                }
            }
        }
        #endregion

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}