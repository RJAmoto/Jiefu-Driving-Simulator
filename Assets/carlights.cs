using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class carlights : MonoBehaviour {


	public Toggle signalR;
	public Toggle signalL;


	public GameObject hazzardB;
	public GameObject sLeftB;
	public GameObject sRightB;

	public Sprite hazardBON;
	public Sprite SLeftBON;
	public Sprite SRightBON;

	public Sprite hazardBOFF;
	public Sprite SLeftBOFF;
	public Sprite SRightBOFF;

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
	private bool hazardSignalON = false;

	public float Brake;
	public bool HeadLight;
	public bool SignalRight;
	public bool SignalLeft;
	public bool hazardL;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 	{
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
		else if (hazardL)
        {
			turnSignalRIGHT.material = turnsignalON;
			turnSignalLEFT.material = turnsignalON;
			hazardSignalON = true;
		}
		else
		{
			turnSignalRIGHT.material = turnsignalOFF;
			turnSignalLEFT.material = turnsignalOFF;
			hazzardB.GetComponent<Image>().sprite = hazardBOFF;
			sLeftB.GetComponent<Image>().sprite = SLeftBOFF;
			sRightB.GetComponent<Image>().sprite = SRightBOFF;


			rightSignalON = false;
			leftSignalON = false;
		}

		if (leftSignalON)
		{
			signalR.isOn = false;
			float floor = 0f;
			float ceiling = 1f;
			float emission = floor + Mathf.PingPong(Time.time * 2f, ceiling - floor);
			turnSignalLEFT.material.SetColor("_EmissionColor", new Color(1f, 1f, 1f) * emission);

			sRightB.GetComponent<Image>().sprite = SRightBOFF;

			if (emission == 0)
			{

				sLeftB.GetComponent<Image>().sprite = SLeftBOFF;

			}

			else if (emission == 1)
			{
				sLeftB.GetComponent<Image>().sprite = SLeftBON;
			}
		}
		if(rightSignalON)
		{
			signalL.isOn = false;

			SignalLeft = false;
			float floor = 0f;
			float ceiling = 1f;
			float emission = floor + Mathf.PingPong(Time.time*2f, ceiling - floor);
			turnSignalRIGHT.material.SetColor("_EmissionColor",new Color(1f,1f,1f)*emission);

			sLeftB.GetComponent<Image>().sprite = SLeftBOFF;

			if (emission == 0)
			{
				sRightB.GetComponent<Image>().sprite = SRightBOFF;
			}

			else if (emission == 1)
			{
				sRightB.GetComponent<Image>().sprite = SRightBON;
			}
		}
        if (hazardSignalON)
        {
			float floor = 0f;
			float ceiling = 1f;
			float emission = floor + Mathf.PingPong(Time.time * 2f, ceiling - floor);
			turnSignalLEFT.material.SetColor("_EmissionColor", new Color(1f, 1f, 1f) * emission);
			turnSignalRIGHT.material.SetColor("_EmissionColor", new Color(1f, 1f, 1f) * emission);

			if (emission == 0)
			{
				hazzardB.GetComponent<Image>().sprite = hazardBOFF;
			}

			else if (emission == 1)
			{
				hazzardB.GetComponent<Image>().sprite = hazardBON;
			}
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

	public void hazard(bool isOn)
    {
		hazardL = isOn;
    }



}









