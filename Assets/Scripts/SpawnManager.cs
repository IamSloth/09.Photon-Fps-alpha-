using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnManager : MonoBehaviour
{
   public static SpawnManager Instance;

   private SpawnPoint[] spawnPoints;

   private void Awake()
   {
      Instance = this;
      spawnPoints = GetComponentsInChildren<SpawnPoint>();
   }

   public Transform GetSpawnPoint()
   {
      return spawnPoints[UnityEngine.Random.Range(0, spawnPoints.Length)].transform;
   }
}
