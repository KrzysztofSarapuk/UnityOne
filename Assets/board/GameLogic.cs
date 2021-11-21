using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public TilePicker picker;
    public enum SelectionMethod { none, Tile, Pawn }

    SelectionMethod currentSelectionMethod;
    ISelectableItem selectedTile, selectedPawn;

    private void Awake()
    {
        currentSelectionMethod = SelectionMethod.none;
    }

    void EnablePawnSelection()
    {
        currentSelectionMethod = SelectionMethod.Pawn;
        picker.Enable(LayerMask.GetMask("PawnLayer"));
    }
    void EnableTileSelection()
    {
        currentSelectionMethod = SelectionMethod.Tile;
        picker.Enable(LayerMask.GetMask("TileLayer"));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentSelectionMethod == SelectionMethod.Tile)
            {
                EnablePawnSelection();
            }
            else
            {
                EnableTileSelection();
            }

        }
    }
}

