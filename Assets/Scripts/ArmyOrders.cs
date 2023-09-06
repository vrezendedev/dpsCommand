public class ArmyOrders
{
    ICommand _onShoot;
    ICommand _onReload;

    public ArmyOrders(ICommand onShoot, ICommand onReload)
    {
        _onShoot = onShoot;
        _onReload = onReload;
    }

    public void ShootBallista() => _onShoot.Execute();

    public void ReloadBallista() => _onReload.Execute();
}
