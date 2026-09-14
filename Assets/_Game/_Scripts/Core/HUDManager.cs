using TMPro;
using UnityEngine;
using Zenject;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI count;

    /*[Inject]
    public void Constructor([Inject(Id = "Count")] TextMeshPro count)
    {
        _count = count;
    }*/
    public void ChangeCount(int valueCount)
    {
        count.text = valueCount.ToString();
    }
}
