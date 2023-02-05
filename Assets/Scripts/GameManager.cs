using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 敵関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Enemys;
    // プレイヤー関係のゲームオブジェクトをアタッチする配列
    public GameObject[] Players;

    /// <summary>
    /// Player側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void PlayerAttack()
    {
        var damagetarget = Enemys[Random.Range(0,2)].GetComponent<IDamagable>();
        if(damagetarget != null)
        {
            damagetarget.AddDamage();
        }
    }

    /// <summary>
    /// Enemy側の攻撃を行う際に呼び出すメソッド
    /// </summary>
    public void EnemyAttack()
    {
        var damageplayer = Players[Random.Range(0, 2)].GetComponent<IDamagable>();
        if(damageplayer != null)
        {
            damageplayer.AddDamage();
        }
    }

    /// <summary>
    /// プレイヤーを回復させる際に呼び出すメソッド
    /// </summary>
    public void PlayerHeal()
    {
        for(int i = 0; i < 2; i++)
        {
            var healtarget = Players[i].GetComponent<IHealable>();
            if(healtarget != null)
            {
                healtarget.AddHp(10);
            }
        }
    }
}
