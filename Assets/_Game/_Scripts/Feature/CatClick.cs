using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

public class CatClick : MonoBehaviour, IPointerClickHandler
{
    public GameManager _gameManager;


    [Inject]
    public void Construct(GameManager gameManager)
    {
        _gameManager = gameManager;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        //Что-то там сделать
        _gameManager.CountChange();
    }

}
