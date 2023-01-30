using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.Repositories
{
    public interface ISliderRepositorie
    {
        List<MasterSlider> View();
        List<MasterSlider> FrontEndView();
        void Add(MasterSlider entity);
        void Update(int id, MasterSlider entity);
        void Delete(int id, MasterSlider entity);
        void Update_Active(int id, MasterSlider entity);
        MasterSlider Find(int id);
    }
}
