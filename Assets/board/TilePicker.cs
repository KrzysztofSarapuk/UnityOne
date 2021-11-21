using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePicker : MonoBehaviour
{
    TileController hoveredTile;
    public LayerMask mask;
    private void Update()
    {
        Ray promien = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Physics.Raycast(promien, out hitInfo, 50f, mask.value))
        {
            //to dzieje si� tylko wtedy gdy trafimi w jaki� obiekt
            TileController tile = hitInfo.collider.GetComponent<TileController>();
            if (tile == null)
                return;

            //tu b�dziemy tylko wtedy, gdy najechali�my mysz� na kafelek
            if (tile == hoveredTile)  //je�eli to ten sam obiekt co klatk� temu
                return;

            if (hoveredTile != null) //je�eli by� poprzedni obiekt
                hoveredTile.OnHoverEnd(); //zako�czy� wybieranie poprzedniego kafelka

            tile.OnHoverStart(); // wybieraanie nowego kafelka

            hoveredTile = tile; // poprzedni kafelek staje si� nowym kafelkiem
        }
        else
        {
            if (hoveredTile != null)
            {
                hoveredTile.OnHoverEnd();
                hoveredTile = null;
            }
        }

    }

}





