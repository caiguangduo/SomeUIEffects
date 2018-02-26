using UnityEngine;
using System.Collections;

public class CubeRotate : MonoBehaviour
{
    private void Update()
    {
        transform.RotateAround(Vector3.up, -2.0f * Time.deltaTime);
    }
}
