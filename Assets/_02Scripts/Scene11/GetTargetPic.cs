using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetTargetPic : MonoBehaviour
{
    public RenderTexture rt;
    public RawImage screenShot;

    public void ForGetPicBt()
    {
        if (rt == null) return;

        int width = rt.width;
        int height = rt.height;
        Texture2D tex2d = new Texture2D(width, height, TextureFormat.ARGB32, false);
        RenderTexture.active = rt;
        tex2d.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        tex2d.Apply();
        screenShot.texture = tex2d;
    }
}
