using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;
using Data.Model;
using Data.Reporitory;
using Data.Reporitory.Interface;
namespace Business.RepositoryHelper
{
    public class UnityRepositoryHelper : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IHotelRepository, HotelReporitory>();
            Container.RegisterType<IRoomRepository, RoomRepository>();
        }
    }
}
