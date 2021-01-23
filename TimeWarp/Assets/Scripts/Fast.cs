using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fast : MonoBehaviour
{
    public GameManager gameManager;

    private void OnMouseDown()
    {
        gameManager.isFast = true;
    }
}
