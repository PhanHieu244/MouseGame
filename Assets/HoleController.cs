using System;
using System.Linq;
using ChuongCustom;
using UnityEngine;
using Random = UnityEngine.Random;

public class HoleController : Singleton<HoleController>
{
    [SerializeField] private Hole[] holes;
    [SerializeField] private Animal[] animals;

    private void OnEnable()
    {
        var sortHoles = holes.ToList();
        sortHoles.Sort((hole1, hole2) => hole1.transform.position.y.CompareTo(hole2.transform.position.y));
        var order = 2;
        foreach (var sortHole in sortHoles)
        {
            sortHole.PreSetup(order);
            order++;
        }
    }

    public void Spawn()
    {
        var hole = GetRandomHole();
        if (hole.IsOccupied()) return;
        var animalPrefab = GetRandomAnimal();
        var animal = Instantiate(animalPrefab, hole.spawnPos);
        hole.SetupAnimal(animal);
    }

    private Hole GetRandomHole()
    {
        return holes[Random.Range(0, holes.Length)];
    }

    private Animal GetRandomAnimal()
    {
        return animals[Random.Range(0, animals.Length)];
    }
}