using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buddy : MonoBehaviour,IDamagable,IHealable
{
    // キャラクターのHPを代入する変数
    public int hp = 100;
    // 残りHPを表示するテキスト
    [SerializeField] Text hpText;

    /// <summary>
    /// HPの値をHpへ表示するメソッド
    /// </summary>
    void DisplayHpValue()
    {
        hpText.text = "HP: " + hp.ToString();
    }

    //追加したところ
    public void AddDamage()
    {
        int damage = Random.Range(0, 40);
        hp -= damage;
        DisplayHpValue();
    }

    public void AddHp(int addHp)
    {
        hp += addHp;
        DisplayHpValue();
    }
}
