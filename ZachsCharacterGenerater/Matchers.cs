using System.Net;
using System.Windows.Forms;
using AutoMapper;

namespace ZachsCharacterGenerater
{
    public static class Matchers
    {
        public static CheckBox[] MapsTo<TMapsTo, TMapsFrom>(TMapsTo expected)
        {
            Mapper.CreateMap<TMapsFrom, TMapsTo>();
            CheckBox[] box = { };
            return box;
        }
    }
}
