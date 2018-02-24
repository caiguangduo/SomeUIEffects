using UnityEngine;
using System.Collections;

/// <summary>
/// 通过鼠标的坐标在屏幕上移动来更新UI的显示位置
/// </summary>
public class UIFollowMouse : MonoBehaviour
{
    Canvas canvas;
    RectTransform rectTransform;
    void Start()
    {
        rectTransform = transform as RectTransform;
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    void Update()
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos))
        {
            rectTransform.anchoredPosition = pos;
        }
    }
}