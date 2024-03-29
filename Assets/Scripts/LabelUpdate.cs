﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LabelUpdate : MonoBehaviour
{
    public Text bigLabel;
    public Text playerAP;
    public Text playerHP;
    public Text enemyAP;
    public Text enemy1HP;
    public Text enemy2HP;
    public Text enemy3HP;

    public EnemyUnit enemy1;
    public EnemyUnit enemy2;
    public EnemyUnit enemy3;

    void Update()
    {
        bigLabel.text = TurnController.bigLabelStatus;
        playerAP.text = PlayerController.playerAP.ToString();
        playerHP.text = (PlayerController.playerHealth).ToString();
        enemyAP.text = EnemyController.enemyAP.ToString();
        if (enemy1.isDead) {
            enemy1HP.text = "";
        } else {
            enemy1HP.text = (enemy1.health).ToString();
        }
        if (enemy2.isDead) {
            enemy2HP.text = "";
        } else {
            enemy2HP.text = (enemy2.health).ToString();
        }
        if (enemy3.isDead) {
            enemy3HP.text = "";
        } else {
            enemy3HP.text = (enemy3.health).ToString();
        }
    }
}
