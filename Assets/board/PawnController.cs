using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnController : MonoBehaviour, ISelectableItem
{

    public Material m;
    private void Awake()
    {

    }

    public void OnHoverEnd()
    {
        m.SetColor("_Color", Color.gray);

    }

    public void OnHoverStart()
    {
        m.SetColor("_Color", Color.green);
    }
}

