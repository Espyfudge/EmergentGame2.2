using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Mono.Data.Sqlite;
using System;
using System.Data;

public class dbManager : MonoBehaviour {
    private string constr;
    private IDbConnection dbc;
    private IDbCommand dbcm;
    private IDataReader dbr;
    public int currentID;

    public Text questionText;
    public Text truthText;
    public Text lieText;
    public Text tooSuspicious;
    public Text tooStressed;
    private float suspicionPerc1;
    private float suspicionPerc2;
    private float stressPerc;
    private int truthNext;
    private int lieNext;
    private float acFill;
    private float stressFill;
    public Image stressMeter;
    public Image suspicionMeter;


    // Use this for initialization
    void Start () {
        currentID = 1;
        getScene();
        dbr.Close();
        dbc.Close();
        acFill = 0;
        stressFill = 0;
}
	
    public void truthQ()
    {
        currentID = truthNext;
        if (acFill >= 0.2)
        {
            acFill -= suspicionPerc1 / 10;
        }
        if (stressFill >= 0.1)
        {
            stressFill -= 0.1f;
        }
        getScene();
    }
    public void lieQ()
    {   if (stressFill < 0.7)
        {
            currentID = lieNext;
            acFill += suspicionPerc2 / 10;
            stressFill += 0.2f;
            getScene();
        }
        else
        {
            tooStressed.text = "No more lies!";
        }
    }

    // Update is called once per frame
    void Update () {
        suspicionMeter.fillAmount = acFill;
        stressMeter.fillAmount = stressFill;

        if (acFill >= 1)
        {
            tooSuspicious.text = "Hmm... that is too suspicious, you got caught boiii!";
        }
        
    }

    void getScene()
    {
        constr = "URI=file:" + Application.dataPath + "/Database/disloyalDB.db";
        dbc = new SqliteConnection(constr);
        dbc.Open();
        dbcm = dbc.CreateCommand();
        dbcm.CommandText = "SELECT * FROM Scenes WHERE questionID = " + currentID;
        dbr = dbcm.ExecuteReader();

        while (dbr.Read())
        {
            string text = dbr.GetString(1);
            string ans1 = dbr.GetString(2);
            string ans2 = dbr.GetString(3);
            string ans3 = dbr.GetString(4);
            string ans4 = dbr.GetString(5);
            int ans1to = dbr.GetInt16(6);
            int ans2to = dbr.GetInt16(7);
            int ans3to = dbr.GetInt16(8);
            int ans4to = dbr.GetInt16(9);
            int ans1p = dbr.GetInt16(10);
            int ans2p = dbr.GetInt16(11);
            int ans3p = dbr.GetInt16(12);
            int ans4p = dbr.GetInt16(13);
            questionText.text = text;
            truthNext = ans1to;
            truthText.text = ans1;
            lieText.text = ans2;
            lieNext = ans2to;
            suspicionPerc1 = ans1p/10;
            suspicionPerc2 = ans2p/10;

            Debug.Log("text =" + text + " ans1 = " + ans1 + " ans2 = " + ans2 + " ans3 = " + ans3 + " ans4 = " + ans4 + " ans1to = " + ans1to + " ans2to = " + ans2to + " ans3to = " + ans3to + " ans4to = " + ans4to + " ans1p = " + ans1p + " ans2p = " + ans2p + " ans3p = " + ans3p + " ans4p = " + ans4p);
        }
        dbc.Close();
    }
}
