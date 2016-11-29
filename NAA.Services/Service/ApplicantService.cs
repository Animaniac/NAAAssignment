using NAA.Data;
using NAA.Data.DAO;
using NAA.Data.IDAO;
using NAA.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.Service
{
    public class ApplicantService: IApplicantService
    {
        private IApplicantDAO _applicantDAO;
        public ApplicantService() { _applicantDAO = new ApplicantDAO(); }
        public Profile GetApplicantDetails(int id)
        {
            return _applicantDAO.GetApplicantDetails(id);
        }
        public void EditProfile(Profile profile)
        {
            _applicantDAO.EditProfile(profile);
        }
        public void CreateProfile(Profile NewProfile)
        {
            _applicantDAO.CreateProfile(NewProfile);
        }

        public IList<Profile> GetApplicants()
        {
            return _applicantDAO.GetApplicants();
        }
        public void DeleteProfile(Profile CurrentProfile)
        {
            _applicantDAO.DeleteProfile(CurrentProfile);
        }



    }
}
