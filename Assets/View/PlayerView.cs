using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerView : MonoBehaviour
{
    public Text hpLabel;//血量标签
    public Button addButton;//模拟按钮触发修改血量

    public event EventHandler OnClick;
    private void Start()
    {
        addButton.onClick.AddListener(BtnClick);
    }

    void BtnClick() {
        if (OnClick !=null)
        {
            OnClick(this,new EventArgs());
        }
    }

    public string Text {
        get { return hpLabel.text; }
        set {
            hpLabel.text = value;
        }
    }
 
}
