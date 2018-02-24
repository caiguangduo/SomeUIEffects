using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class Test0401 : MonoBehaviour, IPointerClickHandler
{
    public GameObject imageTarget;

    public void OnPointerClick(PointerEventData eventData)
    {
        imageTarget.SetActive(!imageTarget.activeInHierarchy);
    }
}
