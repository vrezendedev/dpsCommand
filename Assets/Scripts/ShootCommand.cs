public class ShootCommand : ICommand
{
    private Arrow arrow;

    public ShootCommand(Arrow arrow)
    {
        TextEvent.UpdateText("Shoot Command instanced... Class: " + typeof(ShootCommand).Name);
        this.arrow = arrow;
    }

    public void Execute()
    {
        TextEvent.UpdateText("Shoot Command method executed... Class: " + typeof(ShootCommand).Name);
        arrow.Shoot();
    }

    public void Undo()
    {
        TextEvent.UpdateText("Undo Command method executed... Class: " + typeof(ShootCommand).Name);
        arrow.Reload();
    }
}
