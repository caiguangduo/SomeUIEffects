using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ImagePlus : Image
{
    public bool isCanRayCast = false;

    public override bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
    {
        return isCanRayCast;
    }
}
