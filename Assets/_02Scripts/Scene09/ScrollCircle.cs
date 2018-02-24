using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollCircle : ScrollRect
{
    protected float radius = 0.0f;

    protected override void Start()
    {
        base.Start();
        radius = (transform as RectTransform).sizeDelta.x * 0.5f;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        var contentPosition = this.content.anchoredPosition;
        if (contentPosition.magnitude > radius)
        {
            contentPosition = contentPosition.normalized * radius;
            SetContentAnchoredPosition(contentPosition);
        }
    }
}
