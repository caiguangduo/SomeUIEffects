using UnityEngine;
using System.Collections;

/// <summary>
/// 通过设置sortingOrder使UI和粒子之间出现相互遮挡的效果
/// </summary>
public class UIDepth : MonoBehaviour
{
    public int order;
    public bool isUI = true;

    private void Start()
    {
        if (isUI)
        {
            Canvas canvas = GetComponent<Canvas>();
            if (canvas == null)
            {
                canvas = gameObject.AddComponent<Canvas>();
            }
            canvas.overrideSorting = true;
            canvas.sortingOrder = order;
        }
        else
        {
            Renderer[] renders = GetComponentsInChildren<Renderer>();
            foreach(Renderer render in renders)
            {
                render.sortingOrder = order;
            }
        }
    }
}
