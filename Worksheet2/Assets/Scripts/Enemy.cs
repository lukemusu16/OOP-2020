using UnityEngine;
using System.Collections;
public class Enemy
{
    public int hitpoints, damage;
    string name;

    private GameObject enemy;
    public Enemy(int hp, int dmg, string ID, GameObject enemyPrefab)
    { //this constructor assigns hitpoints, damage, and name to
      //the values passed into the constructor
        hitpoints = hp;
        damage = dmg;
        name = ID;
        enemy = GameObject.Instantiate(enemyPrefab, new Vector3(Random.Range(-5f, +5f), 0f, 0f), Quaternion.identity);
        enemy.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
    public void TakeDamage()
    {
        hitpoints--; //reduce HP by 1
        Debug.Log(name + "'s HP: " + hitpoints); //print out new hp
    }
    public void Die()
    {
        Debug.Log(name + " Has Died"); //print to the console
        GameObject.Destroy(enemy);
    }
}
