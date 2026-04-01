using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerItemFader : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D others)
    {
        ItemFader[] itemFader = others.GetComponentsInChildren<ItemFader>();
        if(itemFader != null)
        {
            foreach (var fader in itemFader)
            {
                fader.FadeOut();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D others)
    {
        ItemFader[] itemFader = others.GetComponentsInChildren<ItemFader>();
        if (itemFader != null)
        {
            foreach (var fader in itemFader)
            {
                fader.FadeIn();
            }
        }
    }
}
