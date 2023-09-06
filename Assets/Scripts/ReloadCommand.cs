public class ReloadCommand : ICommand
{
    private Arrow arrow;

    public ReloadCommand(Arrow arrow)
    {
        TextEvent.UpdateText("Reload Command instanced... Class: " + typeof(ShootCommand).Name);
        this.arrow = arrow;
    }

    public void Execute()
    {
        TextEvent.UpdateText("Reload Command method executed... Class: " + typeof(ShootCommand).Name);
        arrow.Reload();
    }

    public void Undo()
    {
        TextEvent.UpdateText("Undo Command method executed... Class: " + typeof(ShootCommand).Name);
        return;
    }
}
