using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller 
{
    Player playerModel;
    PlayerView currentView;

    public Controller() {
        //1:初始化Model数据
        playerModel = new Player();
        //给Model事件添加函数，此函数功能是修改视图显示
        playerModel.HpChange += UpdateLabel;

        //2:初始化View
        currentView = GameObject.Find("PlayerView").GetComponent<PlayerView>();
        //此事件在点击按钮的时候触发
        currentView.OnClick += (s, e) =>
        {
            Debug.Log("Click");
            playerModel.HP = 50;
        };
    }

    public void UpdateLabel(object sender, EventArgs args) {
        currentView.Text = playerModel.HP.ToString();
    }
}
