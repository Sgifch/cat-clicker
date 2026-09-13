using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CatClick : MonoBehaviour, IPointerClickHandler
{
    public GameObject hit;
    public bool onClick;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        hit.GetComponent<Collider2D>().enabled = true;
        hit.GetComponent<Collider2D>().enabled = false;
    }

}
