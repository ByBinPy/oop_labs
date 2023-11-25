using Itmo.ObjectOrientedProgramming.Lab4.ForParser.Chains;

namespace Itmo.ObjectOrientedProgramming.Lab4.ForParser;

public class DebuilderParser
{
    private ConnectChain _connectChain;
    private ModeConnectFlagChain _modeConnectFlagChain;
    private DisconnectChain _disconnectChain;
    private TreeGoToChain _treeGoToChain;
    private TreeListChain _treeListChain;
    private DepthFlagChain _depthFlagChain;
    private FileShowChain _fileShowChain;
    private ModeShowFlagChain _modeShowFlagChain;
    private FileMoveChain _fileMoveChain;
    private FileCopyChain _fileCopyChain;
    private FileDeleteChain _fileDeleteChain;
    private FileRenameChain _fileRenameChain;
    public DebuilderParser(Parser parser)
    {
        parser.Deconstruct(
            out _connectChain,
            out _modeConnectFlagChain,
            out _disconnectChain,
            out _treeGoToChain,
            out _treeListChain,
            out _depthFlagChain,
            out _fileShowChain,
            out _modeShowFlagChain,
            out _fileMoveChain,
            out _fileCopyChain,
            out _fileDeleteChain,
            out _fileRenameChain);
    }

    public DebuilderParser WithConnectChain(ConnectChain connectChain)
    {
        _connectChain = connectChain;
        return this;
    }

    public DebuilderParser WithModeConnectFlagChain(ModeConnectFlagChain modeConnectFLagChain)
    {
        _modeConnectFlagChain = modeConnectFLagChain;
        return this;
    }

    public DebuilderParser WithDisconnectChain(DisconnectChain disconnectChain)
    {
        _disconnectChain = disconnectChain;
        return this;
    }

    public DebuilderParser WithTreeGoToChain(TreeGoToChain treeGoToChain)
    {
        _treeGoToChain = treeGoToChain;
        return this;
    }

    public DebuilderParser WithModeShowFlagChain(ModeShowFlagChain modeShowFlagChain)
    {
        _modeShowFlagChain = modeShowFlagChain;
        return this;
    }

    public DebuilderParser WithTreeListChain(TreeListChain treeListChain)
    {
        _treeListChain = treeListChain;
        return this;
    }

    public DebuilderParser WithDepthFlagChain(DepthFlagChain depthFlagChain)
    {
        _depthFlagChain = depthFlagChain;
        return this;
    }

    public DebuilderParser WithFileShowChain(FileShowChain fileShowChain)
    {
        _fileShowChain = fileShowChain;
        return this;
    }

    public DebuilderParser WithFileMoveChain(FileMoveChain fileMoveChain)
    {
        _fileMoveChain = fileMoveChain;
        return this;
    }

    public DebuilderParser WithFileCopyChain(FileCopyChain fileCopyChain)
    {
        _fileCopyChain = fileCopyChain;
        return this;
    }

    public DebuilderParser WithFileDeleteChain(FileDeleteChain fileDeleteChain)
    {
        _fileDeleteChain = fileDeleteChain;
        return this;
    }

    public DebuilderParser WithFileRenameChain(FileRenameChain fileRenameChain)
    {
        _fileRenameChain = fileRenameChain;
        return this;
    }
}