﻿#if UNITY_EDITOR

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DebugUILine : MonoBehaviour
{
    static Vector3[] fourCorners = new Vector3[4];

    private void OnDrawGizmos()
    {
        foreach (MaskableGraphic g in GameObject.FindObjectsOfType<MaskableGraphic>())
        {
            Debug.Log(g.name);
            if (g.raycastTarget)
            {
                RectTransform rectTransform = g.transform as RectTransform;
                rectTransform.GetWorldCorners(fourCorners);
                Gizmos.color = Color.red;
                for (int i = 0; i < 4; i++)
                {
                    Gizmos.DrawLine(fourCorners[i], fourCorners[(i + 1) % 4]);
                }
            }
        }
    }
}
#endif
