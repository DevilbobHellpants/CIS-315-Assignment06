﻿/*
 * (Noah Trillizio)
 * (Assignment 6)
 * (Hndles the weapon stats)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    public void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("Enemy eats Weapon");
    }

    public void Recharge()
    {
        Debug.Log("Recharging Weapon!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Recharging Weapon!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
