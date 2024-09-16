using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : TungMonoBehaviour
{
    public PlayerMoving playerMoving;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerMoving = GetComponentInParent<PlayerMoving>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        playerMoving.OnGound = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerMoving.OnGound = false;
    }
}
