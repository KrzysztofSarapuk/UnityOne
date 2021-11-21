using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour, ISelectableItem
{
    public void OnHoverStart()
    {
        transform.localScale = Vector3.one * 1.5f;
    }

    public void OnHoverEnd()
    {
        transform.localScale = Vector3.one;
    }
}


