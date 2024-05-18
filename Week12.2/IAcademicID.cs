using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12._2
{
    public interface IAcademicID
    {
        void setDepartment(string department);
        void setSection(int section);
        void getAcademicID();
    }
}
