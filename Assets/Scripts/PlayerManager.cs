using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public void PickupItem(GameObject obj)
    {
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
