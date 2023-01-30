using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface ISocialMediuauRepositorie
    {
        List<MasterSocialMedia> View();
        List<MasterSocialMedia> FrontEndView();
        void Add(MasterSocialMedia entity);
        void Update(int id, MasterSocialMedia entity);
        void Delete(int id, MasterSocialMedia entity);
        void Update_Active(int id, MasterSocialMedia entity);
        MasterSocialMedia Find(int id);
    }
}
