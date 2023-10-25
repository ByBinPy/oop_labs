using System.Collections.Generic;
using System.Collections.ObjectModel;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repos;

public class MotherBoardRepo
{
    private Collection<MotherBoard> _motherBoards;

    public MotherBoardRepo()
    {
        _motherBoards = new Collection<MotherBoard>();
    }

    public MotherBoardRepo(IList<MotherBoard> motherBoards)
    {
        _motherBoards = new Collection<MotherBoard>(motherBoards);
    }

    public MotherBoardRepo Add(MotherBoard motherBoard)
    {
        if (!RepoValidator.IsValidMotherBoard(motherBoard))
            return new MotherBoardRepo();

        _motherBoards.Add(motherBoard);

        return this;
    }

    public bool Update(MotherBoard motherBoard, MotherBoard newMotherBoard)
    {
        if (_motherBoards.IndexOf(motherBoard) == -1)
            return false;

        _motherBoards[_motherBoards.IndexOf(motherBoard)] = newMotherBoard;

        return true;
    }
}