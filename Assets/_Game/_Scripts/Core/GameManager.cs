using UnityEngine;
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
            _value.valueCount += hit.GetComponent<Hit>().hitObject.GetComponent<Target>().bonus;
            _hudManager.ChangeCount(_value.valueCount);
        }
    }
}
