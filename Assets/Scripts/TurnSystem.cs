using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    bool playerTurn;
    //Initiative formula: initiative = Random.Rangespeed/2, speed + 1)
    [SerializeField] GameObject[] allCharacters;
    List<GameObject> combinedCharacters = new List<GameObject>();

    private void Awake()
    {

        /*if (numberOfCharacters.Length == 0)
        {
            numberOfCharacters = GameObject.FindGameObjectsWithTag("Hero");
        }*/
        List<GameObject> combinedCharacters = new List<GameObject>();

        // Find all GameObjects tagged "Hero" and add them to the list
        GameObject[] heroes = GameObject.FindGameObjectsWithTag("Hero");
        if (heroes.Length > 0)
        {
            combinedCharacters.AddRange(heroes);
        }

        // Find all GameObjects tagged "Enemy" and add them to the list
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length > 0)
        {
            combinedCharacters.AddRange(enemies);
        }
        allCharacters = combinedCharacters.ToArray();
    }

    private void Start()
    {
        if (allCharacters.Length == 0)
            Debug.Log("No GameObjects are tagged with 'Enemy'");
        else
            Debug.Log("Number of GameObjects is: " + allCharacters.Length);
        Debug.Log("First GameObject is: " + allCharacters[0]);
    }
}
