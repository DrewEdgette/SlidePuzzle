using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    public GameObject mainCanvas;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Exit")   // if the target cube hits the exit square, set solved to true so the cube can slide out of the puzzle area.
        {
            mainCanvas.SetActive(true);
        }
    }
}
