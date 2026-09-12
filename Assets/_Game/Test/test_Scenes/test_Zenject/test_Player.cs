using UnityEngine;
using Zenject;

public class test_Player : MonoBehaviour
{
    [Inject]
    public test_say test;

    private void Start()
    {
        print(test.whatsay);
    }
}
