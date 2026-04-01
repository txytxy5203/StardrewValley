using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class EventHandler 
{
    public static event Action<InventoryLocation, List<InventoryItem>> UpdateInventoryUI;

    public static void CallUpdateInventoryUI(InventoryLocation inventoryLocation, List<InventoryItem> list)
    {
        UpdateInventoryUI?.Invoke(inventoryLocation, list);
    }
}
