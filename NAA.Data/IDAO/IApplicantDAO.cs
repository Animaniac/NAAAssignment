using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.IDAO
{
    public interface IApplicantDAO
    {
        Profile GetApplicantDetails(int id);
        void EditProfile(Profile profile);
        void CreateProfile(Profile NewProfile);
        void DeleteProfile(Profile CurrentProfile);
        IList<Profile> GetApplicants();

    }
}
