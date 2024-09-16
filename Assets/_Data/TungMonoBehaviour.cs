using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TungMonoBehaviour : MonoBehaviour
{
    protected virtual void Reset()
    {
        this.LoadComponent();
        this.ResetValue();
    }
    protected virtual void Start()
    {
        //For override
    }
    protected virtual void Awake()
    {
        this.LoadComponent();
    }
    protected virtual void LoadComponent()
    {
        //For override
    }
    protected virtual void ResetValue()
    {
        //For override
    }
    protected virtual void OnEnable()
    {
        //For override
    }
}
