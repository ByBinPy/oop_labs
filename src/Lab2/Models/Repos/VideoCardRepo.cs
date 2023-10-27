using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class VideoCardRepo
{
    private readonly List<VideoCard> _videoCards;

    public VideoCardRepo()
    {
        _videoCards = new List<VideoCard>();
    }

    public VideoCardRepo(IList<VideoCard> videoCards)
    {
        _videoCards = new List<VideoCard>(videoCards);
    }

    public VideoCardRepo Add(VideoCard videoCard)
    {
        if (!RepoValidator.IsValidVideoCard(videoCard))
            return new VideoCardRepo();

        _videoCards.Add(videoCard);

        return this;
    }

    public bool Update(VideoCard videoCard, VideoCard newVideoCard)
    {
        if (_videoCards.IndexOf(videoCard) == -1)
            return false;

        _videoCards[_videoCards.IndexOf(videoCard)] = newVideoCard;

        return true;
    }

    public IList<VideoCard> FindAll(Predicate<VideoCard> predicate) => _videoCards.FindAll(predicate);
}