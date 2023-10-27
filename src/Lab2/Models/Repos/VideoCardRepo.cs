using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Connectors;
using Itmo.ObjectOrientedProgramming.Lab2.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Repos;

public class VideoCardRepo
{
    private readonly List<VideoCard> _videoCards;

    public VideoCardRepo()
    {
        _videoCards = new List<VideoCard>()
        {
            new VideoCardBuilder()
                .WithQtyMemory(4)
                .WithHeight(105)
                .WithWidth(40)
                .WithChipFrequency(660)
                .WithPower(60)
                .WithVersionPciE(new PciE("3.0"))
                .Build(),
            new VideoCardBuilder()
                .WithQtyMemory(8)
                .WithHeight(114)
                .WithWidth(53)
                .WithChipFrequency(744)
                .WithPower(74)
                .WithVersionPciE(new PciE("5.0"))
                .Build(),
            new VideoCardBuilder()
                .WithQtyMemory(8)
                .WithHeight(115)
                .WithWidth(43)
                .WithChipFrequency(783)
                .WithPower(75)
                .WithVersionPciE(new PciE("4.0"))
                .Build(),
            new VideoCardBuilder()
                .WithQtyMemory(6)
                .WithHeight(109)
                .WithWidth(51)
                .WithChipFrequency(710)
                .WithPower(66)
                .WithVersionPciE(new PciE("4.0"))
                .Build(),
        };
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