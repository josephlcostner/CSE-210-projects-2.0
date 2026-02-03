using System;
using System.Reflection;
namespace math_demo;

    public class Math;
    {
        private string _student = "";
        private string _assignment = "";
        public string GetStudent()
        {
            return _student;
        }
        public void GetStudent(string student)
        {
        _student = student;
        }
        public string GetAssignment()
        {
        return _assignment;
        }
        public void GetAssignment(string assignment)
        {
         _assignment = assignment;
        }
        public string GetSummary()
        {
        return $"{_student} - {_assignment}";
        }
    }
