﻿using ModelViewViewModel.commands;

namespace KitsuSeasons.Interfaces
{
    public interface ISeasonEntry
    {
        string ImagePath { get; }

        string Name { get; }

        string EpisodeText { get; }

        string Type { get; } 

        string Status { get; }

        string ScoreText { get; }

        string AiredText { get; } 

        string Rating { get; }

        int AddButtonSize { get; set; }

        ActionCommand AddAnimeToListCmd { get; }

        int AnimeId { get; }
    }
}
