﻿using System.Collections.ObjectModel;
using System.ComponentModel;

namespace KitsuSeasons.Interfaces
{
    public interface ISeasonExpander : INotifyPropertyChanged
    {
        ObservableCollection<ISeasonEntry> SeasonEntries { get; }

        string Header { get; }
    }
}