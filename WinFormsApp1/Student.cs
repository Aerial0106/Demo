using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Student
    {
        private int _stt;
        private string _id;
        private string _name;
        private string _faculty;
        private double _avgScore;

        public int clSTT { get => _stt; set => _stt = value; }
        public string clID { get => _id; set => _id = value; }
        public string clName { get => _name; set => _name = value; }
        public string clFaculty { get => _faculty; set => _faculty = value; }
        public double clAvgScore { get => _avgScore; set => _avgScore = value; }
    }
}
