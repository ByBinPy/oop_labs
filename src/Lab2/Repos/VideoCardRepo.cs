using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class VideoCardRepo
{
    private Collection<VideoCard> _videoCards;

    public VideoCardRepo()
    {
        _videoCards = new Collection<VideoCard>();
    }

    public VideoCardRepo(IList<VideoCard> videoCards)
    {
        _videoCards = new Collection<VideoCard>(videoCards);
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
}