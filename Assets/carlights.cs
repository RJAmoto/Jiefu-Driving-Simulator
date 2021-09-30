﻿using UnityEngine;
using System.Collections;

public class carlights : MonoBehaviour {

	public Renderer brakelights;
	public Material brakelightON;
	public Material brakelightOFF;

	public Renderer headlights;
	public Material headlightsON;
	public Material headlightsOFF;

	public Renderer turnSignalLEFT;
	public Renderer turnSignalRIGHT;
	public Material turnsignalON;
	public Material turnsignalOFF;

	public Light spotlightLEFT;
	public Light spotlightRIGHT;

	private bool rightSignalON = false;
	private bool leftSignalON = false;

	public float Brake;
	public bool HeadLight;
	public bool SignalRight;
	public bool SignalLeft;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		//braking//
		if(Brake==1)
		{
			brakelights.material = brakelightON;
		}
		//not braking//
		else
		{
			brakelights.material = brakelightOFF;
		}

		//headlights on/off//
		if(HeadLight)
		{
			headlights.material = headlightsON;
			spotlightLEFT.intensity = 8f;
			spotlightRIGHT.intensity = 8f;
		}
		else
		{
			headlights.material = headlightsOFF;
			spotlightLEFT.intensity = 0f;
			spotlightRIGHT.intensity = 0f;
		}

		//steer right//
		if(SignalRight)
		{
			turnSignalRIGHT.material = turnsignalON;
			turnSignalLEFT.material = turnsignalOFF;
			rightSignalON = true;
			leftSignalON = false;
		}
		else if(SignalLeft)
		{
			turnSignalRIGHT.material = turnsignalOFF;
			turnSignalLEFT.material = turnsignalON;
			rightSignalON = false;
			leftSignalON = true;
		}
		else
		{
			turnSignalRIGHT.material = turnsignalOFF;
			turnSignalLEFT.material = turnsignalOFF;
			rightSignalON = false;
			leftSignalON = false;
		}

		if(leftSignalON)
		{
			float floor = 0f;
			float ceiling = 1f;
			float emission = floor + Mathf.PingPong(Time.time*2f, ceiling - floor);
			turnSignalLEFT.material.SetColor("_EmissionColor",new Color(1f,1f,1f)*emission);
		}
		if(rightSignalON)
		{
			float floor = 0f;
			float ceiling = 1f;
			float emission = floor + Mathf.PingPong(Time.time*2f, ceiling - floor);
			turnSignalRIGHT.material.SetColor("_EmissionColor",new Color(1f,1f,1f)*emission);
		}
	}

	public void setBrake(float BrakeLight)
    {
		this.Brake = BrakeLight;
	}

	public void setHeadLight(bool isOn)
    {
		HeadLight = isOn;
	}
	public void turnLeft(bool isOn)
	{
		SignalLeft = isOn;
	}
	public void turnRight(bool isOn)
	{
		SignalRight = isOn;
	}




}









