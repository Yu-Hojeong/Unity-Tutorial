using System.Collections.Generic;
using UnityEngine;

public class StudyInherit : MonoBehaviour
{
    // public List<Student> students = new List<Student>();
    // public List<Soldier> soldiers = new List<Soldier>();
    public List<Person> people = new List<Person>(); 

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Student student = new Student();
            // students.Add(student);
            people.Add(student);
        }
        for (int i = 0; i < 10; i++)
        {
            Soldier soldier = new Soldier();
            // soldiers.Add(soldier);
            people.Add(soldier);
        }
    }

    public void AllMove()
    {
        // foreach (var student in students)
        // {
        //     student.Walk();
        // }
        // foreach (var soldier in soldiers)
        // {
        //     soldier.Walk();
        // }
        foreach (var person in people)
        {
            person.Walk();
        }
    }
}
