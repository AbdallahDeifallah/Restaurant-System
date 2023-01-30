using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface ISystemSettingRepositorie
    {
        List<SystemSetting> View();
        List<SystemSetting> FrontEndView();
        void Add(SystemSetting entity);
        void Update(int id, SystemSetting entity);
        void Delete(int id, SystemSetting entity);
        void Update_Active(int id, SystemSetting entity);
        SystemSetting Find(int id);
    }
}
