using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 1000;
    private Text starText;

    void Start()
    {
        starText = GetComponent<Text>();
    }

    void Update()
    {
        starText.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
    }

    public bool SpendStars(int amount)
    {
        if (stars >= amount)
        {
            stars -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
}
