using NAA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Services.IService
{
    public interface IApplicantService
    {
        Profile GetApplicantDetails(int id);
        IList<Profile> GetApplicants();
        void EditProfile(Profile profile);
        void CreateProfile(Profile NewProfile);
        void DeleteProfile(Profile CurrentProfile);

    }
}
