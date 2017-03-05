using NAA.Data.IDAO;
using NAA.Data;
using NAA.Data.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAA.Data.DAO
{
    public class ApplicantDAO:IApplicantDAO
    {
        private b2007512Entities1 _context;
        public ApplicantDAO()
        {
            _context = new b2007512Entities1();
        }        

        public Profile GetApplicantDetails(int id)
        {
            IQueryable<Profile> _profile;
            _profile = from applicant
                       in _context.Profile
                       where applicant.ApplicantId == id
                       select applicant;
            return _profile.ToList<Profile>().First();
        }
        public IList<Profile> GetApplicants()
        {
            IQueryable<Profile> _profile;
            _profile = from applicant
                       in _context.Profile                       
                       select applicant;
            return _profile.ToList<Profile>();
        }
        public void EditProfile(Profile profile)
        {
            Profile record = (from prof
                                        in _context.Profile
                                      where prof.ApplicantId == profile.ApplicantId
                                      select prof).ToList<Profile>().First();
            record.ApplicantAddress = profile.ApplicantAddress;
            record.ApplicantId = profile.ApplicantId;
            record.ApplicantName = profile.ApplicantName;
            record.Email = profile.Email;
            record.Phone = profile.Phone;
            record.UserId = profile.UserId;            
            _context.SaveChanges();
        }

        public void CreateProfile(Profile NewProfile)
        {
            _context.Profile.Add(NewProfile);
            _context.SaveChanges();
        }

        public void DeleteProfile(Profile CurrentProfile)
        {
            _context.Profile.Remove(CurrentProfile);
            _context.SaveChanges();
        }

    }
}
