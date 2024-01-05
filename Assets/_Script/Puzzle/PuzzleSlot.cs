using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleSlot : MonoBehaviour, IDropHandler
{
    public PuzzleGamemanager gamemanager;
    public int id;
    public bool dropped = false;
    public bool forceMatch = false;

    public circleGameManager _circlegamemanager;
    public void OnDrop(PointerEventData eventData)
    {
        if(dropped)
        {
            return;
        }
        print("dropped");
        if (eventData.pointerDrag != null)
        {
            
            if(eventData.pointerDrag.GetComponent<DragAndDropPuzzle>().id == id) 
            {
                if (_circlegamemanager != null) _circlegamemanager.AddScore(1);
                    if (gamemanager) gamemanager.ChabgeState(id, 1);

                
            }
            else
            {
                if(forceMatch)
                {
                    return;
                }
                
                if (gamemanager) gamemanager.ChabgeState(id, 0);
            }
            eventData.pointerDrag.GetComponent<DragAndDropPuzzle>().placed = true;
            dropped = true;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
