using UnityEngine;
/// <summary>
/// 定義怪物物件
/// </summary>

public class Enemy : MonoBehaviour
{
    /// <summary>
    /// HP
    /// </summary>
    [Header("血量"),Tooltip("怪物的血量"),Range(50,500)]
    public int hp;
    /// <summary>
    /// MP
    /// </summary>
    [Header("魔力"), Tooltip("怪物的魔力"), Range(10, 100)]
    public int mp = 100;
    /// <summary>
    /// 能力值
    /// </summary>
    [Header("能力值"), Range(1, 50.5f)]
    public float speed = 10.5f;
    [Range(20,200)]
    public int atk = 50;
    [Range(0, 100)]
    public int def;
    /// <summary>
    /// 裝備
    /// </summary>
    [Header("裝備")]
    public string weapon;
    public string equipment = "皮衣";
    /// <summary>
    /// 其他資料
    /// </summary>
    [Header("其他資料"), Tooltip("怪物是否帶有鑰匙")]
    public bool key;
    [Tooltip("怪物是否帶有寶物")]
    public bool treasure;
}
