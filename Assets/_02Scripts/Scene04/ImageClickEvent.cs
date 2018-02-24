using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class ImageClickEvent : MonoBehaviour, IPointerClickHandler
{
    public GameObject imageTarget;

    public void OnPointerClick(PointerEventData eventData)
    {
        imageTarget.SetActive(!imageTarget.activeInHierarchy);
    }
}
