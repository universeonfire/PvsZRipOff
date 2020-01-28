using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreGameArea : MonoBehaviour
{

    Defender defender;

    private void OnMouseDown()
    {
        CheckAreaClicked();
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private void AttempToPlaceDefender(Vector2 gridPos)
    {
        //reducing core game area z position in game canvas to prevent collision before we create defender 
        //because we shouldn't create defender on top of another one (defender per tile rule)
        var starDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();
        if (starDisplay.SpendStars(defenderCost))
        {
            SpawnDefender(gridPos);
        }
    }

    private void CheckAreaClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        //for snap the defender to 1by1 grids we have to round mouse positions to integer values 
        worldPos = new Vector2(Mathf.RoundToInt(worldPos.x), Mathf.RoundToInt(worldPos.y));
        AttempToPlaceDefender(worldPos);
    }

    private void SpawnDefender(Vector2 wP)
    {
        
        Defender newDefender = Instantiate(defender, wP, Quaternion.identity);

    }
}
