using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class DynamicInventoryDisplay : InventoryDisplay
{
    [SerializeField] protected InventorySlot_UI slotPrefab;

    protected override void Start()
    {
        base.Start();
    }

    public void RefreshDynamicInventory(InventorySystem invToDiplay)
    {
        ClearSlots();
        inventorySystem = invToDiplay;
        if (inventorySystem != null) inventorySystem.OnInventorySlotChanged += UpdateSlot;
        AssignSlot(invToDiplay);
    }

    public override void AssignSlot(InventorySystem invToDislpay)
    {
        slotDictionary = new Dictionary<InventorySlot_UI, InventorySlot>();

        if (invToDislpay == null) return;

        for (int i = 0; i < invToDislpay.InventorySize; i++)
        {
            var uiSlot = Instantiate(slotPrefab, transform);
            slotDictionary.Add(uiSlot, invToDislpay.InventorySlots[i]);
            uiSlot.Init(invToDislpay.InventorySlots[i]);
            uiSlot.UpdateUISlot();
        }
    }

    private void ClearSlots()
    {
        foreach (var item in transform.Cast<Transform>())
        {
            Destroy(item.gameObject);
        }

        if (slotDictionary != null) slotDictionary.Clear();
    }

    private void OnDisable()
    {
        if (inventorySystem != null) inventorySystem.OnInventorySlotChanged -= UpdateSlot;
    }
}
