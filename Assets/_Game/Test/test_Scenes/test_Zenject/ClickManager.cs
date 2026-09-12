using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        print("Нажали на объект: " + eventData.pointerCurrentRaycast.gameObject.name);
    }
}
