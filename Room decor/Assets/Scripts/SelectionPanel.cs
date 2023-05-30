using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPanel : MonoBehaviour
{
    [SerializeField] private ItemData[] _itemDatas;
    [SerializeField] private Transform _objectPlacer;
    [SerializeField] private GameObject _itemTemplate;
    [SerializeField] private Transform _container;

    private void Start()
    {
        for (int i = 0; i < _itemDatas.Length; i++)
        {
            AddItems(_itemDatas[i]);
        }
    }

    private void AddItems(ItemData itemData)
    {
        Instantiate(_itemTemplate,_container).TryGetComponent(out ItemView itemView);
        itemView.Initialize(itemData);
        itemView.ItemSelected += OnItemSelected;
        itemView.ItemDisabled += OnItemDisable;
    }

    private void OnItemSelected(ItemData itemData)
    {

    }

    private void OnItemDisable(ItemView itemView)
    {
        itemView.ItemSelected -= OnItemSelected;
        itemView.ItemDisabled -= OnItemDisable;
    }
}
