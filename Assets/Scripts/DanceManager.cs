﻿using UnityEngine;
using Jam;

public class DanceManager : MonoBehaviour
{

    private DancePointCollisionDetector detector;
    public GameObject dancePoint;
    public static DanceManager instance = null;
    private GameObject currentDancePoint;
    private float xPosition = 1;
    private float yPosition = 2;
    private float zPosition = 0.5f;
    public delegate void DanceDelegate();
    public event DanceDelegate danceEvent;
    public int rattleCountToCompleteDance = 3;
    private int rattleCount = 0;
    public void Awake()
    {
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a DanceManager.
            Destroy(gameObject);
    }



    // Use this for initialization
    void Start()
    {
    }

    public void startDance()
    {
        destroyDancePoint();
        createNewDancePoint(new Vector3(xPosition, yPosition, zPosition));
    }

    public void stopDance()
    {
        destroyDancePoint();
        rattleCount = 0;
    }

    void RattleSuccessful()
    {
        rattleCount++;
        if (danceEvent != null && rattleCount >= rattleCountToCompleteDance)
        {
            danceEvent();
            rattleCount = 0;
        }
        xPosition *= -1;
        destroyDancePoint();
        createNewDancePoint(new Vector3(xPosition, yPosition, zPosition));
    }

    private void createNewDancePoint(Vector3 position)
    {
        currentDancePoint = Instantiate(dancePoint, position, transform.rotation) as GameObject;
        currentDancePoint.GetComponent<DancePointCollisionDetector>().RattleEvent += this.RattleSuccessful;
        if (xPosition == 1)
        {
            currentDancePoint.GetComponent<DancePointCollisionDetector>().type = DancePointCollisionDetector.Type.Right;
        } else
        {
            currentDancePoint.GetComponent<DancePointCollisionDetector>().type = DancePointCollisionDetector.Type.Left;
        }
    }

    private void destroyDancePoint()
    {
        if (currentDancePoint != null)
        {
            currentDancePoint.GetComponent<DancePointCollisionDetector>().RattleEvent -= this.RattleSuccessful;
            Destroy(currentDancePoint);
        }
    }
}
