using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRoomCanvas : MonoBehaviour
{
    public RoomsCanvases _roomCanvases;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        _roomCanvases = canvases;
    }

    public void Show()
    {
        gameObject.SetActive(true); 
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
