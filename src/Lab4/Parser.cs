namespace Itmo.ObjectOrientedProgramming.Lab4;

public class Parser
{
    private ConnectChain _connectChain = new ConnectChain();
    private ModeConnectFlagChain _modeConnectFlagChain = new ModeConnectFlagChain();
    private DisconnectChain _disconnectChain = new DisconnectChain();
    private TreeGoToChain _treeGoToChain = new TreeGoToChain();
    private TreeListChain _treeListChain = new TreeListChain();
    private DepthFlagChain _depthFlagChain = new DepthFlagChain();
    private FileShowChain _fileShowChain = new FileShowChain();
    private ModeShowFlagChain _modeShowFlagChain = new ModeShowFlagChain();
    private FileMoveChain _fileMoveChain = new FileMoveChain();
    private FileCopyChain _fileCopyChain = new FileCopyChain();
    private FileDeleteChain _fileDeleteChain = new FileDeleteChain();
    private FileRenameChain _fileRenameChain = new FileRenameChain();

    public Parser()
    {
        _connectChain.AddNext(_modeConnectFlagChain);
        _modeConnectFlagChain.AddNext(_modeConnectFlagChain);
        _disconnectChain.AddNext(_treeGoToChain);
        _treeGoToChain.AddNext(_treeListChain);
        _treeListChain.AddNext(_depthFlagChain);
        _depthFlagChain.AddNext(_fileShowChain);
        _fileShowChain.AddNext(_modeShowFlagChain);
        _modeConnectFlagChain.AddNext(_fileMoveChain);
        _fileMoveChain.AddNext(_fileCopyChain);
        _fileCopyChain.AddNext(_fileDeleteChain);
        _fileRenameChain.AddNext(_fileRenameChain);
    }

    public void Parse(Context context)
    {
        _connectChain.Handle(context);
    }
}