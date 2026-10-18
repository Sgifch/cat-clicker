using UnityEngine;
using YG;
using Zenject;

public class GameManager : MonoBehaviour
{
    private HUDManager _hudManager;
    public GameObject hit;
    private Value _value;

    [Inject]
    public void Construct(Value value, HUDManager hudManager)
    {
        _value = value;
        _hudManager = hudManager;
    }

    public void CountChange()
    {
        //мб потом поменять доступ через интерфейс
        if (hit.GetComponent<Hit>().hitObject != null)
        {
            YG2.saves.coins += hit.GetComponent<Hit>().hitObject.GetComponent<Target>().bonus;
            _hudManager.ChangeCount(YG2.saves.coins);
        }
    }
}
