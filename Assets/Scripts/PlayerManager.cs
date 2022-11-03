using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public void PickupItem(GameObject obj, Color color)
    {
        this.GetComponent<SpriteRenderer>().color = color;
    }
}
