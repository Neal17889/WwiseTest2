using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Sound : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IBeginDragHandler, IDragHandler
{
    public AK.Wwise.Event OnPointerDownSound;
    public AK.Wwise.Event OnPointerEnterSound;
    public AK.Wwise.Event OnBeginDragSound;
    public AK.Wwise.Event OnDragSound;

    public void OnPointerDown(PointerEventData eventData)
    {
        OnPointerDownSound.Post(this.gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        OnPointerEnterSound.Post(this.gameObject);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        OnBeginDragSound.Post(this.gameObject);
    }

    public void OnDrag(PointerEventData eventData)
    {
        OnDragSound.Post(this.gameObject);
    }
}
