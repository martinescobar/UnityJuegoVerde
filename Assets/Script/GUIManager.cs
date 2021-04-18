using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    public Image hpBar;
    public Image mpBar;

    public Text hpText;
    public Text mpText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerStats playerStats = GetComponent<PlayerStats>();
        this.hpBar.rectTransform.localScale = new Vector3((float)playerStats.currentHP / playerStats.maxHP, 1, 1);
        this.mpBar.rectTransform.localScale = new Vector3((float)playerStats.currentMP / playerStats.maxMP, 1, 1);

        this.hpText.text = playerStats.currentHP + "/" + playerStats.maxHP;
        this.mpText.text = playerStats.currentMP + "/" + playerStats.maxMP;
    }

    public void updateHPbar(float currentHP, float maxHP)
    {
        this.hpBar.rectTransform.localScale = new Vector3(currentHP / maxHP, 1, 1);
        this.hpText.text = currentHP + "/" + maxHP;
    }
    public void updateMPbar(float currentMP, float maxMP)
    {
        this.mpBar.rectTransform.localScale = new Vector3(currentMP / maxMP, 1, 1);
        this.hpText.text = currentMP + "/" + maxMP;
    }
}
