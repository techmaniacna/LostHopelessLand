using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    [Header("Match Settings")]
    public int playersAlive = 121;
    public float matchTimer = 1200f;
    
    [Header("Helicopter Spawns")]
    public Transform[] helipads = new Transform[8];
    public GameObject helicopterPrefab;

    [Header("Auto-Loot System")]
    public List<string> activeLootPool = new List<string> { "Silencer", "Assault Rifle", "Level 3 Vest", "Medkit" };

    void Start()
    {
        Debug.Log("LostHopelessLand Match Initialized. 121 Players Dropping.");
    }
}
