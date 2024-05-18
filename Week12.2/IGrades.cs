using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12._2
{
    public interface IGrades
    {
        void setGrades(int quiz, int midterm, int final);
        double calculateAverage();
        void getGrades();
    }
}
