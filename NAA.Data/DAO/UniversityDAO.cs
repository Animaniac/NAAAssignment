using NAA.Data.Bean;
using NAA.Data.IDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.DAO
{
    public class UniversityDAO:IUniversityDAO
    {
        private SHUService.SHUWebService _ProxySHU;
        private SUService.SheffieldUniCourses _ProxySU;

        public UniversityDAO()
        {
            _ProxySHU = new SHUService.SHUWebService();
            _ProxySU = new SUService.SheffieldUniCourses();
        }

        public IList<SHUService.CourseList> GetSHUCourses(int UniversityID)
        {            
                IList<SHUService.CourseList> hallamCourses = _ProxySHU.GetAllCourses();

                return hallamCourses;
        }

        public IList<SUService.Course> GetSUCourses(int UniversityID)
        {
            return _ProxySU.GetCoursesFullDetails();
        }
    }
}
