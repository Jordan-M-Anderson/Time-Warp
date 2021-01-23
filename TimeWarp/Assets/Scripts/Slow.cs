using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour
{
    public GameManager gameManager;

    private void OnMouseDown()
    {
        gameManager.isFast = false;
    }
}

