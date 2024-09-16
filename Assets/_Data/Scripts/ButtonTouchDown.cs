using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTouchDown : TungMonoBehaviour, IPointerDownHandler
{
    [SerializeField] protected PlayerController playerController;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadPlayerController();
    }
    protected virtual void LoadPlayerController()
    {
        playerController = Transform.FindAnyObjectByType<PlayerController>();
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        if(gameObject.name == "Button Jump")
        {
            playerController.PlayerJump();
        }
        if(gameObject.name == "Button Right")
        {
            playerController.PlayerMoveRight();
        }
        if(gameObject.name == "Button Left")
        {
            playerController.PlayerMoveLeft();
        }
    }
}
