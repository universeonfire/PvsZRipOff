using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderMenu : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderMenu>();
        foreach(DefenderMenu button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(77, 77, 77, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<CoreGameArea>().SetSelectedDefender(defenderPrefab);
    }
}
