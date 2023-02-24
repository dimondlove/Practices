using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private ShopKeeperDisplay _shopKeeperDisplay;

    private void Awake()
    {
        _shopKeeperDisplay.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        ShopKeeper.OnShopWindowRequest += DisplayShopWindow;
    }

    private void OnDisable()
    {
        ShopKeeper.OnShopWindowRequest -= DisplayShopWindow;
    }

    private void DisplayShopWindow(ShopSystem shopSystem, PlayerInventoryHolder playerInventory)
    {
        _shopKeeperDisplay.gameObject.SetActive(true);
    }
}
