using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MFarm.Inventory
{
    public class InventoryUI : MonoBehaviour
    {
        [SerializeField] private SlotUI[] playerSlots;  //玩家的每一个背包格子

        private void Start()
        {
            for (int i = 0; i < playerSlots.Length; i++)
            {
                playerSlots[i].slotIndex = i;
            }
        }
    }
}
