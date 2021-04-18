using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHP;
    public int maxMP;
    public int currentHP;
    public int currentMP;

    GUIManager GUIManager;

    // Start is called before the first frame update
    void Start()
    {
        this.GUIManager = GetComponent<GUIManager>();
    }

    //Testeo de si incrementa la vida
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            decreaseHP(10);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            increaseHP(10);
        }
    }

    public void increaseHP(int increase)
    {
        if((this.currentHP + increase) < this.maxHP)
        {
            this.currentHP += increase;
        }
        else
        {
            this.currentHP = this.maxHP;
        }

        this.GUIManager.updateHPbar(this.currentHP, this.maxHP);
    }
    public void decreaseHP(int decrease)
    {
        if ((this.currentHP - decrease) > 0)
        {
            this.currentHP -= decrease;
        }
        else
        {
            this.currentHP = 0;
        }

        this.GUIManager.updateHPbar(this.currentHP, this.maxHP);
    }

    public void increaseMP(int increase)
    {
        if ((this.currentMP + increase) < this.maxMP)
        {
            this.currentMP += increase;
        }
        else
        {
            this.currentMP = this.maxMP;
        }

        this.GUIManager.updateMPbar(this.currentMP, this.maxMP);
    }
    public void decreaseMP(int decrease)
    {
        if ((this.currentMP - decrease) > 0)
        {
            this.currentMP -= decrease;
        }
        else
        {
            this.currentMP = 0;
        }

        this.GUIManager.updateMPbar(this.currentMP, this.maxMP);
    }
}
