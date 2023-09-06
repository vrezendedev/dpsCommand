using System.Collections.Generic;

public class ArmyOrdersHistoric
{
    Stack<ICommand> _commandList;

    public ArmyOrdersHistoric()
    {
        TextEvent.UpdateText("Invoker instanced... Class: " + typeof(ArmyOrdersHistoric).Name);
        _commandList = new Stack<ICommand>();
    }

    public void AddCommand(ICommand newCommand)
    {
        TextEvent.UpdateText("Add Command method executed... Class: " + typeof(ArmyOrdersHistoric).Name);
        newCommand.Execute();
        _commandList.Push(newCommand);
    }

    public void UndoCommand()
    {
        if (_commandList.Count > 0)
        {
            TextEvent.UpdateText("Undo Command method executed... Class: " + typeof(ArmyOrdersHistoric).Name);
            ICommand latestCommand = _commandList.Pop();
            latestCommand.Undo();
        }
    }
}
