﻿using UnityEngine;
using UnityEngine.UI;

public class TimeLabelBehaviour : MonoBehaviour, ITickListener {

	void Awake ()
	{
		Pools.pool.CreateEntity().AddTickListener(this);
	}

	public void TickChanged ()
	{
		var tick = Pools.pool.tick.currentTick;
		var sec = (tick / 60) % 60;
		var min = (tick / 3600);
		var secText = sec > 9 ? "" + sec : "0" + sec;
		var minText = min > 9 ? "" + min : "0" + min;
		
		GetComponent<Text>().text = minText + ":" + secText;
	}

}
