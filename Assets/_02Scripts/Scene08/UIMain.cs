using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIMain : MonoBehaviour
{
    public Button bt;
    public Image image;

    private void Start()
    {
        EventTriggerListener.Get(bt.gameObject).onClick += OnBtClick;
        EventTriggerListener.Get(image.gameObject).onClick += OnImageClick;
    }

    private void OnBtClick(GameObject go)
    {
        if (go == bt.gameObject)
            Debug.Log("Bt Clicked");
    }

    private void OnImageClick(GameObject go)
    {
        if (go == image.gameObject)
            Debug.Log("Image clicked");
    }

    private void OnGUI()
    {
        if(GUILayout.Button("Auto Button"))
        {
            ExecuteEvents.Execute<IPointerClickHandler>(bt.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
            ExecuteEvents.Execute<ISubmitHandler>(bt.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }
        if(GUILayout.Button("Auto Image"))
        {
            ExecuteEvents.Execute<IPointerClickHandler>(image.gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
        }
    }
}
