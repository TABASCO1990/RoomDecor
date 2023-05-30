using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ItemData", menuName = "ItemData", order = 51)]
public class ItemData : ScriptableObject
{
    [SerializeField] private Sprite _preview;
    [SerializeField] private string _lable;
    [SerializeField] private GameObject _prefab;

    public Sprite Preview => _preview;
    public string Lable => _lable;
    public GameObject Prefab => _prefab;
}
