using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAction : MonoBehaviour
{
    private GameObject enemy;
    private GameObject hero;

    [SerializeField]
    private GameObject basicPrefab;

    [SerializeField]
    private GameObject smitePrefab;

    [SerializeField]
    private Sprite faceIcon;

    private GameObject currenAttack;
    private GameObject basicAttack;
    private GameObject smiteAttack;

    public void SelectAttack(string btn)
    {
        GameObject victim = hero;
        if( tag == "Hero")
        {
            victim = enemy;
        }


        if(btn.CompareTo("basic") == 0)
        {

            hero = GameObject.FindGameObjectWithTag("Hero"); // Temporar
            /*basicAttack.GetComponent<AttackScript>().Attack(victim);*/
            hero.GetComponent<Animator>().Play("Attack1");

        } else if(btn.CompareTo("smite") == 0)
        {
            /*smiteAttack.GetComponent<AttackScript>().Attack(victim);*/
            hero = GameObject.FindGameObjectWithTag("Hero"); // Temporar
            hero.GetComponent<Animator>().Play("Attack2");
        }
        else
        {
            hero = GameObject.FindGameObjectWithTag("Hero"); // Temporar
            hero.GetComponent<Animator>().Play("Block");
            Debug.Log("Block");
        }
    }
}
