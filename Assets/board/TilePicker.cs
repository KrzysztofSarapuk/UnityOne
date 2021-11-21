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
            //to dzieje siê tylko wtedy gdy trafimi w jakiœ obiekt
            TileController tile = hitInfo.collider.GetComponent<TileController>();
            if (tile == null)
                return;

            //tu bêdziemy tylko wtedy, gdy najechaliœmy mysz¹ na kafelek
            if (tile == hoveredTile)  //je¿eli to ten sam obiekt co klatkê temu
                return;

            if (hoveredTile != null) //je¿eli by³ poprzedni obiekt
                hoveredTile.OnHoverEnd(); //zakoñczyæ wybieranie poprzedniego kafelka

            tile.OnHoverStart(); // wybieraanie nowego kafelka

            hoveredTile = tile; // poprzedni kafelek staje siê nowym kafelkiem
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





