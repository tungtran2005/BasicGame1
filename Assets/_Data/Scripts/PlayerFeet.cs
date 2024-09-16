using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFeet : TungMonoBehaviour
{
    public PlayerController playerController;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        playerController = GetComponentInParent<PlayerController>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        playerController.OnGound = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        playerController.OnGound = false;
    }
}
