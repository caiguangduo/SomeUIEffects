using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour
{
    public GameObject cube;
    public GameObject image;

    private void Start()
    {
        EventTriggerListener.Get(cube).onClick += OnCubeClick;
        EventTriggerListener.Get(image).onClick += OnImageClick;
    }

    private void OnCubeClick(GameObject go)
    {
        if (go == cube)
            Debug.Log("Cube");
    }
    private void OnImageClick(GameObject go)
    {
        if (go == image)
            Debug.Log("Image");
    }
}
