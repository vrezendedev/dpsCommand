using UnityEngine;

public class General : MonoBehaviour
{
    [Header("Dependent on:")]
    public Arrow arrow;
    private ArmyOrdersHistoric armyOrdersHistoric;
    //ArmyOrders _armyOrders;

    void Start()
    {
        //ICommand shootCommand = new ShootCommand(arrow);
        //ICommand reloadCommand = new ReloadCommand(arrow);
        //_armyOrders = new ArmyOrders(shootCommand, reloadCommand);
        armyOrdersHistoric = new ArmyOrdersHistoric();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ICommand shootCommand = new ShootCommand(arrow);
            armyOrdersHistoric.AddCommand(shootCommand);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            armyOrdersHistoric.UndoCommand();
        }
    }
}
