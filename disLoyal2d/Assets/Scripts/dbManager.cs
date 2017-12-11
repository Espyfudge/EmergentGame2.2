using UnityEngine;
using System.Collections;
using Mono.Data.Sqlite;
using System;
using System.Data;

public class dbManager : MonoBehaviour {
    private string constr;
    private IDbConnection dbc;
    private IDbCommand dbcm;
    private IDataReader dbr;

    // Use this for initialization
    void Start () {
        constr = "URI=file:" + Application.dataPath + "/Database/disloyalDB.db";
        dbc = new SqliteConnection(constr);
        dbc.Open();
        dbcm = dbc.CreateCommand();
        dbcm.CommandText = "SELECT * FROM Scenes";
        dbr = dbcm.ExecuteReader();

        while (dbr.Read())
        {
            string text = dbr.GetString(0);
            string ans1 = dbr.GetString(1);
            string ans2 = dbr.GetString(2);
            string ans3 = dbr.GetString(3);
            string ans4 = dbr.GetString(4);
            int ans1to = dbr.GetInt16(5);
            int ans2to = dbr.GetInt16(6);
            int ans3to = dbr.GetInt16(7);
            int ans4to = dbr.GetInt16(8);
            int ans1p = dbr.GetInt16(9);
            int ans2p = dbr.GetInt16(10);
            int ans3p = dbr.GetInt16(11);
            int ans4p = dbr.GetInt16(12);


            Debug.Log("text =" + text + " ans1 = " + ans1 + " ans2 = " + ans2 + " ans3 = " + ans3 + " ans4 = " + ans4 + " ans1to = " + ans1to + " ans2to = " + ans2to + " ans3to = " + ans3to + " ans4to = " + ans4to + " ans1p = " + ans1p + " ans2p = " + ans2p + " ans3p = " + ans3p + " ans4p = " + ans4p);
        }
        dbr.Close();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
