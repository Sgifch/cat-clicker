using Unity.VisualScripting;
using UnityEngine;
using Zenject;
using static UnityEngine.Rendering.DebugUI;

public class Target : MonoBehaviour, ITargetActivate
{
    [SerializeField]
    private BoxCollider2D _area;
    public GameObject nextTarget;
    [SerializeField]
    private GameObject _targetList;
    public int bonus;

    [Inject]
    public void Construct(BoxCollider2D area, GameObject targetList)
    {
        _area = area;
        _targetList = targetList;
    }

    public void TargetActivate()
    {
        Bounds bound = _area.bounds;
        float x = Random.Range(bound.min.x, bound.max.x);
        Vector3 newPosition = new Vector3(x, transform.position.y);
        Instantiate(nextTarget, newPosition, Quaternion.identity, _targetList.transform);
        Destroy(gameObject);
    }
}
