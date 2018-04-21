using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Data.Linq;
using System.Data.SqlClient;

public class DataBaseByWiwi : MonoBehaviour {
    //SqlConnection MyConnection = new SqlConnection("server=localhost" + "database=Tasks.mdf");
    static DataContext db = new DataContext(@"C:\Users\Im not a hacker\Documents\Tasks.mdf");
    //Table<Task> Tasks = db.GetTable<Task>();
    // Use this for initialization
    void Start () {
        DataBaseProcess();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void DataBaseProcess()
    {
        db.Connection.Open();
        if (db.Connection.State==System.Data.ConnectionState.Open)
        {
            Debug.Log("Connection established");
           // var query = from task in Tasks where task.taskTitle == "Title" select task;
            Task monday = new Task("mondayToDo", null, System.DateTime.Now);
            
            string command = "INSERT INTO Tasks VALUES(" + monday.taskTitle +", " + monday.taskDescription +", " + monday.taskDate + ")";
            db.ExecuteCommand(command);
            db.Dispose();
            Debug.Log("done");
        }
    }
}
class Task
{
    private string TaskTitle;
    private string TaskDescription;
    private System.DateTime TaskDate;

    public string taskTitle
    {
        get { return TaskTitle; }
        set { TaskTitle = value; }
    }

    public string taskDescription
    {
        get { return TaskDescription; }
        set { TaskDescription = value; }
    }

    public System.DateTime taskDate
    {
        get { return TaskDate; }
        set { TaskDate = value; }
    }

    public Task(string TaskTitle, string TaskDescription, System.DateTime TaskDate)
    {
        this.TaskTitle = TaskTitle;
        this.TaskDescription = TaskDescription;
        this.TaskDate = TaskDate;
    }
}
