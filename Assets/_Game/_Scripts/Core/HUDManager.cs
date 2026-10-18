using TMPro;
using UnityEngine;
using Zenject;
using YG;

public class HUDManager : MonoBehaviour
{
    public TextMeshProUGUI count;
    public TextMeshProUGUI level;
    public void ChangeCount(int valueCount)
    {
        count.text = valueCount.ToString();
    }

    public void LoadUI()
    {
        count.text = YG2.saves.coins.ToString();
        level.text = YG2.saves.level.ToString();
    }
}
