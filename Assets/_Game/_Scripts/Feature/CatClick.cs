using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class CatClick : MonoBehaviour, IPointerClickHandler
{
    public GameManager _gameManager;
    public Hit hit;


    [Inject]
    public void Construct(GameManager gameManager)
    {
        _gameManager = gameManager;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        if (hit.hitObject != null)
        {
            _gameManager.CountChange();
            hit.hitObject.GetComponent<ITargetActivate>().TargetActivate();
            hit.hitObject = null;
        }
    }

}
